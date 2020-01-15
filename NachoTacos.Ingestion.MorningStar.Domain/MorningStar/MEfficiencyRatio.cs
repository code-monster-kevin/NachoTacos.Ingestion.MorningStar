using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    [Table("MEfficiencyRatio", Schema = "MStar")]
    public partial class MEfficiencyRatio : MGeneralInfo
    {
        public Guid MEfficiencyRatioId { get; set; }

        private string reportDateField;

        private string periodEndingDateField;

        private string fileDateField;

        private string statementTypeField;

        private string dataTypeField;

        private string interimField;

        private string fiscalYearEndField;

        private string daysInSalesField;

        private string daysInInventoryField;

        private string daysInPaymentField;

        private string cashConversionCycleField;

        private string receivableTurnoverField;

        private string inventoryTurnoverField;

        private string payableTurnoverField;

        private string fixedAssetsTurnoverField;

        private string assetsTurnoverField;

        private string rOEField;

        private string rOAField;

        private string rOICField;

        private string fCFSalesRatioField;

        private string fCFNetIncomeRatioField;

        private string capitalExpenditureSalesRatioField;

        private string accessionNumberField;

        private string formTypeField;

        private string rOE5YrAvgField;

        private string rOA5YrAvgField;

        private string aVG5YrsROICField;

        private string normalizedROICField;

        /// <remarks/>
        public string ReportDate
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
        public string PeriodEndingDate
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
        public string FileDate
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
        public string FiscalYearEnd
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
        public string DaysInSales
        {
            get
            {
                return this.daysInSalesField;
            }
            set
            {
                this.daysInSalesField = value;
            }
        }

        /// <remarks/>
        public string DaysInInventory
        {
            get
            {
                return this.daysInInventoryField;
            }
            set
            {
                this.daysInInventoryField = value;
            }
        }

        /// <remarks/>
        public string DaysInPayment
        {
            get
            {
                return this.daysInPaymentField;
            }
            set
            {
                this.daysInPaymentField = value;
            }
        }

        /// <remarks/>
        public string CashConversionCycle
        {
            get
            {
                return this.cashConversionCycleField;
            }
            set
            {
                this.cashConversionCycleField = value;
            }
        }

        /// <remarks/>
        public string ReceivableTurnover
        {
            get
            {
                return this.receivableTurnoverField;
            }
            set
            {
                this.receivableTurnoverField = value;
            }
        }

        /// <remarks/>
        public string InventoryTurnover
        {
            get
            {
                return this.inventoryTurnoverField;
            }
            set
            {
                this.inventoryTurnoverField = value;
            }
        }

        /// <remarks/>
        public string PayableTurnover
        {
            get
            {
                return this.payableTurnoverField;
            }
            set
            {
                this.payableTurnoverField = value;
            }
        }

        /// <remarks/>
        public string FixedAssetsTurnover
        {
            get
            {
                return this.fixedAssetsTurnoverField;
            }
            set
            {
                this.fixedAssetsTurnoverField = value;
            }
        }

        /// <remarks/>
        public string AssetsTurnover
        {
            get
            {
                return this.assetsTurnoverField;
            }
            set
            {
                this.assetsTurnoverField = value;
            }
        }

        /// <remarks/>
        public string ROE
        {
            get
            {
                return this.rOEField;
            }
            set
            {
                this.rOEField = value;
            }
        }

        /// <remarks/>
        public string ROA
        {
            get
            {
                return this.rOAField;
            }
            set
            {
                this.rOAField = value;
            }
        }

        /// <remarks/>
        public string ROIC
        {
            get
            {
                return this.rOICField;
            }
            set
            {
                this.rOICField = value;
            }
        }

        /// <remarks/>
        public string FCFSalesRatio
        {
            get
            {
                return this.fCFSalesRatioField;
            }
            set
            {
                this.fCFSalesRatioField = value;
            }
        }

        /// <remarks/>
        public string FCFNetIncomeRatio
        {
            get
            {
                return this.fCFNetIncomeRatioField;
            }
            set
            {
                this.fCFNetIncomeRatioField = value;
            }
        }

        /// <remarks/>
        public string CapitalExpenditureSalesRatio
        {
            get
            {
                return this.capitalExpenditureSalesRatioField;
            }
            set
            {
                this.capitalExpenditureSalesRatioField = value;
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
        public string ROE5YrAvg
        {
            get
            {
                return this.rOE5YrAvgField;
            }
            set
            {
                this.rOE5YrAvgField = value;
            }
        }

        /// <remarks/>
        public string ROA5YrAvg
        {
            get
            {
                return this.rOA5YrAvgField;
            }
            set
            {
                this.rOA5YrAvgField = value;
            }
        }

        /// <remarks/>
        public string AVG5YrsROIC
        {
            get
            {
                return this.aVG5YrsROICField;
            }
            set
            {
                this.aVG5YrsROICField = value;
            }
        }

        /// <remarks/>
        public string NormalizedROIC
        {
            get
            {
                return this.normalizedROICField;
            }
            set
            {
                this.normalizedROICField = value;
            }
        }
    }

}
