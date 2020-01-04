using System.ComponentModel.DataAnnotations;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.StockExchangeSecurity
{
    /// <summary>
    /// Source: https://equityapi.morningstar.com/DataCatalog.aspx?catalogid=161
    /// Endpoint: http://equityapi.morningstar.com/Webservice/GlobalMasterListsService.asmx/GetStockExchangeSecurityList
    /// Request parameters are case sensitive
    /// </summary>
#pragma warning disable IDE1006
    public class Request : BaseRequest
    {
        [Required]
        public string stockStatus { get; set; }

        public static Request Create(string token, string exchangeId, string identifierType, string identifier, string stockStatus, string responseType = "Json")
        {
            return new Request
            {
                exchangeId = exchangeId,
                identifier = identifier,
                identifierType = identifierType,
                stockStatus = stockStatus,
                Token = token,
                ResponseType = responseType
            };
        }
    }
}
