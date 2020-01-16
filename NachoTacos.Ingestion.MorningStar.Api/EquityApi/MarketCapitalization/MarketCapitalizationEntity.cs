using System;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi
{
    public class MarketCapitalizationEntity
    {
        public DateTime MarketCapDate { get; set; }
        public long MarketCap { get; set; }
        public long EnterpriseValue { get; set; }
        public string CurrencyId { get; set; }
        public long SharesOutstanding { get; set; }
        public DateTime SharesDate { get; set; }
    }
}
