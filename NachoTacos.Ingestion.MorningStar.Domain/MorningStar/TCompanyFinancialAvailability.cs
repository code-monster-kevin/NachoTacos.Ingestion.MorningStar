using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    // Class copied from NachoTacos.Ingestion.MorningStar.Api.EquityApi.CompanyFinancials.CompanyFinancialAvailabilityEntity
    // Inherits TBase class
    // Add Schema Annotation
    [Table("TCompanyFinancialAvailability", Schema = "MStar")]
    public class TCompanyFinancialAvailability : TBase
    {
        private string companyNameField;

        private string exchangeIdField;

        private string symbolField;

        private string cUSIPField;

        private string cIKField;

        private string iSINField;

        private string sEDOLField;

        private int startField;

        private int endField;

        private string sectorIdField;

        private string sectorNameField;

        private string industryGroupIdField;

        private string industryGroupNameField;

        private string industryIdField;

        private string industryNameField;

        private DateTime latestQuarterlyReportDateField;

        private DateTime latestAnnualReportDateField;

        private DateTime latestPreliminaryReportDateField;

        private DateTime latestSemiAnnualReportDateField;

        private string templateCodeField;

        private string globalTemplateCodeField;

        /// <remarks/>
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        public string ExchangeId
        {
            get
            {
                return this.exchangeIdField;
            }
            set
            {
                this.exchangeIdField = value;
            }
        }

        /// <remarks/>
        public string Symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        public string CUSIP
        {
            get
            {
                return this.cUSIPField;
            }
            set
            {
                this.cUSIPField = value;
            }
        }

        /// <remarks/>
        public string CIK
        {
            get
            {
                return this.cIKField;
            }
            set
            {
                this.cIKField = value;
            }
        }

        /// <remarks/>
        public string ISIN
        {
            get
            {
                return this.iSINField;
            }
            set
            {
                this.iSINField = value;
            }
        }

        /// <remarks/>
        public string SEDOL
        {
            get
            {
                return this.sEDOLField;
            }
            set
            {
                this.sEDOLField = value;
            }
        }

        /// <remarks/>
        public int Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        public int End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        public string SectorId
        {
            get
            {
                return this.sectorIdField;
            }
            set
            {
                this.sectorIdField = value;
            }
        }

        /// <remarks/>
        public string SectorName
        {
            get
            {
                return this.sectorNameField;
            }
            set
            {
                this.sectorNameField = value;
            }
        }

        /// <remarks/>
        public string IndustryGroupId
        {
            get
            {
                return this.industryGroupIdField;
            }
            set
            {
                this.industryGroupIdField = value;
            }
        }

        /// <remarks/>
        public string IndustryGroupName
        {
            get
            {
                return this.industryGroupNameField;
            }
            set
            {
                this.industryGroupNameField = value;
            }
        }

        /// <remarks/>
        public string IndustryId
        {
            get
            {
                return this.industryIdField;
            }
            set
            {
                this.industryIdField = value;
            }
        }

        /// <remarks/>
        public string IndustryName
        {
            get
            {
                return this.industryNameField;
            }
            set
            {
                this.industryNameField = value;
            }
        }

        /// <remarks/>
        public DateTime LatestQuarterlyReportDate
        {
            get
            {
                return this.latestQuarterlyReportDateField;
            }
            set
            {
                this.latestQuarterlyReportDateField = value;
            }
        }

        /// <remarks/>
        public DateTime LatestAnnualReportDate
        {
            get
            {
                return this.latestAnnualReportDateField;
            }
            set
            {
                this.latestAnnualReportDateField = value;
            }
        }

        /// <remarks/>
        public DateTime LatestPreliminaryReportDate
        {
            get
            {
                return this.latestPreliminaryReportDateField;
            }
            set
            {
                this.latestPreliminaryReportDateField = value;
            }
        }

        /// <remarks/>
        public DateTime LatestSemiAnnualReportDate
        {
            get
            {
                return this.latestSemiAnnualReportDateField;
            }
            set
            {
                this.latestSemiAnnualReportDateField = value;
            }
        }

        /// <remarks/>
        public string TemplateCode
        {
            get
            {
                return this.templateCodeField;
            }
            set
            {
                this.templateCodeField = value;
            }
        }

        /// <remarks/>
        public string GlobalTemplateCode
        {
            get
            {
                return this.globalTemplateCodeField;
            }
            set
            {
                this.globalTemplateCodeField = value;
            }
        }
    }

}
