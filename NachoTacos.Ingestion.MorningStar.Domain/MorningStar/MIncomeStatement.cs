using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    [Table("MIncomeStatement", Schema = "MStar")]
    public class MIncomeStatement : MGeneralInfo
    {
        public Guid MIncomeStatementId { get; set; }

        private DateTime reportDateField;

        private DateTime periodEndingDateField;

        private DateTime? fileDateField;

        private string statementTypeField;

        private string dataTypeField;

        private string interimField;

        private string currencyIdField;

        private string fiscalYearEndField;

        private decimal? accretionOnPreferredStockField;

        private decimal? accruedPreferredStockDividendsField;

        private decimal? acquiredInProcessRnDField;

        private decimal? acquisitionExpenseField;

        private decimal? administrativeExpenseField;

        private decimal? agencyFeesField;

        private decimal? agencyFeesAndCommissionsField;

        private decimal? allowancesForConstructionField;

        private decimal? amortizationField;

        private decimal? securitiesAmortizationField;

        private decimal? capitalnBusinessTaxesField;

        private decimal? cededPremiumsField;

        private decimal? commissionExpensesField;

        private decimal? commissionRevenueField;

        private decimal? costOfRevenueField;

        private decimal? creditCardField;

        private decimal? cumulativeEffectOfAccountingChangeField;

        private decimal? depletionField;

        private decimal? depreciationField;

        private decimal? depreciationAndAmortizationField;

        private decimal? depreciationAmortizationDepletionField;

        private decimal? developmentExpenseField;

        private decimal? netIncomeDiscontinuousOperationsField;

        private decimal? dividendIncomeField;

        private decimal? earningLossOfEquityInvestmentsField;

        private decimal? earningsFromEquityInterestField;

        private decimal? electricRevenueField;

        private decimal? equipmentField;

        private decimal? exciseTaxesField;

        private decimal? explorationDevelopmentAndMineralPropertyLeaseExpensesField;

        private decimal? netIncomeExtraordinaryField;

        private decimal? feeRevenueAndOtherIncomeField;

        private decimal? feesField;

        private decimal? feesAndCommissionsField;

        private decimal? foreignExchangeTradingGainsField;

        private decimal? fuelField;

        private decimal? fuelAndPurchasePowerField;

        private decimal? gainOnSaleOfBusinessField;

        private decimal? gainOnSaleOfPPEField;

        private decimal? gainOnSaleOfSecurityField;

        private decimal? gainsLossOnDisposalOfDiscontinuedOperationsField;

        private decimal? gasRevenueField;

        private decimal? generalAccountAssetsField;

        private decimal? generalExpenseField;

        private decimal? generalAndAdministrativeExpenseField;

        private decimal? grossProfitField;

        private decimal? grossPremiumsWrittenField;

        private decimal? impairmentOfCapitalAssetsField;

        private decimal? otherImpairmentOfCapitalAssetsField;

        private decimal? incomeFromEquityMethodInvestmentsField;

        private decimal? restructringAndMnAIncomeField;

        private decimal? increaseDecreaseInNetUnearnedPremiumReservesField;

        private decimal? insuranceAndClaimsField;

        private decimal? insuranceAndPremiumsField;

        private decimal? interestIncomeFromInterestBearingDepositsField;

        private decimal? interestExpenseField;

        private decimal? interestExpenseForCapitalizedLeaseObligationsField;

        private decimal? interestExpenseForDepositField;

        private decimal? interestExpenseForFederalFundsSoldAndSecuritiesPurchaseUnderAgreementsToResellField;

        private decimal? interestExpenseForLongTermDebtField;

        private decimal? interestExpenseForLongTermDebtAndCapitalSecuritiesField;

        private decimal? interestExpenseForShortTermDebtField;

        private decimal? interestExpenseNonOperatingField;

        private decimal? interestExpenseOperatingField;

        private decimal? interestIncomeAfterProvisionForLoanLossField;

        private decimal? interestIncomeFromDepositsField;

        private decimal? interestIncomeFromFederalFundsSoldAndSecuritiesPurchaseUnderAgreementsToResellField;

        private decimal? interestIncomeFromInvestmentSecuritiesField;

        private decimal? interestIncomeFromLeasesField;

        private decimal? interestIncomeFromLoansField;

        private decimal? interestIncomeFromLoansAndLeaseField;

        private decimal? interestIncomeFromSecuritiesField;

        private decimal? interestIncomeFromTradingAccountSecuritiesField;

        private decimal? interestIncomeNonOperatingField;

        private decimal? interestIncomeOperatingField;

        private decimal? netNonOperatingInterestIncomeExpenseField;

        private decimal? netOperatingInterestIncomeExpenseField;

        private decimal? investmentBankingProfitField;

        private decimal? lifeAnnuityPremiumsField;

        private decimal? loansHeldForResellField;

        private decimal? lossAndLossAdjustmentExpectedIncurredField;

        private decimal? lossAdjustmentExpenseField;

        private decimal? maintenanceAndRepairsField;

        private decimal? marketingExpenseField;

        private decimal? minorityInterestsField;

        private decimal? interestIncomeFromOtherMoneyMarketInvestmentsField;

        private decimal? netForeignExchangeGainLossField;

        private decimal? netIncomeField;

        private decimal? netIncomeCommonStockholdersField;

        private decimal? netIncomeContinuousOperationsField;

        private decimal? netInterestIncomeField;

        private decimal? netInvestmentIncomeField;

        private decimal? netOccupancyExpenseField;

        private decimal? netPremiumsWrittenField;

        private decimal? netRealizedGainLossOnInvestmentsField;

        private decimal? totalRevenueField;

        private decimal? nonRecurringOperationExpenseField;

        private decimal? nonInterestExpenseField;

        private decimal? nonInterestIncomeField;

        private decimal? occupancyAndEquipmentField;

        private decimal? operatingExpenseField;

        private decimal? operatingIncomeField;

        private decimal? operatingRevenueField;

        private decimal? operatingTaxesnLicensesField;

        private decimal? operationAndMaintenanceField;

        private decimal? otherCustomerServicesField;

        private decimal? otherGainLossFromDispositionOfDiscontinuedOperationsField;

        private decimal? otherIncomeExpenseField;

        private decimal? otherInterestExpenseField;

        private decimal? otherInterestIncomeField;

        private decimal? otherNonInterestExpenseField;

        private decimal? otherOperatingRevenueField;

        private decimal? otherSpecialChargesField;

        private decimal? miscOtherSpecialChargesField;

        private decimal? otherTaxesField;

        private decimal? policyAcquisitionExpenseField;

        private decimal? policyFeesField;

        private decimal? policyholderBenefitsCededField;

        private decimal? policyholderBenefitsGrossField;

        private decimal? netPolicyholderBenefitsAndClaimsField;

        private decimal? policyholderDividendsField;

        private decimal? policyholderInterestField;

        private decimal? policyholderAndReinsurerAccountsField;

        private decimal? trustPreferredSecuritiesField;

        private decimal? preferredStockDividendsField;

        private decimal? totalPremiumsEarnedField;

        private decimal? pretaxIncomeField;

        private decimal? principleTransactionRevenueField;

        private decimal? professionalExpenseAndContractServicesExpenseField;

        private decimal? promotionAndAdvertisingField;

        private decimal? propertyCasualtyPremiumsField;

        private decimal? provisionForDoubtfulAccountsField;

        private decimal? provisionForGainLossOnDisposalField;

        private decimal? taxProvisionField;

        private decimal? creditLossesProvisionField;

        private decimal? purchasedTransportationServicesField;

        private decimal? realizedCapitalGainField;

        private decimal? rentAndLandingFeesField;

        private decimal? researchExpenseField;

        private decimal? researchAndDevelopmentField;

        private decimal? restructuringAndMergernAcquisitionField;

        private decimal? revenuesCargoField;

        private decimal? revenuesPassengerField;

        private decimal? salariesAndWagesField;

        private decimal? securitiesActivitiesField;

        private decimal? sellingExpenseField;

        private decimal? sellingAndMarketingExpenseField;

        private decimal? sellingGeneralAndAdministrationField;

        private decimal? serviceChargeOnDepositorAccountsField;

        private decimal? shareInNetIncomeOfUnconsolidatedEntitiesField;

        private decimal? specialIncomeChargesField;

        private decimal? timeDepositsPlacedField;

        private decimal? totalExpensesField;

        private decimal? tradingGainLossField;

        private decimal? transportationRevenueField;

        private decimal? trustFeesbyCommissionsField;

        private decimal? underwritingExpensesField;

        private decimal? writeDownField;

        private decimal? otherWriteDownField;

        private decimal? writeOffField;

        private decimal? otherWriteOffField;

        private decimal? otherNonInterestIncomeField;

        private decimal? premiumTaxesCreditField;

        private decimal? amortizationOfIntangiblesField;

        private decimal? amortizationOfDeferredAcquisitionCostsField;

        private decimal? interestIncomeField;

        private decimal? netIncomeFromContinuingAndDiscontinuedOperationField;

        private decimal? netIncomeFromOtherGainsLossesField;

        private decimal? netIncomeFromTaxLossCarryforwardField;

        private decimal? otherOperatingExpensesField;

        private decimal? propertyLiabilityInsuranceClaimsField;

        private decimal? totalMoneyMarketInvestmentsField;

        private decimal? reconciledCostOfRevenueField;

        private decimal? reconciledDepreciationField;

        private decimal? earningBeforeInterestAndTaxField;

        private decimal? normalizedIncomeField;

        private decimal? eBITDAField;

        private decimal? nonOperatingExpensesField;

        private decimal? nonOperatingIncomeField;

        private decimal? basicContinuousOperationsField;

        private decimal? basicDiscontinuousOperationsField;

        private decimal? basicExtraordinaryField;

        private decimal? basicAccountingChangeField;

        private decimal? basicEPSField;

        private decimal? dilutedContinuousOperationsField;

        private decimal? dilutedDiscontinuousOperationsField;

        private decimal? dilutedExtraordinaryField;

        private decimal? dilutedAccountingChangeField;

        private decimal? dilutedEPSField;

        private decimal? basicAverageSharesField;

        private decimal? dilutedAverageSharesField;

        private decimal? dividendPerShareField;

        private decimal? basicEPSOtherGainsLossesField;

        private decimal? continuingAndDiscontinuedBasicEPSField;

        private decimal? taxLossCarryforwardBasicEPSField;

        private decimal? dilutedEPSOtherGainsLossesField;

        private decimal? continuingAndDiscontinuedDilutedEPSField;

        private decimal? taxLossCarryforwardDilutedEPSField;

        private decimal? netIncomeFromContinuingOperationNetMinorityInterestField;

        private string accessionNumberField;

        private string formTypeField;

        private decimal? principleInvestmentGainLossField;

        private decimal? gainLossonSaleofAssetsField;

        private decimal? gainonSaleofLoansField;

        private decimal? gainonSaleofInvestmentPropertyField;

        private decimal? specialIncomeField;

        private decimal? acquiredinProcessRnDIncomeField;

        private decimal? restructuringAndMergerAndAcquisitionIncomeField;

        private decimal? impairmentofCapitalAssetsIncomeField;

        private decimal? gainonExtinguishmentofDebtField;

        private decimal? specialChargeField;

        private decimal? lossonExtinguishmentofDebtField;

        private decimal? earningsFromEquityInterestNetOfTaxField;

        private decimal? netIncomeIncludingNoncontrollingInterestsField;

        private decimal? otherunderPreferredStockDividendField;

        private decimal? earningsfromEquityInterestRevenueField;

        private decimal? gainLossfromDisposalSaleofAssetsField;

        private decimal? gainLossfromDisposalSaleofAssetsOtherField;

        private decimal? gainonSaleofOtherRealEstateOwnedField;

        private decimal? interestIncomeRevenueField;

        private decimal? litigationExpenseField;

        private decimal? otherthanTemporaryImpairmentLossesInvestmentsField;

        private decimal? unrealizedGainorLossField;

        private decimal? changesinInventoriesofFinishedGoodsandWorkinProgressField;

        private decimal? workPerformedbyEntityandCapitalizedField;

        private decimal? distributionCostsField;

        private decimal? staffCostsField;

        private decimal? socialSecurityCostsField;

        private decimal? pensionCostsField;

        private decimal? otherOperatingIncomeTotalField;

        private decimal? shareofOperatingProfitLossfromJointVenturesAndAssociatesField;

        private decimal? exceptionalItemsField;

        private decimal? incomefromSharesinSubsidiariesGroupUndertakingsField;

        private decimal? incomefromAssociatesandOtherParticipatingInterestsField;

        private decimal? totalOtherFinanceCostField;

        private decimal? grossDividendPaymentField;

        private decimal? interestandSimilarIncomeField;

        private decimal? feesandCommissionIncomeField;

        private decimal? feesandCommissionExpenseField;

        private decimal? netTradingIncomeField;

        private decimal? outwardReinsurancePremiumsField;

        private decimal? otherStaffCostsField;

        private decimal? shareBasedPaymentsField;

        private decimal? gainonInvestmentPropertiesField;

        private decimal? averageDilutionEarnField;

        private decimal? gainonRedemptionandExtinguishmentofDebtField;

        private decimal? miscellaneousOtherOperatingIncomeField;

        private decimal? gainLossonFinancialInstrumentsDesignatedasCashFlowHedgesField;

        private decimal? gainLossonDerecognitionofAvailableForSaleFinancialAssetsField;

        private decimal? gainLossonDerecognitionofNonCurrentAssetsNotHeldforSaleTotalField;

        private decimal? negativeGoodwillImmediatelyRecognizedField;

        private decimal? gainsLossesonFinancialInstrumentsDuetoFairValueAdjustmentsinHedgeAccountingTotalField;

        private decimal? impairmentLossesReversalsFinancialInstrumentsNetField;

        private decimal? shareofProfitLossfromEquityAccountedInvestmentsField;

        private decimal? claimsandPaidIncurredField;

        private decimal? reinsuranceRecoveriesClaimsandBenefitsField;

        private decimal? changeinInsuranceLiabilitiesNetofReinsuranceField;

        private decimal? changeinInvestmentContractField;

        private decimal? changeinReinsuranceAssetsField;

        private decimal? creditRiskProvisionsField;

        private decimal? wagesandSalariesField;

        private decimal? otherNonOperatingIncomeExpensesField;

        private decimal? interestIncomeOtherOperatingIncomeField;

        private decimal? otherNonOperatingIncomeField;

        private decimal? otherNonOperatingExpensesField;

        private decimal? totalUnusualItemsField;

        private decimal? totalUnusualItemsExcludingGoodwillField;

        private decimal? taxRateForCalcsField;

        private decimal? calculatedTaxEffectOfUnusualItemsField;

        private decimal? normalizedBasicEPSField;

        private decimal? normalizedDilutedEPSField;

        private decimal? gainOnForeignCurrencyExchangeFromBorrowingsRelatingToInterestCostsField;

        private decimal? stockBasedCompensationField;

        private string fiscalYearChangeField;

        private decimal? otherGandAField;

        private decimal? otherCostofRevenueField;

        private decimal? rentandLandingFeesCostofRevenueField;

        private decimal? dDACostofRevenueField;

        private decimal? totalOperatingIncomeAsReportedField;

        private decimal? reportedNormalizedBasicEPSField;

        private decimal? reportedNormalizedDilutedEPSField;

        private decimal? rentExpenseSupplementalField;

        private decimal? normalizedPretaxIncomeField;

        private decimal? dividendCoverageRatioField;

        private decimal? researchAndDevelopmentExpensesSupplementalField;

        private decimal? depreciationSupplementalField;

        private decimal? amortizationSupplementalField;

        private decimal? dilutedNIAvailtoComStockholdersField;

        private decimal? investmentContractLiabilitiesIncurredField;

        private decimal? reinsuranceRecoveriesofInvestmentContractField;

        private decimal? totalDividendPaymentofEquitySharesField;

        private decimal? totalDividendPaymentofNonEquitySharesField;

        private decimal? changeinTheGrossProvisionforUnearnedPremiumsField;

        private decimal? changeinTheGrossProvisionforUnearnedPremiumsReinsurersShareField;

        private decimal? claimsandChangeinInsuranceLiabilitiesField;

        private decimal? reinsuranceRecoveriesofInsuranceLiabilitiesField;

        private decimal? totalRevenueAsReportedField;

        private decimal? operatingExpenseAsReportedField;

        private decimal? normalizedIncomeAsReportedField;

        private decimal? effectiveTaxRateAsReportedField;

        private decimal? normalizedEBITDAAsReportedField;

        private decimal? normalizedEBITAsReportedField;

        private decimal? normalizedOperatingProfitAsReportedField;

        private decimal? disposalofBusinessesSupplementalField;

        private decimal? discontinuedOperationsSupplementalField;

        private decimal? assetDisposalsSupplementalField;

        private decimal? impairmentWriteOffWriteDownofCapitalAssetsSupplementalField;

        private decimal? goodwillImpairmentWriteOffSupplementalField;

        private decimal? impairmentWriteOffWriteDownofOtherAssetsSupplementalField;

        private decimal? gainLossonExtinguishmentofDebtSupplementalField;

        private decimal? debtRestructuringSupplementalField;

        private decimal? litigationIncomeExpenseSupplementalField;

        private decimal? mergerandAcquisitionIncomeExpenseSupplementalField;

        private decimal? restructuringandReorganizationExpenseSupplementalField;

        private decimal? otherIrregularIncomeExpensesSupplementalField;

        private decimal? normalizedEBITDAField;

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
        public decimal? AccretionOnPreferredStock
        {
            get
            {
                return this.accretionOnPreferredStockField;
            }
            set
            {
                this.accretionOnPreferredStockField = value;
            }
        }

        /// <remarks/>
        public decimal? AccruedPreferredStockDividends
        {
            get
            {
                return this.accruedPreferredStockDividendsField;
            }
            set
            {
                this.accruedPreferredStockDividendsField = value;
            }
        }

        /// <remarks/>
        public decimal? AcquiredInProcessRnD
        {
            get
            {
                return this.acquiredInProcessRnDField;
            }
            set
            {
                this.acquiredInProcessRnDField = value;
            }
        }

        /// <remarks/>
        public decimal? AcquisitionExpense
        {
            get
            {
                return this.acquisitionExpenseField;
            }
            set
            {
                this.acquisitionExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? AdministrativeExpense
        {
            get
            {
                return this.administrativeExpenseField;
            }
            set
            {
                this.administrativeExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? AgencyFees
        {
            get
            {
                return this.agencyFeesField;
            }
            set
            {
                this.agencyFeesField = value;
            }
        }

        /// <remarks/>
        public decimal? AgencyFeesAndCommissions
        {
            get
            {
                return this.agencyFeesAndCommissionsField;
            }
            set
            {
                this.agencyFeesAndCommissionsField = value;
            }
        }

        /// <remarks/>
        public decimal? AllowancesForConstruction
        {
            get
            {
                return this.allowancesForConstructionField;
            }
            set
            {
                this.allowancesForConstructionField = value;
            }
        }

        /// <remarks/>
        public decimal? Amortization
        {
            get
            {
                return this.amortizationField;
            }
            set
            {
                this.amortizationField = value;
            }
        }

        /// <remarks/>
        public decimal? SecuritiesAmortization
        {
            get
            {
                return this.securitiesAmortizationField;
            }
            set
            {
                this.securitiesAmortizationField = value;
            }
        }

        /// <remarks/>
        public decimal? CapitalnBusinessTaxes
        {
            get
            {
                return this.capitalnBusinessTaxesField;
            }
            set
            {
                this.capitalnBusinessTaxesField = value;
            }
        }

        /// <remarks/>
        public decimal? CededPremiums
        {
            get
            {
                return this.cededPremiumsField;
            }
            set
            {
                this.cededPremiumsField = value;
            }
        }

        /// <remarks/>
        public decimal? CommissionExpenses
        {
            get
            {
                return this.commissionExpensesField;
            }
            set
            {
                this.commissionExpensesField = value;
            }
        }

        /// <remarks/>
        public decimal? CommissionRevenue
        {
            get
            {
                return this.commissionRevenueField;
            }
            set
            {
                this.commissionRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? CostOfRevenue
        {
            get
            {
                return this.costOfRevenueField;
            }
            set
            {
                this.costOfRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? CreditCard
        {
            get
            {
                return this.creditCardField;
            }
            set
            {
                this.creditCardField = value;
            }
        }

        /// <remarks/>
        public decimal? CumulativeEffectOfAccountingChange
        {
            get
            {
                return this.cumulativeEffectOfAccountingChangeField;
            }
            set
            {
                this.cumulativeEffectOfAccountingChangeField = value;
            }
        }

        /// <remarks/>
        public decimal? Depletion
        {
            get
            {
                return this.depletionField;
            }
            set
            {
                this.depletionField = value;
            }
        }

        /// <remarks/>
        public decimal? Depreciation
        {
            get
            {
                return this.depreciationField;
            }
            set
            {
                this.depreciationField = value;
            }
        }

        /// <remarks/>
        public decimal? DepreciationAndAmortization
        {
            get
            {
                return this.depreciationAndAmortizationField;
            }
            set
            {
                this.depreciationAndAmortizationField = value;
            }
        }

        /// <remarks/>
        public decimal? DepreciationAmortizationDepletion
        {
            get
            {
                return this.depreciationAmortizationDepletionField;
            }
            set
            {
                this.depreciationAmortizationDepletionField = value;
            }
        }

        /// <remarks/>
        public decimal? DevelopmentExpense
        {
            get
            {
                return this.developmentExpenseField;
            }
            set
            {
                this.developmentExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeDiscontinuousOperations
        {
            get
            {
                return this.netIncomeDiscontinuousOperationsField;
            }
            set
            {
                this.netIncomeDiscontinuousOperationsField = value;
            }
        }

        /// <remarks/>
        public decimal? DividendIncome
        {
            get
            {
                return this.dividendIncomeField;
            }
            set
            {
                this.dividendIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? EarningLossOfEquityInvestments
        {
            get
            {
                return this.earningLossOfEquityInvestmentsField;
            }
            set
            {
                this.earningLossOfEquityInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? EarningsFromEquityInterest
        {
            get
            {
                return this.earningsFromEquityInterestField;
            }
            set
            {
                this.earningsFromEquityInterestField = value;
            }
        }

        /// <remarks/>
        public decimal? ElectricRevenue
        {
            get
            {
                return this.electricRevenueField;
            }
            set
            {
                this.electricRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? Equipment
        {
            get
            {
                return this.equipmentField;
            }
            set
            {
                this.equipmentField = value;
            }
        }

        /// <remarks/>
        public decimal? ExciseTaxes
        {
            get
            {
                return this.exciseTaxesField;
            }
            set
            {
                this.exciseTaxesField = value;
            }
        }

        /// <remarks/>
        public decimal? ExplorationDevelopmentAndMineralPropertyLeaseExpenses
        {
            get
            {
                return this.explorationDevelopmentAndMineralPropertyLeaseExpensesField;
            }
            set
            {
                this.explorationDevelopmentAndMineralPropertyLeaseExpensesField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeExtraordinary
        {
            get
            {
                return this.netIncomeExtraordinaryField;
            }
            set
            {
                this.netIncomeExtraordinaryField = value;
            }
        }

        /// <remarks/>
        public decimal? FeeRevenueAndOtherIncome
        {
            get
            {
                return this.feeRevenueAndOtherIncomeField;
            }
            set
            {
                this.feeRevenueAndOtherIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? Fees
        {
            get
            {
                return this.feesField;
            }
            set
            {
                this.feesField = value;
            }
        }

        /// <remarks/>
        public decimal? FeesAndCommissions
        {
            get
            {
                return this.feesAndCommissionsField;
            }
            set
            {
                this.feesAndCommissionsField = value;
            }
        }

        /// <remarks/>
        public decimal? ForeignExchangeTradingGains
        {
            get
            {
                return this.foreignExchangeTradingGainsField;
            }
            set
            {
                this.foreignExchangeTradingGainsField = value;
            }
        }

        /// <remarks/>
        public decimal? Fuel
        {
            get
            {
                return this.fuelField;
            }
            set
            {
                this.fuelField = value;
            }
        }

        /// <remarks/>
        public decimal? FuelAndPurchasePower
        {
            get
            {
                return this.fuelAndPurchasePowerField;
            }
            set
            {
                this.fuelAndPurchasePowerField = value;
            }
        }

        /// <remarks/>
        public decimal? GainOnSaleOfBusiness
        {
            get
            {
                return this.gainOnSaleOfBusinessField;
            }
            set
            {
                this.gainOnSaleOfBusinessField = value;
            }
        }

        /// <remarks/>
        public decimal? GainOnSaleOfPPE
        {
            get
            {
                return this.gainOnSaleOfPPEField;
            }
            set
            {
                this.gainOnSaleOfPPEField = value;
            }
        }

        /// <remarks/>
        public decimal? GainOnSaleOfSecurity
        {
            get
            {
                return this.gainOnSaleOfSecurityField;
            }
            set
            {
                this.gainOnSaleOfSecurityField = value;
            }
        }

        /// <remarks/>
        public decimal? GainsLossOnDisposalOfDiscontinuedOperations
        {
            get
            {
                return this.gainsLossOnDisposalOfDiscontinuedOperationsField;
            }
            set
            {
                this.gainsLossOnDisposalOfDiscontinuedOperationsField = value;
            }
        }

        /// <remarks/>
        public decimal? GasRevenue
        {
            get
            {
                return this.gasRevenueField;
            }
            set
            {
                this.gasRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? GeneralAccountAssets
        {
            get
            {
                return this.generalAccountAssetsField;
            }
            set
            {
                this.generalAccountAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? GeneralExpense
        {
            get
            {
                return this.generalExpenseField;
            }
            set
            {
                this.generalExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? GeneralAndAdministrativeExpense
        {
            get
            {
                return this.generalAndAdministrativeExpenseField;
            }
            set
            {
                this.generalAndAdministrativeExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? GrossProfit
        {
            get
            {
                return this.grossProfitField;
            }
            set
            {
                this.grossProfitField = value;
            }
        }

        /// <remarks/>
        public decimal? GrossPremiumsWritten
        {
            get
            {
                return this.grossPremiumsWrittenField;
            }
            set
            {
                this.grossPremiumsWrittenField = value;
            }
        }

        /// <remarks/>
        public decimal? ImpairmentOfCapitalAssets
        {
            get
            {
                return this.impairmentOfCapitalAssetsField;
            }
            set
            {
                this.impairmentOfCapitalAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherImpairmentOfCapitalAssets
        {
            get
            {
                return this.otherImpairmentOfCapitalAssetsField;
            }
            set
            {
                this.otherImpairmentOfCapitalAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? IncomeFromEquityMethodInvestments
        {
            get
            {
                return this.incomeFromEquityMethodInvestmentsField;
            }
            set
            {
                this.incomeFromEquityMethodInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? RestructringAndMnAIncome
        {
            get
            {
                return this.restructringAndMnAIncomeField;
            }
            set
            {
                this.restructringAndMnAIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? IncreaseDecreaseInNetUnearnedPremiumReserves
        {
            get
            {
                return this.increaseDecreaseInNetUnearnedPremiumReservesField;
            }
            set
            {
                this.increaseDecreaseInNetUnearnedPremiumReservesField = value;
            }
        }

        /// <remarks/>
        public decimal? InsuranceAndClaims
        {
            get
            {
                return this.insuranceAndClaimsField;
            }
            set
            {
                this.insuranceAndClaimsField = value;
            }
        }

        /// <remarks/>
        public decimal? InsuranceAndPremiums
        {
            get
            {
                return this.insuranceAndPremiumsField;
            }
            set
            {
                this.insuranceAndPremiumsField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestIncomeFromInterestBearingDeposits
        {
            get
            {
                return this.interestIncomeFromInterestBearingDepositsField;
            }
            set
            {
                this.interestIncomeFromInterestBearingDepositsField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestExpense
        {
            get
            {
                return this.interestExpenseField;
            }
            set
            {
                this.interestExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestExpenseForCapitalizedLeaseObligations
        {
            get
            {
                return this.interestExpenseForCapitalizedLeaseObligationsField;
            }
            set
            {
                this.interestExpenseForCapitalizedLeaseObligationsField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestExpenseForDeposit
        {
            get
            {
                return this.interestExpenseForDepositField;
            }
            set
            {
                this.interestExpenseForDepositField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestExpenseForFederalFundsSoldAndSecuritiesPurchaseUnderAgreementsToResell
        {
            get
            {
                return this.interestExpenseForFederalFundsSoldAndSecuritiesPurchaseUnderAgreementsToResellField;
            }
            set
            {
                this.interestExpenseForFederalFundsSoldAndSecuritiesPurchaseUnderAgreementsToResellField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestExpenseForLongTermDebt
        {
            get
            {
                return this.interestExpenseForLongTermDebtField;
            }
            set
            {
                this.interestExpenseForLongTermDebtField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestExpenseForLongTermDebtAndCapitalSecurities
        {
            get
            {
                return this.interestExpenseForLongTermDebtAndCapitalSecuritiesField;
            }
            set
            {
                this.interestExpenseForLongTermDebtAndCapitalSecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestExpenseForShortTermDebt
        {
            get
            {
                return this.interestExpenseForShortTermDebtField;
            }
            set
            {
                this.interestExpenseForShortTermDebtField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestExpenseNonOperating
        {
            get
            {
                return this.interestExpenseNonOperatingField;
            }
            set
            {
                this.interestExpenseNonOperatingField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestExpenseOperating
        {
            get
            {
                return this.interestExpenseOperatingField;
            }
            set
            {
                this.interestExpenseOperatingField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestIncomeAfterProvisionForLoanLoss
        {
            get
            {
                return this.interestIncomeAfterProvisionForLoanLossField;
            }
            set
            {
                this.interestIncomeAfterProvisionForLoanLossField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestIncomeFromDeposits
        {
            get
            {
                return this.interestIncomeFromDepositsField;
            }
            set
            {
                this.interestIncomeFromDepositsField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestIncomeFromFederalFundsSoldAndSecuritiesPurchaseUnderAgreementsToResell
        {
            get
            {
                return this.interestIncomeFromFederalFundsSoldAndSecuritiesPurchaseUnderAgreementsToResellField;
            }
            set
            {
                this.interestIncomeFromFederalFundsSoldAndSecuritiesPurchaseUnderAgreementsToResellField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestIncomeFromInvestmentSecurities
        {
            get
            {
                return this.interestIncomeFromInvestmentSecuritiesField;
            }
            set
            {
                this.interestIncomeFromInvestmentSecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestIncomeFromLeases
        {
            get
            {
                return this.interestIncomeFromLeasesField;
            }
            set
            {
                this.interestIncomeFromLeasesField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestIncomeFromLoans
        {
            get
            {
                return this.interestIncomeFromLoansField;
            }
            set
            {
                this.interestIncomeFromLoansField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestIncomeFromLoansAndLease
        {
            get
            {
                return this.interestIncomeFromLoansAndLeaseField;
            }
            set
            {
                this.interestIncomeFromLoansAndLeaseField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestIncomeFromSecurities
        {
            get
            {
                return this.interestIncomeFromSecuritiesField;
            }
            set
            {
                this.interestIncomeFromSecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestIncomeFromTradingAccountSecurities
        {
            get
            {
                return this.interestIncomeFromTradingAccountSecuritiesField;
            }
            set
            {
                this.interestIncomeFromTradingAccountSecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestIncomeNonOperating
        {
            get
            {
                return this.interestIncomeNonOperatingField;
            }
            set
            {
                this.interestIncomeNonOperatingField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestIncomeOperating
        {
            get
            {
                return this.interestIncomeOperatingField;
            }
            set
            {
                this.interestIncomeOperatingField = value;
            }
        }

        /// <remarks/>
        public decimal? NetNonOperatingInterestIncomeExpense
        {
            get
            {
                return this.netNonOperatingInterestIncomeExpenseField;
            }
            set
            {
                this.netNonOperatingInterestIncomeExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? NetOperatingInterestIncomeExpense
        {
            get
            {
                return this.netOperatingInterestIncomeExpenseField;
            }
            set
            {
                this.netOperatingInterestIncomeExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? InvestmentBankingProfit
        {
            get
            {
                return this.investmentBankingProfitField;
            }
            set
            {
                this.investmentBankingProfitField = value;
            }
        }

        /// <remarks/>
        public decimal? LifeAnnuityPremiums
        {
            get
            {
                return this.lifeAnnuityPremiumsField;
            }
            set
            {
                this.lifeAnnuityPremiumsField = value;
            }
        }

        /// <remarks/>
        public decimal? LoansHeldForResell
        {
            get
            {
                return this.loansHeldForResellField;
            }
            set
            {
                this.loansHeldForResellField = value;
            }
        }

        /// <remarks/>
        public decimal? LossAndLossAdjustmentExpectedIncurred
        {
            get
            {
                return this.lossAndLossAdjustmentExpectedIncurredField;
            }
            set
            {
                this.lossAndLossAdjustmentExpectedIncurredField = value;
            }
        }

        /// <remarks/>
        public decimal? LossAdjustmentExpense
        {
            get
            {
                return this.lossAdjustmentExpenseField;
            }
            set
            {
                this.lossAdjustmentExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? MaintenanceAndRepairs
        {
            get
            {
                return this.maintenanceAndRepairsField;
            }
            set
            {
                this.maintenanceAndRepairsField = value;
            }
        }

        /// <remarks/>
        public decimal? MarketingExpense
        {
            get
            {
                return this.marketingExpenseField;
            }
            set
            {
                this.marketingExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? MinorityInterests
        {
            get
            {
                return this.minorityInterestsField;
            }
            set
            {
                this.minorityInterestsField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestIncomeFromOtherMoneyMarketInvestments
        {
            get
            {
                return this.interestIncomeFromOtherMoneyMarketInvestmentsField;
            }
            set
            {
                this.interestIncomeFromOtherMoneyMarketInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? NetForeignExchangeGainLoss
        {
            get
            {
                return this.netForeignExchangeGainLossField;
            }
            set
            {
                this.netForeignExchangeGainLossField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncome
        {
            get
            {
                return this.netIncomeField;
            }
            set
            {
                this.netIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeCommonStockholders
        {
            get
            {
                return this.netIncomeCommonStockholdersField;
            }
            set
            {
                this.netIncomeCommonStockholdersField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeContinuousOperations
        {
            get
            {
                return this.netIncomeContinuousOperationsField;
            }
            set
            {
                this.netIncomeContinuousOperationsField = value;
            }
        }

        /// <remarks/>
        public decimal? NetInterestIncome
        {
            get
            {
                return this.netInterestIncomeField;
            }
            set
            {
                this.netInterestIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? NetInvestmentIncome
        {
            get
            {
                return this.netInvestmentIncomeField;
            }
            set
            {
                this.netInvestmentIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? NetOccupancyExpense
        {
            get
            {
                return this.netOccupancyExpenseField;
            }
            set
            {
                this.netOccupancyExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? NetPremiumsWritten
        {
            get
            {
                return this.netPremiumsWrittenField;
            }
            set
            {
                this.netPremiumsWrittenField = value;
            }
        }

        /// <remarks/>
        public decimal? NetRealizedGainLossOnInvestments
        {
            get
            {
                return this.netRealizedGainLossOnInvestmentsField;
            }
            set
            {
                this.netRealizedGainLossOnInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalRevenue
        {
            get
            {
                return this.totalRevenueField;
            }
            set
            {
                this.totalRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? NonRecurringOperationExpense
        {
            get
            {
                return this.nonRecurringOperationExpenseField;
            }
            set
            {
                this.nonRecurringOperationExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? NonInterestExpense
        {
            get
            {
                return this.nonInterestExpenseField;
            }
            set
            {
                this.nonInterestExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? NonInterestIncome
        {
            get
            {
                return this.nonInterestIncomeField;
            }
            set
            {
                this.nonInterestIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? OccupancyAndEquipment
        {
            get
            {
                return this.occupancyAndEquipmentField;
            }
            set
            {
                this.occupancyAndEquipmentField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingExpense
        {
            get
            {
                return this.operatingExpenseField;
            }
            set
            {
                this.operatingExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingIncome
        {
            get
            {
                return this.operatingIncomeField;
            }
            set
            {
                this.operatingIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingRevenue
        {
            get
            {
                return this.operatingRevenueField;
            }
            set
            {
                this.operatingRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingTaxesnLicenses
        {
            get
            {
                return this.operatingTaxesnLicensesField;
            }
            set
            {
                this.operatingTaxesnLicensesField = value;
            }
        }

        /// <remarks/>
        public decimal? OperationAndMaintenance
        {
            get
            {
                return this.operationAndMaintenanceField;
            }
            set
            {
                this.operationAndMaintenanceField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherCustomerServices
        {
            get
            {
                return this.otherCustomerServicesField;
            }
            set
            {
                this.otherCustomerServicesField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherGainLossFromDispositionOfDiscontinuedOperations
        {
            get
            {
                return this.otherGainLossFromDispositionOfDiscontinuedOperationsField;
            }
            set
            {
                this.otherGainLossFromDispositionOfDiscontinuedOperationsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherIncomeExpense
        {
            get
            {
                return this.otherIncomeExpenseField;
            }
            set
            {
                this.otherIncomeExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherInterestExpense
        {
            get
            {
                return this.otherInterestExpenseField;
            }
            set
            {
                this.otherInterestExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherInterestIncome
        {
            get
            {
                return this.otherInterestIncomeField;
            }
            set
            {
                this.otherInterestIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherNonInterestExpense
        {
            get
            {
                return this.otherNonInterestExpenseField;
            }
            set
            {
                this.otherNonInterestExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherOperatingRevenue
        {
            get
            {
                return this.otherOperatingRevenueField;
            }
            set
            {
                this.otherOperatingRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherSpecialCharges
        {
            get
            {
                return this.otherSpecialChargesField;
            }
            set
            {
                this.otherSpecialChargesField = value;
            }
        }

        /// <remarks/>
        public decimal? MiscOtherSpecialCharges
        {
            get
            {
                return this.miscOtherSpecialChargesField;
            }
            set
            {
                this.miscOtherSpecialChargesField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherTaxes
        {
            get
            {
                return this.otherTaxesField;
            }
            set
            {
                this.otherTaxesField = value;
            }
        }

        /// <remarks/>
        public decimal? PolicyAcquisitionExpense
        {
            get
            {
                return this.policyAcquisitionExpenseField;
            }
            set
            {
                this.policyAcquisitionExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? PolicyFees
        {
            get
            {
                return this.policyFeesField;
            }
            set
            {
                this.policyFeesField = value;
            }
        }

        /// <remarks/>
        public decimal? PolicyholderBenefitsCeded
        {
            get
            {
                return this.policyholderBenefitsCededField;
            }
            set
            {
                this.policyholderBenefitsCededField = value;
            }
        }

        /// <remarks/>
        public decimal? PolicyholderBenefitsGross
        {
            get
            {
                return this.policyholderBenefitsGrossField;
            }
            set
            {
                this.policyholderBenefitsGrossField = value;
            }
        }

        /// <remarks/>
        public decimal? NetPolicyholderBenefitsAndClaims
        {
            get
            {
                return this.netPolicyholderBenefitsAndClaimsField;
            }
            set
            {
                this.netPolicyholderBenefitsAndClaimsField = value;
            }
        }

        /// <remarks/>
        public decimal? PolicyholderDividends
        {
            get
            {
                return this.policyholderDividendsField;
            }
            set
            {
                this.policyholderDividendsField = value;
            }
        }

        /// <remarks/>
        public decimal? PolicyholderInterest
        {
            get
            {
                return this.policyholderInterestField;
            }
            set
            {
                this.policyholderInterestField = value;
            }
        }

        /// <remarks/>
        public decimal? PolicyholderAndReinsurerAccounts
        {
            get
            {
                return this.policyholderAndReinsurerAccountsField;
            }
            set
            {
                this.policyholderAndReinsurerAccountsField = value;
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
        public decimal? PreferredStockDividends
        {
            get
            {
                return this.preferredStockDividendsField;
            }
            set
            {
                this.preferredStockDividendsField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalPremiumsEarned
        {
            get
            {
                return this.totalPremiumsEarnedField;
            }
            set
            {
                this.totalPremiumsEarnedField = value;
            }
        }

        /// <remarks/>
        public decimal? PretaxIncome
        {
            get
            {
                return this.pretaxIncomeField;
            }
            set
            {
                this.pretaxIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? PrincipleTransactionRevenue
        {
            get
            {
                return this.principleTransactionRevenueField;
            }
            set
            {
                this.principleTransactionRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? ProfessionalExpenseAndContractServicesExpense
        {
            get
            {
                return this.professionalExpenseAndContractServicesExpenseField;
            }
            set
            {
                this.professionalExpenseAndContractServicesExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? PromotionAndAdvertising
        {
            get
            {
                return this.promotionAndAdvertisingField;
            }
            set
            {
                this.promotionAndAdvertisingField = value;
            }
        }

        /// <remarks/>
        public decimal? PropertyCasualtyPremiums
        {
            get
            {
                return this.propertyCasualtyPremiumsField;
            }
            set
            {
                this.propertyCasualtyPremiumsField = value;
            }
        }

        /// <remarks/>
        public decimal? ProvisionForDoubtfulAccounts
        {
            get
            {
                return this.provisionForDoubtfulAccountsField;
            }
            set
            {
                this.provisionForDoubtfulAccountsField = value;
            }
        }

        /// <remarks/>
        public decimal? ProvisionForGainLossOnDisposal
        {
            get
            {
                return this.provisionForGainLossOnDisposalField;
            }
            set
            {
                this.provisionForGainLossOnDisposalField = value;
            }
        }

        /// <remarks/>
        public decimal? TaxProvision
        {
            get
            {
                return this.taxProvisionField;
            }
            set
            {
                this.taxProvisionField = value;
            }
        }

        /// <remarks/>
        public decimal? CreditLossesProvision
        {
            get
            {
                return this.creditLossesProvisionField;
            }
            set
            {
                this.creditLossesProvisionField = value;
            }
        }

        /// <remarks/>
        public decimal? PurchasedTransportationServices
        {
            get
            {
                return this.purchasedTransportationServicesField;
            }
            set
            {
                this.purchasedTransportationServicesField = value;
            }
        }

        /// <remarks/>
        public decimal? RealizedCapitalGain
        {
            get
            {
                return this.realizedCapitalGainField;
            }
            set
            {
                this.realizedCapitalGainField = value;
            }
        }

        /// <remarks/>
        public decimal? RentAndLandingFees
        {
            get
            {
                return this.rentAndLandingFeesField;
            }
            set
            {
                this.rentAndLandingFeesField = value;
            }
        }

        /// <remarks/>
        public decimal? ResearchExpense
        {
            get
            {
                return this.researchExpenseField;
            }
            set
            {
                this.researchExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? ResearchAndDevelopment
        {
            get
            {
                return this.researchAndDevelopmentField;
            }
            set
            {
                this.researchAndDevelopmentField = value;
            }
        }

        /// <remarks/>
        public decimal? RestructuringAndMergernAcquisition
        {
            get
            {
                return this.restructuringAndMergernAcquisitionField;
            }
            set
            {
                this.restructuringAndMergernAcquisitionField = value;
            }
        }

        /// <remarks/>
        public decimal? RevenuesCargo
        {
            get
            {
                return this.revenuesCargoField;
            }
            set
            {
                this.revenuesCargoField = value;
            }
        }

        /// <remarks/>
        public decimal? RevenuesPassenger
        {
            get
            {
                return this.revenuesPassengerField;
            }
            set
            {
                this.revenuesPassengerField = value;
            }
        }

        /// <remarks/>
        public decimal? SalariesAndWages
        {
            get
            {
                return this.salariesAndWagesField;
            }
            set
            {
                this.salariesAndWagesField = value;
            }
        }

        /// <remarks/>
        public decimal? SecuritiesActivities
        {
            get
            {
                return this.securitiesActivitiesField;
            }
            set
            {
                this.securitiesActivitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? SellingExpense
        {
            get
            {
                return this.sellingExpenseField;
            }
            set
            {
                this.sellingExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? SellingAndMarketingExpense
        {
            get
            {
                return this.sellingAndMarketingExpenseField;
            }
            set
            {
                this.sellingAndMarketingExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? SellingGeneralAndAdministration
        {
            get
            {
                return this.sellingGeneralAndAdministrationField;
            }
            set
            {
                this.sellingGeneralAndAdministrationField = value;
            }
        }

        /// <remarks/>
        public decimal? ServiceChargeOnDepositorAccounts
        {
            get
            {
                return this.serviceChargeOnDepositorAccountsField;
            }
            set
            {
                this.serviceChargeOnDepositorAccountsField = value;
            }
        }

        /// <remarks/>
        public decimal? ShareInNetIncomeOfUnconsolidatedEntities
        {
            get
            {
                return this.shareInNetIncomeOfUnconsolidatedEntitiesField;
            }
            set
            {
                this.shareInNetIncomeOfUnconsolidatedEntitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? SpecialIncomeCharges
        {
            get
            {
                return this.specialIncomeChargesField;
            }
            set
            {
                this.specialIncomeChargesField = value;
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
        public decimal? TotalExpenses
        {
            get
            {
                return this.totalExpensesField;
            }
            set
            {
                this.totalExpensesField = value;
            }
        }

        /// <remarks/>
        public decimal? TradingGainLoss
        {
            get
            {
                return this.tradingGainLossField;
            }
            set
            {
                this.tradingGainLossField = value;
            }
        }

        /// <remarks/>
        public decimal? TransportationRevenue
        {
            get
            {
                return this.transportationRevenueField;
            }
            set
            {
                this.transportationRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? TrustFeesbyCommissions
        {
            get
            {
                return this.trustFeesbyCommissionsField;
            }
            set
            {
                this.trustFeesbyCommissionsField = value;
            }
        }

        /// <remarks/>
        public decimal? UnderwritingExpenses
        {
            get
            {
                return this.underwritingExpensesField;
            }
            set
            {
                this.underwritingExpensesField = value;
            }
        }

        /// <remarks/>
        public decimal? WriteDown
        {
            get
            {
                return this.writeDownField;
            }
            set
            {
                this.writeDownField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherWriteDown
        {
            get
            {
                return this.otherWriteDownField;
            }
            set
            {
                this.otherWriteDownField = value;
            }
        }

        /// <remarks/>
        public decimal? WriteOff
        {
            get
            {
                return this.writeOffField;
            }
            set
            {
                this.writeOffField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherWriteOff
        {
            get
            {
                return this.otherWriteOffField;
            }
            set
            {
                this.otherWriteOffField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherNonInterestIncome
        {
            get
            {
                return this.otherNonInterestIncomeField;
            }
            set
            {
                this.otherNonInterestIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? PremiumTaxesCredit
        {
            get
            {
                return this.premiumTaxesCreditField;
            }
            set
            {
                this.premiumTaxesCreditField = value;
            }
        }

        /// <remarks/>
        public decimal? AmortizationOfIntangibles
        {
            get
            {
                return this.amortizationOfIntangiblesField;
            }
            set
            {
                this.amortizationOfIntangiblesField = value;
            }
        }

        /// <remarks/>
        public decimal? AmortizationOfDeferredAcquisitionCosts
        {
            get
            {
                return this.amortizationOfDeferredAcquisitionCostsField;
            }
            set
            {
                this.amortizationOfDeferredAcquisitionCostsField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestIncome
        {
            get
            {
                return this.interestIncomeField;
            }
            set
            {
                this.interestIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeFromContinuingAndDiscontinuedOperation
        {
            get
            {
                return this.netIncomeFromContinuingAndDiscontinuedOperationField;
            }
            set
            {
                this.netIncomeFromContinuingAndDiscontinuedOperationField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeFromOtherGainsLosses
        {
            get
            {
                return this.netIncomeFromOtherGainsLossesField;
            }
            set
            {
                this.netIncomeFromOtherGainsLossesField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeFromTaxLossCarryforward
        {
            get
            {
                return this.netIncomeFromTaxLossCarryforwardField;
            }
            set
            {
                this.netIncomeFromTaxLossCarryforwardField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherOperatingExpenses
        {
            get
            {
                return this.otherOperatingExpensesField;
            }
            set
            {
                this.otherOperatingExpensesField = value;
            }
        }

        /// <remarks/>
        public decimal? PropertyLiabilityInsuranceClaims
        {
            get
            {
                return this.propertyLiabilityInsuranceClaimsField;
            }
            set
            {
                this.propertyLiabilityInsuranceClaimsField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalMoneyMarketInvestments
        {
            get
            {
                return this.totalMoneyMarketInvestmentsField;
            }
            set
            {
                this.totalMoneyMarketInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? ReconciledCostOfRevenue
        {
            get
            {
                return this.reconciledCostOfRevenueField;
            }
            set
            {
                this.reconciledCostOfRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? ReconciledDepreciation
        {
            get
            {
                return this.reconciledDepreciationField;
            }
            set
            {
                this.reconciledDepreciationField = value;
            }
        }

        /// <remarks/>
        public decimal? EarningBeforeInterestAndTax
        {
            get
            {
                return this.earningBeforeInterestAndTaxField;
            }
            set
            {
                this.earningBeforeInterestAndTaxField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedIncome
        {
            get
            {
                return this.normalizedIncomeField;
            }
            set
            {
                this.normalizedIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? EBITDA
        {
            get
            {
                return this.eBITDAField;
            }
            set
            {
                this.eBITDAField = value;
            }
        }

        /// <remarks/>
        public decimal? NonOperatingExpenses
        {
            get
            {
                return this.nonOperatingExpensesField;
            }
            set
            {
                this.nonOperatingExpensesField = value;
            }
        }

        /// <remarks/>
        public decimal? NonOperatingIncome
        {
            get
            {
                return this.nonOperatingIncomeField;
            }
            set
            {
                this.nonOperatingIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? BasicContinuousOperations
        {
            get
            {
                return this.basicContinuousOperationsField;
            }
            set
            {
                this.basicContinuousOperationsField = value;
            }
        }

        /// <remarks/>
        public decimal? BasicDiscontinuousOperations
        {
            get
            {
                return this.basicDiscontinuousOperationsField;
            }
            set
            {
                this.basicDiscontinuousOperationsField = value;
            }
        }

        /// <remarks/>
        public decimal? BasicExtraordinary
        {
            get
            {
                return this.basicExtraordinaryField;
            }
            set
            {
                this.basicExtraordinaryField = value;
            }
        }

        /// <remarks/>
        public decimal? BasicAccountingChange
        {
            get
            {
                return this.basicAccountingChangeField;
            }
            set
            {
                this.basicAccountingChangeField = value;
            }
        }

        /// <remarks/>
        public decimal? BasicEPS
        {
            get
            {
                return this.basicEPSField;
            }
            set
            {
                this.basicEPSField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedContinuousOperations
        {
            get
            {
                return this.dilutedContinuousOperationsField;
            }
            set
            {
                this.dilutedContinuousOperationsField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedDiscontinuousOperations
        {
            get
            {
                return this.dilutedDiscontinuousOperationsField;
            }
            set
            {
                this.dilutedDiscontinuousOperationsField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedExtraordinary
        {
            get
            {
                return this.dilutedExtraordinaryField;
            }
            set
            {
                this.dilutedExtraordinaryField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedAccountingChange
        {
            get
            {
                return this.dilutedAccountingChangeField;
            }
            set
            {
                this.dilutedAccountingChangeField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedEPS
        {
            get
            {
                return this.dilutedEPSField;
            }
            set
            {
                this.dilutedEPSField = value;
            }
        }

        /// <remarks/>
        public decimal? BasicAverageShares
        {
            get
            {
                return this.basicAverageSharesField;
            }
            set
            {
                this.basicAverageSharesField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedAverageShares
        {
            get
            {
                return this.dilutedAverageSharesField;
            }
            set
            {
                this.dilutedAverageSharesField = value;
            }
        }

        /// <remarks/>
        public decimal? DividendPerShare
        {
            get
            {
                return this.dividendPerShareField;
            }
            set
            {
                this.dividendPerShareField = value;
            }
        }

        /// <remarks/>
        public decimal? BasicEPSOtherGainsLosses
        {
            get
            {
                return this.basicEPSOtherGainsLossesField;
            }
            set
            {
                this.basicEPSOtherGainsLossesField = value;
            }
        }

        /// <remarks/>
        public decimal? ContinuingAndDiscontinuedBasicEPS
        {
            get
            {
                return this.continuingAndDiscontinuedBasicEPSField;
            }
            set
            {
                this.continuingAndDiscontinuedBasicEPSField = value;
            }
        }

        /// <remarks/>
        public decimal? TaxLossCarryforwardBasicEPS
        {
            get
            {
                return this.taxLossCarryforwardBasicEPSField;
            }
            set
            {
                this.taxLossCarryforwardBasicEPSField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedEPSOtherGainsLosses
        {
            get
            {
                return this.dilutedEPSOtherGainsLossesField;
            }
            set
            {
                this.dilutedEPSOtherGainsLossesField = value;
            }
        }

        /// <remarks/>
        public decimal? ContinuingAndDiscontinuedDilutedEPS
        {
            get
            {
                return this.continuingAndDiscontinuedDilutedEPSField;
            }
            set
            {
                this.continuingAndDiscontinuedDilutedEPSField = value;
            }
        }

        /// <remarks/>
        public decimal? TaxLossCarryforwardDilutedEPS
        {
            get
            {
                return this.taxLossCarryforwardDilutedEPSField;
            }
            set
            {
                this.taxLossCarryforwardDilutedEPSField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeFromContinuingOperationNetMinorityInterest
        {
            get
            {
                return this.netIncomeFromContinuingOperationNetMinorityInterestField;
            }
            set
            {
                this.netIncomeFromContinuingOperationNetMinorityInterestField = value;
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
        public decimal? PrincipleInvestmentGainLoss
        {
            get
            {
                return this.principleInvestmentGainLossField;
            }
            set
            {
                this.principleInvestmentGainLossField = value;
            }
        }

        /// <remarks/>
        public decimal? GainLossonSaleofAssets
        {
            get
            {
                return this.gainLossonSaleofAssetsField;
            }
            set
            {
                this.gainLossonSaleofAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? GainonSaleofLoans
        {
            get
            {
                return this.gainonSaleofLoansField;
            }
            set
            {
                this.gainonSaleofLoansField = value;
            }
        }

        /// <remarks/>
        public decimal? GainonSaleofInvestmentProperty
        {
            get
            {
                return this.gainonSaleofInvestmentPropertyField;
            }
            set
            {
                this.gainonSaleofInvestmentPropertyField = value;
            }
        }

        /// <remarks/>
        public decimal? SpecialIncome
        {
            get
            {
                return this.specialIncomeField;
            }
            set
            {
                this.specialIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? AcquiredinProcessRnDIncome
        {
            get
            {
                return this.acquiredinProcessRnDIncomeField;
            }
            set
            {
                this.acquiredinProcessRnDIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? RestructuringAndMergerAndAcquisitionIncome
        {
            get
            {
                return this.restructuringAndMergerAndAcquisitionIncomeField;
            }
            set
            {
                this.restructuringAndMergerAndAcquisitionIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? ImpairmentofCapitalAssetsIncome
        {
            get
            {
                return this.impairmentofCapitalAssetsIncomeField;
            }
            set
            {
                this.impairmentofCapitalAssetsIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? GainonExtinguishmentofDebt
        {
            get
            {
                return this.gainonExtinguishmentofDebtField;
            }
            set
            {
                this.gainonExtinguishmentofDebtField = value;
            }
        }

        /// <remarks/>
        public decimal? SpecialCharge
        {
            get
            {
                return this.specialChargeField;
            }
            set
            {
                this.specialChargeField = value;
            }
        }

        /// <remarks/>
        public decimal? LossonExtinguishmentofDebt
        {
            get
            {
                return this.lossonExtinguishmentofDebtField;
            }
            set
            {
                this.lossonExtinguishmentofDebtField = value;
            }
        }

        /// <remarks/>
        public decimal? EarningsFromEquityInterestNetOfTax
        {
            get
            {
                return this.earningsFromEquityInterestNetOfTaxField;
            }
            set
            {
                this.earningsFromEquityInterestNetOfTaxField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeIncludingNoncontrollingInterests
        {
            get
            {
                return this.netIncomeIncludingNoncontrollingInterestsField;
            }
            set
            {
                this.netIncomeIncludingNoncontrollingInterestsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherunderPreferredStockDividend
        {
            get
            {
                return this.otherunderPreferredStockDividendField;
            }
            set
            {
                this.otherunderPreferredStockDividendField = value;
            }
        }

        /// <remarks/>
        public decimal? EarningsfromEquityInterestRevenue
        {
            get
            {
                return this.earningsfromEquityInterestRevenueField;
            }
            set
            {
                this.earningsfromEquityInterestRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? GainLossfromDisposalSaleofAssets
        {
            get
            {
                return this.gainLossfromDisposalSaleofAssetsField;
            }
            set
            {
                this.gainLossfromDisposalSaleofAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? GainLossfromDisposalSaleofAssetsOther
        {
            get
            {
                return this.gainLossfromDisposalSaleofAssetsOtherField;
            }
            set
            {
                this.gainLossfromDisposalSaleofAssetsOtherField = value;
            }
        }

        /// <remarks/>
        public decimal? GainonSaleofOtherRealEstateOwned
        {
            get
            {
                return this.gainonSaleofOtherRealEstateOwnedField;
            }
            set
            {
                this.gainonSaleofOtherRealEstateOwnedField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestIncomeRevenue
        {
            get
            {
                return this.interestIncomeRevenueField;
            }
            set
            {
                this.interestIncomeRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? LitigationExpense
        {
            get
            {
                return this.litigationExpenseField;
            }
            set
            {
                this.litigationExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherthanTemporaryImpairmentLossesInvestments
        {
            get
            {
                return this.otherthanTemporaryImpairmentLossesInvestmentsField;
            }
            set
            {
                this.otherthanTemporaryImpairmentLossesInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? UnrealizedGainorLoss
        {
            get
            {
                return this.unrealizedGainorLossField;
            }
            set
            {
                this.unrealizedGainorLossField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangesinInventoriesofFinishedGoodsandWorkinProgress
        {
            get
            {
                return this.changesinInventoriesofFinishedGoodsandWorkinProgressField;
            }
            set
            {
                this.changesinInventoriesofFinishedGoodsandWorkinProgressField = value;
            }
        }

        /// <remarks/>
        public decimal? WorkPerformedbyEntityandCapitalized
        {
            get
            {
                return this.workPerformedbyEntityandCapitalizedField;
            }
            set
            {
                this.workPerformedbyEntityandCapitalizedField = value;
            }
        }

        /// <remarks/>
        public decimal? DistributionCosts
        {
            get
            {
                return this.distributionCostsField;
            }
            set
            {
                this.distributionCostsField = value;
            }
        }

        /// <remarks/>
        public decimal? StaffCosts
        {
            get
            {
                return this.staffCostsField;
            }
            set
            {
                this.staffCostsField = value;
            }
        }

        /// <remarks/>
        public decimal? SocialSecurityCosts
        {
            get
            {
                return this.socialSecurityCostsField;
            }
            set
            {
                this.socialSecurityCostsField = value;
            }
        }

        /// <remarks/>
        public decimal? PensionCosts
        {
            get
            {
                return this.pensionCostsField;
            }
            set
            {
                this.pensionCostsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherOperatingIncomeTotal
        {
            get
            {
                return this.otherOperatingIncomeTotalField;
            }
            set
            {
                this.otherOperatingIncomeTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? ShareofOperatingProfitLossfromJointVenturesAndAssociates
        {
            get
            {
                return this.shareofOperatingProfitLossfromJointVenturesAndAssociatesField;
            }
            set
            {
                this.shareofOperatingProfitLossfromJointVenturesAndAssociatesField = value;
            }
        }

        /// <remarks/>
        public decimal? ExceptionalItems
        {
            get
            {
                return this.exceptionalItemsField;
            }
            set
            {
                this.exceptionalItemsField = value;
            }
        }

        /// <remarks/>
        public decimal? IncomefromSharesinSubsidiariesGroupUndertakings
        {
            get
            {
                return this.incomefromSharesinSubsidiariesGroupUndertakingsField;
            }
            set
            {
                this.incomefromSharesinSubsidiariesGroupUndertakingsField = value;
            }
        }

        /// <remarks/>
        public decimal? IncomefromAssociatesandOtherParticipatingInterests
        {
            get
            {
                return this.incomefromAssociatesandOtherParticipatingInterestsField;
            }
            set
            {
                this.incomefromAssociatesandOtherParticipatingInterestsField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalOtherFinanceCost
        {
            get
            {
                return this.totalOtherFinanceCostField;
            }
            set
            {
                this.totalOtherFinanceCostField = value;
            }
        }

        /// <remarks/>
        public decimal? GrossDividendPayment
        {
            get
            {
                return this.grossDividendPaymentField;
            }
            set
            {
                this.grossDividendPaymentField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestandSimilarIncome
        {
            get
            {
                return this.interestandSimilarIncomeField;
            }
            set
            {
                this.interestandSimilarIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? FeesandCommissionIncome
        {
            get
            {
                return this.feesandCommissionIncomeField;
            }
            set
            {
                this.feesandCommissionIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? FeesandCommissionExpense
        {
            get
            {
                return this.feesandCommissionExpenseField;
            }
            set
            {
                this.feesandCommissionExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? NetTradingIncome
        {
            get
            {
                return this.netTradingIncomeField;
            }
            set
            {
                this.netTradingIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? OutwardReinsurancePremiums
        {
            get
            {
                return this.outwardReinsurancePremiumsField;
            }
            set
            {
                this.outwardReinsurancePremiumsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherStaffCosts
        {
            get
            {
                return this.otherStaffCostsField;
            }
            set
            {
                this.otherStaffCostsField = value;
            }
        }

        /// <remarks/>
        public decimal? ShareBasedPayments
        {
            get
            {
                return this.shareBasedPaymentsField;
            }
            set
            {
                this.shareBasedPaymentsField = value;
            }
        }

        /// <remarks/>
        public decimal? GainonInvestmentProperties
        {
            get
            {
                return this.gainonInvestmentPropertiesField;
            }
            set
            {
                this.gainonInvestmentPropertiesField = value;
            }
        }

        /// <remarks/>
        public decimal? AverageDilutionEarn
        {
            get
            {
                return this.averageDilutionEarnField;
            }
            set
            {
                this.averageDilutionEarnField = value;
            }
        }

        /// <remarks/>
        public decimal? GainonRedemptionandExtinguishmentofDebt
        {
            get
            {
                return this.gainonRedemptionandExtinguishmentofDebtField;
            }
            set
            {
                this.gainonRedemptionandExtinguishmentofDebtField = value;
            }
        }

        /// <remarks/>
        public decimal? MiscellaneousOtherOperatingIncome
        {
            get
            {
                return this.miscellaneousOtherOperatingIncomeField;
            }
            set
            {
                this.miscellaneousOtherOperatingIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? GainLossonFinancialInstrumentsDesignatedasCashFlowHedges
        {
            get
            {
                return this.gainLossonFinancialInstrumentsDesignatedasCashFlowHedgesField;
            }
            set
            {
                this.gainLossonFinancialInstrumentsDesignatedasCashFlowHedgesField = value;
            }
        }

        /// <remarks/>
        public decimal? GainLossonDerecognitionofAvailableForSaleFinancialAssets
        {
            get
            {
                return this.gainLossonDerecognitionofAvailableForSaleFinancialAssetsField;
            }
            set
            {
                this.gainLossonDerecognitionofAvailableForSaleFinancialAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? GainLossonDerecognitionofNonCurrentAssetsNotHeldforSaleTotal
        {
            get
            {
                return this.gainLossonDerecognitionofNonCurrentAssetsNotHeldforSaleTotalField;
            }
            set
            {
                this.gainLossonDerecognitionofNonCurrentAssetsNotHeldforSaleTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? NegativeGoodwillImmediatelyRecognized
        {
            get
            {
                return this.negativeGoodwillImmediatelyRecognizedField;
            }
            set
            {
                this.negativeGoodwillImmediatelyRecognizedField = value;
            }
        }

        /// <remarks/>
        public decimal? GainsLossesonFinancialInstrumentsDuetoFairValueAdjustmentsinHedgeAccountingTotal
        {
            get
            {
                return this.gainsLossesonFinancialInstrumentsDuetoFairValueAdjustmentsinHedgeAccountingTotalField;
            }
            set
            {
                this.gainsLossesonFinancialInstrumentsDuetoFairValueAdjustmentsinHedgeAccountingTotalField = value;
            }
        }

        /// <remarks/>
        public decimal? ImpairmentLossesReversalsFinancialInstrumentsNet
        {
            get
            {
                return this.impairmentLossesReversalsFinancialInstrumentsNetField;
            }
            set
            {
                this.impairmentLossesReversalsFinancialInstrumentsNetField = value;
            }
        }

        /// <remarks/>
        public decimal? ShareofProfitLossfromEquityAccountedInvestments
        {
            get
            {
                return this.shareofProfitLossfromEquityAccountedInvestmentsField;
            }
            set
            {
                this.shareofProfitLossfromEquityAccountedInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? ClaimsandPaidIncurred
        {
            get
            {
                return this.claimsandPaidIncurredField;
            }
            set
            {
                this.claimsandPaidIncurredField = value;
            }
        }

        /// <remarks/>
        public decimal? ReinsuranceRecoveriesClaimsandBenefits
        {
            get
            {
                return this.reinsuranceRecoveriesClaimsandBenefitsField;
            }
            set
            {
                this.reinsuranceRecoveriesClaimsandBenefitsField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinInsuranceLiabilitiesNetofReinsurance
        {
            get
            {
                return this.changeinInsuranceLiabilitiesNetofReinsuranceField;
            }
            set
            {
                this.changeinInsuranceLiabilitiesNetofReinsuranceField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinInvestmentContract
        {
            get
            {
                return this.changeinInvestmentContractField;
            }
            set
            {
                this.changeinInvestmentContractField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinReinsuranceAssets
        {
            get
            {
                return this.changeinReinsuranceAssetsField;
            }
            set
            {
                this.changeinReinsuranceAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? CreditRiskProvisions
        {
            get
            {
                return this.creditRiskProvisionsField;
            }
            set
            {
                this.creditRiskProvisionsField = value;
            }
        }

        /// <remarks/>
        public decimal? WagesandSalaries
        {
            get
            {
                return this.wagesandSalariesField;
            }
            set
            {
                this.wagesandSalariesField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherNonOperatingIncomeExpenses
        {
            get
            {
                return this.otherNonOperatingIncomeExpensesField;
            }
            set
            {
                this.otherNonOperatingIncomeExpensesField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestIncomeOtherOperatingIncome
        {
            get
            {
                return this.interestIncomeOtherOperatingIncomeField;
            }
            set
            {
                this.interestIncomeOtherOperatingIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherNonOperatingIncome
        {
            get
            {
                return this.otherNonOperatingIncomeField;
            }
            set
            {
                this.otherNonOperatingIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherNonOperatingExpenses
        {
            get
            {
                return this.otherNonOperatingExpensesField;
            }
            set
            {
                this.otherNonOperatingExpensesField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalUnusualItems
        {
            get
            {
                return this.totalUnusualItemsField;
            }
            set
            {
                this.totalUnusualItemsField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalUnusualItemsExcludingGoodwill
        {
            get
            {
                return this.totalUnusualItemsExcludingGoodwillField;
            }
            set
            {
                this.totalUnusualItemsExcludingGoodwillField = value;
            }
        }

        /// <remarks/>
        public decimal? TaxRateForCalcs
        {
            get
            {
                return this.taxRateForCalcsField;
            }
            set
            {
                this.taxRateForCalcsField = value;
            }
        }

        /// <remarks/>
        public decimal? CalculatedTaxEffectOfUnusualItems
        {
            get
            {
                return this.calculatedTaxEffectOfUnusualItemsField;
            }
            set
            {
                this.calculatedTaxEffectOfUnusualItemsField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedBasicEPS
        {
            get
            {
                return this.normalizedBasicEPSField;
            }
            set
            {
                this.normalizedBasicEPSField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedDilutedEPS
        {
            get
            {
                return this.normalizedDilutedEPSField;
            }
            set
            {
                this.normalizedDilutedEPSField = value;
            }
        }

        /// <remarks/>
        public decimal? GainOnForeignCurrencyExchangeFromBorrowingsRelatingToInterestCosts
        {
            get
            {
                return this.gainOnForeignCurrencyExchangeFromBorrowingsRelatingToInterestCostsField;
            }
            set
            {
                this.gainOnForeignCurrencyExchangeFromBorrowingsRelatingToInterestCostsField = value;
            }
        }

        /// <remarks/>
        public decimal? StockBasedCompensation
        {
            get
            {
                return this.stockBasedCompensationField;
            }
            set
            {
                this.stockBasedCompensationField = value;
            }
        }

        /// <remarks/>
        public string FiscalYearChange
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
        public decimal? OtherGandA
        {
            get
            {
                return this.otherGandAField;
            }
            set
            {
                this.otherGandAField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherCostofRevenue
        {
            get
            {
                return this.otherCostofRevenueField;
            }
            set
            {
                this.otherCostofRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? RentandLandingFeesCostofRevenue
        {
            get
            {
                return this.rentandLandingFeesCostofRevenueField;
            }
            set
            {
                this.rentandLandingFeesCostofRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? DDACostofRevenue
        {
            get
            {
                return this.dDACostofRevenueField;
            }
            set
            {
                this.dDACostofRevenueField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalOperatingIncomeAsReported
        {
            get
            {
                return this.totalOperatingIncomeAsReportedField;
            }
            set
            {
                this.totalOperatingIncomeAsReportedField = value;
            }
        }

        /// <remarks/>
        public decimal? ReportedNormalizedBasicEPS
        {
            get
            {
                return this.reportedNormalizedBasicEPSField;
            }
            set
            {
                this.reportedNormalizedBasicEPSField = value;
            }
        }

        /// <remarks/>
        public decimal? ReportedNormalizedDilutedEPS
        {
            get
            {
                return this.reportedNormalizedDilutedEPSField;
            }
            set
            {
                this.reportedNormalizedDilutedEPSField = value;
            }
        }

        /// <remarks/>
        public decimal? RentExpenseSupplemental
        {
            get
            {
                return this.rentExpenseSupplementalField;
            }
            set
            {
                this.rentExpenseSupplementalField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedPretaxIncome
        {
            get
            {
                return this.normalizedPretaxIncomeField;
            }
            set
            {
                this.normalizedPretaxIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? DividendCoverageRatio
        {
            get
            {
                return this.dividendCoverageRatioField;
            }
            set
            {
                this.dividendCoverageRatioField = value;
            }
        }

        /// <remarks/>
        public decimal? ResearchAndDevelopmentExpensesSupplemental
        {
            get
            {
                return this.researchAndDevelopmentExpensesSupplementalField;
            }
            set
            {
                this.researchAndDevelopmentExpensesSupplementalField = value;
            }
        }

        /// <remarks/>
        public decimal? DepreciationSupplemental
        {
            get
            {
                return this.depreciationSupplementalField;
            }
            set
            {
                this.depreciationSupplementalField = value;
            }
        }

        /// <remarks/>
        public decimal? AmortizationSupplemental
        {
            get
            {
                return this.amortizationSupplementalField;
            }
            set
            {
                this.amortizationSupplementalField = value;
            }
        }

        /// <remarks/>
        public decimal? DilutedNIAvailtoComStockholders
        {
            get
            {
                return this.dilutedNIAvailtoComStockholdersField;
            }
            set
            {
                this.dilutedNIAvailtoComStockholdersField = value;
            }
        }

        /// <remarks/>
        public decimal? InvestmentContractLiabilitiesIncurred
        {
            get
            {
                return this.investmentContractLiabilitiesIncurredField;
            }
            set
            {
                this.investmentContractLiabilitiesIncurredField = value;
            }
        }

        /// <remarks/>
        public decimal? ReinsuranceRecoveriesofInvestmentContract
        {
            get
            {
                return this.reinsuranceRecoveriesofInvestmentContractField;
            }
            set
            {
                this.reinsuranceRecoveriesofInvestmentContractField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalDividendPaymentofEquityShares
        {
            get
            {
                return this.totalDividendPaymentofEquitySharesField;
            }
            set
            {
                this.totalDividendPaymentofEquitySharesField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalDividendPaymentofNonEquityShares
        {
            get
            {
                return this.totalDividendPaymentofNonEquitySharesField;
            }
            set
            {
                this.totalDividendPaymentofNonEquitySharesField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinTheGrossProvisionforUnearnedPremiums
        {
            get
            {
                return this.changeinTheGrossProvisionforUnearnedPremiumsField;
            }
            set
            {
                this.changeinTheGrossProvisionforUnearnedPremiumsField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinTheGrossProvisionforUnearnedPremiumsReinsurersShare
        {
            get
            {
                return this.changeinTheGrossProvisionforUnearnedPremiumsReinsurersShareField;
            }
            set
            {
                this.changeinTheGrossProvisionforUnearnedPremiumsReinsurersShareField = value;
            }
        }

        /// <remarks/>
        public decimal? ClaimsandChangeinInsuranceLiabilities
        {
            get
            {
                return this.claimsandChangeinInsuranceLiabilitiesField;
            }
            set
            {
                this.claimsandChangeinInsuranceLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? ReinsuranceRecoveriesofInsuranceLiabilities
        {
            get
            {
                return this.reinsuranceRecoveriesofInsuranceLiabilitiesField;
            }
            set
            {
                this.reinsuranceRecoveriesofInsuranceLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalRevenueAsReported
        {
            get
            {
                return this.totalRevenueAsReportedField;
            }
            set
            {
                this.totalRevenueAsReportedField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingExpenseAsReported
        {
            get
            {
                return this.operatingExpenseAsReportedField;
            }
            set
            {
                this.operatingExpenseAsReportedField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedIncomeAsReported
        {
            get
            {
                return this.normalizedIncomeAsReportedField;
            }
            set
            {
                this.normalizedIncomeAsReportedField = value;
            }
        }

        /// <remarks/>
        public decimal? EffectiveTaxRateAsReported
        {
            get
            {
                return this.effectiveTaxRateAsReportedField;
            }
            set
            {
                this.effectiveTaxRateAsReportedField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedEBITDAAsReported
        {
            get
            {
                return this.normalizedEBITDAAsReportedField;
            }
            set
            {
                this.normalizedEBITDAAsReportedField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedEBITAsReported
        {
            get
            {
                return this.normalizedEBITAsReportedField;
            }
            set
            {
                this.normalizedEBITAsReportedField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedOperatingProfitAsReported
        {
            get
            {
                return this.normalizedOperatingProfitAsReportedField;
            }
            set
            {
                this.normalizedOperatingProfitAsReportedField = value;
            }
        }

        /// <remarks/>
        public decimal? DisposalofBusinessesSupplemental
        {
            get
            {
                return this.disposalofBusinessesSupplementalField;
            }
            set
            {
                this.disposalofBusinessesSupplementalField = value;
            }
        }

        /// <remarks/>
        public decimal? DiscontinuedOperationsSupplemental
        {
            get
            {
                return this.discontinuedOperationsSupplementalField;
            }
            set
            {
                this.discontinuedOperationsSupplementalField = value;
            }
        }

        /// <remarks/>
        public decimal? AssetDisposalsSupplemental
        {
            get
            {
                return this.assetDisposalsSupplementalField;
            }
            set
            {
                this.assetDisposalsSupplementalField = value;
            }
        }

        /// <remarks/>
        public decimal? ImpairmentWriteOffWriteDownofCapitalAssetsSupplemental
        {
            get
            {
                return this.impairmentWriteOffWriteDownofCapitalAssetsSupplementalField;
            }
            set
            {
                this.impairmentWriteOffWriteDownofCapitalAssetsSupplementalField = value;
            }
        }

        /// <remarks/>
        public decimal? GoodwillImpairmentWriteOffSupplemental
        {
            get
            {
                return this.goodwillImpairmentWriteOffSupplementalField;
            }
            set
            {
                this.goodwillImpairmentWriteOffSupplementalField = value;
            }
        }

        /// <remarks/>
        public decimal? ImpairmentWriteOffWriteDownofOtherAssetsSupplemental
        {
            get
            {
                return this.impairmentWriteOffWriteDownofOtherAssetsSupplementalField;
            }
            set
            {
                this.impairmentWriteOffWriteDownofOtherAssetsSupplementalField = value;
            }
        }

        /// <remarks/>
        public decimal? GainLossonExtinguishmentofDebtSupplemental
        {
            get
            {
                return this.gainLossonExtinguishmentofDebtSupplementalField;
            }
            set
            {
                this.gainLossonExtinguishmentofDebtSupplementalField = value;
            }
        }

        /// <remarks/>
        public decimal? DebtRestructuringSupplemental
        {
            get
            {
                return this.debtRestructuringSupplementalField;
            }
            set
            {
                this.debtRestructuringSupplementalField = value;
            }
        }

        /// <remarks/>
        public decimal? LitigationIncomeExpenseSupplemental
        {
            get
            {
                return this.litigationIncomeExpenseSupplementalField;
            }
            set
            {
                this.litigationIncomeExpenseSupplementalField = value;
            }
        }

        /// <remarks/>
        public decimal? MergerandAcquisitionIncomeExpenseSupplemental
        {
            get
            {
                return this.mergerandAcquisitionIncomeExpenseSupplementalField;
            }
            set
            {
                this.mergerandAcquisitionIncomeExpenseSupplementalField = value;
            }
        }

        /// <remarks/>
        public decimal? RestructuringandReorganizationExpenseSupplemental
        {
            get
            {
                return this.restructuringandReorganizationExpenseSupplementalField;
            }
            set
            {
                this.restructuringandReorganizationExpenseSupplementalField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherIrregularIncomeExpensesSupplemental
        {
            get
            {
                return this.otherIrregularIncomeExpensesSupplementalField;
            }
            set
            {
                this.otherIrregularIncomeExpensesSupplementalField = value;
            }
        }

        /// <remarks/>
        public decimal? NormalizedEBITDA
        {
            get
            {
                return this.normalizedEBITDAField;
            }
            set
            {
                this.normalizedEBITDAField = value;
            }
        }
    }
}
