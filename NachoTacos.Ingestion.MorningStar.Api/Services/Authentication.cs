using Flurl;
using Microsoft.Extensions.Logging;
using NachoTacos.Ingestion.MorningStar.Data;
using NachoTacos.Ingestion.MorningStar.Domain;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;


namespace NachoTacos.Ingestion.MorningStar.Api.Services
{
    /// <summary>
    /// Connecting to MorningStar equity API service
    /// based on sample code from https://equityapi.morningstar.com/SampleCode.aspx
    /// </summary>
    public class Authentication
    {
        private readonly ILogger _logger;
        private readonly IIngestionContext _ingestionContext;

        public Authentication(IIngestionContext ingestionContext, ILogger logger)
        {
            _logger = logger;
            _ingestionContext = ingestionContext;
        }

        public async Task<TokenEntity> Login(string url, string email, string password)
        {
            try
            {
                var requestUrl = url.SetQueryParam("email", email)
                                    .SetQueryParam("password", password);

                string loginResult = await RestClient.GetFlurlResponse(requestUrl);
                if (string.IsNullOrEmpty(loginResult))
                    return null;

                TokenEntity tokenEntity = GetTokenEntity(loginResult);
                return tokenEntity;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public async Task<TokenEntity> GetAccessTokenByClientConfigId(Guid id)
        {
            ClientConfiguration clientConfiguration = _ingestionContext.ClientConfigurations.FirstOrDefault(x => x.ClientConfigurationId == id);
            if (clientConfiguration == null) return null;

            TokenEntity tokenEntity = await Login(clientConfiguration.LoginUrl, clientConfiguration.AccountLogin, clientConfiguration.AccountPassword);
            if (tokenEntity != null && tokenEntity.IsSuccess && tokenEntity.ExpireDate > DateTime.Now)
            {
                return tokenEntity;
            }
            return null;
        }

        /// <summary>
        /// Deserialize the XML result into TokenEntity class
        /// fixed a bug where the miliseconds expire date sometimes return 6 or 7 digits
        /// truncate the miliseconds to limit to 6 digits
        /// </summary>
        /// <param name="loginResult"></param>
        /// <returns></returns>
        private TokenEntity GetTokenEntity(string loginResult)
        {
            TokenEntity token = null;
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.LoadXml(Regex.Replace(loginResult, @"(xmlns:?[^=]*=[""][^""]*[""])", "", RegexOptions.IgnoreCase | RegexOptions.Multiline));
                string tokenExpireDate = string.Format("{0}Z", doc.SelectSingleNode(@"//TokenEntity/expireDate").InnerText.Substring(0, 26));

                token = new TokenEntity
                {
                    IsSuccess = doc.SelectSingleNode(@"//TokenEntity/IsSuccess").InnerText == "true" ? true : false,
                    Token = doc.SelectSingleNode(@"//TokenEntity/Token").InnerText,
                    ExpireDate = DateTime.ParseExact(tokenExpireDate, "yyyy-MM-ddTHH:mm:ss.ffffffZ", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return token;
        }

    }

    public class TokenEntity
    {
        public bool IsSuccess { set; get; }
        public string Token { set; get; }
        private DateTime _expireDate = DateTime.MinValue;

        public DateTime ExpireDate
        {
            set { _expireDate = value; }
            get { return _expireDate; }
        }
    }
}
