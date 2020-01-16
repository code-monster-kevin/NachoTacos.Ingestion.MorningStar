using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    [Table("MEODPriceHistory", Schema = "MStar")]
    public class MEODPriceHistory : MGeneralInfo
    {
        public Guid MEODPriceHistoryId { get; set; }
        public DateTime TradingDate { get; set; }
        public decimal? OpenPrice { get; set; }
        public decimal? HighPrice { get; set; }
        public decimal? LowPrice { get; set; }
        public decimal? ClosePrice { get; set; }
        public int Volume { get; set; }
        public string PriceCurrencyId { get; set; }
    }
}
