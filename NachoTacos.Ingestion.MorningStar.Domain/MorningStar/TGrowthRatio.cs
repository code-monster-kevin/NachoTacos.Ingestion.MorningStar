using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    [Table("TGrowthRatio", Schema = "MStar")]
    public class TGrowthRatio : TBase
    {
        private DateTime reportDateField;

        private DateTime periodEndingDateField;

        private DateTime? fileDateField;

        private string statementTypeField;

        private string dataTypeField;

        private string interimField;

        private int fiscalYearEndField;

        private decimal? dilutedEPS3MonthSamePeriodGrowthField;

        private decimal? dilutedEPS6MonthSamePeriodGrowthField;

        private decimal? dilutedEPS9MonthSamePeriodGrowthField;

        private decimal? dilutedEPSSequentialGrowthField;

        private decimal? dilutedEPS1YearGrowthField;

        private decimal? dilutedEPS3YearGrowthField;

        private decimal? dilutedEPS5YearGrowthField;

        private decimal? dilutedEPS10YearGrowthField;

        private decimal? dilutedContinuousEPS3MonthSamePeriodGrowthField;

        private decimal? dilutedContinuousEPS6MonthSamePeriodGrowthField;

        private decimal? dilutedContinuousEPS9MonthSamePeriodGrowthField;

        private decimal? dilutedContinuousEPSSequentialGrowthField;

        private decimal? dilutedContinuousEPS1YearGrowthField;

        private decimal? dilutedContinuousEPS3YearGrowthField;

        private decimal? dilutedContinuousEPS5YearGrowthField;

        private decimal? dilutedContinuousEPS10YearGrowthField;

        private decimal? dividend3MonthSamePeriodGrowthField;

        private decimal? dividend6MonthSamePeriodGrowthField;

        private decimal? dividend9MonthSamePeriodGrowthField;

        private decimal? dividendSequentialGrowthField;

        private decimal? dividend1YearGrowthField;

        private decimal? dividend3YearGrowthField;

        private decimal? dividend5YearGrowthField;

        private decimal? dividend10YearGrowthField;

        private decimal? equityPerShare3MonthSamePeriodGrowthField;

        private decimal? equityPerShare6MonthSamePeriodGrowthField;

        private decimal? equityPerShare9MonthSamePeriodGrowthField;

        private decimal? equityPerShareSequentialGrowthField;

        private decimal? equityPerShare1YearGrowthField;

        private decimal? equityPerShare3YearGrowthField;

        private decimal? equityPerShare5YearGrowthField;

        private decimal? equityPerShare10YearGrowthField;

        private decimal? revenue3MonthSamePeriodGrowthField;

        private decimal? revenue6MonthSamePeriodGrowthField;

        private decimal? revenue9MonthSamePeriodGrowthField;

        private decimal? revenueSequentialGrowthField;

        private decimal? revenue1YearGrowthField;

        private decimal? revenue3YearGrowthField;

        private decimal? revenue5YearGrowthField;

        private decimal? revenue10YearGrowthField;

        private decimal? operatingIncome3MonthSamePeriodGrowthField;

        private decimal? operatingIncome6MonthSamePeriodGrowthField;

        private decimal? operatingIncome9MonthSamePeriodGrowthField;

        private decimal? operatingIncomeSequentialGrowthField;

        private decimal? operatingIncome1YearGrowthField;

        private decimal? operatingIncome3YearGrowthField;

        private decimal? operatingIncome5YearGrowthField;

        private decimal? operatingIncome10YearGrowthField;

        private decimal? netIncome3MonthSamePeriodGrowthField;

        private decimal? netIncome6MonthSamePeriodGrowthField;

        private decimal? netIncome9MonthSamePeriodGrowthField;

        private decimal? netIncomeSequentialGrowthField;

        private decimal? netIncome1YearGrowthField;

        private decimal? netIncome3YearGrowthField;

        private decimal? netIncome5YearGrowthField;

        private decimal? netIncome10YearGrowthField;

        private decimal? netIncomeContOps3MonthSamePeriodGrowthField;

        private decimal? netIncomeContOps6MonthSamePeriodGrowthField;

        private decimal? netIncomeContOps9MonthSamePeriodGrowthField;

        private decimal? netIncomeContOpsSequentialGrowthField;

        private decimal? netIncomeContOps1YearGrowthField;

        private decimal? netIncomeContOps3YearGrowthField;

        private decimal? netIncomeContOps5YearGrowthField;

        private decimal? netIncomeContOps10YearGrowthField;

        private decimal? cFO3MonthSamePeriodGrowthField;

        private decimal? cFO6MonthSamePeriodGrowthField;

        private decimal? cFO9MonthSamePeriodGrowthField;

        private decimal? cFOSequentialGrowthField;

        private decimal? cFO1YearGrowthField;

        private decimal? cFO3YearGrowthField;

        private decimal? cFO5YearGrowthField;

        private decimal? cFO10YearGrowthField;

        private decimal? fCF3MonthSamePeriodGrowthField;

        private decimal? fCF6MonthSamePeriodGrowthField;

        private decimal? fCF9MonthSamePeriodGrowthField;

        private decimal? fCFSequentialGrowthField;

        private decimal? fCF1YearGrowthField;

        private decimal? fCF3YearGrowthField;

        private decimal? fCF5YearGrowthField;

        private decimal? fCF10YearGrowthField;

        private decimal? operatingRevenue3MonthSamePeriodGrowthField;

        private decimal? operatingRevenue6MonthSamePeriodGrowthField;

        private decimal? operatingRevenue9MonthSamePeriodGrowthField;

        private decimal? operatingRevenueSequentialGrowthField;

        private decimal? operatingRevenue1YearGrowthField;

        private decimal? operatingRevenue3YearGrowthField;

        private decimal? operatingRevenue5YearGrowthField;

        private decimal? operatingRevenue10YearGrowthField;

        private decimal? growthAnnCapitalSpending5YearField;

        private decimal? growthAnnGrossProfit5YearField;

        private decimal? avgGrossMargin5YearField;

        private decimal? avgPostTaxMargin5YearField;

        private decimal? avgPreTaxMargin5YearField;

        private decimal? avgNetProfitMargin5YearField;

        private decimal? avgRetCommonEquity5YearField;

        private decimal? avgRetAssets5YearField;

        private decimal? avgRetInvestedCapital5YearField;

        private string accessionNumberField;

        private string formTypeField;

        private decimal? regressionGrowthOperatingRevenue5YearsField;

        private decimal? normalizedDilutedEPSGrowth1yearField;

        private decimal? normalizedDilutedEPSGrowth3yearField;

        private decimal? normalizedDilutedEPSGrowth5yearField;

        private decimal? normalizedDilutedEPSGrowth10yearField;

        private decimal? normalizedDilutedEPSSamePeriodGrowth3monthsField;

        private decimal? normalizedDilutedEPSSamePeriodGrowth6monthsField;

        private decimal? normalizedDilutedEPSSamePeriodGrowth9monthsField;

        private decimal? normalizedDilutedEPSSequentialGrowthField;

        private decimal? normalizedBasicEPSGrowth1yearField;

        private decimal? normalizedBasicEPSGrowth3yearField;

        private decimal? normalizedBasicEPSGrowth5yearField;

        private decimal? normalizedBasicEPSGrowth10yearField;

        private decimal? normalizedBasicEPSSamePeriodGrowth3monthsField;

        private decimal? normalizedBasicEPSSamePeriodGrowth6monthsField;

        private decimal? normalizedBasicEPSSamePeriodGrowth9monthsField;

        private decimal? normalizedBasicEPSSequentialGrowthField;

        /// <remarks/>
        public DateTime ReportDate
        {
            get
            {
                return this.reportDateField;
            }
            set
            {
                this.reportDateField = value;
            }
        }

        /// <remarks/>
        public DateTime PeriodEndingDate
        {
            get
            {
                return this.periodEndingDateField;
            }
            set
            {
                this.periodEndingDateField = value;
            }
        }

        /// <remarks/>
        public DateTime? FileDate
        {
            get
            {
                return this.fileDateField;
            }
            set
            {
                this.fileDateField = value;
            }
        }

        /// <remarks/>
        public string StatementType
        {
            get
            {
                return this.statementTypeField;
            }
            set
            {
                this.statementTypeField = value;
            }
        }

        /// <remarks/>
        public string DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        public string Interim
        {
            get
            {
                return this.interimField;
            }
            set
            {
                this.interimField = value;
            }
        }

        /// <remarks/>
        public int FiscalYearEnd
        {
            get
            {
                return this.fiscalYearEndField;
            }
            set
            {
                this.fiscalYearEndField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedEPS3MonthSamePeriodGrowth
        {
            get
            {
                return this.dilutedEPS3MonthSamePeriodGrowthField;
            }
            set
            {
                this.dilutedEPS3MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedEPS6MonthSamePeriodGrowth
        {
            get
            {
                return this.dilutedEPS6MonthSamePeriodGrowthField;
            }
            set
            {
                this.dilutedEPS6MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedEPS9MonthSamePeriodGrowth
        {
            get
            {
                return this.dilutedEPS9MonthSamePeriodGrowthField;
            }
            set
            {
                this.dilutedEPS9MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedEPSSequentialGrowth
        {
            get
            {
                return this.dilutedEPSSequentialGrowthField;
            }
            set
            {
                this.dilutedEPSSequentialGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedEPS1YearGrowth
        {
            get
            {
                return this.dilutedEPS1YearGrowthField;
            }
            set
            {
                this.dilutedEPS1YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedEPS3YearGrowth
        {
            get
            {
                return this.dilutedEPS3YearGrowthField;
            }
            set
            {
                this.dilutedEPS3YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedEPS5YearGrowth
        {
            get
            {
                return this.dilutedEPS5YearGrowthField;
            }
            set
            {
                this.dilutedEPS5YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedEPS10YearGrowth
        {
            get
            {
                return this.dilutedEPS10YearGrowthField;
            }
            set
            {
                this.dilutedEPS10YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedContinuousEPS3MonthSamePeriodGrowth
        {
            get
            {
                return this.dilutedContinuousEPS3MonthSamePeriodGrowthField;
            }
            set
            {
                this.dilutedContinuousEPS3MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedContinuousEPS6MonthSamePeriodGrowth
        {
            get
            {
                return this.dilutedContinuousEPS6MonthSamePeriodGrowthField;
            }
            set
            {
                this.dilutedContinuousEPS6MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedContinuousEPS9MonthSamePeriodGrowth
        {
            get
            {
                return this.dilutedContinuousEPS9MonthSamePeriodGrowthField;
            }
            set
            {
                this.dilutedContinuousEPS9MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedContinuousEPSSequentialGrowth
        {
            get
            {
                return this.dilutedContinuousEPSSequentialGrowthField;
            }
            set
            {
                this.dilutedContinuousEPSSequentialGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedContinuousEPS1YearGrowth
        {
            get
            {
                return this.dilutedContinuousEPS1YearGrowthField;
            }
            set
            {
                this.dilutedContinuousEPS1YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedContinuousEPS3YearGrowth
        {
            get
            {
                return this.dilutedContinuousEPS3YearGrowthField;
            }
            set
            {
                this.dilutedContinuousEPS3YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedContinuousEPS5YearGrowth
        {
            get
            {
                return this.dilutedContinuousEPS5YearGrowthField;
            }
            set
            {
                this.dilutedContinuousEPS5YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedContinuousEPS10YearGrowth
        {
            get
            {
                return this.dilutedContinuousEPS10YearGrowthField;
            }
            set
            {
                this.dilutedContinuousEPS10YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? Dividend3MonthSamePeriodGrowth
        {
            get
            {
                return this.dividend3MonthSamePeriodGrowthField;
            }
            set
            {
                this.dividend3MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? Dividend6MonthSamePeriodGrowth
        {
            get
            {
                return this.dividend6MonthSamePeriodGrowthField;
            }
            set
            {
                this.dividend6MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? Dividend9MonthSamePeriodGrowth
        {
            get
            {
                return this.dividend9MonthSamePeriodGrowthField;
            }
            set
            {
                this.dividend9MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? DividendSequentialGrowth
        {
            get
            {
                return this.dividendSequentialGrowthField;
            }
            set
            {
                this.dividendSequentialGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? Dividend1YearGrowth
        {
            get
            {
                return this.dividend1YearGrowthField;
            }
            set
            {
                this.dividend1YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? Dividend3YearGrowth
        {
            get
            {
                return this.dividend3YearGrowthField;
            }
            set
            {
                this.dividend3YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? Dividend5YearGrowth
        {
            get
            {
                return this.dividend5YearGrowthField;
            }
            set
            {
                this.dividend5YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? Dividend10YearGrowth
        {
            get
            {
                return this.dividend10YearGrowthField;
            }
            set
            {
                this.dividend10YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? EquityPerShare3MonthSamePeriodGrowth
        {
            get
            {
                return this.equityPerShare3MonthSamePeriodGrowthField;
            }
            set
            {
                this.equityPerShare3MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? EquityPerShare6MonthSamePeriodGrowth
        {
            get
            {
                return this.equityPerShare6MonthSamePeriodGrowthField;
            }
            set
            {
                this.equityPerShare6MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? EquityPerShare9MonthSamePeriodGrowth
        {
            get
            {
                return this.equityPerShare9MonthSamePeriodGrowthField;
            }
            set
            {
                this.equityPerShare9MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? EquityPerShareSequentialGrowth
        {
            get
            {
                return this.equityPerShareSequentialGrowthField;
            }
            set
            {
                this.equityPerShareSequentialGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? EquityPerShare1YearGrowth
        {
            get
            {
                return this.equityPerShare1YearGrowthField;
            }
            set
            {
                this.equityPerShare1YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? EquityPerShare3YearGrowth
        {
            get
            {
                return this.equityPerShare3YearGrowthField;
            }
            set
            {
                this.equityPerShare3YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? EquityPerShare5YearGrowth
        {
            get
            {
                return this.equityPerShare5YearGrowthField;
            }
            set
            {
                this.equityPerShare5YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? EquityPerShare10YearGrowth
        {
            get
            {
                return this.equityPerShare10YearGrowthField;
            }
            set
            {
                this.equityPerShare10YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? Revenue3MonthSamePeriodGrowth
        {
            get
            {
                return this.revenue3MonthSamePeriodGrowthField;
            }
            set
            {
                this.revenue3MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? Revenue6MonthSamePeriodGrowth
        {
            get
            {
                return this.revenue6MonthSamePeriodGrowthField;
            }
            set
            {
                this.revenue6MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? Revenue9MonthSamePeriodGrowth
        {
            get
            {
                return this.revenue9MonthSamePeriodGrowthField;
            }
            set
            {
                this.revenue9MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? RevenueSequentialGrowth
        {
            get
            {
                return this.revenueSequentialGrowthField;
            }
            set
            {
                this.revenueSequentialGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? Revenue1YearGrowth
        {
            get
            {
                return this.revenue1YearGrowthField;
            }
            set
            {
                this.revenue1YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? Revenue3YearGrowth
        {
            get
            {
                return this.revenue3YearGrowthField;
            }
            set
            {
                this.revenue3YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? Revenue5YearGrowth
        {
            get
            {
                return this.revenue5YearGrowthField;
            }
            set
            {
                this.revenue5YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? Revenue10YearGrowth
        {
            get
            {
                return this.revenue10YearGrowthField;
            }
            set
            {
                this.revenue10YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingIncome3MonthSamePeriodGrowth
        {
            get
            {
                return this.operatingIncome3MonthSamePeriodGrowthField;
            }
            set
            {
                this.operatingIncome3MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingIncome6MonthSamePeriodGrowth
        {
            get
            {
                return this.operatingIncome6MonthSamePeriodGrowthField;
            }
            set
            {
                this.operatingIncome6MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingIncome9MonthSamePeriodGrowth
        {
            get
            {
                return this.operatingIncome9MonthSamePeriodGrowthField;
            }
            set
            {
                this.operatingIncome9MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingIncomeSequentialGrowth
        {
            get
            {
                return this.operatingIncomeSequentialGrowthField;
            }
            set
            {
                this.operatingIncomeSequentialGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingIncome1YearGrowth
        {
            get
            {
                return this.operatingIncome1YearGrowthField;
            }
            set
            {
                this.operatingIncome1YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingIncome3YearGrowth
        {
            get
            {
                return this.operatingIncome3YearGrowthField;
            }
            set
            {
                this.operatingIncome3YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingIncome5YearGrowth
        {
            get
            {
                return this.operatingIncome5YearGrowthField;
            }
            set
            {
                this.operatingIncome5YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingIncome10YearGrowth
        {
            get
            {
                return this.operatingIncome10YearGrowthField;
            }
            set
            {
                this.operatingIncome10YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncome3MonthSamePeriodGrowth
        {
            get
            {
                return this.netIncome3MonthSamePeriodGrowthField;
            }
            set
            {
                this.netIncome3MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncome6MonthSamePeriodGrowth
        {
            get
            {
                return this.netIncome6MonthSamePeriodGrowthField;
            }
            set
            {
                this.netIncome6MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncome9MonthSamePeriodGrowth
        {
            get
            {
                return this.netIncome9MonthSamePeriodGrowthField;
            }
            set
            {
                this.netIncome9MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeSequentialGrowth
        {
            get
            {
                return this.netIncomeSequentialGrowthField;
            }
            set
            {
                this.netIncomeSequentialGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncome1YearGrowth
        {
            get
            {
                return this.netIncome1YearGrowthField;
            }
            set
            {
                this.netIncome1YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncome3YearGrowth
        {
            get
            {
                return this.netIncome3YearGrowthField;
            }
            set
            {
                this.netIncome3YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncome5YearGrowth
        {
            get
            {
                return this.netIncome5YearGrowthField;
            }
            set
            {
                this.netIncome5YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncome10YearGrowth
        {
            get
            {
                return this.netIncome10YearGrowthField;
            }
            set
            {
                this.netIncome10YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeContOps3MonthSamePeriodGrowth
        {
            get
            {
                return this.netIncomeContOps3MonthSamePeriodGrowthField;
            }
            set
            {
                this.netIncomeContOps3MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeContOps6MonthSamePeriodGrowth
        {
            get
            {
                return this.netIncomeContOps6MonthSamePeriodGrowthField;
            }
            set
            {
                this.netIncomeContOps6MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeContOps9MonthSamePeriodGrowth
        {
            get
            {
                return this.netIncomeContOps9MonthSamePeriodGrowthField;
            }
            set
            {
                this.netIncomeContOps9MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeContOpsSequentialGrowth
        {
            get
            {
                return this.netIncomeContOpsSequentialGrowthField;
            }
            set
            {
                this.netIncomeContOpsSequentialGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeContOps1YearGrowth
        {
            get
            {
                return this.netIncomeContOps1YearGrowthField;
            }
            set
            {
                this.netIncomeContOps1YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeContOps3YearGrowth
        {
            get
            {
                return this.netIncomeContOps3YearGrowthField;
            }
            set
            {
                this.netIncomeContOps3YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeContOps5YearGrowth
        {
            get
            {
                return this.netIncomeContOps5YearGrowthField;
            }
            set
            {
                this.netIncomeContOps5YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeContOps10YearGrowth
        {
            get
            {
                return this.netIncomeContOps10YearGrowthField;
            }
            set
            {
                this.netIncomeContOps10YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? CFO3MonthSamePeriodGrowth
        {
            get
            {
                return this.cFO3MonthSamePeriodGrowthField;
            }
            set
            {
                this.cFO3MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? CFO6MonthSamePeriodGrowth
        {
            get
            {
                return this.cFO6MonthSamePeriodGrowthField;
            }
            set
            {
                this.cFO6MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? CFO9MonthSamePeriodGrowth
        {
            get
            {
                return this.cFO9MonthSamePeriodGrowthField;
            }
            set
            {
                this.cFO9MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? CFOSequentialGrowth
        {
            get
            {
                return this.cFOSequentialGrowthField;
            }
            set
            {
                this.cFOSequentialGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? CFO1YearGrowth
        {
            get
            {
                return this.cFO1YearGrowthField;
            }
            set
            {
                this.cFO1YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? CFO3YearGrowth
        {
            get
            {
                return this.cFO3YearGrowthField;
            }
            set
            {
                this.cFO3YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? CFO5YearGrowth
        {
            get
            {
                return this.cFO5YearGrowthField;
            }
            set
            {
                this.cFO5YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? CFO10YearGrowth
        {
            get
            {
                return this.cFO10YearGrowthField;
            }
            set
            {
                this.cFO10YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? FCF3MonthSamePeriodGrowth
        {
            get
            {
                return this.fCF3MonthSamePeriodGrowthField;
            }
            set
            {
                this.fCF3MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? FCF6MonthSamePeriodGrowth
        {
            get
            {
                return this.fCF6MonthSamePeriodGrowthField;
            }
            set
            {
                this.fCF6MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? FCF9MonthSamePeriodGrowth
        {
            get
            {
                return this.fCF9MonthSamePeriodGrowthField;
            }
            set
            {
                this.fCF9MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? FCFSequentialGrowth
        {
            get
            {
                return this.fCFSequentialGrowthField;
            }
            set
            {
                this.fCFSequentialGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? FCF1YearGrowth
        {
            get
            {
                return this.fCF1YearGrowthField;
            }
            set
            {
                this.fCF1YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? FCF3YearGrowth
        {
            get
            {
                return this.fCF3YearGrowthField;
            }
            set
            {
                this.fCF3YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? FCF5YearGrowth
        {
            get
            {
                return this.fCF5YearGrowthField;
            }
            set
            {
                this.fCF5YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? FCF10YearGrowth
        {
            get
            {
                return this.fCF10YearGrowthField;
            }
            set
            {
                this.fCF10YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingRevenue3MonthSamePeriodGrowth
        {
            get
            {
                return this.operatingRevenue3MonthSamePeriodGrowthField;
            }
            set
            {
                this.operatingRevenue3MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingRevenue6MonthSamePeriodGrowth
        {
            get
            {
                return this.operatingRevenue6MonthSamePeriodGrowthField;
            }
            set
            {
                this.operatingRevenue6MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingRevenue9MonthSamePeriodGrowth
        {
            get
            {
                return this.operatingRevenue9MonthSamePeriodGrowthField;
            }
            set
            {
                this.operatingRevenue9MonthSamePeriodGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingRevenueSequentialGrowth
        {
            get
            {
                return this.operatingRevenueSequentialGrowthField;
            }
            set
            {
                this.operatingRevenueSequentialGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingRevenue1YearGrowth
        {
            get
            {
                return this.operatingRevenue1YearGrowthField;
            }
            set
            {
                this.operatingRevenue1YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingRevenue3YearGrowth
        {
            get
            {
                return this.operatingRevenue3YearGrowthField;
            }
            set
            {
                this.operatingRevenue3YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingRevenue5YearGrowth
        {
            get
            {
                return this.operatingRevenue5YearGrowthField;
            }
            set
            {
                this.operatingRevenue5YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingRevenue10YearGrowth
        {
            get
            {
                return this.operatingRevenue10YearGrowthField;
            }
            set
            {
                this.operatingRevenue10YearGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? GrowthAnnCapitalSpending5Year
        {
            get
            {
                return this.growthAnnCapitalSpending5YearField;
            }
            set
            {
                this.growthAnnCapitalSpending5YearField = value;
            }
        }

        /// <remarks/>
        public decimal? GrowthAnnGrossProfit5Year
        {
            get
            {
                return this.growthAnnGrossProfit5YearField;
            }
            set
            {
                this.growthAnnGrossProfit5YearField = value;
            }
        }

        /// <remarks/>
        public decimal? AvgGrossMargin5Year
        {
            get
            {
                return this.avgGrossMargin5YearField;
            }
            set
            {
                this.avgGrossMargin5YearField = value;
            }
        }

        /// <remarks/>
        public decimal? AvgPostTaxMargin5Year
        {
            get
            {
                return this.avgPostTaxMargin5YearField;
            }
            set
            {
                this.avgPostTaxMargin5YearField = value;
            }
        }

        /// <remarks/>
        public decimal? AvgPreTaxMargin5Year
        {
            get
            {
                return this.avgPreTaxMargin5YearField;
            }
            set
            {
                this.avgPreTaxMargin5YearField = value;
            }
        }

        /// <remarks/>
        public decimal? AvgNetProfitMargin5Year
        {
            get
            {
                return this.avgNetProfitMargin5YearField;
            }
            set
            {
                this.avgNetProfitMargin5YearField = value;
            }
        }

        /// <remarks/>
        public decimal? AvgRetCommonEquity5Year
        {
            get
            {
                return this.avgRetCommonEquity5YearField;
            }
            set
            {
                this.avgRetCommonEquity5YearField = value;
            }
        }

        /// <remarks/>
        public decimal? AvgRetAssets5Year
        {
            get
            {
                return this.avgRetAssets5YearField;
            }
            set
            {
                this.avgRetAssets5YearField = value;
            }
        }

        /// <remarks/>
        public decimal? AvgRetInvestedCapital5Year
        {
            get
            {
                return this.avgRetInvestedCapital5YearField;
            }
            set
            {
                this.avgRetInvestedCapital5YearField = value;
            }
        }

        /// <remarks/>
        public string AccessionNumber
        {
            get
            {
                return this.accessionNumberField;
            }
            set
            {
                this.accessionNumberField = value;
            }
        }

        /// <remarks/>
        public string FormType
        {
            get
            {
                return this.formTypeField;
            }
            set
            {
                this.formTypeField = value;
            }
        }

        /// <remarks/>
        public decimal? RegressionGrowthOperatingRevenue5Years
        {
            get
            {
                return this.regressionGrowthOperatingRevenue5YearsField;
            }
            set
            {
                this.regressionGrowthOperatingRevenue5YearsField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedDilutedEPSGrowth1year
        {
            get
            {
                return this.normalizedDilutedEPSGrowth1yearField;
            }
            set
            {
                this.normalizedDilutedEPSGrowth1yearField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedDilutedEPSGrowth3year
        {
            get
            {
                return this.normalizedDilutedEPSGrowth3yearField;
            }
            set
            {
                this.normalizedDilutedEPSGrowth3yearField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedDilutedEPSGrowth5year
        {
            get
            {
                return this.normalizedDilutedEPSGrowth5yearField;
            }
            set
            {
                this.normalizedDilutedEPSGrowth5yearField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedDilutedEPSGrowth10year
        {
            get
            {
                return this.normalizedDilutedEPSGrowth10yearField;
            }
            set
            {
                this.normalizedDilutedEPSGrowth10yearField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedDilutedEPSSamePeriodGrowth3months
        {
            get
            {
                return this.normalizedDilutedEPSSamePeriodGrowth3monthsField;
            }
            set
            {
                this.normalizedDilutedEPSSamePeriodGrowth3monthsField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedDilutedEPSSamePeriodGrowth6months
        {
            get
            {
                return this.normalizedDilutedEPSSamePeriodGrowth6monthsField;
            }
            set
            {
                this.normalizedDilutedEPSSamePeriodGrowth6monthsField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedDilutedEPSSamePeriodGrowth9months
        {
            get
            {
                return this.normalizedDilutedEPSSamePeriodGrowth9monthsField;
            }
            set
            {
                this.normalizedDilutedEPSSamePeriodGrowth9monthsField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedDilutedEPSSequentialGrowth
        {
            get
            {
                return this.normalizedDilutedEPSSequentialGrowthField;
            }
            set
            {
                this.normalizedDilutedEPSSequentialGrowthField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedBasicEPSGrowth1year
        {
            get
            {
                return this.normalizedBasicEPSGrowth1yearField;
            }
            set
            {
                this.normalizedBasicEPSGrowth1yearField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedBasicEPSGrowth3year
        {
            get
            {
                return this.normalizedBasicEPSGrowth3yearField;
            }
            set
            {
                this.normalizedBasicEPSGrowth3yearField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedBasicEPSGrowth5year
        {
            get
            {
                return this.normalizedBasicEPSGrowth5yearField;
            }
            set
            {
                this.normalizedBasicEPSGrowth5yearField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedBasicEPSGrowth10year
        {
            get
            {
                return this.normalizedBasicEPSGrowth10yearField;
            }
            set
            {
                this.normalizedBasicEPSGrowth10yearField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedBasicEPSSamePeriodGrowth3months
        {
            get
            {
                return this.normalizedBasicEPSSamePeriodGrowth3monthsField;
            }
            set
            {
                this.normalizedBasicEPSSamePeriodGrowth3monthsField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedBasicEPSSamePeriodGrowth6months
        {
            get
            {
                return this.normalizedBasicEPSSamePeriodGrowth6monthsField;
            }
            set
            {
                this.normalizedBasicEPSSamePeriodGrowth6monthsField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedBasicEPSSamePeriodGrowth9months
        {
            get
            {
                return this.normalizedBasicEPSSamePeriodGrowth9monthsField;
            }
            set
            {
                this.normalizedBasicEPSSamePeriodGrowth9monthsField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedBasicEPSSequentialGrowth
        {
            get
            {
                return this.normalizedBasicEPSSequentialGrowthField;
            }
            set
            {
                this.normalizedBasicEPSSequentialGrowthField = value;
            }
        }
    }
}
