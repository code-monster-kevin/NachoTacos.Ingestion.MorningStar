using System;
using System.ComponentModel.DataAnnotations;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi
{
    /// <summary>
    /// Source: https://equityapi.morningstar.com/DataCatalog.aspx?catalogid=161
    /// Endpoint: http://equityapi.morningstar.com/Webservice/GlobalMasterListsService.asmx/GetStockExchangeSecurityList
    /// </summary>
    public class StockExchangeSecurityEntity : Equity
    {
        public string InvestmentTypeId { get; set; }
        [Required]
        public string StockStatus { get; set; }
        public DateTime DelistingDate { get; set; }
        public string DelistingReason { get; set; }
        [Required]
        public string ExchangeSubMarketGlobalId { get; set; }
        [Required]
        public decimal ParValue { get; set; }
        [Required]
        public string SuspendedFlag { get; set; }
    }
}
