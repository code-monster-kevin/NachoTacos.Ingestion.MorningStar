using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    [Table("MMonthlyMarketCapitalizationHistory", Schema = "MStar")]
    public class MMonthlyMarketCapitalizationHistory : MGeneralInfo
    {
        public Guid MMonthlyMarketCapitalizationHistoryId { get; set; }
        public DateTime MarketCapDate { get; set; }
        public long MarketCap { get; set; }
        public long EnterpriseValue { get; set; }
        public string CurrencyId { get; set; }
        public long SharesOutstanding { get; set; }
        public DateTime SharesDate { get; set; }
    }
}
