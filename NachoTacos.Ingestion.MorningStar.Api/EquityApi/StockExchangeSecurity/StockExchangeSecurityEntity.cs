using System;
using System.ComponentModel.DataAnnotations;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.StockExchangeSecurity
{
    /// <summary>
    /// Source: https://equityapi.morningstar.com/DataCatalog.aspx?catalogid=161
    /// Endpoint: http://equityapi.morningstar.com/Webservice/GlobalMasterListsService.asmx/GetStockExchangeSecurityList
    /// </summary>
    public class StockExchangeSecurityEntity
    {
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ExchangeId { get; set; }
        public string Symbol { get; set; }
        public string CUSIP { get; set; }
        public string CIK { get; set; }
        public string ISIN { get; set; }
        public string SEDOL { get; set; }
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
