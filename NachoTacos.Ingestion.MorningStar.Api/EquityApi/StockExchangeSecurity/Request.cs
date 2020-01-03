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
        public string exchangeId { get; set; }
        [Required]
        public string identifierType { get; set; }
        [Required]
        public string identifier { get; set; }
        [Required]
        public string stockStatus { get; set; }
    }
}
