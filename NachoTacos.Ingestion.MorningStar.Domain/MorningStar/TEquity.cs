using System.ComponentModel.DataAnnotations;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    public abstract class TEquity
    {
        [Required]
        public string ExchangeId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string Symbol { get; set; }
        public string CUSIP { get; set; }
        public string CIK { get; set; }
        public string ISIN { get; set; }
        public string SEDOL { get; set; }
    }
}
