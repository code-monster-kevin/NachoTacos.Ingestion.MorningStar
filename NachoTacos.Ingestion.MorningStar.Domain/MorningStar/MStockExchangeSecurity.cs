using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    [Table("MStockExchangeSecurity", Schema = "MStar")]
    public class MStockExchangeSecurity : MEquity
    {
        public Guid MStockExchangeSecurityId { get; set; }
        public string InvestmentTypeId { get; set; }
        public string StockStatus { get; set; }
        public DateTime DelistingDate { get; set; }
        public string DelistingReason { get; set; }
        public string ExchangeSubMarketGlobalId { get; set; }
        public decimal ParValue { get; set; }
        public string SuspendedFlag { get; set; }
    }
}
