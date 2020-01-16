using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    [Table("TQuantitativeRating", Schema = "MStar")]
    public class TQuantitativeRating : TBase
    {
        private DateTime asOfDateField;

        private decimal? quantitativeMoatField;

        private string quantitativeMoatLabelField;

        private decimal? quantitativeValuationField;

        private DateTime quantitativeValuationUpdateTimeField;

        private string quantitativeValuationLabelField;

        private DateTime quantitativeValuationLabelUpdateTimeField;

        private decimal? quantitativeValuationUncertaintyField;

        private string quantitativeValuationUncertaintyLabelField;

        private decimal? quantitativeFinancialHealthField;

        private string quantitativeFinancialHealthLabelField;

        private decimal? solvencyScoreField;

        private int quantitativeFinancialHealthDecileField;

        private int quantitativeStarRatingField;

        private DateTime quantitativeStarRatingUpdateTimeField;

        private decimal? quantitativeFairValueField;

        private DateTime quantitativeFairValueUpdateTimeField;

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
        public decimal? QuantitativeMoat
        {
            get
            {
                return this.quantitativeMoatField;
            }
            set
            {
                this.quantitativeMoatField = value;
            }
        }

        /// <remarks/>
        public string QuantitativeMoatLabel
        {
            get
            {
                return this.quantitativeMoatLabelField;
            }
            set
            {
                this.quantitativeMoatLabelField = value;
            }
        }

        /// <remarks/>
        public decimal? QuantitativeValuation
        {
            get
            {
                return this.quantitativeValuationField;
            }
            set
            {
                this.quantitativeValuationField = value;
            }
        }

        /// <remarks/>
        public DateTime QuantitativeValuationUpdateTime
        {
            get
            {
                return this.quantitativeValuationUpdateTimeField;
            }
            set
            {
                this.quantitativeValuationUpdateTimeField = value;
            }
        }

        /// <remarks/>
        public string QuantitativeValuationLabel
        {
            get
            {
                return this.quantitativeValuationLabelField;
            }
            set
            {
                this.quantitativeValuationLabelField = value;
            }
        }

        /// <remarks/>
        public DateTime QuantitativeValuationLabelUpdateTime
        {
            get
            {
                return this.quantitativeValuationLabelUpdateTimeField;
            }
            set
            {
                this.quantitativeValuationLabelUpdateTimeField = value;
            }
        }

        /// <remarks/>
        public decimal? QuantitativeValuationUncertainty
        {
            get
            {
                return this.quantitativeValuationUncertaintyField;
            }
            set
            {
                this.quantitativeValuationUncertaintyField = value;
            }
        }

        /// <remarks/>
        public string QuantitativeValuationUncertaintyLabel
        {
            get
            {
                return this.quantitativeValuationUncertaintyLabelField;
            }
            set
            {
                this.quantitativeValuationUncertaintyLabelField = value;
            }
        }

        /// <remarks/>
        public decimal? QuantitativeFinancialHealth
        {
            get
            {
                return this.quantitativeFinancialHealthField;
            }
            set
            {
                this.quantitativeFinancialHealthField = value;
            }
        }

        /// <remarks/>
        public string QuantitativeFinancialHealthLabel
        {
            get
            {
                return this.quantitativeFinancialHealthLabelField;
            }
            set
            {
                this.quantitativeFinancialHealthLabelField = value;
            }
        }

        /// <remarks/>
        public decimal? SolvencyScore
        {
            get
            {
                return this.solvencyScoreField;
            }
            set
            {
                this.solvencyScoreField = value;
            }
        }

        /// <remarks/>
        public int QuantitativeFinancialHealthDecile
        {
            get
            {
                return this.quantitativeFinancialHealthDecileField;
            }
            set
            {
                this.quantitativeFinancialHealthDecileField = value;
            }
        }

        /// <remarks/>
        public int QuantitativeStarRating
        {
            get
            {
                return this.quantitativeStarRatingField;
            }
            set
            {
                this.quantitativeStarRatingField = value;
            }
        }

        /// <remarks/>
        public DateTime QuantitativeStarRatingUpdateTime
        {
            get
            {
                return this.quantitativeStarRatingUpdateTimeField;
            }
            set
            {
                this.quantitativeStarRatingUpdateTimeField = value;
            }
        }

        /// <remarks/>
        public decimal? QuantitativeFairValue
        {
            get
            {
                return this.quantitativeFairValueField;
            }
            set
            {
                this.quantitativeFairValueField = value;
            }
        }

        /// <remarks/>
        public DateTime QuantitativeFairValueUpdateTime
        {
            get
            {
                return this.quantitativeFairValueUpdateTimeField;
            }
            set
            {
                this.quantitativeFairValueUpdateTimeField = value;
            }
        }
    }

}
