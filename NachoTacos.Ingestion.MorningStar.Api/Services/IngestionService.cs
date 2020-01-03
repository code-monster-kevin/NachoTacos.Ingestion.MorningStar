using Flurl;
using Microsoft.Extensions.Logging;
using NachoTacos.Ingestion.MorningStar.Data;
using NachoTacos.Ingestion.MorningStar.Domain.MorningStar;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.Services
{
    public class IngestionService
    {
        private readonly ILogger _logger;
        private readonly IIngestionContext _ingestionContext;

        public IngestionService(IIngestionContext ingestionContext, ILogger logger)
        {
            _ingestionContext = ingestionContext;
            _logger = logger;
        }

        public async Task<StockExchangeSecurityResponse> IngestionMain(string token)
        {
            string url = "http://equityapi.morningstar.com/Webservice/GlobalMasterListsService.asmx/GetStockExchangeSecurityList";

            StockExchangeSecurityResponse stockExchangeSecurityResponse = await GetStockExchangeSecurityList(url, token, "KLS", "KLS", "exchangeId", "Active");

            return stockExchangeSecurityResponse;
        }

        private async Task<StockExchangeSecurityResponse> GetStockExchangeSecurityList(string url, string token, string exchangeId, string identifier, string identifierType, string stockStatus, string responseType = "Json")
        {
            StockExchangeSecurityRequest requestParams = new StockExchangeSecurityRequest
            {
                exchangeId = exchangeId,
                identifier = identifier,
                identifierType = identifierType,
                stockStatus = stockStatus,
                Token = token,
                ResponseType = responseType
            };

            string requestUrl = url.SetQueryParams(requestParams);

            _logger.LogInformation("{0} GetStockExchangeList: {1}", "#".PadLeft(10, '#'), requestUrl);
            StockExchangeSecurityResponse response = await RestClient.GetDynamicResponseAsync<StockExchangeSecurityResponse>(requestUrl);

            return response;
        }
    }
}
