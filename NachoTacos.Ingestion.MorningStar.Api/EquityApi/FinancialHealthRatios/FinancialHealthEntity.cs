using System;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class FinancialHealthEntity
    {

        private DateTime reportDateField;

        private DateTime periodEndingDateField;

        private DateTime? fileDateField;

        private string statementTypeField;

        private string dataTypeField;

        private string interimField;

        private int fiscalYearEndField;

        private decimal? currentRatioField;

        private decimal? quickRatioField;

        private decimal? debtTotalCapitalRatioField;

        private decimal? debtEquityRatioField;

        private decimal? financialLeverageField;

        private decimal? totalDebtToEquityField;

        private string accessionNumberField;

        private string formTypeField;

        private decimal? debttoAssetsField;

        private decimal? commonEquityToAssetsField;

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
        public decimal? CurrentRatio
        {
            get
            {
                return this.currentRatioField;
            }
            set
            {
                this.currentRatioField = value;
            }
        }

        /// <remarks/>
        public decimal? QuickRatio
        {
            get
            {
                return this.quickRatioField;
            }
            set
            {
                this.quickRatioField = value;
            }
        }

        /// <remarks/>
        public decimal? DebtTotalCapitalRatio
        {
            get
            {
                return this.debtTotalCapitalRatioField;
            }
            set
            {
                this.debtTotalCapitalRatioField = value;
            }
        }

        /// <remarks/>
        public decimal? DebtEquityRatio
        {
            get
            {
                return this.debtEquityRatioField;
            }
            set
            {
                this.debtEquityRatioField = value;
            }
        }

        /// <remarks/>
        public decimal? FinancialLeverage
        {
            get
            {
                return this.financialLeverageField;
            }
            set
            {
                this.financialLeverageField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalDebtToEquity
        {
            get
            {
                return this.totalDebtToEquityField;
            }
            set
            {
                this.totalDebtToEquityField = value;
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
        public decimal? DebttoAssets
        {
            get
            {
                return this.debttoAssetsField;
            }
            set
            {
                this.debttoAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? CommonEquityToAssets
        {
            get
            {
                return this.commonEquityToAssetsField;
            }
            set
            {
                this.commonEquityToAssetsField = value;
            }
        }
    }
}
