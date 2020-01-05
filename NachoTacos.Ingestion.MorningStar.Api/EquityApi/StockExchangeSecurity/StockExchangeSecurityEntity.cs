using System;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi
{
    /// <summary>
    /// Source: https://equityapi.morningstar.com/DataCatalog.aspx?catalogid=161
    /// Endpoint: http://equityapi.morningstar.com/Webservice/GlobalMasterListsService.asmx/GetStockExchangeSecurityList
    /// </summary>
    public class StockExchangeSecurityEntity : Equity
    {
        public string InvestmentTypeId { get; set; }
        public string StockStatus { get; set; }
        public DateTime DelistingDate { get; set; }
        public string DelistingReason { get; set; }
        public string ExchangeSubMarketGlobalId { get; set; }
        public decimal ParValue { get; set; }
        public string SuspendedFlag { get; set; }
    }
}
