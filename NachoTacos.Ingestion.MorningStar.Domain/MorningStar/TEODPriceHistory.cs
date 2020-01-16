using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    [Table("TEODPriceHistory", Schema = "MStar")]
    public class TEODPriceHistory : TBase
    {
        public DateTime TradingDate { get; set; }
        public decimal? OpenPrice { get; set; }
        public decimal? HighPrice { get; set; }
        public decimal? LowPrice { get; set; }
        public decimal? ClosePrice { get; set; }
        public int Volume { get; set; }
        public string PriceCurrencyId { get; set; }
    }
}
