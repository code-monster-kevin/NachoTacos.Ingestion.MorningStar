namespace NachoTacos.Ingestion.MorningStar.Domain
{
    public abstract class TEquity : TBase
    {
        public string ExchangeId { get; set; }
        public string CompanyName { get; set; }
        public string Symbol { get; set; }
        public string CUSIP { get; set; }
        public string CIK { get; set; }
        public string ISIN { get; set; }
        public string SEDOL { get; set; }
    }
}
