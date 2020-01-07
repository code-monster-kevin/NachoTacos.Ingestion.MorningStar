using System;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    // Code generated from xml/BalanceSheetEntity.xml (Paste Special -> Paste XML as Classes)

    // Steps after copy XML to class
    // Replaced string with decimal?
    // Changed reportDate, periodEndingDate, fileDate to DateTime
    // Changed StatementType, DataType, Interim, CurrencyId, AccessionNumber, FormType to string
#pragma warning disable IDE1006
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class BalanceSheetEntity
    {

        private DateTime reportDateField;

        private DateTime periodEndingDateField;

        private DateTime? fileDateField;

        private string statementTypeField;

        private string dataTypeField;

        private string interimField;

        private string currencyIdField;

        private int fiscalYearEndField;

        private decimal? accountsPayableField;

        private decimal? accountsReceivableField;

        private decimal? grossAccountsReceivableField;

        private decimal? nonCurrentAccountsReceivableField;

        private decimal? currentAccruedExpensesField;

        private decimal? nonCurrentAccruedExpensesField;

        private decimal? accruedInterestReceivableField;

        private decimal? accruedInvestmentIncomeField;

        private decimal? accumulatedDepreciationField;

        private decimal? gainsLossesNotAffectingRetainedEarningsField;

        private decimal? additionalPaidInCapitalField;

        private decimal? advanceFromFederalHomeLoanBanksField;

        private decimal? allowanceForDoubtfulAccountsReceivableField;

        private decimal? allowanceForLoansAndLeaseLossesField;

        private decimal? allowanceForNotesReceivableField;

        private decimal? assetsHeldForSaleField;

        private decimal? assetsOfDiscontinuedOperationsField;

        private decimal? availableForSaleSecuritiesField;

        private decimal? bankAcceptanceExecutedAndOutstandingField;

        private decimal? bankIndebtednessField;

        private decimal? bankLoanField;

        private decimal? bankOwnedLifeInsuranceField;

        private decimal? securityBorrowedField;

        private decimal? buildingsAndImprovementsField;

        private decimal? capitalStockField;

        private decimal? cashField;

        private decimal? cashEquivalentsField;

        private decimal? cashAndCashEquivalentsField;

        private decimal? cashAndDueFromBanksField;

        private decimal? cashCashEquivalentsAndFederalFundsSoldField;

        private decimal? cashCashEquivalentsAndShortTermInvestmentsField;

        private decimal? casualtyClaimsField;

        private decimal? cededUnearnedPremiumsField;

        private decimal? commercialLoanField;

        private decimal? commercialPaperField;

        private decimal? commonStockField;

        private decimal? commonStockEquityField;

        private decimal? commonStocksAvailableForSaleField;

        private decimal? constructionInProgressField;

        private decimal? consumerLoanField;

        private decimal? minimumPensionLiabilitiesField;

        private decimal? currentAssetsField;

        private decimal? currentDebtField;

        private decimal? currentDebtAndCapitalLeaseObligationField;

        private decimal? currentLiabilitiesField;

        private decimal? currentCapitalLeaseObligationField;

        private decimal? customerAcceptancesField;

        private decimal? deferredAcquisitionCostsField;

        private decimal? deferredAssetsField;

        private decimal? deferredCostsField;

        private decimal? deferredFinancingCostsField;

        private decimal? nonCurrentDeferredLiabilitiesField;

        private decimal? currentDeferredLiabilitiesField;

        private decimal? deferredPolicyAcquisitionCostsField;

        private decimal? currentDeferredRevenueField;

        private decimal? nonCurrentDeferredRevenueField;

        private decimal? deferredTaxAssetsField;

        private decimal? currentDeferredTaxesAssetsField;

        private decimal? currentDeferredTaxesLiabilitiesField;

        private decimal? nonCurrentDeferredTaxesAssetsField;

        private decimal? nonCurrentDeferredTaxesLiabilitiesField;

        private decimal? definedPensionBenefitField;

        private decimal? derivativeProductLiabilitiesField;

        private decimal? derivativeAssetsField;

        private decimal? dividendsPayableField;

        private decimal? eSOPDebtGuaranteeField;

        private decimal? employeeBenefitsField;

        private decimal? equityInvestmentsField;

        private decimal? facilitiesAndOtherField;

        private decimal? federalFundsPurchasedField;

        private decimal? federalFundsPurchasedAndSecuritiesSoldUnderAgreementToRepurchaseField;

        private decimal? federalFundsSoldField;

        private decimal? federalFundsSoldAndSecuritiesPurchaseUnderAgreementsToResellField;

        private decimal? federalHomeLoanBankStockField;

        private decimal? financialAssetsField;

        private decimal? financialInstrumentsSoldUnderAgreementsToRepurchaseField;

        private decimal? finishedGoodsField;

        private decimal? fixedMaturitiesAvailableForSaleField;

        private decimal? fixedMaturitiesHeldToMaturityField;

        private decimal? fixedMaturitiesTradingField;

        private decimal? fixedMaturityInvestmentsField;

        private decimal? flightFleetVehicleAndRelatedEquipmentsField;

        private decimal? foreclosedAssetsField;

        private decimal? foreignComponentField;

        private decimal? foreignCurrencyTranslationAdjustmentsField;

        private decimal? fuelAndNaturalGasField;

        private decimal? futurePolicyBenefitsField;

        private decimal? generalPartnershipCapitalField;

        private decimal? goodwillField;

        private decimal? goodwillAndOtherIntangibleAssetsField;

        private decimal? grossLoanField;

        private decimal? grossPPEField;

        private decimal? guaranteedInvestmentContractField;

        private decimal? heldToMaturitySecuritiesField;

        private decimal? incomeTaxPayableField;

        private decimal? interestBearingDepositsLiabilitiesField;

        private decimal? interestPayableField;

        private decimal? interestBearingDepositsAssetsField;

        private decimal? inventoryField;

        private decimal? inventoriesAdjustmentsAllowancesField;

        private decimal? investmentTaxCreditsField;

        private decimal? investmentsAndAdvancesField;

        private decimal? investmentsInAffiliatesSubsidiariesAssociatesAndJointVenturesField;

        private decimal? investmentsInOtherVenturesUnderEquityMethodField;

        private decimal? investmentsInVariableInterestEntityField;

        private decimal? landAndImprovementsField;

        private decimal? leasesField;

        private decimal? liabilitiesOfDiscontinuedOperationsField;

        private decimal? limitedPartnershipCapitalField;

        private decimal? limitedPartnershipField;

        private decimal? lineOfCreditField;

        private decimal? loansHeldForSaleField;

        private decimal? loansReceivableField;

        private decimal? longTermDebtField;

        private decimal? longTermDebtAndCapitalLeaseObligationField;

        private decimal? longTermEquityInvestmentField;

        private decimal? longTermCapitalLeaseObligationField;

        private decimal? machineryFurnitureEquipmentField;

        private decimal? materialsAndSuppliesField;

        private decimal? mineralPropertiesField;

        private decimal? minorityInterestField;

        private decimal? moneyMarketInvestmentsField;

        private decimal? mortgageLoanField;

        private decimal? mortgageAndConsumerloansField;

        private decimal? naturalResourceAssetsField;

        private decimal? netLoanField;

        private decimal? netOtherUnrealizedGainLossField;

        private decimal? netPPEField;

        private decimal? netUnrealizedGainLossForeignCurrencyField;

        private decimal? netUnrealizedGainLossInvestmentsField;

        private decimal? nonInterestBearingDepositsField;

        private decimal? currentNotesPayableField;

        private decimal? notesReceivableField;

        private decimal? grossNotesReceivableField;

        private decimal? nonCurrentNoteReceivablesField;

        private decimal? otherAssetsField;

        private decimal? otherCapitalStockField;

        private decimal? otherCurrentAssetsField;

        private decimal? otherCurrentBorrowingsField;

        private decimal? otherCurrentLiabilitiesField;

        private decimal? otherDeferredCostsField;

        private decimal? otherDepositsField;

        private decimal? otherEquityAdjustmentsField;

        private decimal? otherIntangibleAssetsField;

        private decimal? otherInterestEarningAssetsField;

        private decimal? otherInventoriesField;

        private decimal? otherInvestedAssetsField;

        private decimal? otherNonCurrentAssetsField;

        private decimal? otherPropertiesField;

        private decimal? otherRealEstateOwnedField;

        private decimal? otherReceivablesField;

        private decimal? shortTermInvestmentsField;

        private decimal? patentsField;

        private decimal? payablesField;

        private decimal? payablesAndAccruedExpensesField;

        private decimal? nonCurrentPensionAndOtherPostretirementBenefitPlansField;

        private decimal? policyLoansField;

        private decimal? totalPolicyHoldersLiabilitiesField;

        private decimal? policyholderFundsField;

        private decimal? preferredSecuritiesOutsideStockEquityField;

        private decimal? trustPreferredSecuritiesField;

        private decimal? preferredStockField;

        private decimal? preferredStockEquityField;

        private decimal? preferredStockOfSubsidiaryField;

        private decimal? preferredStocksAvailableForSaleField;

        private decimal? premiumsReceivableField;

        private decimal? prepaidAssetsField;

        private decimal? nonCurrentPrepaidAssetsField;

        private decimal? prepaidReinsurancePremiumsField;

        private decimal? propertiesField;

        private decimal? currentProvisionsField;

        private decimal? longTermProvisionsField;

        private decimal? purchasedComponentsField;

        private decimal? rawMaterialsField;

        private decimal? realEstateHeldForSaleField;

        private decimal? realEstateAndRealEstateJointVenturesHeldForInvestmentField;

        private decimal? receivablesField;

        private decimal? recievablesAdjustmentsAllowancesField;

        private decimal? redeemablePreferredStockField;

        private decimal? regulatoryAssetsField;

        private decimal? regulatoryLiabilitiesField;

        private decimal? reinsuranceBalancesPayableField;

        private decimal? reinsuranceReceivablesField;

        private decimal? reinsuranceRecoverableField;

        private decimal? reinsuranceRecoverableForPaidLossesField;

        private decimal? reinsuranceRecoverableForUnpaidLossesField;

        private decimal? restrictedCashField;

        private decimal? restrictedCashAndCashEquivalentsField;

        private decimal? restrictedCashAndInvestmentsField;

        private decimal? restrictedCommonStockField;

        private decimal? restrictedInvestmentsField;

        private decimal? retainedEarningsField;

        private decimal? securitiesLendingCollateralField;

        private decimal? securitiesLendingPayableField;

        private decimal? securityAgreeToBeResellField;

        private decimal? securitySoldNotYetRepurchasedField;

        private decimal? separateAccountAssetsField;

        private decimal? separateAccountLiabilityField;

        private decimal? shortTermInvestmentsAvailableForSaleField;

        private decimal? shortTermInvestmentsHeldToMaturityField;

        private decimal? shortTermInvestmentsTradingField;

        private decimal? stockholdersEquityField;

        private decimal? studentLoanField;

        private decimal? totalTaxPayableField;

        private decimal? taxesReceivableField;

        private decimal? timeDepositsPlacedField;

        private decimal? totalAssetsField;

        private decimal? totalCapitalizationField;

        private decimal? totalDeferredCreditsAndOtherNonCurrentLiabilitiesField;

        private decimal? totalDepositsField;

        private decimal? totalInvestmentsField;

        private decimal? totalLiabilitiesField;

        private decimal? totalNonCurrentAssetsField;

        private decimal? totalNonCurrentLiabilitiesField;

        private decimal? totalPartnershipCapitalField;

        private decimal? tradingAssetsField;

        private decimal? tradingLiabilitiesField;

        private decimal? tradingSecuritiesField;

        private decimal? treasuryStockField;

        private decimal? unbilledReceivablesField;

        private decimal? unearnedIncomeField;

        private decimal? unearnedPremiumsField;

        private decimal? unpaidLossAndLossReserveField;

        private decimal? unrealizedGainLossField;

        private decimal? workInProcessField;

        private decimal? otherNonCurrentLiabilitiesField;

        private decimal? capitalLeaseObligationsField;

        private decimal? otherLiabilitiesField;

        private decimal? otherPayableField;

        private decimal? investedCapitalField;

        private decimal? tangibleBookValueField;

        private decimal? totalEquityField;

        private decimal? workingCapitalField;

        private decimal? totalDebtField;

        private decimal? cashValueOfLifeInsuranceField;

        private decimal? commonUtilityPlantField;

        private decimal? currentDeferredAssetsField;

        private decimal? nonCurrentDeferredAssetsField;

        private decimal? electricUtilityPlantField;

        private decimal? naturalGasFuelAndOtherField;

        private decimal? netUtilityPlantField;

        private decimal? waterProductionField;

        private decimal? securitiesAndInvestmentsField;

        private decimal? ordinarySharesNumberField;

        private decimal? preferredSharesNumberField;

        private decimal? treasurySharesNumberField;

        private decimal? totalLiabilitiesNetMinorityInterestField;

        private decimal? totalNonCurrentLiabilitiesNetMinorityInterestField;

        private decimal? totalEquityGrossMinorityInterestField;

        private decimal? tradingAndOtherReceivableField;

        private string accessionNumberField;

        private string formTypeField;

        private decimal? securitiesLoanedField;

        private decimal? participatingPolicyholderEquityField;

        private decimal? netTangibleAssetsField;

        private decimal? duefromRelatedPartiesCurrentField;

        private decimal? duefromRelatedPartiesNonCurrentField;

        private decimal? duetoRelatedPartiesField;

        private decimal? duetoRelatedPartiesCurrentField;

        private decimal? duetoRelatedPartiesNonCurrentField;

        private decimal? netAssetsField;

        private decimal? investmentPropertiesField;

        private decimal? investmentsinSubsidiariesatCostField;

        private decimal? investmentsinAssociatesatCostField;

        private decimal? investmentsinJointVenturesatCostField;

        private decimal? investmentinFinancialAssetsField;

        private decimal? financeLeaseReceivablesField;

        private decimal? convertibleLoansCurrentField;

        private decimal? bankLoansCurrentField;

        private decimal? otherLoansCurrentField;

        private decimal? accruedandDeferredIncomeField;

        private decimal? bankLoansNonCurrentField;

        private decimal? otherLoansNonCurrentField;

        private decimal? otherReservesField;

        private decimal? loansandAdvancestoBankField;

        private decimal? loansandAdvancestoCustomerField;

        private decimal? treasuryBillsandOtherEligibleBillsField;

        private decimal? equitySharesInvestmentsField;

        private decimal? depositsbyBankField;

        private decimal? customerAccountsField;

        private decimal? itemsinTheCourseofTransmissiontoOtherBanksField;

        private decimal? tradingandFinancialLiabilitiesField;

        private decimal? debtSecuritiesinIssueField;

        private decimal? subordinatedLiabilitiesField;

        private decimal? provisionsTotalField;

        private decimal? operatingLeaseAssetsField;

        private decimal? claimsOutstandingField;

        private decimal? longTermContractsField;

        private decimal? realEstateField;

        private decimal? paymentofBillsField;

        private decimal? liabilitiesHeldforSaleCurrentField;

        private decimal? liabilitiesHeldforSaleNonCurrentField;

        private decimal? unclassifiedCurrentAssetsField;

        private decimal? debtSecuritiesField;

        private decimal? totalFinancialLeaseObligationsField;

        private decimal? accruedandDeferredIncomeCurrentField;

        private decimal? accruedandDeferredIncomeNonCurrentField;

        private decimal? financeLeaseReceivablesCurrentField;

        private decimal? financeLeaseReceivablesNonCurrentField;

        private decimal? financialLiabilitiesCurrentField;

        private decimal? financialLiabilitiesNonCurrentField;

        private decimal? financialAssetsDesignatedasFairValueThroughProfitorLossTotalField;

        private decimal? taxesAssetsCurrentField;

        private decimal? otherEquityInterestField;

        private decimal? interestBearingBorrowingsNonCurrentField;

        private decimal? nonInterestBearingBorrowingsNonCurrentField;

        private decimal? tradeandOtherPayablesNonCurrentField;

        private decimal? interestBearingBorrowingsCurrentField;

        private decimal? nonInterestBearingBorrowingsCurrentField;

        private decimal? pensionandOtherPostRetirementBenefitPlansCurrentField;

        private decimal? cashandBalanceswithCentralBanksField;

        private decimal? placementwithBanksandOtherFinancialInstitutionsField;

        private decimal? otherLoanAssetsField;

        private decimal? hedgingAssetsTotalField;

        private decimal? assetsPledgedasCollateralSubjecttoSaleorRepledgingTotalField;

        private decimal? taxAssetsTotalField;

        private decimal? advancesfromCentralBanksField;

        private decimal? certificatesofDepositsandOtherDebtSecuritiesIssuedField;

        private decimal? depositCertificatesField;

        private decimal? debenturesandDebtCertificatesField;

        private decimal? interestBearingBorrowingsTotalField;

        private decimal? nonInterestBearingBorrowingsTotalField;

        private decimal? otherBorrowedFundsField;

        private decimal? financialLiabilitiesDesignatedasFairValueThroughProfitorLossTotalField;

        private decimal? financialLiabilitiesMeasuredatAmortizedCostTotalField;

        private decimal? loanCapitalField;

        private decimal? hedgingLiabilitiesTotalField;

        private decimal? liabilitiesRecognizedforFairValueChangesinPortfolioHedgeofInterestRateRiskField;

        private decimal? accruedLiabilitiesTotalField;

        private decimal? deferredIncomeTotalField;

        private decimal? deferredTaxLiabilitiesTotalField;

        private decimal? reinsuranceAssetsField;

        private decimal? reinsuranceShareofInsuranceContractField;

        private decimal? reinsuranceShareofAccruedPolicyholderClaimsField;

        private decimal? depositsMadeunderAssumedReinsuranceContractField;

        private decimal? insuranceContractAssetsField;

        private decimal? insuranceReceivablesField;

        private decimal? insuranceContractLiabilitiesField;

        private decimal? insurancePayablesField;

        private decimal? depositsReceivedunderCededInsuranceContractField;

        private decimal? investmentContractLiabilitiesField;

        private decimal? constructionGrantsField;

        private decimal? deferredCostCurrentField;

        private decimal? pensionAndOtherPostretirementBenefitPlansTotalField;

        private decimal? liabilitiesHeldforSaleTotalField;

        private decimal? hedgingAssetsNonCurrentField;

        private decimal? hedgingAssetsCurrentField;

        private decimal? convertibleLoansTotalField;

        private decimal? bankLoansTotalField;

        private decimal? otherLoansTotalField;

        private decimal? hedgingLiabilitiesNonCurrentField;

        private decimal? hedgingLiabilitiesCurrentField;

        private decimal? insuranceFundsNonCurrentField;

        private decimal? insuranceFundsCurrentField;

        private decimal? debtTotalField;

        private decimal? assetsHeldForSaleCurrentField;

        private decimal? assetsHeldForSaleNonCurrentField;

        private decimal? biologicalAssetsField;

        private decimal? cashRestrictedOrPledgedField;

        private decimal? convertibleLoansNonCurrentField;

        private decimal? financialOrDerivativeInvestmentCurrentLiabilitiesField;

        private decimal? loanAndLoanReceivablesField;

        private decimal? otherInvestmentsField;

        private decimal? tradeAndOtherReceivablesNonCurrentField;

        private decimal? debtDueInYear1Field;

        private decimal? debtDueInYear2Field;

        private decimal? debtDueInYear5Field;

        private decimal? debtDueBeyondField;

        private decimal? totalDebtInMaturityScheduleField;

        private decimal? fiscalYearChangeField;

        private decimal? fixedAssetsRevaluationReserveField;

        private decimal? currentOtherFinancialLiabilitiesField;

        private decimal? nonCurrentOtherFinancialLiabilitiesField;

        private decimal? otherFinancialLiabilitiesField;

        private decimal? totalLiabilitiesAsReportedField;

        private decimal? totalEquityAsReportedField;

        private decimal? unallocatedSurplusField;

        private decimal? netDebtField;

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
        public decimal? AccountsPayable
        {
            get
            {
                return this.accountsPayableField;
            }
            set
            {
                this.accountsPayableField = value;
            }
        }

        /// <remarks/>
        public decimal? AccountsReceivable
        {
            get
            {
                return this.accountsReceivableField;
            }
            set
            {
                this.accountsReceivableField = value;
            }
        }

        /// <remarks/>
        public decimal? GrossAccountsReceivable
        {
            get
            {
                return this.grossAccountsReceivableField;
            }
            set
            {
                this.grossAccountsReceivableField = value;
            }
        }

        /// <remarks/>
        public decimal? NonCurrentAccountsReceivable
        {
            get
            {
                return this.nonCurrentAccountsReceivableField;
            }
            set
            {
                this.nonCurrentAccountsReceivableField = value;
            }
        }

        /// <remarks/>
        public decimal? CurrentAccruedExpenses
        {
            get
            {
                return this.currentAccruedExpensesField;
            }
            set
            {
                this.currentAccruedExpensesField = value;
            }
        }

        /// <remarks/>
        public decimal? NonCurrentAccruedExpenses
        {
            get
            {
                return this.nonCurrentAccruedExpensesField;
            }
            set
            {
                this.nonCurrentAccruedExpensesField = value;
            }
        }

        /// <remarks/>
        public decimal? AccruedInterestReceivable
        {
            get
            {
                return this.accruedInterestReceivableField;
            }
            set
            {
                this.accruedInterestReceivableField = value;
            }
        }

        /// <remarks/>
        public decimal? AccruedInvestmentIncome
        {
            get
            {
                return this.accruedInvestmentIncomeField;
            }
            set
            {
                this.accruedInvestmentIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? AccumulatedDepreciation
        {
            get
            {
                return this.accumulatedDepreciationField;
            }
            set
            {
                this.accumulatedDepreciationField = value;
            }
        }

        /// <remarks/>
        public decimal? GainsLossesNotAffectingRetainedEarnings
        {
            get
            {
                return this.gainsLossesNotAffectingRetainedEarningsField;
            }
            set
            {
                this.gainsLossesNotAffectingRetainedEarningsField = value;
            }
        }

        /// <remarks/>
        public decimal? AdditionalPaidInCapital
        {
            get
            {
                return this.additionalPaidInCapitalField;
            }
            set
            {
                this.additionalPaidInCapitalField = value;
            }
        }

        /// <remarks/>
        public decimal? AdvanceFromFederalHomeLoanBanks
        {
            get
            {
                return this.advanceFromFederalHomeLoanBanksField;
            }
            set
            {
                this.advanceFromFederalHomeLoanBanksField = value;
            }
        }

        /// <remarks/>
        public decimal? AllowanceForDoubtfulAccountsReceivable
        {
            get
            {
                return this.allowanceForDoubtfulAccountsReceivableField;
            }
            set
            {
                this.allowanceForDoubtfulAccountsReceivableField = value;
            }
        }

        /// <remarks/>
        public decimal? AllowanceForLoansAndLeaseLosses
        {
            get
            {
                return this.allowanceForLoansAndLeaseLossesField;
            }
            set
            {
                this.allowanceForLoansAndLeaseLossesField = value;
            }
        }

        /// <remarks/>
        public decimal? AllowanceForNotesReceivable
        {
            get
            {
                return this.allowanceForNotesReceivableField;
            }
            set
            {
                this.allowanceForNotesReceivableField = value;
            }
        }

        /// <remarks/>
        public decimal? AssetsHeldForSale
        {
            get
            {
                return this.assetsHeldForSaleField;
            }
            set
            {
                this.assetsHeldForSaleField = value;
            }
        }

        /// <remarks/>
        public decimal? AssetsOfDiscontinuedOperations
        {
            get
            {
                return this.assetsOfDiscontinuedOperationsField;
            }
            set
            {
                this.assetsOfDiscontinuedOperationsField = value;
            }
        }

        /// <remarks/>
        public decimal? AvailableForSaleSecurities
        {
            get
            {
                return this.availableForSaleSecuritiesField;
            }
            set
            {
                this.availableForSaleSecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? BankAcceptanceExecutedAndOutstanding
        {
            get
            {
                return this.bankAcceptanceExecutedAndOutstandingField;
            }
            set
            {
                this.bankAcceptanceExecutedAndOutstandingField = value;
            }
        }

        /// <remarks/>
        public decimal? BankIndebtedness
        {
            get
            {
                return this.bankIndebtednessField;
            }
            set
            {
                this.bankIndebtednessField = value;
            }
        }

        /// <remarks/>
        public decimal? BankLoan
        {
            get
            {
                return this.bankLoanField;
            }
            set
            {
                this.bankLoanField = value;
            }
        }

        /// <remarks/>
        public decimal? BankOwnedLifeInsurance
        {
            get
            {
                return this.bankOwnedLifeInsuranceField;
            }
            set
            {
                this.bankOwnedLifeInsuranceField = value;
            }
        }

        /// <remarks/>
        public decimal? SecurityBorrowed
        {
            get
            {
                return this.securityBorrowedField;
            }
            set
            {
                this.securityBorrowedField = value;
            }
        }

        /// <remarks/>
        public decimal? BuildingsAndImprovements
        {
            get
            {
                return this.buildingsAndImprovementsField;
            }
            set
            {
                this.buildingsAndImprovementsField = value;
            }
        }

        /// <remarks/>
        public decimal? CapitalStock
        {
            get
            {
                return this.capitalStockField;
            }
            set
            {
                this.capitalStockField = value;
            }
        }

        /// <remarks/>
        public decimal? Cash
        {
            get
            {
                return this.cashField;
            }
            set
            {
                this.cashField = value;
            }
        }

        /// <remarks/>
        public decimal? CashEquivalents
        {
            get
            {
                return this.cashEquivalentsField;
            }
            set
            {
                this.cashEquivalentsField = value;
            }
        }

        /// <remarks/>
        public decimal? CashAndCashEquivalents
        {
            get
            {
                return this.cashAndCashEquivalentsField;
            }
            set
            {
                this.cashAndCashEquivalentsField = value;
            }
        }

        /// <remarks/>
        public decimal? CashAndDueFromBanks
        {
            get
            {
                return this.cashAndDueFromBanksField;
            }
            set
            {
                this.cashAndDueFromBanksField = value;
            }
        }

        /// <remarks/>
        public decimal? CashCashEquivalentsAndFederalFundsSold
        {
            get
            {
                return this.cashCashEquivalentsAndFederalFundsSoldField;
            }
            set
            {
                this.cashCashEquivalentsAndFederalFundsSoldField = value;
            }
        }

        /// <remarks/>
        public decimal? CashCashEquivalentsAndShortTermInvestments
        {
            get
            {
                return this.cashCashEquivalentsAndShortTermInvestmentsField;
            }
            set
            {
                this.cashCashEquivalentsAndShortTermInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? CasualtyClaims
        {
            get
            {
                return this.casualtyClaimsField;
            }
            set
            {
                this.casualtyClaimsField = value;
            }
        }

        /// <remarks/>
        public decimal? CededUnearnedPremiums
        {
            get
            {
                return this.cededUnearnedPremiumsField;
            }
            set
            {
                this.cededUnearnedPremiumsField = value;
            }
        }

        /// <remarks/>
        public decimal? CommercialLoan
        {
            get
            {
                return this.commercialLoanField;
            }
            set
            {
                this.commercialLoanField = value;
            }
        }

        /// <remarks/>
        public decimal? CommercialPaper
        {
            get
            {
                return this.commercialPaperField;
            }
            set
            {
                this.commercialPaperField = value;
            }
        }

        /// <remarks/>
        public decimal? CommonStock
        {
            get
            {
                return this.commonStockField;
            }
            set
            {
                this.commonStockField = value;
            }
        }

        /// <remarks/>
        public decimal? CommonStockEquity
        {
            get
            {
                return this.commonStockEquityField;
            }
            set
            {
                this.commonStockEquityField = value;
            }
        }

        /// <remarks/>
        public decimal? CommonStocksAvailableForSale
        {
            get
            {
                return this.commonStocksAvailableForSaleField;
            }
            set
            {
                this.commonStocksAvailableForSaleField = value;
            }
        }

        /// <remarks/>
        public decimal? ConstructionInProgress
        {
            get
            {
                return this.constructionInProgressField;
            }
            set
            {
                this.constructionInProgressField = value;
            }
        }

        /// <remarks/>
        public decimal? ConsumerLoan
        {
            get
            {
                return this.consumerLoanField;
            }
            set
            {
                this.consumerLoanField = value;
            }
        }

        /// <remarks/>
        public decimal? MinimumPensionLiabilities
        {
            get
            {
                return this.minimumPensionLiabilitiesField;
            }
            set
            {
                this.minimumPensionLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? CurrentAssets
        {
            get
            {
                return this.currentAssetsField;
            }
            set
            {
                this.currentAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? CurrentDebt
        {
            get
            {
                return this.currentDebtField;
            }
            set
            {
                this.currentDebtField = value;
            }
        }

        /// <remarks/>
        public decimal? CurrentDebtAndCapitalLeaseObligation
        {
            get
            {
                return this.currentDebtAndCapitalLeaseObligationField;
            }
            set
            {
                this.currentDebtAndCapitalLeaseObligationField = value;
            }
        }

        /// <remarks/>
        public decimal? CurrentLiabilities
        {
            get
            {
                return this.currentLiabilitiesField;
            }
            set
            {
                this.currentLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? CurrentCapitalLeaseObligation
        {
            get
            {
                return this.currentCapitalLeaseObligationField;
            }
            set
            {
                this.currentCapitalLeaseObligationField = value;
            }
        }

        /// <remarks/>
        public decimal? CustomerAcceptances
        {
            get
            {
                return this.customerAcceptancesField;
            }
            set
            {
                this.customerAcceptancesField = value;
            }
        }

        /// <remarks/>
        public decimal? DeferredAcquisitionCosts
        {
            get
            {
                return this.deferredAcquisitionCostsField;
            }
            set
            {
                this.deferredAcquisitionCostsField = value;
            }
        }

        /// <remarks/>
        public decimal? DeferredAssets
        {
            get
            {
                return this.deferredAssetsField;
            }
            set
            {
                this.deferredAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? DeferredCosts
        {
            get
            {
                return this.deferredCostsField;
            }
            set
            {
                this.deferredCostsField = value;
            }
        }

        /// <remarks/>
        public decimal? DeferredFinancingCosts
        {
            get
            {
                return this.deferredFinancingCostsField;
            }
            set
            {
                this.deferredFinancingCostsField = value;
            }
        }

        /// <remarks/>
        public decimal? NonCurrentDeferredLiabilities
        {
            get
            {
                return this.nonCurrentDeferredLiabilitiesField;
            }
            set
            {
                this.nonCurrentDeferredLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? CurrentDeferredLiabilities
        {
            get
            {
                return this.currentDeferredLiabilitiesField;
            }
            set
            {
                this.currentDeferredLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? DeferredPolicyAcquisitionCosts
        {
            get
            {
                return this.deferredPolicyAcquisitionCostsField;
            }
            set
            {
                this.deferredPolicyAcquisitionCostsField = value;
            }
        }

        /// <remarks/>
        public decimal? CurrentDeferredRevenue
        {
            get
            {
                return this.currentDeferredRevenueField;
            }
            set
            {
                this.currentDeferredRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? NonCurrentDeferredRevenue
        {
            get
            {
                return this.nonCurrentDeferredRevenueField;
            }
            set
            {
                this.nonCurrentDeferredRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? DeferredTaxAssets
        {
            get
            {
                return this.deferredTaxAssetsField;
            }
            set
            {
                this.deferredTaxAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? CurrentDeferredTaxesAssets
        {
            get
            {
                return this.currentDeferredTaxesAssetsField;
            }
            set
            {
                this.currentDeferredTaxesAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? CurrentDeferredTaxesLiabilities
        {
            get
            {
                return this.currentDeferredTaxesLiabilitiesField;
            }
            set
            {
                this.currentDeferredTaxesLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? NonCurrentDeferredTaxesAssets
        {
            get
            {
                return this.nonCurrentDeferredTaxesAssetsField;
            }
            set
            {
                this.nonCurrentDeferredTaxesAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? NonCurrentDeferredTaxesLiabilities
        {
            get
            {
                return this.nonCurrentDeferredTaxesLiabilitiesField;
            }
            set
            {
                this.nonCurrentDeferredTaxesLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? DefinedPensionBenefit
        {
            get
            {
                return this.definedPensionBenefitField;
            }
            set
            {
                this.definedPensionBenefitField = value;
            }
        }

        /// <remarks/>
        public decimal? DerivativeProductLiabilities
        {
            get
            {
                return this.derivativeProductLiabilitiesField;
            }
            set
            {
                this.derivativeProductLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? DerivativeAssets
        {
            get
            {
                return this.derivativeAssetsField;
            }
            set
            {
                this.derivativeAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? DividendsPayable
        {
            get
            {
                return this.dividendsPayableField;
            }
            set
            {
                this.dividendsPayableField = value;
            }
        }

        /// <remarks/>
        public decimal? ESOPDebtGuarantee
        {
            get
            {
                return this.eSOPDebtGuaranteeField;
            }
            set
            {
                this.eSOPDebtGuaranteeField = value;
            }
        }

        /// <remarks/>
        public decimal? EmployeeBenefits
        {
            get
            {
                return this.employeeBenefitsField;
            }
            set
            {
                this.employeeBenefitsField = value;
            }
        }

        /// <remarks/>
        public decimal? EquityInvestments
        {
            get
            {
                return this.equityInvestmentsField;
            }
            set
            {
                this.equityInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? FacilitiesAndOther
        {
            get
            {
                return this.facilitiesAndOtherField;
            }
            set
            {
                this.facilitiesAndOtherField = value;
            }
        }

        /// <remarks/>
        public decimal? FederalFundsPurchased
        {
            get
            {
                return this.federalFundsPurchasedField;
            }
            set
            {
                this.federalFundsPurchasedField = value;
            }
        }

        /// <remarks/>
        public decimal? FederalFundsPurchasedAndSecuritiesSoldUnderAgreementToRepurchase
        {
            get
            {
                return this.federalFundsPurchasedAndSecuritiesSoldUnderAgreementToRepurchaseField;
            }
            set
            {
                this.federalFundsPurchasedAndSecuritiesSoldUnderAgreementToRepurchaseField = value;
            }
        }

        /// <remarks/>
        public decimal? FederalFundsSold
        {
            get
            {
                return this.federalFundsSoldField;
            }
            set
            {
                this.federalFundsSoldField = value;
            }
        }

        /// <remarks/>
        public decimal? FederalFundsSoldAndSecuritiesPurchaseUnderAgreementsToResell
        {
            get
            {
                return this.federalFundsSoldAndSecuritiesPurchaseUnderAgreementsToResellField;
            }
            set
            {
                this.federalFundsSoldAndSecuritiesPurchaseUnderAgreementsToResellField = value;
            }
        }

        /// <remarks/>
        public decimal? FederalHomeLoanBankStock
        {
            get
            {
                return this.federalHomeLoanBankStockField;
            }
            set
            {
                this.federalHomeLoanBankStockField = value;
            }
        }

        /// <remarks/>
        public decimal? FinancialAssets
        {
            get
            {
                return this.financialAssetsField;
            }
            set
            {
                this.financialAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? FinancialInstrumentsSoldUnderAgreementsToRepurchase
        {
            get
            {
                return this.financialInstrumentsSoldUnderAgreementsToRepurchaseField;
            }
            set
            {
                this.financialInstrumentsSoldUnderAgreementsToRepurchaseField = value;
            }
        }

        /// <remarks/>
        public decimal? FinishedGoods
        {
            get
            {
                return this.finishedGoodsField;
            }
            set
            {
                this.finishedGoodsField = value;
            }
        }

        /// <remarks/>
        public decimal? FixedMaturitiesAvailableForSale
        {
            get
            {
                return this.fixedMaturitiesAvailableForSaleField;
            }
            set
            {
                this.fixedMaturitiesAvailableForSaleField = value;
            }
        }

        /// <remarks/>
        public decimal? FixedMaturitiesHeldToMaturity
        {
            get
            {
                return this.fixedMaturitiesHeldToMaturityField;
            }
            set
            {
                this.fixedMaturitiesHeldToMaturityField = value;
            }
        }

        /// <remarks/>
        public decimal? FixedMaturitiesTrading
        {
            get
            {
                return this.fixedMaturitiesTradingField;
            }
            set
            {
                this.fixedMaturitiesTradingField = value;
            }
        }

        /// <remarks/>
        public decimal? FixedMaturityInvestments
        {
            get
            {
                return this.fixedMaturityInvestmentsField;
            }
            set
            {
                this.fixedMaturityInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? FlightFleetVehicleAndRelatedEquipments
        {
            get
            {
                return this.flightFleetVehicleAndRelatedEquipmentsField;
            }
            set
            {
                this.flightFleetVehicleAndRelatedEquipmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? ForeclosedAssets
        {
            get
            {
                return this.foreclosedAssetsField;
            }
            set
            {
                this.foreclosedAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? ForeignComponent
        {
            get
            {
                return this.foreignComponentField;
            }
            set
            {
                this.foreignComponentField = value;
            }
        }

        /// <remarks/>
        public decimal? ForeignCurrencyTranslationAdjustments
        {
            get
            {
                return this.foreignCurrencyTranslationAdjustmentsField;
            }
            set
            {
                this.foreignCurrencyTranslationAdjustmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? FuelAndNaturalGas
        {
            get
            {
                return this.fuelAndNaturalGasField;
            }
            set
            {
                this.fuelAndNaturalGasField = value;
            }
        }

        /// <remarks/>
        public decimal? FuturePolicyBenefits
        {
            get
            {
                return this.futurePolicyBenefitsField;
            }
            set
            {
                this.futurePolicyBenefitsField = value;
            }
        }

        /// <remarks/>
        public decimal? GeneralPartnershipCapital
        {
            get
            {
                return this.generalPartnershipCapitalField;
            }
            set
            {
                this.generalPartnershipCapitalField = value;
            }
        }

        /// <remarks/>
        public decimal? Goodwill
        {
            get
            {
                return this.goodwillField;
            }
            set
            {
                this.goodwillField = value;
            }
        }

        /// <remarks/>
        public decimal? GoodwillAndOtherIntangibleAssets
        {
            get
            {
                return this.goodwillAndOtherIntangibleAssetsField;
            }
            set
            {
                this.goodwillAndOtherIntangibleAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? GrossLoan
        {
            get
            {
                return this.grossLoanField;
            }
            set
            {
                this.grossLoanField = value;
            }
        }

        /// <remarks/>
        public decimal? GrossPPE
        {
            get
            {
                return this.grossPPEField;
            }
            set
            {
                this.grossPPEField = value;
            }
        }

        /// <remarks/>
        public decimal? GuaranteedInvestmentContract
        {
            get
            {
                return this.guaranteedInvestmentContractField;
            }
            set
            {
                this.guaranteedInvestmentContractField = value;
            }
        }

        /// <remarks/>
        public decimal? HeldToMaturitySecurities
        {
            get
            {
                return this.heldToMaturitySecuritiesField;
            }
            set
            {
                this.heldToMaturitySecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? IncomeTaxPayable
        {
            get
            {
                return this.incomeTaxPayableField;
            }
            set
            {
                this.incomeTaxPayableField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestBearingDepositsLiabilities
        {
            get
            {
                return this.interestBearingDepositsLiabilitiesField;
            }
            set
            {
                this.interestBearingDepositsLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestPayable
        {
            get
            {
                return this.interestPayableField;
            }
            set
            {
                this.interestPayableField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestBearingDepositsAssets
        {
            get
            {
                return this.interestBearingDepositsAssetsField;
            }
            set
            {
                this.interestBearingDepositsAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? Inventory
        {
            get
            {
                return this.inventoryField;
            }
            set
            {
                this.inventoryField = value;
            }
        }

        /// <remarks/>
        public decimal? InventoriesAdjustmentsAllowances
        {
            get
            {
                return this.inventoriesAdjustmentsAllowancesField;
            }
            set
            {
                this.inventoriesAdjustmentsAllowancesField = value;
            }
        }

        /// <remarks/>
        public decimal? InvestmentTaxCredits
        {
            get
            {
                return this.investmentTaxCreditsField;
            }
            set
            {
                this.investmentTaxCreditsField = value;
            }
        }

        /// <remarks/>
        public decimal? InvestmentsAndAdvances
        {
            get
            {
                return this.investmentsAndAdvancesField;
            }
            set
            {
                this.investmentsAndAdvancesField = value;
            }
        }

        /// <remarks/>
        public decimal? InvestmentsInAffiliatesSubsidiariesAssociatesAndJointVentures
        {
            get
            {
                return this.investmentsInAffiliatesSubsidiariesAssociatesAndJointVenturesField;
            }
            set
            {
                this.investmentsInAffiliatesSubsidiariesAssociatesAndJointVenturesField = value;
            }
        }

        /// <remarks/>
        public decimal? InvestmentsInOtherVenturesUnderEquityMethod
        {
            get
            {
                return this.investmentsInOtherVenturesUnderEquityMethodField;
            }
            set
            {
                this.investmentsInOtherVenturesUnderEquityMethodField = value;
            }
        }

        /// <remarks/>
        public decimal? InvestmentsInVariableInterestEntity
        {
            get
            {
                return this.investmentsInVariableInterestEntityField;
            }
            set
            {
                this.investmentsInVariableInterestEntityField = value;
            }
        }

        /// <remarks/>
        public decimal? LandAndImprovements
        {
            get
            {
                return this.landAndImprovementsField;
            }
            set
            {
                this.landAndImprovementsField = value;
            }
        }

        /// <remarks/>
        public decimal? Leases
        {
            get
            {
                return this.leasesField;
            }
            set
            {
                this.leasesField = value;
            }
        }

        /// <remarks/>
        public decimal? LiabilitiesOfDiscontinuedOperations
        {
            get
            {
                return this.liabilitiesOfDiscontinuedOperationsField;
            }
            set
            {
                this.liabilitiesOfDiscontinuedOperationsField = value;
            }
        }

        /// <remarks/>
        public decimal? LimitedPartnershipCapital
        {
            get
            {
                return this.limitedPartnershipCapitalField;
            }
            set
            {
                this.limitedPartnershipCapitalField = value;
            }
        }

        /// <remarks/>
        public decimal? LimitedPartnership
        {
            get
            {
                return this.limitedPartnershipField;
            }
            set
            {
                this.limitedPartnershipField = value;
            }
        }

        /// <remarks/>
        public decimal? LineOfCredit
        {
            get
            {
                return this.lineOfCreditField;
            }
            set
            {
                this.lineOfCreditField = value;
            }
        }

        /// <remarks/>
        public decimal? LoansHeldForSale
        {
            get
            {
                return this.loansHeldForSaleField;
            }
            set
            {
                this.loansHeldForSaleField = value;
            }
        }

        /// <remarks/>
        public decimal? LoansReceivable
        {
            get
            {
                return this.loansReceivableField;
            }
            set
            {
                this.loansReceivableField = value;
            }
        }

        /// <remarks/>
        public decimal? LongTermDebt
        {
            get
            {
                return this.longTermDebtField;
            }
            set
            {
                this.longTermDebtField = value;
            }
        }

        /// <remarks/>
        public decimal? LongTermDebtAndCapitalLeaseObligation
        {
            get
            {
                return this.longTermDebtAndCapitalLeaseObligationField;
            }
            set
            {
                this.longTermDebtAndCapitalLeaseObligationField = value;
            }
        }

        /// <remarks/>
        public decimal? LongTermEquityInvestment
        {
            get
            {
                return this.longTermEquityInvestmentField;
            }
            set
            {
                this.longTermEquityInvestmentField = value;
            }
        }

        /// <remarks/>
        public decimal? LongTermCapitalLeaseObligation
        {
            get
            {
                return this.longTermCapitalLeaseObligationField;
            }
            set
            {
                this.longTermCapitalLeaseObligationField = value;
            }
        }

        /// <remarks/>
        public decimal? MachineryFurnitureEquipment
        {
            get
            {
                return this.machineryFurnitureEquipmentField;
            }
            set
            {
                this.machineryFurnitureEquipmentField = value;
            }
        }

        /// <remarks/>
        public decimal? MaterialsAndSupplies
        {
            get
            {
                return this.materialsAndSuppliesField;
            }
            set
            {
                this.materialsAndSuppliesField = value;
            }
        }

        /// <remarks/>
        public decimal? MineralProperties
        {
            get
            {
                return this.mineralPropertiesField;
            }
            set
            {
                this.mineralPropertiesField = value;
            }
        }

        /// <remarks/>
        public decimal? MinorityInterest
        {
            get
            {
                return this.minorityInterestField;
            }
            set
            {
                this.minorityInterestField = value;
            }
        }

        /// <remarks/>
        public decimal? MoneyMarketInvestments
        {
            get
            {
                return this.moneyMarketInvestmentsField;
            }
            set
            {
                this.moneyMarketInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? MortgageLoan
        {
            get
            {
                return this.mortgageLoanField;
            }
            set
            {
                this.mortgageLoanField = value;
            }
        }

        /// <remarks/>
        public decimal? MortgageAndConsumerloans
        {
            get
            {
                return this.mortgageAndConsumerloansField;
            }
            set
            {
                this.mortgageAndConsumerloansField = value;
            }
        }

        /// <remarks/>
        public decimal? NaturalResourceAssets
        {
            get
            {
                return this.naturalResourceAssetsField;
            }
            set
            {
                this.naturalResourceAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? NetLoan
        {
            get
            {
                return this.netLoanField;
            }
            set
            {
                this.netLoanField = value;
            }
        }

        /// <remarks/>
        public decimal? NetOtherUnrealizedGainLoss
        {
            get
            {
                return this.netOtherUnrealizedGainLossField;
            }
            set
            {
                this.netOtherUnrealizedGainLossField = value;
            }
        }

        /// <remarks/>
        public decimal? NetPPE
        {
            get
            {
                return this.netPPEField;
            }
            set
            {
                this.netPPEField = value;
            }
        }

        /// <remarks/>
        public decimal? NetUnrealizedGainLossForeignCurrency
        {
            get
            {
                return this.netUnrealizedGainLossForeignCurrencyField;
            }
            set
            {
                this.netUnrealizedGainLossForeignCurrencyField = value;
            }
        }

        /// <remarks/>
        public decimal? NetUnrealizedGainLossInvestments
        {
            get
            {
                return this.netUnrealizedGainLossInvestmentsField;
            }
            set
            {
                this.netUnrealizedGainLossInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? NonInterestBearingDeposits
        {
            get
            {
                return this.nonInterestBearingDepositsField;
            }
            set
            {
                this.nonInterestBearingDepositsField = value;
            }
        }

        /// <remarks/>
        public decimal? CurrentNotesPayable
        {
            get
            {
                return this.currentNotesPayableField;
            }
            set
            {
                this.currentNotesPayableField = value;
            }
        }

        /// <remarks/>
        public decimal? NotesReceivable
        {
            get
            {
                return this.notesReceivableField;
            }
            set
            {
                this.notesReceivableField = value;
            }
        }

        /// <remarks/>
        public decimal? GrossNotesReceivable
        {
            get
            {
                return this.grossNotesReceivableField;
            }
            set
            {
                this.grossNotesReceivableField = value;
            }
        }

        /// <remarks/>
        public decimal? NonCurrentNoteReceivables
        {
            get
            {
                return this.nonCurrentNoteReceivablesField;
            }
            set
            {
                this.nonCurrentNoteReceivablesField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherAssets
        {
            get
            {
                return this.otherAssetsField;
            }
            set
            {
                this.otherAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherCapitalStock
        {
            get
            {
                return this.otherCapitalStockField;
            }
            set
            {
                this.otherCapitalStockField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherCurrentAssets
        {
            get
            {
                return this.otherCurrentAssetsField;
            }
            set
            {
                this.otherCurrentAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherCurrentBorrowings
        {
            get
            {
                return this.otherCurrentBorrowingsField;
            }
            set
            {
                this.otherCurrentBorrowingsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherCurrentLiabilities
        {
            get
            {
                return this.otherCurrentLiabilitiesField;
            }
            set
            {
                this.otherCurrentLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherDeferredCosts
        {
            get
            {
                return this.otherDeferredCostsField;
            }
            set
            {
                this.otherDeferredCostsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherDeposits
        {
            get
            {
                return this.otherDepositsField;
            }
            set
            {
                this.otherDepositsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherEquityAdjustments
        {
            get
            {
                return this.otherEquityAdjustmentsField;
            }
            set
            {
                this.otherEquityAdjustmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherIntangibleAssets
        {
            get
            {
                return this.otherIntangibleAssetsField;
            }
            set
            {
                this.otherIntangibleAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherInterestEarningAssets
        {
            get
            {
                return this.otherInterestEarningAssetsField;
            }
            set
            {
                this.otherInterestEarningAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherInventories
        {
            get
            {
                return this.otherInventoriesField;
            }
            set
            {
                this.otherInventoriesField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherInvestedAssets
        {
            get
            {
                return this.otherInvestedAssetsField;
            }
            set
            {
                this.otherInvestedAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherNonCurrentAssets
        {
            get
            {
                return this.otherNonCurrentAssetsField;
            }
            set
            {
                this.otherNonCurrentAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherProperties
        {
            get
            {
                return this.otherPropertiesField;
            }
            set
            {
                this.otherPropertiesField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherRealEstateOwned
        {
            get
            {
                return this.otherRealEstateOwnedField;
            }
            set
            {
                this.otherRealEstateOwnedField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherReceivables
        {
            get
            {
                return this.otherReceivablesField;
            }
            set
            {
                this.otherReceivablesField = value;
            }
        }

        /// <remarks/>
        public decimal? ShortTermInvestments
        {
            get
            {
                return this.shortTermInvestmentsField;
            }
            set
            {
                this.shortTermInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? Patents
        {
            get
            {
                return this.patentsField;
            }
            set
            {
                this.patentsField = value;
            }
        }

        /// <remarks/>
        public decimal? Payables
        {
            get
            {
                return this.payablesField;
            }
            set
            {
                this.payablesField = value;
            }
        }

        /// <remarks/>
        public decimal? PayablesAndAccruedExpenses
        {
            get
            {
                return this.payablesAndAccruedExpensesField;
            }
            set
            {
                this.payablesAndAccruedExpensesField = value;
            }
        }

        /// <remarks/>
        public decimal? NonCurrentPensionAndOtherPostretirementBenefitPlans
        {
            get
            {
                return this.nonCurrentPensionAndOtherPostretirementBenefitPlansField;
            }
            set
            {
                this.nonCurrentPensionAndOtherPostretirementBenefitPlansField = value;
            }
        }

        /// <remarks/>
        public decimal? PolicyLoans
        {
            get
            {
                return this.policyLoansField;
            }
            set
            {
                this.policyLoansField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalPolicyHoldersLiabilities
        {
            get
            {
                return this.totalPolicyHoldersLiabilitiesField;
            }
            set
            {
                this.totalPolicyHoldersLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? PolicyholderFunds
        {
            get
            {
                return this.policyholderFundsField;
            }
            set
            {
                this.policyholderFundsField = value;
            }
        }

        /// <remarks/>
        public decimal? PreferredSecuritiesOutsideStockEquity
        {
            get
            {
                return this.preferredSecuritiesOutsideStockEquityField;
            }
            set
            {
                this.preferredSecuritiesOutsideStockEquityField = value;
            }
        }

        /// <remarks/>
        public decimal? TrustPreferredSecurities
        {
            get
            {
                return this.trustPreferredSecuritiesField;
            }
            set
            {
                this.trustPreferredSecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? PreferredStock
        {
            get
            {
                return this.preferredStockField;
            }
            set
            {
                this.preferredStockField = value;
            }
        }

        /// <remarks/>
        public decimal? PreferredStockEquity
        {
            get
            {
                return this.preferredStockEquityField;
            }
            set
            {
                this.preferredStockEquityField = value;
            }
        }

        /// <remarks/>
        public decimal? PreferredStockOfSubsidiary
        {
            get
            {
                return this.preferredStockOfSubsidiaryField;
            }
            set
            {
                this.preferredStockOfSubsidiaryField = value;
            }
        }

        /// <remarks/>
        public decimal? PreferredStocksAvailableForSale
        {
            get
            {
                return this.preferredStocksAvailableForSaleField;
            }
            set
            {
                this.preferredStocksAvailableForSaleField = value;
            }
        }

        /// <remarks/>
        public decimal? PremiumsReceivable
        {
            get
            {
                return this.premiumsReceivableField;
            }
            set
            {
                this.premiumsReceivableField = value;
            }
        }

        /// <remarks/>
        public decimal? PrepaidAssets
        {
            get
            {
                return this.prepaidAssetsField;
            }
            set
            {
                this.prepaidAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? NonCurrentPrepaidAssets
        {
            get
            {
                return this.nonCurrentPrepaidAssetsField;
            }
            set
            {
                this.nonCurrentPrepaidAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? PrepaidReinsurancePremiums
        {
            get
            {
                return this.prepaidReinsurancePremiumsField;
            }
            set
            {
                this.prepaidReinsurancePremiumsField = value;
            }
        }

        /// <remarks/>
        public decimal? Properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        public decimal? CurrentProvisions
        {
            get
            {
                return this.currentProvisionsField;
            }
            set
            {
                this.currentProvisionsField = value;
            }
        }

        /// <remarks/>
        public decimal? LongTermProvisions
        {
            get
            {
                return this.longTermProvisionsField;
            }
            set
            {
                this.longTermProvisionsField = value;
            }
        }

        /// <remarks/>
        public decimal? PurchasedComponents
        {
            get
            {
                return this.purchasedComponentsField;
            }
            set
            {
                this.purchasedComponentsField = value;
            }
        }

        /// <remarks/>
        public decimal? RawMaterials
        {
            get
            {
                return this.rawMaterialsField;
            }
            set
            {
                this.rawMaterialsField = value;
            }
        }

        /// <remarks/>
        public decimal? RealEstateHeldForSale
        {
            get
            {
                return this.realEstateHeldForSaleField;
            }
            set
            {
                this.realEstateHeldForSaleField = value;
            }
        }

        /// <remarks/>
        public decimal? RealEstateAndRealEstateJointVenturesHeldForInvestment
        {
            get
            {
                return this.realEstateAndRealEstateJointVenturesHeldForInvestmentField;
            }
            set
            {
                this.realEstateAndRealEstateJointVenturesHeldForInvestmentField = value;
            }
        }

        /// <remarks/>
        public decimal? Receivables
        {
            get
            {
                return this.receivablesField;
            }
            set
            {
                this.receivablesField = value;
            }
        }

        /// <remarks/>
        public decimal? RecievablesAdjustmentsAllowances
        {
            get
            {
                return this.recievablesAdjustmentsAllowancesField;
            }
            set
            {
                this.recievablesAdjustmentsAllowancesField = value;
            }
        }

        /// <remarks/>
        public decimal? RedeemablePreferredStock
        {
            get
            {
                return this.redeemablePreferredStockField;
            }
            set
            {
                this.redeemablePreferredStockField = value;
            }
        }

        /// <remarks/>
        public decimal? RegulatoryAssets
        {
            get
            {
                return this.regulatoryAssetsField;
            }
            set
            {
                this.regulatoryAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? RegulatoryLiabilities
        {
            get
            {
                return this.regulatoryLiabilitiesField;
            }
            set
            {
                this.regulatoryLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? ReinsuranceBalancesPayable
        {
            get
            {
                return this.reinsuranceBalancesPayableField;
            }
            set
            {
                this.reinsuranceBalancesPayableField = value;
            }
        }

        /// <remarks/>
        public decimal? ReinsuranceReceivables
        {
            get
            {
                return this.reinsuranceReceivablesField;
            }
            set
            {
                this.reinsuranceReceivablesField = value;
            }
        }

        /// <remarks/>
        public decimal? ReinsuranceRecoverable
        {
            get
            {
                return this.reinsuranceRecoverableField;
            }
            set
            {
                this.reinsuranceRecoverableField = value;
            }
        }

        /// <remarks/>
        public decimal? ReinsuranceRecoverableForPaidLosses
        {
            get
            {
                return this.reinsuranceRecoverableForPaidLossesField;
            }
            set
            {
                this.reinsuranceRecoverableForPaidLossesField = value;
            }
        }

        /// <remarks/>
        public decimal? ReinsuranceRecoverableForUnpaidLosses
        {
            get
            {
                return this.reinsuranceRecoverableForUnpaidLossesField;
            }
            set
            {
                this.reinsuranceRecoverableForUnpaidLossesField = value;
            }
        }

        /// <remarks/>
        public decimal? RestrictedCash
        {
            get
            {
                return this.restrictedCashField;
            }
            set
            {
                this.restrictedCashField = value;
            }
        }

        /// <remarks/>
        public decimal? RestrictedCashAndCashEquivalents
        {
            get
            {
                return this.restrictedCashAndCashEquivalentsField;
            }
            set
            {
                this.restrictedCashAndCashEquivalentsField = value;
            }
        }

        /// <remarks/>
        public decimal? RestrictedCashAndInvestments
        {
            get
            {
                return this.restrictedCashAndInvestmentsField;
            }
            set
            {
                this.restrictedCashAndInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? RestrictedCommonStock
        {
            get
            {
                return this.restrictedCommonStockField;
            }
            set
            {
                this.restrictedCommonStockField = value;
            }
        }

        /// <remarks/>
        public decimal? RestrictedInvestments
        {
            get
            {
                return this.restrictedInvestmentsField;
            }
            set
            {
                this.restrictedInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? RetainedEarnings
        {
            get
            {
                return this.retainedEarningsField;
            }
            set
            {
                this.retainedEarningsField = value;
            }
        }

        /// <remarks/>
        public decimal? SecuritiesLendingCollateral
        {
            get
            {
                return this.securitiesLendingCollateralField;
            }
            set
            {
                this.securitiesLendingCollateralField = value;
            }
        }

        /// <remarks/>
        public decimal? SecuritiesLendingPayable
        {
            get
            {
                return this.securitiesLendingPayableField;
            }
            set
            {
                this.securitiesLendingPayableField = value;
            }
        }

        /// <remarks/>
        public decimal? SecurityAgreeToBeResell
        {
            get
            {
                return this.securityAgreeToBeResellField;
            }
            set
            {
                this.securityAgreeToBeResellField = value;
            }
        }

        /// <remarks/>
        public decimal? SecuritySoldNotYetRepurchased
        {
            get
            {
                return this.securitySoldNotYetRepurchasedField;
            }
            set
            {
                this.securitySoldNotYetRepurchasedField = value;
            }
        }

        /// <remarks/>
        public decimal? SeparateAccountAssets
        {
            get
            {
                return this.separateAccountAssetsField;
            }
            set
            {
                this.separateAccountAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? SeparateAccountLiability
        {
            get
            {
                return this.separateAccountLiabilityField;
            }
            set
            {
                this.separateAccountLiabilityField = value;
            }
        }

        /// <remarks/>
        public decimal? ShortTermInvestmentsAvailableForSale
        {
            get
            {
                return this.shortTermInvestmentsAvailableForSaleField;
            }
            set
            {
                this.shortTermInvestmentsAvailableForSaleField = value;
            }
        }

        /// <remarks/>
        public decimal? ShortTermInvestmentsHeldToMaturity
        {
            get
            {
                return this.shortTermInvestmentsHeldToMaturityField;
            }
            set
            {
                this.shortTermInvestmentsHeldToMaturityField = value;
            }
        }

        /// <remarks/>
        public decimal? ShortTermInvestmentsTrading
        {
            get
            {
                return this.shortTermInvestmentsTradingField;
            }
            set
            {
                this.shortTermInvestmentsTradingField = value;
            }
        }

        /// <remarks/>
        public decimal? StockholdersEquity
        {
            get
            {
                return this.stockholdersEquityField;
            }
            set
            {
                this.stockholdersEquityField = value;
            }
        }

        /// <remarks/>
        public decimal? StudentLoan
        {
            get
            {
                return this.studentLoanField;
            }
            set
            {
                this.studentLoanField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalTaxPayable
        {
            get
            {
                return this.totalTaxPayableField;
            }
            set
            {
                this.totalTaxPayableField = value;
            }
        }

        /// <remarks/>
        public decimal? TaxesReceivable
        {
            get
            {
                return this.taxesReceivableField;
            }
            set
            {
                this.taxesReceivableField = value;
            }
        }

        /// <remarks/>
        public decimal? TimeDepositsPlaced
        {
            get
            {
                return this.timeDepositsPlacedField;
            }
            set
            {
                this.timeDepositsPlacedField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalAssets
        {
            get
            {
                return this.totalAssetsField;
            }
            set
            {
                this.totalAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalCapitalization
        {
            get
            {
                return this.totalCapitalizationField;
            }
            set
            {
                this.totalCapitalizationField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalDeferredCreditsAndOtherNonCurrentLiabilities
        {
            get
            {
                return this.totalDeferredCreditsAndOtherNonCurrentLiabilitiesField;
            }
            set
            {
                this.totalDeferredCreditsAndOtherNonCurrentLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalDeposits
        {
            get
            {
                return this.totalDepositsField;
            }
            set
            {
                this.totalDepositsField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalInvestments
        {
            get
            {
                return this.totalInvestmentsField;
            }
            set
            {
                this.totalInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalLiabilities
        {
            get
            {
                return this.totalLiabilitiesField;
            }
            set
            {
                this.totalLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalNonCurrentAssets
        {
            get
            {
                return this.totalNonCurrentAssetsField;
            }
            set
            {
                this.totalNonCurrentAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalNonCurrentLiabilities
        {
            get
            {
                return this.totalNonCurrentLiabilitiesField;
            }
            set
            {
                this.totalNonCurrentLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalPartnershipCapital
        {
            get
            {
                return this.totalPartnershipCapitalField;
            }
            set
            {
                this.totalPartnershipCapitalField = value;
            }
        }

        /// <remarks/>
        public decimal? TradingAssets
        {
            get
            {
                return this.tradingAssetsField;
            }
            set
            {
                this.tradingAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? TradingLiabilities
        {
            get
            {
                return this.tradingLiabilitiesField;
            }
            set
            {
                this.tradingLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? TradingSecurities
        {
            get
            {
                return this.tradingSecuritiesField;
            }
            set
            {
                this.tradingSecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? TreasuryStock
        {
            get
            {
                return this.treasuryStockField;
            }
            set
            {
                this.treasuryStockField = value;
            }
        }

        /// <remarks/>
        public decimal? UnbilledReceivables
        {
            get
            {
                return this.unbilledReceivablesField;
            }
            set
            {
                this.unbilledReceivablesField = value;
            }
        }

        /// <remarks/>
        public decimal? UnearnedIncome
        {
            get
            {
                return this.unearnedIncomeField;
            }
            set
            {
                this.unearnedIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? UnearnedPremiums
        {
            get
            {
                return this.unearnedPremiumsField;
            }
            set
            {
                this.unearnedPremiumsField = value;
            }
        }

        /// <remarks/>
        public decimal? UnpaidLossAndLossReserve
        {
            get
            {
                return this.unpaidLossAndLossReserveField;
            }
            set
            {
                this.unpaidLossAndLossReserveField = value;
            }
        }

        /// <remarks/>
        public decimal? UnrealizedGainLoss
        {
            get
            {
                return this.unrealizedGainLossField;
            }
            set
            {
                this.unrealizedGainLossField = value;
            }
        }

        /// <remarks/>
        public decimal? WorkInProcess
        {
            get
            {
                return this.workInProcessField;
            }
            set
            {
                this.workInProcessField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherNonCurrentLiabilities
        {
            get
            {
                return this.otherNonCurrentLiabilitiesField;
            }
            set
            {
                this.otherNonCurrentLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? CapitalLeaseObligations
        {
            get
            {
                return this.capitalLeaseObligationsField;
            }
            set
            {
                this.capitalLeaseObligationsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherLiabilities
        {
            get
            {
                return this.otherLiabilitiesField;
            }
            set
            {
                this.otherLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherPayable
        {
            get
            {
                return this.otherPayableField;
            }
            set
            {
                this.otherPayableField = value;
            }
        }

        /// <remarks/>
        public decimal? InvestedCapital
        {
            get
            {
                return this.investedCapitalField;
            }
            set
            {
                this.investedCapitalField = value;
            }
        }

        /// <remarks/>
        public decimal? TangibleBookValue
        {
            get
            {
                return this.tangibleBookValueField;
            }
            set
            {
                this.tangibleBookValueField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalEquity
        {
            get
            {
                return this.totalEquityField;
            }
            set
            {
                this.totalEquityField = value;
            }
        }

        /// <remarks/>
        public decimal? WorkingCapital
        {
            get
            {
                return this.workingCapitalField;
            }
            set
            {
                this.workingCapitalField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalDebt
        {
            get
            {
                return this.totalDebtField;
            }
            set
            {
                this.totalDebtField = value;
            }
        }

        /// <remarks/>
        public decimal? CashValueOfLifeInsurance
        {
            get
            {
                return this.cashValueOfLifeInsuranceField;
            }
            set
            {
                this.cashValueOfLifeInsuranceField = value;
            }
        }

        /// <remarks/>
        public decimal? CommonUtilityPlant
        {
            get
            {
                return this.commonUtilityPlantField;
            }
            set
            {
                this.commonUtilityPlantField = value;
            }
        }

        /// <remarks/>
        public decimal? CurrentDeferredAssets
        {
            get
            {
                return this.currentDeferredAssetsField;
            }
            set
            {
                this.currentDeferredAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? NonCurrentDeferredAssets
        {
            get
            {
                return this.nonCurrentDeferredAssetsField;
            }
            set
            {
                this.nonCurrentDeferredAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? ElectricUtilityPlant
        {
            get
            {
                return this.electricUtilityPlantField;
            }
            set
            {
                this.electricUtilityPlantField = value;
            }
        }

        /// <remarks/>
        public decimal? NaturalGasFuelAndOther
        {
            get
            {
                return this.naturalGasFuelAndOtherField;
            }
            set
            {
                this.naturalGasFuelAndOtherField = value;
            }
        }

        /// <remarks/>
        public decimal? NetUtilityPlant
        {
            get
            {
                return this.netUtilityPlantField;
            }
            set
            {
                this.netUtilityPlantField = value;
            }
        }

        /// <remarks/>
        public decimal? WaterProduction
        {
            get
            {
                return this.waterProductionField;
            }
            set
            {
                this.waterProductionField = value;
            }
        }

        /// <remarks/>
        public decimal? SecuritiesAndInvestments
        {
            get
            {
                return this.securitiesAndInvestmentsField;
            }
            set
            {
                this.securitiesAndInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? OrdinarySharesNumber
        {
            get
            {
                return this.ordinarySharesNumberField;
            }
            set
            {
                this.ordinarySharesNumberField = value;
            }
        }

        /// <remarks/>
        public decimal? PreferredSharesNumber
        {
            get
            {
                return this.preferredSharesNumberField;
            }
            set
            {
                this.preferredSharesNumberField = value;
            }
        }

        /// <remarks/>
        public decimal? TreasurySharesNumber
        {
            get
            {
                return this.treasurySharesNumberField;
            }
            set
            {
                this.treasurySharesNumberField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalLiabilitiesNetMinorityInterest
        {
            get
            {
                return this.totalLiabilitiesNetMinorityInterestField;
            }
            set
            {
                this.totalLiabilitiesNetMinorityInterestField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalNonCurrentLiabilitiesNetMinorityInterest
        {
            get
            {
                return this.totalNonCurrentLiabilitiesNetMinorityInterestField;
            }
            set
            {
                this.totalNonCurrentLiabilitiesNetMinorityInterestField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalEquityGrossMinorityInterest
        {
            get
            {
                return this.totalEquityGrossMinorityInterestField;
            }
            set
            {
                this.totalEquityGrossMinorityInterestField = value;
            }
        }

        /// <remarks/>
        public decimal? TradingAndOtherReceivable
        {
            get
            {
                return this.tradingAndOtherReceivableField;
            }
            set
            {
                this.tradingAndOtherReceivableField = value;
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
        public decimal? SecuritiesLoaned
        {
            get
            {
                return this.securitiesLoanedField;
            }
            set
            {
                this.securitiesLoanedField = value;
            }
        }

        /// <remarks/>
        public decimal? ParticipatingPolicyholderEquity
        {
            get
            {
                return this.participatingPolicyholderEquityField;
            }
            set
            {
                this.participatingPolicyholderEquityField = value;
            }
        }

        /// <remarks/>
        public decimal? NetTangibleAssets
        {
            get
            {
                return this.netTangibleAssetsField;
            }
            set
            {
                this.netTangibleAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? DuefromRelatedPartiesCurrent
        {
            get
            {
                return this.duefromRelatedPartiesCurrentField;
            }
            set
            {
                this.duefromRelatedPartiesCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? DuefromRelatedPartiesNonCurrent
        {
            get
            {
                return this.duefromRelatedPartiesNonCurrentField;
            }
            set
            {
                this.duefromRelatedPartiesNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? DuetoRelatedParties
        {
            get
            {
                return this.duetoRelatedPartiesField;
            }
            set
            {
                this.duetoRelatedPartiesField = value;
            }
        }

        /// <remarks/>
        public decimal? DuetoRelatedPartiesCurrent
        {
            get
            {
                return this.duetoRelatedPartiesCurrentField;
            }
            set
            {
                this.duetoRelatedPartiesCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? DuetoRelatedPartiesNonCurrent
        {
            get
            {
                return this.duetoRelatedPartiesNonCurrentField;
            }
            set
            {
                this.duetoRelatedPartiesNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? NetAssets
        {
            get
            {
                return this.netAssetsField;
            }
            set
            {
                this.netAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? InvestmentProperties
        {
            get
            {
                return this.investmentPropertiesField;
            }
            set
            {
                this.investmentPropertiesField = value;
            }
        }

        /// <remarks/>
        public decimal? InvestmentsinSubsidiariesatCost
        {
            get
            {
                return this.investmentsinSubsidiariesatCostField;
            }
            set
            {
                this.investmentsinSubsidiariesatCostField = value;
            }
        }

        /// <remarks/>
        public decimal? InvestmentsinAssociatesatCost
        {
            get
            {
                return this.investmentsinAssociatesatCostField;
            }
            set
            {
                this.investmentsinAssociatesatCostField = value;
            }
        }

        /// <remarks/>
        public decimal? InvestmentsinJointVenturesatCost
        {
            get
            {
                return this.investmentsinJointVenturesatCostField;
            }
            set
            {
                this.investmentsinJointVenturesatCostField = value;
            }
        }

        /// <remarks/>
        public decimal? InvestmentinFinancialAssets
        {
            get
            {
                return this.investmentinFinancialAssetsField;
            }
            set
            {
                this.investmentinFinancialAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? FinanceLeaseReceivables
        {
            get
            {
                return this.financeLeaseReceivablesField;
            }
            set
            {
                this.financeLeaseReceivablesField = value;
            }
        }

        /// <remarks/>
        public decimal? ConvertibleLoansCurrent
        {
            get
            {
                return this.convertibleLoansCurrentField;
            }
            set
            {
                this.convertibleLoansCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? BankLoansCurrent
        {
            get
            {
                return this.bankLoansCurrentField;
            }
            set
            {
                this.bankLoansCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherLoansCurrent
        {
            get
            {
                return this.otherLoansCurrentField;
            }
            set
            {
                this.otherLoansCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? AccruedandDeferredIncome
        {
            get
            {
                return this.accruedandDeferredIncomeField;
            }
            set
            {
                this.accruedandDeferredIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? BankLoansNonCurrent
        {
            get
            {
                return this.bankLoansNonCurrentField;
            }
            set
            {
                this.bankLoansNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherLoansNonCurrent
        {
            get
            {
                return this.otherLoansNonCurrentField;
            }
            set
            {
                this.otherLoansNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherReserves
        {
            get
            {
                return this.otherReservesField;
            }
            set
            {
                this.otherReservesField = value;
            }
        }

        /// <remarks/>
        public decimal? LoansandAdvancestoBank
        {
            get
            {
                return this.loansandAdvancestoBankField;
            }
            set
            {
                this.loansandAdvancestoBankField = value;
            }
        }

        /// <remarks/>
        public decimal? LoansandAdvancestoCustomer
        {
            get
            {
                return this.loansandAdvancestoCustomerField;
            }
            set
            {
                this.loansandAdvancestoCustomerField = value;
            }
        }

        /// <remarks/>
        public decimal? TreasuryBillsandOtherEligibleBills
        {
            get
            {
                return this.treasuryBillsandOtherEligibleBillsField;
            }
            set
            {
                this.treasuryBillsandOtherEligibleBillsField = value;
            }
        }

        /// <remarks/>
        public decimal? EquitySharesInvestments
        {
            get
            {
                return this.equitySharesInvestmentsField;
            }
            set
            {
                this.equitySharesInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? DepositsbyBank
        {
            get
            {
                return this.depositsbyBankField;
            }
            set
            {
                this.depositsbyBankField = value;
            }
        }

        /// <remarks/>
        public decimal? CustomerAccounts
        {
            get
            {
                return this.customerAccountsField;
            }
            set
            {
                this.customerAccountsField = value;
            }
        }

        /// <remarks/>
        public decimal? ItemsinTheCourseofTransmissiontoOtherBanks
        {
            get
            {
                return this.itemsinTheCourseofTransmissiontoOtherBanksField;
            }
            set
            {
                this.itemsinTheCourseofTransmissiontoOtherBanksField = value;
            }
        }

        /// <remarks/>
        public decimal? TradingandFinancialLiabilities
        {
            get
            {
                return this.tradingandFinancialLiabilitiesField;
            }
            set
            {
                this.tradingandFinancialLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? DebtSecuritiesinIssue
        {
            get
            {
                return this.debtSecuritiesinIssueField;
            }
            set
            {
                this.debtSecuritiesinIssueField = value;
            }
        }

        /// <remarks/>
        public decimal? SubordinatedLiabilities
        {
            get
            {
                return this.subordinatedLiabilitiesField;
            }
            set
            {
                this.subordinatedLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? ProvisionsTotal
        {
            get
            {
                return this.provisionsTotalField;
            }
            set
            {
                this.provisionsTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingLeaseAssets
        {
            get
            {
                return this.operatingLeaseAssetsField;
            }
            set
            {
                this.operatingLeaseAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? ClaimsOutstanding
        {
            get
            {
                return this.claimsOutstandingField;
            }
            set
            {
                this.claimsOutstandingField = value;
            }
        }

        /// <remarks/>
        public decimal? LongTermContracts
        {
            get
            {
                return this.longTermContractsField;
            }
            set
            {
                this.longTermContractsField = value;
            }
        }

        /// <remarks/>
        public decimal? RealEstate
        {
            get
            {
                return this.realEstateField;
            }
            set
            {
                this.realEstateField = value;
            }
        }

        /// <remarks/>
        public decimal? PaymentofBills
        {
            get
            {
                return this.paymentofBillsField;
            }
            set
            {
                this.paymentofBillsField = value;
            }
        }

        /// <remarks/>
        public decimal? LiabilitiesHeldforSaleCurrent
        {
            get
            {
                return this.liabilitiesHeldforSaleCurrentField;
            }
            set
            {
                this.liabilitiesHeldforSaleCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? LiabilitiesHeldforSaleNonCurrent
        {
            get
            {
                return this.liabilitiesHeldforSaleNonCurrentField;
            }
            set
            {
                this.liabilitiesHeldforSaleNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? UnclassifiedCurrentAssets
        {
            get
            {
                return this.unclassifiedCurrentAssetsField;
            }
            set
            {
                this.unclassifiedCurrentAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? DebtSecurities
        {
            get
            {
                return this.debtSecuritiesField;
            }
            set
            {
                this.debtSecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalFinancialLeaseObligations
        {
            get
            {
                return this.totalFinancialLeaseObligationsField;
            }
            set
            {
                this.totalFinancialLeaseObligationsField = value;
            }
        }

        /// <remarks/>
        public decimal? AccruedandDeferredIncomeCurrent
        {
            get
            {
                return this.accruedandDeferredIncomeCurrentField;
            }
            set
            {
                this.accruedandDeferredIncomeCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? AccruedandDeferredIncomeNonCurrent
        {
            get
            {
                return this.accruedandDeferredIncomeNonCurrentField;
            }
            set
            {
                this.accruedandDeferredIncomeNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? FinanceLeaseReceivablesCurrent
        {
            get
            {
                return this.financeLeaseReceivablesCurrentField;
            }
            set
            {
                this.financeLeaseReceivablesCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? FinanceLeaseReceivablesNonCurrent
        {
            get
            {
                return this.financeLeaseReceivablesNonCurrentField;
            }
            set
            {
                this.financeLeaseReceivablesNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? FinancialLiabilitiesCurrent
        {
            get
            {
                return this.financialLiabilitiesCurrentField;
            }
            set
            {
                this.financialLiabilitiesCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? FinancialLiabilitiesNonCurrent
        {
            get
            {
                return this.financialLiabilitiesNonCurrentField;
            }
            set
            {
                this.financialLiabilitiesNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? FinancialAssetsDesignatedasFairValueThroughProfitorLossTotal
        {
            get
            {
                return this.financialAssetsDesignatedasFairValueThroughProfitorLossTotalField;
            }
            set
            {
                this.financialAssetsDesignatedasFairValueThroughProfitorLossTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? TaxesAssetsCurrent
        {
            get
            {
                return this.taxesAssetsCurrentField;
            }
            set
            {
                this.taxesAssetsCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherEquityInterest
        {
            get
            {
                return this.otherEquityInterestField;
            }
            set
            {
                this.otherEquityInterestField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestBearingBorrowingsNonCurrent
        {
            get
            {
                return this.interestBearingBorrowingsNonCurrentField;
            }
            set
            {
                this.interestBearingBorrowingsNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? NonInterestBearingBorrowingsNonCurrent
        {
            get
            {
                return this.nonInterestBearingBorrowingsNonCurrentField;
            }
            set
            {
                this.nonInterestBearingBorrowingsNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? TradeandOtherPayablesNonCurrent
        {
            get
            {
                return this.tradeandOtherPayablesNonCurrentField;
            }
            set
            {
                this.tradeandOtherPayablesNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestBearingBorrowingsCurrent
        {
            get
            {
                return this.interestBearingBorrowingsCurrentField;
            }
            set
            {
                this.interestBearingBorrowingsCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? NonInterestBearingBorrowingsCurrent
        {
            get
            {
                return this.nonInterestBearingBorrowingsCurrentField;
            }
            set
            {
                this.nonInterestBearingBorrowingsCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? PensionandOtherPostRetirementBenefitPlansCurrent
        {
            get
            {
                return this.pensionandOtherPostRetirementBenefitPlansCurrentField;
            }
            set
            {
                this.pensionandOtherPostRetirementBenefitPlansCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? CashandBalanceswithCentralBanks
        {
            get
            {
                return this.cashandBalanceswithCentralBanksField;
            }
            set
            {
                this.cashandBalanceswithCentralBanksField = value;
            }
        }

        /// <remarks/>
        public decimal? PlacementwithBanksandOtherFinancialInstitutions
        {
            get
            {
                return this.placementwithBanksandOtherFinancialInstitutionsField;
            }
            set
            {
                this.placementwithBanksandOtherFinancialInstitutionsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherLoanAssets
        {
            get
            {
                return this.otherLoanAssetsField;
            }
            set
            {
                this.otherLoanAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? HedgingAssetsTotal
        {
            get
            {
                return this.hedgingAssetsTotalField;
            }
            set
            {
                this.hedgingAssetsTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? AssetsPledgedasCollateralSubjecttoSaleorRepledgingTotal
        {
            get
            {
                return this.assetsPledgedasCollateralSubjecttoSaleorRepledgingTotalField;
            }
            set
            {
                this.assetsPledgedasCollateralSubjecttoSaleorRepledgingTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? TaxAssetsTotal
        {
            get
            {
                return this.taxAssetsTotalField;
            }
            set
            {
                this.taxAssetsTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? AdvancesfromCentralBanks
        {
            get
            {
                return this.advancesfromCentralBanksField;
            }
            set
            {
                this.advancesfromCentralBanksField = value;
            }
        }

        /// <remarks/>
        public decimal? CertificatesofDepositsandOtherDebtSecuritiesIssued
        {
            get
            {
                return this.certificatesofDepositsandOtherDebtSecuritiesIssuedField;
            }
            set
            {
                this.certificatesofDepositsandOtherDebtSecuritiesIssuedField = value;
            }
        }

        /// <remarks/>
        public decimal? DepositCertificates
        {
            get
            {
                return this.depositCertificatesField;
            }
            set
            {
                this.depositCertificatesField = value;
            }
        }

        /// <remarks/>
        public decimal? DebenturesandDebtCertificates
        {
            get
            {
                return this.debenturesandDebtCertificatesField;
            }
            set
            {
                this.debenturesandDebtCertificatesField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestBearingBorrowingsTotal
        {
            get
            {
                return this.interestBearingBorrowingsTotalField;
            }
            set
            {
                this.interestBearingBorrowingsTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? NonInterestBearingBorrowingsTotal
        {
            get
            {
                return this.nonInterestBearingBorrowingsTotalField;
            }
            set
            {
                this.nonInterestBearingBorrowingsTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherBorrowedFunds
        {
            get
            {
                return this.otherBorrowedFundsField;
            }
            set
            {
                this.otherBorrowedFundsField = value;
            }
        }

        /// <remarks/>
        public decimal? FinancialLiabilitiesDesignatedasFairValueThroughProfitorLossTotal
        {
            get
            {
                return this.financialLiabilitiesDesignatedasFairValueThroughProfitorLossTotalField;
            }
            set
            {
                this.financialLiabilitiesDesignatedasFairValueThroughProfitorLossTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? FinancialLiabilitiesMeasuredatAmortizedCostTotal
        {
            get
            {
                return this.financialLiabilitiesMeasuredatAmortizedCostTotalField;
            }
            set
            {
                this.financialLiabilitiesMeasuredatAmortizedCostTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? LoanCapital
        {
            get
            {
                return this.loanCapitalField;
            }
            set
            {
                this.loanCapitalField = value;
            }
        }

        /// <remarks/>
        public decimal? HedgingLiabilitiesTotal
        {
            get
            {
                return this.hedgingLiabilitiesTotalField;
            }
            set
            {
                this.hedgingLiabilitiesTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? LiabilitiesRecognizedforFairValueChangesinPortfolioHedgeofInterestRateRisk
        {
            get
            {
                return this.liabilitiesRecognizedforFairValueChangesinPortfolioHedgeofInterestRateRiskField;
            }
            set
            {
                this.liabilitiesRecognizedforFairValueChangesinPortfolioHedgeofInterestRateRiskField = value;
            }
        }

        /// <remarks/>
        public decimal? AccruedLiabilitiesTotal
        {
            get
            {
                return this.accruedLiabilitiesTotalField;
            }
            set
            {
                this.accruedLiabilitiesTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? DeferredIncomeTotal
        {
            get
            {
                return this.deferredIncomeTotalField;
            }
            set
            {
                this.deferredIncomeTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? DeferredTaxLiabilitiesTotal
        {
            get
            {
                return this.deferredTaxLiabilitiesTotalField;
            }
            set
            {
                this.deferredTaxLiabilitiesTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? ReinsuranceAssets
        {
            get
            {
                return this.reinsuranceAssetsField;
            }
            set
            {
                this.reinsuranceAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? ReinsuranceShareofInsuranceContract
        {
            get
            {
                return this.reinsuranceShareofInsuranceContractField;
            }
            set
            {
                this.reinsuranceShareofInsuranceContractField = value;
            }
        }

        /// <remarks/>
        public decimal? ReinsuranceShareofAccruedPolicyholderClaims
        {
            get
            {
                return this.reinsuranceShareofAccruedPolicyholderClaimsField;
            }
            set
            {
                this.reinsuranceShareofAccruedPolicyholderClaimsField = value;
            }
        }

        /// <remarks/>
        public decimal? DepositsMadeunderAssumedReinsuranceContract
        {
            get
            {
                return this.depositsMadeunderAssumedReinsuranceContractField;
            }
            set
            {
                this.depositsMadeunderAssumedReinsuranceContractField = value;
            }
        }

        /// <remarks/>
        public decimal? InsuranceContractAssets
        {
            get
            {
                return this.insuranceContractAssetsField;
            }
            set
            {
                this.insuranceContractAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? InsuranceReceivables
        {
            get
            {
                return this.insuranceReceivablesField;
            }
            set
            {
                this.insuranceReceivablesField = value;
            }
        }

        /// <remarks/>
        public decimal? InsuranceContractLiabilities
        {
            get
            {
                return this.insuranceContractLiabilitiesField;
            }
            set
            {
                this.insuranceContractLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? InsurancePayables
        {
            get
            {
                return this.insurancePayablesField;
            }
            set
            {
                this.insurancePayablesField = value;
            }
        }

        /// <remarks/>
        public decimal? DepositsReceivedunderCededInsuranceContract
        {
            get
            {
                return this.depositsReceivedunderCededInsuranceContractField;
            }
            set
            {
                this.depositsReceivedunderCededInsuranceContractField = value;
            }
        }

        /// <remarks/>
        public decimal? InvestmentContractLiabilities
        {
            get
            {
                return this.investmentContractLiabilitiesField;
            }
            set
            {
                this.investmentContractLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? ConstructionGrants
        {
            get
            {
                return this.constructionGrantsField;
            }
            set
            {
                this.constructionGrantsField = value;
            }
        }

        /// <remarks/>
        public decimal? DeferredCostCurrent
        {
            get
            {
                return this.deferredCostCurrentField;
            }
            set
            {
                this.deferredCostCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? PensionAndOtherPostretirementBenefitPlansTotal
        {
            get
            {
                return this.pensionAndOtherPostretirementBenefitPlansTotalField;
            }
            set
            {
                this.pensionAndOtherPostretirementBenefitPlansTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? LiabilitiesHeldforSaleTotal
        {
            get
            {
                return this.liabilitiesHeldforSaleTotalField;
            }
            set
            {
                this.liabilitiesHeldforSaleTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? HedgingAssetsNonCurrent
        {
            get
            {
                return this.hedgingAssetsNonCurrentField;
            }
            set
            {
                this.hedgingAssetsNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? HedgingAssetsCurrent
        {
            get
            {
                return this.hedgingAssetsCurrentField;
            }
            set
            {
                this.hedgingAssetsCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? ConvertibleLoansTotal
        {
            get
            {
                return this.convertibleLoansTotalField;
            }
            set
            {
                this.convertibleLoansTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? BankLoansTotal
        {
            get
            {
                return this.bankLoansTotalField;
            }
            set
            {
                this.bankLoansTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherLoansTotal
        {
            get
            {
                return this.otherLoansTotalField;
            }
            set
            {
                this.otherLoansTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? HedgingLiabilitiesNonCurrent
        {
            get
            {
                return this.hedgingLiabilitiesNonCurrentField;
            }
            set
            {
                this.hedgingLiabilitiesNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? HedgingLiabilitiesCurrent
        {
            get
            {
                return this.hedgingLiabilitiesCurrentField;
            }
            set
            {
                this.hedgingLiabilitiesCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? InsuranceFundsNonCurrent
        {
            get
            {
                return this.insuranceFundsNonCurrentField;
            }
            set
            {
                this.insuranceFundsNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? InsuranceFundsCurrent
        {
            get
            {
                return this.insuranceFundsCurrentField;
            }
            set
            {
                this.insuranceFundsCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? DebtTotal
        {
            get
            {
                return this.debtTotalField;
            }
            set
            {
                this.debtTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? AssetsHeldForSaleCurrent
        {
            get
            {
                return this.assetsHeldForSaleCurrentField;
            }
            set
            {
                this.assetsHeldForSaleCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? AssetsHeldForSaleNonCurrent
        {
            get
            {
                return this.assetsHeldForSaleNonCurrentField;
            }
            set
            {
                this.assetsHeldForSaleNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? BiologicalAssets
        {
            get
            {
                return this.biologicalAssetsField;
            }
            set
            {
                this.biologicalAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? CashRestrictedOrPledged
        {
            get
            {
                return this.cashRestrictedOrPledgedField;
            }
            set
            {
                this.cashRestrictedOrPledgedField = value;
            }
        }

        /// <remarks/>
        public decimal? ConvertibleLoansNonCurrent
        {
            get
            {
                return this.convertibleLoansNonCurrentField;
            }
            set
            {
                this.convertibleLoansNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? FinancialOrDerivativeInvestmentCurrentLiabilities
        {
            get
            {
                return this.financialOrDerivativeInvestmentCurrentLiabilitiesField;
            }
            set
            {
                this.financialOrDerivativeInvestmentCurrentLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? LoanAndLoanReceivables
        {
            get
            {
                return this.loanAndLoanReceivablesField;
            }
            set
            {
                this.loanAndLoanReceivablesField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherInvestments
        {
            get
            {
                return this.otherInvestmentsField;
            }
            set
            {
                this.otherInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? TradeAndOtherReceivablesNonCurrent
        {
            get
            {
                return this.tradeAndOtherReceivablesNonCurrentField;
            }
            set
            {
                this.tradeAndOtherReceivablesNonCurrentField = value;
            }
        }

        /// <remarks/>
        public decimal? DebtDueInYear1
        {
            get
            {
                return this.debtDueInYear1Field;
            }
            set
            {
                this.debtDueInYear1Field = value;
            }
        }

        /// <remarks/>
        public decimal? DebtDueInYear2
        {
            get
            {
                return this.debtDueInYear2Field;
            }
            set
            {
                this.debtDueInYear2Field = value;
            }
        }

        /// <remarks/>
        public decimal? DebtDueInYear5
        {
            get
            {
                return this.debtDueInYear5Field;
            }
            set
            {
                this.debtDueInYear5Field = value;
            }
        }

        /// <remarks/>
        public decimal? DebtDueBeyond
        {
            get
            {
                return this.debtDueBeyondField;
            }
            set
            {
                this.debtDueBeyondField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalDebtInMaturitySchedule
        {
            get
            {
                return this.totalDebtInMaturityScheduleField;
            }
            set
            {
                this.totalDebtInMaturityScheduleField = value;
            }
        }

        /// <remarks/>
        public decimal? FiscalYearChange
        {
            get
            {
                return this.fiscalYearChangeField;
            }
            set
            {
                this.fiscalYearChangeField = value;
            }
        }

        /// <remarks/>
        public decimal? FixedAssetsRevaluationReserve
        {
            get
            {
                return this.fixedAssetsRevaluationReserveField;
            }
            set
            {
                this.fixedAssetsRevaluationReserveField = value;
            }
        }

        /// <remarks/>
        public decimal? CurrentOtherFinancialLiabilities
        {
            get
            {
                return this.currentOtherFinancialLiabilitiesField;
            }
            set
            {
                this.currentOtherFinancialLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? NonCurrentOtherFinancialLiabilities
        {
            get
            {
                return this.nonCurrentOtherFinancialLiabilitiesField;
            }
            set
            {
                this.nonCurrentOtherFinancialLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherFinancialLiabilities
        {
            get
            {
                return this.otherFinancialLiabilitiesField;
            }
            set
            {
                this.otherFinancialLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalLiabilitiesAsReported
        {
            get
            {
                return this.totalLiabilitiesAsReportedField;
            }
            set
            {
                this.totalLiabilitiesAsReportedField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalEquityAsReported
        {
            get
            {
                return this.totalEquityAsReportedField;
            }
            set
            {
                this.totalEquityAsReportedField = value;
            }
        }

        /// <remarks/>
        public decimal? UnallocatedSurplus
        {
            get
            {
                return this.unallocatedSurplusField;
            }
            set
            {
                this.unallocatedSurplusField = value;
            }
        }

        /// <remarks/>
        public decimal? NetDebt
        {
            get
            {
                return this.netDebtField;
            }
            set
            {
                this.netDebtField = value;
            }
        }
    }
}
