using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    /// <summary>
    /// Report Table for basic stock screening purposes
    /// </summary>
    [Table("RBaseScreener", Schema = "MStar")]
    public class RBaseScreener
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string Symbol { get; set; }
        public string SectorName { get; set; }
        public string IndustryGroupName { get; set; }
        public string IndustryName { get; set; }
        public DateTime? MarketCapDate { get; set; }
        public long? MarketCap { get; set; }
        public long? SharesOutStanding { get; set; }
        public DateTime? SharesDate { get; set; }
        public long? EnterpriseValue { get; set; }
        public DateTime? ValuationRatioDate { get; set; }
        public decimal? TotalAssetPerShare { get; set; }
        public decimal? TangibleBookValuePerShare { get; set; }
        public decimal? BookValuePerShare { get; set; }
        public decimal? SalesPerShare { get; set; }
        public decimal? CFPerShare { get; set; }
        public decimal? FCFPerShare { get; set; }
        public decimal? PriceToBook { get; set; }
        public decimal? PriceToSales { get; set; }
        public decimal? PriceToCashFlow { get; set; }
        public decimal? PriceToFreeCashFlow { get; set; }
        public decimal? PriceToEPS { get; set; }
        public decimal? PEGRatio { get; set; }
        public decimal? PricetoCashRatio { get; set; }
        public decimal? DividendYield { get; set; }
        public decimal? ForwardDividend { get; set; }
        public decimal? PayoutRatio { get; set; }
        public decimal? SustainableGrowthRate { get; set; }
        public decimal? EVToEBITDA { get; set; }
        public DateTime? QuantRatingDate { get; set; }
        public decimal? QuantitativeMoat { get; set; }
        public decimal? QuantitativeValuation { get; set; }
        public DateTime? QuantitativeValuationUpdateTime { get; set; }
        public DateTime? QuantitativeValuationLabelUpdateTime { get; set; }
        public DateTime? QuantitativeStarRatingUpdateTime { get; set; }
        public DateTime? QuantitativeFairValueUpdateTime { get; set; }
        public string QuantitativeMoatLabel { get; set; }
        public string QuantitativeValuationLabel { get; set; }
        public string QuantitativeValuationUncertaintyLabel { get; set; }
        public string QuantitativeFinancialHealthLabel { get; set; }
        public int? QuantitativeStarRating { get; set; }
        public decimal? QuantitativeFairValue { get; set; }
    }
}
