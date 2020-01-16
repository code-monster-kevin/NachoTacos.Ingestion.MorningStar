using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    [Table("MEfficiencyRatioTTM", Schema = "MStar")]
    public partial class MEfficiencyRatioTTM : MGeneralInfo
    {
        public Guid MEfficiencyRatioTTMId { get; set; }

        private DateTime reportDateField;

        private DateTime periodEndingDateField;

        private DateTime? fileDateField;

        private string statementTypeField;

        private string dataTypeField;

        private string interimField;

        private int fiscalYearEndField;

        private decimal? daysInSalesField;

        private decimal? daysInInventoryField;

        private decimal? daysInPaymentField;

        private decimal? cashConversionCycleField;

        private decimal? receivableTurnoverField;

        private decimal? inventoryTurnoverField;

        private decimal? payableTurnoverField;

        private decimal? fixedAssetsTurnoverField;

        private decimal? assetsTurnoverField;

        private decimal? rOEField;

        private decimal? rOAField;

        private decimal? rOICField;

        private decimal? fCFSalesRatioField;

        private decimal? fCFNetIncomeRatioField;

        private decimal? capitalExpenditureSalesRatioField;

        private string accessionNumberField;

        private string formTypeField;

        private decimal? rOE5YrAvgField;

        private decimal? rOA5YrAvgField;

        private decimal? aVG5YrsROICField;

        private decimal? normalizedROICField;

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
        public decimal? DaysInSales
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
        public decimal? DaysInInventory
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
        public decimal? DaysInPayment
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
        public decimal? CashConversionCycle
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
        public decimal? ReceivableTurnover
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
        public decimal? InventoryTurnover
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
        public decimal? PayableTurnover
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
        public decimal? FixedAssetsTurnover
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
        public decimal? AssetsTurnover
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
        public decimal? ROE
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
        public decimal? ROA
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
        public decimal? ROIC
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
        public decimal? FCFSalesRatio
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
        public decimal? FCFNetIncomeRatio
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
        public decimal? CapitalExpenditureSalesRatio
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
        public decimal? ROE5YrAvg
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
        public decimal? ROA5YrAvg
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
        public decimal? AVG5YrsROIC
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
        public decimal? NormalizedROIC
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
