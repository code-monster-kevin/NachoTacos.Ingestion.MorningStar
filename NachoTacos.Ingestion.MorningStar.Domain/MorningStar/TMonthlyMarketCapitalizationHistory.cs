using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    [Table("TMonthlyMarketCapitalizationHistory", Schema = "MStar")]
    public class TMonthlyMarketCapitalizationHistory : TBase
    {
        public DateTime MarketCapDate { get; set; }
        public long MarketCap { get; set; }
        public long EnterpriseValue { get; set; }
        public string CurrencyId { get; set; }
        public long SharesOutstanding { get; set; }
        public DateTime SharesDate { get; set; }
    }
}
