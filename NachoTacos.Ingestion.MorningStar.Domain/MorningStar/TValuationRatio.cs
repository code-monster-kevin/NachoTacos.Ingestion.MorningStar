using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    [Table("TValuationRatio", Schema = "MStar")]
    public class TValuationRatio : TBase
    {
        private DateTime asOfDateField;

        private decimal? salesPerShareField;

        private decimal? growthAnnSalesPerShare5YearField;

        private decimal? bookValuePerShareField;

        private decimal? cFPerShareField;

        private decimal? fCFPerShareField;

        private decimal? priceToEPSField;

        private decimal? ratioPE5YearHighField;

        private decimal? ratioPE5YearLowField;

        private decimal? priceToBookField;

        private decimal? priceToSalesField;

        private decimal? priceToCashFlowField;

        private decimal? priceToFreeCashFlowField;

        private decimal? divRateField;

        private decimal? dividendYieldField;

        private decimal? divPayoutTotOpsField;

        private decimal? divPayout5YearField;

        private decimal? divYield5YearField;

        private decimal? payoutRatioField;

        private decimal? sustainableGrowthRateField;

        private decimal? cashReturnField;

        private decimal? forwardEarningYieldField;

        private decimal? pEGRatioField;

        private decimal? pEGPaybackField;

        private decimal? forwardDividendYieldField;

        private decimal? forwardPERatioField;

        private decimal? tangibleBookValuePerShareField;

        private decimal? tangibleBVPerShare3YrAvgField;

        private decimal? tangibleBVPerShare5YrAvgField;

        private decimal? eVToEBITDAField;

        private decimal? ratioPE5YearAverageField;

        private decimal? normalizedPERatioField;

        private decimal? fCFYieldField;

        private decimal? eVToForwardEBITField;

        private decimal? eVToForwardEBITDAField;

        private decimal? eVToForwardRevenueField;

        private decimal? twoYearsEVToForwardEBITField;

        private decimal? twoYearsEVToForwardEBITDAField;

        private decimal? firstYearEstimatedEPSGrowthField;

        private decimal? secondYearEstimatedEPSGrowthField;

        private decimal? normalizedPEGField;

        private decimal? earningYieldField;

        private decimal? salesYieldField;

        private decimal? bookValueYieldField;

        private decimal? cashFlowYieldField;

        private decimal? forwardDividendField;

        private decimal? workingCapitalPerShareField;

        private decimal? workingCapitalPerShare3YrAvgField;

        private decimal? workingCapitalPerShare5YrAvgField;

        private decimal? buyBackYieldField;

        private decimal? totalYieldField;

        private decimal? pricetoEBITDAField;

        private decimal? forwardROEField;

        private decimal? forwardROAField;

        private decimal? twoYearsForwardEarningYieldField;

        private decimal? twoYearsForwardPERatioField;

        private decimal? totalAssetPerShareField;

        private decimal? eVtoRevenueField;

        private decimal? eVtoPreTaxIncomeField;

        private decimal? eVtoTotalAssetsField;

        private decimal? eVtoFCFField;

        private decimal? eVtoEBITField;

        private decimal? fFOPerShareField;

        private decimal? pricetoCashRatioField;

        private decimal? cAPERatioField;

        /// <remarks/>
        public DateTime AsOfDate
        {
            get
            {
                return this.asOfDateField;
            }
            set
            {
                this.asOfDateField = value;
            }
        }

        /// <remarks/>
        public decimal? SalesPerShare
        {
            get
            {
                return this.salesPerShareField;
            }
            set
            {
                this.salesPerShareField = value;
            }
        }

        /// <remarks/>
        public decimal? GrowthAnnSalesPerShare5Year
        {
            get
            {
                return this.growthAnnSalesPerShare5YearField;
            }
            set
            {
                this.growthAnnSalesPerShare5YearField = value;
            }
        }

        /// <remarks/>
        public decimal? BookValuePerShare
        {
            get
            {
                return this.bookValuePerShareField;
            }
            set
            {
                this.bookValuePerShareField = value;
            }
        }

        /// <remarks/>
        public decimal? CFPerShare
        {
            get
            {
                return this.cFPerShareField;
            }
            set
            {
                this.cFPerShareField = value;
            }
        }

        /// <remarks/>
        public decimal? FCFPerShare
        {
            get
            {
                return this.fCFPerShareField;
            }
            set
            {
                this.fCFPerShareField = value;
            }
        }

        /// <remarks/>
        public decimal? PriceToEPS
        {
            get
            {
                return this.priceToEPSField;
            }
            set
            {
                this.priceToEPSField = value;
            }
        }

        /// <remarks/>
        public decimal? RatioPE5YearHigh
        {
            get
            {
                return this.ratioPE5YearHighField;
            }
            set
            {
                this.ratioPE5YearHighField = value;
            }
        }

        /// <remarks/>
        public decimal? RatioPE5YearLow
        {
            get
            {
                return this.ratioPE5YearLowField;
            }
            set
            {
                this.ratioPE5YearLowField = value;
            }
        }

        /// <remarks/>
        public decimal? PriceToBook
        {
            get
            {
                return this.priceToBookField;
            }
            set
            {
                this.priceToBookField = value;
            }
        }

        /// <remarks/>
        public decimal? PriceToSales
        {
            get
            {
                return this.priceToSalesField;
            }
            set
            {
                this.priceToSalesField = value;
            }
        }

        /// <remarks/>
        public decimal? PriceToCashFlow
        {
            get
            {
                return this.priceToCashFlowField;
            }
            set
            {
                this.priceToCashFlowField = value;
            }
        }

        /// <remarks/>
        public decimal? PriceToFreeCashFlow
        {
            get
            {
                return this.priceToFreeCashFlowField;
            }
            set
            {
                this.priceToFreeCashFlowField = value;
            }
        }

        /// <remarks/>
        public decimal? DivRate
        {
            get
            {
                return this.divRateField;
            }
            set
            {
                this.divRateField = value;
            }
        }

        /// <remarks/>
        public decimal? DividendYield
        {
            get
            {
                return this.dividendYieldField;
            }
            set
            {
                this.dividendYieldField = value;
            }
        }

        /// <remarks/>
        public decimal? DivPayoutTotOps
        {
            get
            {
                return this.divPayoutTotOpsField;
            }
            set
            {
                this.divPayoutTotOpsField = value;
            }
        }

        /// <remarks/>
        public decimal? DivPayout5Year
        {
            get
            {
                return this.divPayout5YearField;
            }
            set
            {
                this.divPayout5YearField = value;
            }
        }

        /// <remarks/>
        public decimal? DivYield5Year
        {
            get
            {
                return this.divYield5YearField;
            }
            set
            {
                this.divYield5YearField = value;
            }
        }

        /// <remarks/>
        public decimal? PayoutRatio
        {
            get
            {
                return this.payoutRatioField;
            }
            set
            {
                this.payoutRatioField = value;
            }
        }

        /// <remarks/>
        public decimal? SustainableGrowthRate
        {
            get
            {
                return this.sustainableGrowthRateField;
            }
            set
            {
                this.sustainableGrowthRateField = value;
            }
        }

        /// <remarks/>
        public decimal? CashReturn
        {
            get
            {
                return this.cashReturnField;
            }
            set
            {
                this.cashReturnField = value;
            }
        }

        /// <remarks/>
        public decimal? ForwardEarningYield
        {
            get
            {
                return this.forwardEarningYieldField;
            }
            set
            {
                this.forwardEarningYieldField = value;
            }
        }

        /// <remarks/>
        public decimal? PEGRatio
        {
            get
            {
                return this.pEGRatioField;
            }
            set
            {
                this.pEGRatioField = value;
            }
        }

        /// <remarks/>
        public decimal? PEGPayback
        {
            get
            {
                return this.pEGPaybackField;
            }
            set
            {
                this.pEGPaybackField = value;
            }
        }

        /// <remarks/>
        public decimal? ForwardDividendYield
        {
            get
            {
                return this.forwardDividendYieldField;
            }
            set
            {
                this.forwardDividendYieldField = value;
            }
        }

        /// <remarks/>
        public decimal? ForwardPERatio
        {
            get
            {
                return this.forwardPERatioField;
            }
            set
            {
                this.forwardPERatioField = value;
            }
        }

        /// <remarks/>
        public decimal? TangibleBookValuePerShare
        {
            get
            {
                return this.tangibleBookValuePerShareField;
            }
            set
            {
                this.tangibleBookValuePerShareField = value;
            }
        }

        /// <remarks/>
        public decimal? TangibleBVPerShare3YrAvg
        {
            get
            {
                return this.tangibleBVPerShare3YrAvgField;
            }
            set
            {
                this.tangibleBVPerShare3YrAvgField = value;
            }
        }

        /// <remarks/>
        public decimal? TangibleBVPerShare5YrAvg
        {
            get
            {
                return this.tangibleBVPerShare5YrAvgField;
            }
            set
            {
                this.tangibleBVPerShare5YrAvgField = value;
            }
        }

        /// <remarks/>
        public decimal? EVToEBITDA
        {
            get
            {
                return this.eVToEBITDAField;
            }
            set
            {
                this.eVToEBITDAField = value;
            }
        }

        /// <remarks/>
        public decimal? RatioPE5YearAverage
        {
            get
            {
                return this.ratioPE5YearAverageField;
            }
            set
            {
                this.ratioPE5YearAverageField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedPERatio
        {
            get
            {
                return this.normalizedPERatioField;
            }
            set
            {
                this.normalizedPERatioField = value;
            }
        }

        /// <remarks/>
        public decimal? FCFYield
        {
            get
            {
                return this.fCFYieldField;
            }
            set
            {
                this.fCFYieldField = value;
            }
        }

        /// <remarks/>
        public decimal? EVToForwardEBIT
        {
            get
            {
                return this.eVToForwardEBITField;
            }
            set
            {
                this.eVToForwardEBITField = value;
            }
        }

        /// <remarks/>
        public decimal? EVToForwardEBITDA
        {
            get
            {
                return this.eVToForwardEBITDAField;
            }
            set
            {
                this.eVToForwardEBITDAField = value;
            }
        }

        /// <remarks/>
        public decimal? EVToForwardRevenue
        {
            get
            {
                return this.eVToForwardRevenueField;
            }
            set
            {
                this.eVToForwardRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? TwoYearsEVToForwardEBIT
        {
            get
            {
                return this.twoYearsEVToForwardEBITField;
            }
            set
            {
                this.twoYearsEVToForwardEBITField = value;
            }
        }

        /// <remarks/>
        public decimal? TwoYearsEVToForwardEBITDA
        {
            get
            {
                return this.twoYearsEVToForwardEBITDAField;
            }
            set
            {
                this.twoYearsEVToForwardEBITDAField = value;
            }
        }

        /// <remarks/>
        public decimal? FirstYearEstimatedEPSGrowth
        {
            get
            {
                return this.firstYearEstimatedEPSGrowthField;
            }
            set
            {
                this.firstYearEstimatedEPSGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? SecondYearEstimatedEPSGrowth
        {
            get
            {
                return this.secondYearEstimatedEPSGrowthField;
            }
            set
            {
                this.secondYearEstimatedEPSGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedPEG
        {
            get
            {
                return this.normalizedPEGField;
            }
            set
            {
                this.normalizedPEGField = value;
            }
        }

        /// <remarks/>
        public decimal? EarningYield
        {
            get
            {
                return this.earningYieldField;
            }
            set
            {
                this.earningYieldField = value;
            }
        }

        /// <remarks/>
        public decimal? SalesYield
        {
            get
            {
                return this.salesYieldField;
            }
            set
            {
                this.salesYieldField = value;
            }
        }

        /// <remarks/>
        public decimal? BookValueYield
        {
            get
            {
                return this.bookValueYieldField;
            }
            set
            {
                this.bookValueYieldField = value;
            }
        }

        /// <remarks/>
        public decimal? CashFlowYield
        {
            get
            {
                return this.cashFlowYieldField;
            }
            set
            {
                this.cashFlowYieldField = value;
            }
        }

        /// <remarks/>
        public decimal? ForwardDividend
        {
            get
            {
                return this.forwardDividendField;
            }
            set
            {
                this.forwardDividendField = value;
            }
        }

        /// <remarks/>
        public decimal? WorkingCapitalPerShare
        {
            get
            {
                return this.workingCapitalPerShareField;
            }
            set
            {
                this.workingCapitalPerShareField = value;
            }
        }

        /// <remarks/>
        public decimal? WorkingCapitalPerShare3YrAvg
        {
            get
            {
                return this.workingCapitalPerShare3YrAvgField;
            }
            set
            {
                this.workingCapitalPerShare3YrAvgField = value;
            }
        }

        /// <remarks/>
        public decimal? WorkingCapitalPerShare5YrAvg
        {
            get
            {
                return this.workingCapitalPerShare5YrAvgField;
            }
            set
            {
                this.workingCapitalPerShare5YrAvgField = value;
            }
        }

        /// <remarks/>
        public decimal? BuyBackYield
        {
            get
            {
                return this.buyBackYieldField;
            }
            set
            {
                this.buyBackYieldField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalYield
        {
            get
            {
                return this.totalYieldField;
            }
            set
            {
                this.totalYieldField = value;
            }
        }

        /// <remarks/>
        public decimal? PricetoEBITDA
        {
            get
            {
                return this.pricetoEBITDAField;
            }
            set
            {
                this.pricetoEBITDAField = value;
            }
        }

        /// <remarks/>
        public decimal? ForwardROE
        {
            get
            {
                return this.forwardROEField;
            }
            set
            {
                this.forwardROEField = value;
            }
        }

        /// <remarks/>
        public decimal? ForwardROA
        {
            get
            {
                return this.forwardROAField;
            }
            set
            {
                this.forwardROAField = value;
            }
        }

        /// <remarks/>
        public decimal? TwoYearsForwardEarningYield
        {
            get
            {
                return this.twoYearsForwardEarningYieldField;
            }
            set
            {
                this.twoYearsForwardEarningYieldField = value;
            }
        }

        /// <remarks/>
        public decimal? TwoYearsForwardPERatio
        {
            get
            {
                return this.twoYearsForwardPERatioField;
            }
            set
            {
                this.twoYearsForwardPERatioField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalAssetPerShare
        {
            get
            {
                return this.totalAssetPerShareField;
            }
            set
            {
                this.totalAssetPerShareField = value;
            }
        }

        /// <remarks/>
        public decimal? EVtoRevenue
        {
            get
            {
                return this.eVtoRevenueField;
            }
            set
            {
                this.eVtoRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? EVtoPreTaxIncome
        {
            get
            {
                return this.eVtoPreTaxIncomeField;
            }
            set
            {
                this.eVtoPreTaxIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? EVtoTotalAssets
        {
            get
            {
                return this.eVtoTotalAssetsField;
            }
            set
            {
                this.eVtoTotalAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? EVtoFCF
        {
            get
            {
                return this.eVtoFCFField;
            }
            set
            {
                this.eVtoFCFField = value;
            }
        }

        /// <remarks/>
        public decimal? EVtoEBIT
        {
            get
            {
                return this.eVtoEBITField;
            }
            set
            {
                this.eVtoEBITField = value;
            }
        }

        /// <remarks/>
        public decimal? FFOPerShare
        {
            get
            {
                return this.fFOPerShareField;
            }
            set
            {
                this.fFOPerShareField = value;
            }
        }

        /// <remarks/>
        public decimal? PricetoCashRatio
        {
            get
            {
                return this.pricetoCashRatioField;
            }
            set
            {
                this.pricetoCashRatioField = value;
            }
        }

        /// <remarks/>
        public decimal? CAPERatio
        {
            get
            {
                return this.cAPERatioField;
            }
            set
            {
                this.cAPERatioField = value;
            }
        }
    }
}
