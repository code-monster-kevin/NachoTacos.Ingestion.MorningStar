using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    [Table("TStockExchangeSecurity", Schema = "MStar")]
    public class TStockExchangeSecurity : TEquity
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
        public Guid IngestionTaskId { get; set; }
        public virtual IngestionTask IngestionTask { get; set; }
    }
}
