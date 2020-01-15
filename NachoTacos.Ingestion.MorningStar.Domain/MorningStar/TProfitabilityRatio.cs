using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    [Table("TProfitabilityRatio", Schema = "MStar")]
    public partial class TProfitabilityRatio : TBase
    {

        private DateTime reportDateField;

        private DateTime periodEndingDateField;

        private DateTime? fileDateField;

        private string statementTypeField;

        private string dataTypeField;

        private string interimField;

        private string currencyIdField;

        private int fiscalYearEndField;

        private decimal? grossMarginField;

        private decimal? operatingMarginField;

        private decimal? eBTMarginField;

        private decimal? taxRateField;

        private decimal? netMarginField;

        private decimal? salesPerEmployeeField;

        private decimal? eBITMarginField;

        private decimal? eBITDAMarginField;

        private decimal? normalizedNetProfitMarginField;

        private decimal? interestCoverageField;

        private decimal? netIncomeperFullTimeEmployeeField;

        private decimal? incPerEmployeeTotOpsField;

        private decimal? solvencyRatioField;

        private decimal? expenseRatioField;

        private decimal? lossRatioField;

        private string accessionNumberField;

        private string formTypeField;

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
        public string CurrencyId
        {
            get
            {
                return this.currencyIdField;
            }
            set
            {
                this.currencyIdField = value;
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
        public decimal? GrossMargin
        {
            get
            {
                return this.grossMarginField;
            }
            set
            {
                this.grossMarginField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingMargin
        {
            get
            {
                return this.operatingMarginField;
            }
            set
            {
                this.operatingMarginField = value;
            }
        }

        /// <remarks/>
        public decimal? EBTMargin
        {
            get
            {
                return this.eBTMarginField;
            }
            set
            {
                this.eBTMarginField = value;
            }
        }

        /// <remarks/>
        public decimal? TaxRate
        {
            get
            {
                return this.taxRateField;
            }
            set
            {
                this.taxRateField = value;
            }
        }

        /// <remarks/>
        public decimal? NetMargin
        {
            get
            {
                return this.netMarginField;
            }
            set
            {
                this.netMarginField = value;
            }
        }

        /// <remarks/>
        public decimal? SalesPerEmployee
        {
            get
            {
                return this.salesPerEmployeeField;
            }
            set
            {
                this.salesPerEmployeeField = value;
            }
        }

        /// <remarks/>
        public decimal? EBITMargin
        {
            get
            {
                return this.eBITMarginField;
            }
            set
            {
                this.eBITMarginField = value;
            }
        }

        /// <remarks/>
        public decimal? EBITDAMargin
        {
            get
            {
                return this.eBITDAMarginField;
            }
            set
            {
                this.eBITDAMarginField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedNetProfitMargin
        {
            get
            {
                return this.normalizedNetProfitMarginField;
            }
            set
            {
                this.normalizedNetProfitMarginField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestCoverage
        {
            get
            {
                return this.interestCoverageField;
            }
            set
            {
                this.interestCoverageField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeperFullTimeEmployee
        {
            get
            {
                return this.netIncomeperFullTimeEmployeeField;
            }
            set
            {
                this.netIncomeperFullTimeEmployeeField = value;
            }
        }

        /// <remarks/>
        public decimal? IncPerEmployeeTotOps
        {
            get
            {
                return this.incPerEmployeeTotOpsField;
            }
            set
            {
                this.incPerEmployeeTotOpsField = value;
            }
        }

        /// <remarks/>
        public decimal? SolvencyRatio
        {
            get
            {
                return this.solvencyRatioField;
            }
            set
            {
                this.solvencyRatioField = value;
            }
        }

        /// <remarks/>
        public decimal? ExpenseRatio
        {
            get
            {
                return this.expenseRatioField;
            }
            set
            {
                this.expenseRatioField = value;
            }
        }

        /// <remarks/>
        public decimal? LossRatio
        {
            get
            {
                return this.lossRatioField;
            }
            set
            {
                this.lossRatioField = value;
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
    }

}
