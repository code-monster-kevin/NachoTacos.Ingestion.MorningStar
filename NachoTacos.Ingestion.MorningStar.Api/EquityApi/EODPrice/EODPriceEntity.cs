using System;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi
{
    public class EODPriceEntity
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
