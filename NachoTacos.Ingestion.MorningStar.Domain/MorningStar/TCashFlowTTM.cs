using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    [Table("TCashFlowTTM", Schema = "MStar")]
    public partial class TCashFlowTTM : TBase
    {
        private DateTime reportDateField;

        private DateTime periodEndingDateField;

        private DateTime fileDateField;

        private string statementTypeField;

        private string dataTypeField;

        private string interimField;

        private string currencyIdField;

        private int fiscalYearEndField;

        private decimal? amortizationField;

        private decimal? amortizationOfFinancingCostsAndDiscountsField;

        private decimal? amortizationOfSecuritiesField;

        private decimal? assetImpairmentChargeField;

        private decimal? callsMaturitiesOfMaturitySecuritiesField;

        private decimal? capitalExpenditureField;

        private decimal? netCapitalExpenditureDisposalsField;

        private decimal? capitalExpenditureReportedField;

        private decimal? cashDividendsPaidField;

        private decimal? cashFlowFromContinuingFinancingActivitiesField;

        private decimal? cashFlowFromContinuingInvestingActivitiesField;

        private decimal? cashFlowFromContinuingOperatingActivitiesField;

        private decimal? cashFlowFromDiscontinuedOperationField;

        private decimal? financingCashFlowField;

        private decimal? investingCashFlowField;

        private decimal? operatingCashFlowField;

        private decimal? beginningCashPositionField;

        private decimal? endCashPositionField;

        private decimal? cashFromDiscontinuedFinancingActivitiesField;

        private decimal? cashFromDiscontinuedInvestingActivitiesField;

        private decimal? changeInAccountPayableField;

        private decimal? changeInDividendPayableField;

        private decimal? changeInTaxPayableField;

        private decimal? changeInAccruedExpenseField;

        private decimal? changeInAccruedInvestmentIncomeField;

        private decimal? changesInCashField;

        private decimal? changeInDeferredAcquisitionCostsField;

        private decimal? changeInDeferredChargesField;

        private decimal? changeInFederalFundsAndSecuritiesSoldForRepurchaseField;

        private decimal? changeInFundsWithheldField;

        private decimal? changeInIncomeTaxPayableField;

        private decimal? changeInInterestPayableField;

        private decimal? changeInInventoryField;

        private decimal? changeInLoansField;

        private decimal? changeInLossAndLossAdjustmentExpenseReservesField;

        private decimal? changeInOtherCurrentAssetsField;

        private decimal? changeInOtherCurrentLiabilitiesField;

        private decimal? changeInOtherWorkingCapitalField;

        private decimal? changeInPayableField;

        private decimal? changeInPayablesAndAccruedExpenseField;

        private decimal? changeInPremiumsReceivableField;

        private decimal? changeInPrepaidAssetsField;

        private decimal? changeInPrepaidReinsurancePremiumsField;

        private decimal? changeInReceivablesField;

        private decimal? changeInReinsuranceReceivableOnPaidLossesField;

        private decimal? changeInReinsuranceRecoverableOnPaidAndUnpaidLossesField;

        private decimal? changeInReinsuranceRecoverableOnUnpaidLossesField;

        private decimal? changeInRestrictedCashField;

        private decimal? changeInTradingAccountSecuritiesField;

        private decimal? changeInUnearnedPremiumsField;

        private decimal? changeInUnearnedPremiumsCededField;

        private decimal? changeInWorkingCapitalField;

        private decimal? commonStockDividendPaidField;

        private decimal? cumulativeEffectOfAccountingChangeField;

        private decimal? deferredIncomeTaxField;

        private decimal? deferredTaxField;

        private decimal? depletionField;

        private decimal? depreciationField;

        private decimal? depreciationAndAmortizationField;

        private decimal? depreciationAmortizationDepletionField;

        private decimal? earningsLossesFromEquityInvestmentsField;

        private decimal? effectOfExchangeRateChangesField;

        private decimal? excessTaxBenefitFromStockBasedCompensationField;

        private decimal? extraordinaryItemsField;

        private decimal? gainLossOnInvestmentSecuritiesField;

        private decimal? gainLossOnSaleOfBusinessField;

        private decimal? gainLossOnSaleOfPPEField;

        private decimal? increaseDecreaseInDepositField;

        private decimal? interestCreditedOnPolicyholderDepositsField;

        private decimal? netCommonStockIssuanceField;

        private decimal? netIssuancePaymentsOfDebtField;

        private decimal? netLongTermDebtIssuanceField;

        private decimal? netPreferredStockIssuanceField;

        private decimal? netShortTermDebtIssuanceField;

        private decimal? cashFromDiscontinuedOperatingActivitiesField;

        private decimal? netForeignCurrencyExchangeGainLossField;

        private decimal? netIncomeField;

        private decimal? netIncomeFromContinuingOperationsField;

        private decimal? netIncomeFromDiscontinuedOperationsField;

        private decimal? netRealizedInvestmentGainsField;

        private decimal? operatingGainsLossesField;

        private decimal? netOtherFinancingChargesField;

        private decimal? netOtherInvestingChangesField;

        private decimal? otherNonCashItemsField;

        private decimal? paymentForLoansField;

        private decimal? commonStockPaymentsField;

        private decimal? preferredStockPaymentsField;

        private decimal? longTermDebtPaymentsField;

        private decimal? shortTermDebtPaymentsField;

        private decimal? pensionAndEmployeeBenefitExpenseField;

        private decimal? preferredStockDividendPaidField;

        private decimal? proceedsFromIssuanceOfWarrantsField;

        private decimal? proceedsFromLoansField;

        private decimal? proceedsFromStockOptionExercisedField;

        private decimal? commonStockIssuanceField;

        private decimal? longTermDebtIssuanceField;

        private decimal? preferredStockIssuanceField;

        private decimal? shortTermDebtIssuanceField;

        private decimal? proceedsPaymentFederalFundsSoldAndSecuritiesPurchasedUnderAgreementToResellField;

        private decimal? netProceedsPaymentForLoanField;

        private decimal? proceedsPaymentInInterestBearingDepositsInBankField;

        private decimal? provisionForLoanLeaseAndOtherLossesField;

        private decimal? purchaseOfEquitySecuritiesField;

        private decimal? purchaseOfFixedMaturitySecuritiesField;

        private decimal? purchaseOfIntangiblesField;

        private decimal? purchaseOfInvestmentField;

        private decimal? purchaseOfLongTermInvestmentsField;

        private decimal? purchaseOfPPEField;

        private decimal? purchaseOfShortTermInvestmentsField;

        private decimal? purchaseOfTechnologyField;

        private decimal? purchaseOfBusinessField;

        private decimal? netBusinessPurchaseAndSaleField;

        private decimal? netIntangiblesPurchaseAndSaleField;

        private decimal? netInvestmentPurchaseAndSaleField;

        private decimal? netPPEPurchaseAndSaleField;

        private decimal? netTechnologyPurchaseAndSaleField;

        private decimal? realizedGainLossOnSaleOfLoansAndLeaseField;

        private decimal? saleOfBusinessField;

        private decimal? saleOfIntangiblesField;

        private decimal? saleOfInvestmentField;

        private decimal? saleOfLongTermInvestmentsField;

        private decimal? saleOfPPEField;

        private decimal? saleOfShortTermInvestmentsField;

        private decimal? saleOfTechnologyField;

        private decimal? salesOfEquitySecuritiesField;

        private decimal? salesOfFixedMaturitySecuritiesField;

        private decimal? stockBasedCompensationField;

        private decimal? unrealizedGainLossOnInvestmentSecuritiesField;

        private decimal? unrealizedGainsLossesOnDerivativesField;

        private decimal? amortizationOfIntangiblesField;

        private decimal? allowanceForFundsConstructionField;

        private decimal? changesInAccountReceivablesField;

        private decimal? domesticSalesField;

        private decimal? foreignSalesField;

        private decimal? incomeTaxPaidSupplementalDataField;

        private decimal? interestPaidSupplementalDataField;

        private decimal? issuanceOfCapitalStockField;

        private decimal? issuanceOfDebtField;

        private decimal? repaymentOfDebtField;

        private decimal? repurchaseOfCapitalStockField;

        private decimal? freeCashFlowField;

        private decimal? directCashFlowsFromOperatingActivitiesField;

        private string accessionNumberField;

        private string formTypeField;

        private decimal? decreaseinInterestBearingDepositsinBankField;

        private decimal? increaseinInterestBearingDepositsinBankField;

        private decimal? adjustedGeographySegmentDataField;

        private decimal? interestReceivedCFOField;

        private decimal? interestPaidCFOField;

        private decimal? purchaseofSubsidiariesField;

        private decimal? purchaseofJointVentureAssociateField;

        private decimal? saleofSubsidiariesField;

        private decimal? saleofJointVentureAssociateField;

        private decimal? increaseDecreaseinLeaseFinancingField;

        private decimal? increaseinLeaseFinancingField;

        private decimal? repaymentinLeaseFinancingField;

        private decimal? shareofAssociatesField;

        private decimal? profitonDisposalsField;

        private decimal? reorganizationOtherCostsField;

        private decimal? otherFinancingField;

        private decimal? netOutwardLoansField;

        private decimal? issueExpensesField;

        private decimal? changeinCertificatesofDepositsandDebtSecuritiesIssuedField;

        private decimal? paymentstoAcquireHeldToMaturityInvestmentsField;

        private decimal? paymentstoAcquireAvailableForSaleFinancialAssetsField;

        private decimal? paymentstoAcquireFinancialAssetsDesignatedasFairValueField;

        private decimal? proceedsfromDisposalofHeldToMaturityInvestmentsField;

        private decimal? proceedsfromDisposalofAvailableForSaleFinancialAssetsField;

        private decimal? proceedsfromDisposalofFinancialAssetsDesignatedasFairValueField;

        private decimal? changeinFairValueofInvestmentPropertiesField;

        private decimal? changeinDepositsbyBanksandCustomersField;

        private decimal? cashFlowsfromusedinOperatingActivitiesDirectField;

        private decimal? classesofCashReceiptsfromOperatingActivitiesField;

        private decimal? otherCashReceiptsfromOperatingActivitiesField;

        private decimal? classesofCashPaymentsField;

        private decimal? paymentstoSuppliersforGoodsandServicesField;

        private decimal? paymentsfromContractsHeldforDealingorTradingPurposeField;

        private decimal? paymentsonBehalfofEmployeesField;

        private decimal? paymentsforPremiumsandClaimsAnnuitiesandOtherPolicyBenefitsField;

        private decimal? otherCashPaymentsfromOperatingActivitiesField;

        private decimal? dividendsPaidDirectField;

        private decimal? dividendsReceivedDirectField;

        private decimal? interestPaidDirectField;

        private decimal? interestReceivedDirectField;

        private decimal? taxesRefundPaidDirectField;

        private decimal? totalAdjustmentsforNonCashItemsField;

        private decimal? impairmentLossReversalRecognizedinProfitorLossField;

        private decimal? adjustmentsforUndistributedProfitsofAssociatesField;

        private decimal? otherAdjustmentsforWhichCashEffectsAreInvestingorFinancingCashFlowField;

        private decimal? dividendPaidCFOField;

        private decimal? dividendReceivedCFOField;

        private decimal? taxesRefundPaidField;

        private decimal? otherOperatingInflowsOutflowsofCashField;

        private decimal? proceedsfromGovernmentGrantsCFIField;

        private decimal? cashAdvancesandLoansMadetoOtherPartiesField;

        private decimal? cashReceiptsfromRepaymentofAdvancesandLoansMadetoOtherPartiesField;

        private decimal? cashReceiptsfromPaymentsforFinancialDerivativeContractsField;

        private decimal? dividendsReceivedCFIField;

        private decimal? interestReceivedCFIField;

        private decimal? incomeTaxesRefundPaidCFIField;

        private decimal? issuancePaymentofOtherEquityInstrumentsNetField;

        private decimal? paymentsofOtherEquityInstrumentsField;

        private decimal? proceedsfromIssuingOtherEquityInstrumentsField;

        private decimal? proceedsfromGovernmentGrantsCFFField;

        private decimal? interestPaidCFFField;

        private decimal? incomeTaxesRefundPaidCFFField;

        private decimal? changeinAccruedIncomeField;

        private decimal? changeinDeferredIncomeField;

        private decimal? changeinFinancialAssetsField;

        private decimal? changeinAdvancesfromCentralBanksField;

        private decimal? changeinFinancialLiabilitiesField;

        private decimal? changeinInsuranceContractAssetsField;

        private decimal? changeinReinsuranceReceivablesField;

        private decimal? changeinDeferredAcquisitionCostsNetField;

        private decimal? changeinInsuranceFundsField;

        private decimal? changeinReinsurancePayablesField;

        private decimal? changeinInvestmentContractLiabilitiesField;

        private decimal? changeinInsuranceContractLiabilitiesField;

        private decimal? provisionandWriteOffofAssetsField;

        private decimal? receiptsfromCustomersField;

        private decimal? receiptsfromGovernmentGrantsField;

        private decimal? minorityInterestField;

        private decimal? cashDividendsForMinoritiesField;

        private decimal? fundFromOperationField;

        private int fiscalYearChangeField;

        private decimal? netInvestmentPropertiesPurchaseAndSaleField;

        private decimal? purchaseOfInvestmentPropertiesField;

        private decimal? saleOfInvestmentPropertiesField;

        private decimal? otherCashAdjustIncludedIntoChangeinCashField;

        private decimal? otherCashAdjustExcludeFromChangeinCashField;

        private decimal? changeinCashSupplementalAsReportedField;

        private decimal? cashGeneratedfromOperatingActivitiesField;

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
        public DateTime FileDate
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
        public decimal? AmortizationOfFinancingCostsAndDiscounts
        {
            get
            {
                return this.amortizationOfFinancingCostsAndDiscountsField;
            }
            set
            {
                this.amortizationOfFinancingCostsAndDiscountsField = value;
            }
        }

        /// <remarks/>
        public decimal? AmortizationOfSecurities
        {
            get
            {
                return this.amortizationOfSecuritiesField;
            }
            set
            {
                this.amortizationOfSecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? AssetImpairmentCharge
        {
            get
            {
                return this.assetImpairmentChargeField;
            }
            set
            {
                this.assetImpairmentChargeField = value;
            }
        }

        /// <remarks/>
        public decimal? CallsMaturitiesOfMaturitySecurities
        {
            get
            {
                return this.callsMaturitiesOfMaturitySecuritiesField;
            }
            set
            {
                this.callsMaturitiesOfMaturitySecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? CapitalExpenditure
        {
            get
            {
                return this.capitalExpenditureField;
            }
            set
            {
                this.capitalExpenditureField = value;
            }
        }

        /// <remarks/>
        public decimal? NetCapitalExpenditureDisposals
        {
            get
            {
                return this.netCapitalExpenditureDisposalsField;
            }
            set
            {
                this.netCapitalExpenditureDisposalsField = value;
            }
        }

        /// <remarks/>
        public decimal? CapitalExpenditureReported
        {
            get
            {
                return this.capitalExpenditureReportedField;
            }
            set
            {
                this.capitalExpenditureReportedField = value;
            }
        }

        /// <remarks/>
        public decimal? CashDividendsPaid
        {
            get
            {
                return this.cashDividendsPaidField;
            }
            set
            {
                this.cashDividendsPaidField = value;
            }
        }

        /// <remarks/>
        public decimal? CashFlowFromContinuingFinancingActivities
        {
            get
            {
                return this.cashFlowFromContinuingFinancingActivitiesField;
            }
            set
            {
                this.cashFlowFromContinuingFinancingActivitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? CashFlowFromContinuingInvestingActivities
        {
            get
            {
                return this.cashFlowFromContinuingInvestingActivitiesField;
            }
            set
            {
                this.cashFlowFromContinuingInvestingActivitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? CashFlowFromContinuingOperatingActivities
        {
            get
            {
                return this.cashFlowFromContinuingOperatingActivitiesField;
            }
            set
            {
                this.cashFlowFromContinuingOperatingActivitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? CashFlowFromDiscontinuedOperation
        {
            get
            {
                return this.cashFlowFromDiscontinuedOperationField;
            }
            set
            {
                this.cashFlowFromDiscontinuedOperationField = value;
            }
        }

        /// <remarks/>
        public decimal? FinancingCashFlow
        {
            get
            {
                return this.financingCashFlowField;
            }
            set
            {
                this.financingCashFlowField = value;
            }
        }

        /// <remarks/>
        public decimal? InvestingCashFlow
        {
            get
            {
                return this.investingCashFlowField;
            }
            set
            {
                this.investingCashFlowField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingCashFlow
        {
            get
            {
                return this.operatingCashFlowField;
            }
            set
            {
                this.operatingCashFlowField = value;
            }
        }

        /// <remarks/>
        public decimal? BeginningCashPosition
        {
            get
            {
                return this.beginningCashPositionField;
            }
            set
            {
                this.beginningCashPositionField = value;
            }
        }

        /// <remarks/>
        public decimal? EndCashPosition
        {
            get
            {
                return this.endCashPositionField;
            }
            set
            {
                this.endCashPositionField = value;
            }
        }

        /// <remarks/>
        public decimal? CashFromDiscontinuedFinancingActivities
        {
            get
            {
                return this.cashFromDiscontinuedFinancingActivitiesField;
            }
            set
            {
                this.cashFromDiscontinuedFinancingActivitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? CashFromDiscontinuedInvestingActivities
        {
            get
            {
                return this.cashFromDiscontinuedInvestingActivitiesField;
            }
            set
            {
                this.cashFromDiscontinuedInvestingActivitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInAccountPayable
        {
            get
            {
                return this.changeInAccountPayableField;
            }
            set
            {
                this.changeInAccountPayableField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInDividendPayable
        {
            get
            {
                return this.changeInDividendPayableField;
            }
            set
            {
                this.changeInDividendPayableField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInTaxPayable
        {
            get
            {
                return this.changeInTaxPayableField;
            }
            set
            {
                this.changeInTaxPayableField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInAccruedExpense
        {
            get
            {
                return this.changeInAccruedExpenseField;
            }
            set
            {
                this.changeInAccruedExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInAccruedInvestmentIncome
        {
            get
            {
                return this.changeInAccruedInvestmentIncomeField;
            }
            set
            {
                this.changeInAccruedInvestmentIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangesInCash
        {
            get
            {
                return this.changesInCashField;
            }
            set
            {
                this.changesInCashField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInDeferredAcquisitionCosts
        {
            get
            {
                return this.changeInDeferredAcquisitionCostsField;
            }
            set
            {
                this.changeInDeferredAcquisitionCostsField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInDeferredCharges
        {
            get
            {
                return this.changeInDeferredChargesField;
            }
            set
            {
                this.changeInDeferredChargesField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInFederalFundsAndSecuritiesSoldForRepurchase
        {
            get
            {
                return this.changeInFederalFundsAndSecuritiesSoldForRepurchaseField;
            }
            set
            {
                this.changeInFederalFundsAndSecuritiesSoldForRepurchaseField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInFundsWithheld
        {
            get
            {
                return this.changeInFundsWithheldField;
            }
            set
            {
                this.changeInFundsWithheldField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInIncomeTaxPayable
        {
            get
            {
                return this.changeInIncomeTaxPayableField;
            }
            set
            {
                this.changeInIncomeTaxPayableField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInInterestPayable
        {
            get
            {
                return this.changeInInterestPayableField;
            }
            set
            {
                this.changeInInterestPayableField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInInventory
        {
            get
            {
                return this.changeInInventoryField;
            }
            set
            {
                this.changeInInventoryField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInLoans
        {
            get
            {
                return this.changeInLoansField;
            }
            set
            {
                this.changeInLoansField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInLossAndLossAdjustmentExpenseReserves
        {
            get
            {
                return this.changeInLossAndLossAdjustmentExpenseReservesField;
            }
            set
            {
                this.changeInLossAndLossAdjustmentExpenseReservesField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInOtherCurrentAssets
        {
            get
            {
                return this.changeInOtherCurrentAssetsField;
            }
            set
            {
                this.changeInOtherCurrentAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInOtherCurrentLiabilities
        {
            get
            {
                return this.changeInOtherCurrentLiabilitiesField;
            }
            set
            {
                this.changeInOtherCurrentLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInOtherWorkingCapital
        {
            get
            {
                return this.changeInOtherWorkingCapitalField;
            }
            set
            {
                this.changeInOtherWorkingCapitalField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInPayable
        {
            get
            {
                return this.changeInPayableField;
            }
            set
            {
                this.changeInPayableField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInPayablesAndAccruedExpense
        {
            get
            {
                return this.changeInPayablesAndAccruedExpenseField;
            }
            set
            {
                this.changeInPayablesAndAccruedExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInPremiumsReceivable
        {
            get
            {
                return this.changeInPremiumsReceivableField;
            }
            set
            {
                this.changeInPremiumsReceivableField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInPrepaidAssets
        {
            get
            {
                return this.changeInPrepaidAssetsField;
            }
            set
            {
                this.changeInPrepaidAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInPrepaidReinsurancePremiums
        {
            get
            {
                return this.changeInPrepaidReinsurancePremiumsField;
            }
            set
            {
                this.changeInPrepaidReinsurancePremiumsField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInReceivables
        {
            get
            {
                return this.changeInReceivablesField;
            }
            set
            {
                this.changeInReceivablesField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInReinsuranceReceivableOnPaidLosses
        {
            get
            {
                return this.changeInReinsuranceReceivableOnPaidLossesField;
            }
            set
            {
                this.changeInReinsuranceReceivableOnPaidLossesField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInReinsuranceRecoverableOnPaidAndUnpaidLosses
        {
            get
            {
                return this.changeInReinsuranceRecoverableOnPaidAndUnpaidLossesField;
            }
            set
            {
                this.changeInReinsuranceRecoverableOnPaidAndUnpaidLossesField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInReinsuranceRecoverableOnUnpaidLosses
        {
            get
            {
                return this.changeInReinsuranceRecoverableOnUnpaidLossesField;
            }
            set
            {
                this.changeInReinsuranceRecoverableOnUnpaidLossesField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInRestrictedCash
        {
            get
            {
                return this.changeInRestrictedCashField;
            }
            set
            {
                this.changeInRestrictedCashField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInTradingAccountSecurities
        {
            get
            {
                return this.changeInTradingAccountSecuritiesField;
            }
            set
            {
                this.changeInTradingAccountSecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInUnearnedPremiums
        {
            get
            {
                return this.changeInUnearnedPremiumsField;
            }
            set
            {
                this.changeInUnearnedPremiumsField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInUnearnedPremiumsCeded
        {
            get
            {
                return this.changeInUnearnedPremiumsCededField;
            }
            set
            {
                this.changeInUnearnedPremiumsCededField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeInWorkingCapital
        {
            get
            {
                return this.changeInWorkingCapitalField;
            }
            set
            {
                this.changeInWorkingCapitalField = value;
            }
        }

        /// <remarks/>
        public decimal? CommonStockDividendPaid
        {
            get
            {
                return this.commonStockDividendPaidField;
            }
            set
            {
                this.commonStockDividendPaidField = value;
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
        public decimal? DeferredIncomeTax
        {
            get
            {
                return this.deferredIncomeTaxField;
            }
            set
            {
                this.deferredIncomeTaxField = value;
            }
        }

        /// <remarks/>
        public decimal? DeferredTax
        {
            get
            {
                return this.deferredTaxField;
            }
            set
            {
                this.deferredTaxField = value;
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
        public decimal? EarningsLossesFromEquityInvestments
        {
            get
            {
                return this.earningsLossesFromEquityInvestmentsField;
            }
            set
            {
                this.earningsLossesFromEquityInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? EffectOfExchangeRateChanges
        {
            get
            {
                return this.effectOfExchangeRateChangesField;
            }
            set
            {
                this.effectOfExchangeRateChangesField = value;
            }
        }

        /// <remarks/>
        public decimal? ExcessTaxBenefitFromStockBasedCompensation
        {
            get
            {
                return this.excessTaxBenefitFromStockBasedCompensationField;
            }
            set
            {
                this.excessTaxBenefitFromStockBasedCompensationField = value;
            }
        }

        /// <remarks/>
        public decimal? ExtraordinaryItems
        {
            get
            {
                return this.extraordinaryItemsField;
            }
            set
            {
                this.extraordinaryItemsField = value;
            }
        }

        /// <remarks/>
        public decimal? GainLossOnInvestmentSecurities
        {
            get
            {
                return this.gainLossOnInvestmentSecuritiesField;
            }
            set
            {
                this.gainLossOnInvestmentSecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? GainLossOnSaleOfBusiness
        {
            get
            {
                return this.gainLossOnSaleOfBusinessField;
            }
            set
            {
                this.gainLossOnSaleOfBusinessField = value;
            }
        }

        /// <remarks/>
        public decimal? GainLossOnSaleOfPPE
        {
            get
            {
                return this.gainLossOnSaleOfPPEField;
            }
            set
            {
                this.gainLossOnSaleOfPPEField = value;
            }
        }

        /// <remarks/>
        public decimal? IncreaseDecreaseInDeposit
        {
            get
            {
                return this.increaseDecreaseInDepositField;
            }
            set
            {
                this.increaseDecreaseInDepositField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestCreditedOnPolicyholderDeposits
        {
            get
            {
                return this.interestCreditedOnPolicyholderDepositsField;
            }
            set
            {
                this.interestCreditedOnPolicyholderDepositsField = value;
            }
        }

        /// <remarks/>
        public decimal? NetCommonStockIssuance
        {
            get
            {
                return this.netCommonStockIssuanceField;
            }
            set
            {
                this.netCommonStockIssuanceField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIssuancePaymentsOfDebt
        {
            get
            {
                return this.netIssuancePaymentsOfDebtField;
            }
            set
            {
                this.netIssuancePaymentsOfDebtField = value;
            }
        }

        /// <remarks/>
        public decimal? NetLongTermDebtIssuance
        {
            get
            {
                return this.netLongTermDebtIssuanceField;
            }
            set
            {
                this.netLongTermDebtIssuanceField = value;
            }
        }

        /// <remarks/>
        public decimal? NetPreferredStockIssuance
        {
            get
            {
                return this.netPreferredStockIssuanceField;
            }
            set
            {
                this.netPreferredStockIssuanceField = value;
            }
        }

        /// <remarks/>
        public decimal? NetShortTermDebtIssuance
        {
            get
            {
                return this.netShortTermDebtIssuanceField;
            }
            set
            {
                this.netShortTermDebtIssuanceField = value;
            }
        }

        /// <remarks/>
        public decimal? CashFromDiscontinuedOperatingActivities
        {
            get
            {
                return this.cashFromDiscontinuedOperatingActivitiesField;
            }
            set
            {
                this.cashFromDiscontinuedOperatingActivitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? NetForeignCurrencyExchangeGainLoss
        {
            get
            {
                return this.netForeignCurrencyExchangeGainLossField;
            }
            set
            {
                this.netForeignCurrencyExchangeGainLossField = value;
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
        public decimal? NetIncomeFromContinuingOperations
        {
            get
            {
                return this.netIncomeFromContinuingOperationsField;
            }
            set
            {
                this.netIncomeFromContinuingOperationsField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIncomeFromDiscontinuedOperations
        {
            get
            {
                return this.netIncomeFromDiscontinuedOperationsField;
            }
            set
            {
                this.netIncomeFromDiscontinuedOperationsField = value;
            }
        }

        /// <remarks/>
        public decimal? NetRealizedInvestmentGains
        {
            get
            {
                return this.netRealizedInvestmentGainsField;
            }
            set
            {
                this.netRealizedInvestmentGainsField = value;
            }
        }

        /// <remarks/>
        public decimal? OperatingGainsLosses
        {
            get
            {
                return this.operatingGainsLossesField;
            }
            set
            {
                this.operatingGainsLossesField = value;
            }
        }

        /// <remarks/>
        public decimal? NetOtherFinancingCharges
        {
            get
            {
                return this.netOtherFinancingChargesField;
            }
            set
            {
                this.netOtherFinancingChargesField = value;
            }
        }

        /// <remarks/>
        public decimal? NetOtherInvestingChanges
        {
            get
            {
                return this.netOtherInvestingChangesField;
            }
            set
            {
                this.netOtherInvestingChangesField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherNonCashItems
        {
            get
            {
                return this.otherNonCashItemsField;
            }
            set
            {
                this.otherNonCashItemsField = value;
            }
        }

        /// <remarks/>
        public decimal? PaymentForLoans
        {
            get
            {
                return this.paymentForLoansField;
            }
            set
            {
                this.paymentForLoansField = value;
            }
        }

        /// <remarks/>
        public decimal? CommonStockPayments
        {
            get
            {
                return this.commonStockPaymentsField;
            }
            set
            {
                this.commonStockPaymentsField = value;
            }
        }

        /// <remarks/>
        public decimal? PreferredStockPayments
        {
            get
            {
                return this.preferredStockPaymentsField;
            }
            set
            {
                this.preferredStockPaymentsField = value;
            }
        }

        /// <remarks/>
        public decimal? LongTermDebtPayments
        {
            get
            {
                return this.longTermDebtPaymentsField;
            }
            set
            {
                this.longTermDebtPaymentsField = value;
            }
        }

        /// <remarks/>
        public decimal? ShortTermDebtPayments
        {
            get
            {
                return this.shortTermDebtPaymentsField;
            }
            set
            {
                this.shortTermDebtPaymentsField = value;
            }
        }

        /// <remarks/>
        public decimal? PensionAndEmployeeBenefitExpense
        {
            get
            {
                return this.pensionAndEmployeeBenefitExpenseField;
            }
            set
            {
                this.pensionAndEmployeeBenefitExpenseField = value;
            }
        }

        /// <remarks/>
        public decimal? PreferredStockDividendPaid
        {
            get
            {
                return this.preferredStockDividendPaidField;
            }
            set
            {
                this.preferredStockDividendPaidField = value;
            }
        }

        /// <remarks/>
        public decimal? ProceedsFromIssuanceOfWarrants
        {
            get
            {
                return this.proceedsFromIssuanceOfWarrantsField;
            }
            set
            {
                this.proceedsFromIssuanceOfWarrantsField = value;
            }
        }

        /// <remarks/>
        public decimal? ProceedsFromLoans
        {
            get
            {
                return this.proceedsFromLoansField;
            }
            set
            {
                this.proceedsFromLoansField = value;
            }
        }

        /// <remarks/>
        public decimal? ProceedsFromStockOptionExercised
        {
            get
            {
                return this.proceedsFromStockOptionExercisedField;
            }
            set
            {
                this.proceedsFromStockOptionExercisedField = value;
            }
        }

        /// <remarks/>
        public decimal? CommonStockIssuance
        {
            get
            {
                return this.commonStockIssuanceField;
            }
            set
            {
                this.commonStockIssuanceField = value;
            }
        }

        /// <remarks/>
        public decimal? LongTermDebtIssuance
        {
            get
            {
                return this.longTermDebtIssuanceField;
            }
            set
            {
                this.longTermDebtIssuanceField = value;
            }
        }

        /// <remarks/>
        public decimal? PreferredStockIssuance
        {
            get
            {
                return this.preferredStockIssuanceField;
            }
            set
            {
                this.preferredStockIssuanceField = value;
            }
        }

        /// <remarks/>
        public decimal? ShortTermDebtIssuance
        {
            get
            {
                return this.shortTermDebtIssuanceField;
            }
            set
            {
                this.shortTermDebtIssuanceField = value;
            }
        }

        /// <remarks/>
        public decimal? ProceedsPaymentFederalFundsSoldAndSecuritiesPurchasedUnderAgreementToResell
        {
            get
            {
                return this.proceedsPaymentFederalFundsSoldAndSecuritiesPurchasedUnderAgreementToResellField;
            }
            set
            {
                this.proceedsPaymentFederalFundsSoldAndSecuritiesPurchasedUnderAgreementToResellField = value;
            }
        }

        /// <remarks/>
        public decimal? NetProceedsPaymentForLoan
        {
            get
            {
                return this.netProceedsPaymentForLoanField;
            }
            set
            {
                this.netProceedsPaymentForLoanField = value;
            }
        }

        /// <remarks/>
        public decimal? ProceedsPaymentInInterestBearingDepositsInBank
        {
            get
            {
                return this.proceedsPaymentInInterestBearingDepositsInBankField;
            }
            set
            {
                this.proceedsPaymentInInterestBearingDepositsInBankField = value;
            }
        }

        /// <remarks/>
        public decimal? ProvisionForLoanLeaseAndOtherLosses
        {
            get
            {
                return this.provisionForLoanLeaseAndOtherLossesField;
            }
            set
            {
                this.provisionForLoanLeaseAndOtherLossesField = value;
            }
        }

        /// <remarks/>
        public decimal? PurchaseOfEquitySecurities
        {
            get
            {
                return this.purchaseOfEquitySecuritiesField;
            }
            set
            {
                this.purchaseOfEquitySecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? PurchaseOfFixedMaturitySecurities
        {
            get
            {
                return this.purchaseOfFixedMaturitySecuritiesField;
            }
            set
            {
                this.purchaseOfFixedMaturitySecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? PurchaseOfIntangibles
        {
            get
            {
                return this.purchaseOfIntangiblesField;
            }
            set
            {
                this.purchaseOfIntangiblesField = value;
            }
        }

        /// <remarks/>
        public decimal? PurchaseOfInvestment
        {
            get
            {
                return this.purchaseOfInvestmentField;
            }
            set
            {
                this.purchaseOfInvestmentField = value;
            }
        }

        /// <remarks/>
        public decimal? PurchaseOfLongTermInvestments
        {
            get
            {
                return this.purchaseOfLongTermInvestmentsField;
            }
            set
            {
                this.purchaseOfLongTermInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? PurchaseOfPPE
        {
            get
            {
                return this.purchaseOfPPEField;
            }
            set
            {
                this.purchaseOfPPEField = value;
            }
        }

        /// <remarks/>
        public decimal? PurchaseOfShortTermInvestments
        {
            get
            {
                return this.purchaseOfShortTermInvestmentsField;
            }
            set
            {
                this.purchaseOfShortTermInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? PurchaseOfTechnology
        {
            get
            {
                return this.purchaseOfTechnologyField;
            }
            set
            {
                this.purchaseOfTechnologyField = value;
            }
        }

        /// <remarks/>
        public decimal? PurchaseOfBusiness
        {
            get
            {
                return this.purchaseOfBusinessField;
            }
            set
            {
                this.purchaseOfBusinessField = value;
            }
        }

        /// <remarks/>
        public decimal? NetBusinessPurchaseAndSale
        {
            get
            {
                return this.netBusinessPurchaseAndSaleField;
            }
            set
            {
                this.netBusinessPurchaseAndSaleField = value;
            }
        }

        /// <remarks/>
        public decimal? NetIntangiblesPurchaseAndSale
        {
            get
            {
                return this.netIntangiblesPurchaseAndSaleField;
            }
            set
            {
                this.netIntangiblesPurchaseAndSaleField = value;
            }
        }

        /// <remarks/>
        public decimal? NetInvestmentPurchaseAndSale
        {
            get
            {
                return this.netInvestmentPurchaseAndSaleField;
            }
            set
            {
                this.netInvestmentPurchaseAndSaleField = value;
            }
        }

        /// <remarks/>
        public decimal? NetPPEPurchaseAndSale
        {
            get
            {
                return this.netPPEPurchaseAndSaleField;
            }
            set
            {
                this.netPPEPurchaseAndSaleField = value;
            }
        }

        /// <remarks/>
        public decimal? NetTechnologyPurchaseAndSale
        {
            get
            {
                return this.netTechnologyPurchaseAndSaleField;
            }
            set
            {
                this.netTechnologyPurchaseAndSaleField = value;
            }
        }

        /// <remarks/>
        public decimal? RealizedGainLossOnSaleOfLoansAndLease
        {
            get
            {
                return this.realizedGainLossOnSaleOfLoansAndLeaseField;
            }
            set
            {
                this.realizedGainLossOnSaleOfLoansAndLeaseField = value;
            }
        }

        /// <remarks/>
        public decimal? SaleOfBusiness
        {
            get
            {
                return this.saleOfBusinessField;
            }
            set
            {
                this.saleOfBusinessField = value;
            }
        }

        /// <remarks/>
        public decimal? SaleOfIntangibles
        {
            get
            {
                return this.saleOfIntangiblesField;
            }
            set
            {
                this.saleOfIntangiblesField = value;
            }
        }

        /// <remarks/>
        public decimal? SaleOfInvestment
        {
            get
            {
                return this.saleOfInvestmentField;
            }
            set
            {
                this.saleOfInvestmentField = value;
            }
        }

        /// <remarks/>
        public decimal? SaleOfLongTermInvestments
        {
            get
            {
                return this.saleOfLongTermInvestmentsField;
            }
            set
            {
                this.saleOfLongTermInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? SaleOfPPE
        {
            get
            {
                return this.saleOfPPEField;
            }
            set
            {
                this.saleOfPPEField = value;
            }
        }

        /// <remarks/>
        public decimal? SaleOfShortTermInvestments
        {
            get
            {
                return this.saleOfShortTermInvestmentsField;
            }
            set
            {
                this.saleOfShortTermInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? SaleOfTechnology
        {
            get
            {
                return this.saleOfTechnologyField;
            }
            set
            {
                this.saleOfTechnologyField = value;
            }
        }

        /// <remarks/>
        public decimal? SalesOfEquitySecurities
        {
            get
            {
                return this.salesOfEquitySecuritiesField;
            }
            set
            {
                this.salesOfEquitySecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? SalesOfFixedMaturitySecurities
        {
            get
            {
                return this.salesOfFixedMaturitySecuritiesField;
            }
            set
            {
                this.salesOfFixedMaturitySecuritiesField = value;
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
        public decimal? UnrealizedGainLossOnInvestmentSecurities
        {
            get
            {
                return this.unrealizedGainLossOnInvestmentSecuritiesField;
            }
            set
            {
                this.unrealizedGainLossOnInvestmentSecuritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? UnrealizedGainsLossesOnDerivatives
        {
            get
            {
                return this.unrealizedGainsLossesOnDerivativesField;
            }
            set
            {
                this.unrealizedGainsLossesOnDerivativesField = value;
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
        public decimal? AllowanceForFundsConstruction
        {
            get
            {
                return this.allowanceForFundsConstructionField;
            }
            set
            {
                this.allowanceForFundsConstructionField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangesInAccountReceivables
        {
            get
            {
                return this.changesInAccountReceivablesField;
            }
            set
            {
                this.changesInAccountReceivablesField = value;
            }
        }

        /// <remarks/>
        public decimal? DomesticSales
        {
            get
            {
                return this.domesticSalesField;
            }
            set
            {
                this.domesticSalesField = value;
            }
        }

        /// <remarks/>
        public decimal? ForeignSales
        {
            get
            {
                return this.foreignSalesField;
            }
            set
            {
                this.foreignSalesField = value;
            }
        }

        /// <remarks/>
        public decimal? IncomeTaxPaidSupplementalData
        {
            get
            {
                return this.incomeTaxPaidSupplementalDataField;
            }
            set
            {
                this.incomeTaxPaidSupplementalDataField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestPaidSupplementalData
        {
            get
            {
                return this.interestPaidSupplementalDataField;
            }
            set
            {
                this.interestPaidSupplementalDataField = value;
            }
        }

        /// <remarks/>
        public decimal? IssuanceOfCapitalStock
        {
            get
            {
                return this.issuanceOfCapitalStockField;
            }
            set
            {
                this.issuanceOfCapitalStockField = value;
            }
        }

        /// <remarks/>
        public decimal? IssuanceOfDebt
        {
            get
            {
                return this.issuanceOfDebtField;
            }
            set
            {
                this.issuanceOfDebtField = value;
            }
        }

        /// <remarks/>
        public decimal? RepaymentOfDebt
        {
            get
            {
                return this.repaymentOfDebtField;
            }
            set
            {
                this.repaymentOfDebtField = value;
            }
        }

        /// <remarks/>
        public decimal? RepurchaseOfCapitalStock
        {
            get
            {
                return this.repurchaseOfCapitalStockField;
            }
            set
            {
                this.repurchaseOfCapitalStockField = value;
            }
        }

        /// <remarks/>
        public decimal? FreeCashFlow
        {
            get
            {
                return this.freeCashFlowField;
            }
            set
            {
                this.freeCashFlowField = value;
            }
        }

        /// <remarks/>
        public decimal? DirectCashFlowsFromOperatingActivities
        {
            get
            {
                return this.directCashFlowsFromOperatingActivitiesField;
            }
            set
            {
                this.directCashFlowsFromOperatingActivitiesField = value;
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
        public decimal? DecreaseinInterestBearingDepositsinBank
        {
            get
            {
                return this.decreaseinInterestBearingDepositsinBankField;
            }
            set
            {
                this.decreaseinInterestBearingDepositsinBankField = value;
            }
        }

        /// <remarks/>
        public decimal? IncreaseinInterestBearingDepositsinBank
        {
            get
            {
                return this.increaseinInterestBearingDepositsinBankField;
            }
            set
            {
                this.increaseinInterestBearingDepositsinBankField = value;
            }
        }

        /// <remarks/>
        public decimal? AdjustedGeographySegmentData
        {
            get
            {
                return this.adjustedGeographySegmentDataField;
            }
            set
            {
                this.adjustedGeographySegmentDataField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestReceivedCFO
        {
            get
            {
                return this.interestReceivedCFOField;
            }
            set
            {
                this.interestReceivedCFOField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestPaidCFO
        {
            get
            {
                return this.interestPaidCFOField;
            }
            set
            {
                this.interestPaidCFOField = value;
            }
        }

        /// <remarks/>
        public decimal? PurchaseofSubsidiaries
        {
            get
            {
                return this.purchaseofSubsidiariesField;
            }
            set
            {
                this.purchaseofSubsidiariesField = value;
            }
        }

        /// <remarks/>
        public decimal? PurchaseofJointVentureAssociate
        {
            get
            {
                return this.purchaseofJointVentureAssociateField;
            }
            set
            {
                this.purchaseofJointVentureAssociateField = value;
            }
        }

        /// <remarks/>
        public decimal? SaleofSubsidiaries
        {
            get
            {
                return this.saleofSubsidiariesField;
            }
            set
            {
                this.saleofSubsidiariesField = value;
            }
        }

        /// <remarks/>
        public decimal? SaleofJointVentureAssociate
        {
            get
            {
                return this.saleofJointVentureAssociateField;
            }
            set
            {
                this.saleofJointVentureAssociateField = value;
            }
        }

        /// <remarks/>
        public decimal? IncreaseDecreaseinLeaseFinancing
        {
            get
            {
                return this.increaseDecreaseinLeaseFinancingField;
            }
            set
            {
                this.increaseDecreaseinLeaseFinancingField = value;
            }
        }

        /// <remarks/>
        public decimal? IncreaseinLeaseFinancing
        {
            get
            {
                return this.increaseinLeaseFinancingField;
            }
            set
            {
                this.increaseinLeaseFinancingField = value;
            }
        }

        /// <remarks/>
        public decimal? RepaymentinLeaseFinancing
        {
            get
            {
                return this.repaymentinLeaseFinancingField;
            }
            set
            {
                this.repaymentinLeaseFinancingField = value;
            }
        }

        /// <remarks/>
        public decimal? ShareofAssociates
        {
            get
            {
                return this.shareofAssociatesField;
            }
            set
            {
                this.shareofAssociatesField = value;
            }
        }

        /// <remarks/>
        public decimal? ProfitonDisposals
        {
            get
            {
                return this.profitonDisposalsField;
            }
            set
            {
                this.profitonDisposalsField = value;
            }
        }

        /// <remarks/>
        public decimal? ReorganizationOtherCosts
        {
            get
            {
                return this.reorganizationOtherCostsField;
            }
            set
            {
                this.reorganizationOtherCostsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherFinancing
        {
            get
            {
                return this.otherFinancingField;
            }
            set
            {
                this.otherFinancingField = value;
            }
        }

        /// <remarks/>
        public decimal? NetOutwardLoans
        {
            get
            {
                return this.netOutwardLoansField;
            }
            set
            {
                this.netOutwardLoansField = value;
            }
        }

        /// <remarks/>
        public decimal? IssueExpenses
        {
            get
            {
                return this.issueExpensesField;
            }
            set
            {
                this.issueExpensesField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinCertificatesofDepositsandDebtSecuritiesIssued
        {
            get
            {
                return this.changeinCertificatesofDepositsandDebtSecuritiesIssuedField;
            }
            set
            {
                this.changeinCertificatesofDepositsandDebtSecuritiesIssuedField = value;
            }
        }

        /// <remarks/>
        public decimal? PaymentstoAcquireHeldToMaturityInvestments
        {
            get
            {
                return this.paymentstoAcquireHeldToMaturityInvestmentsField;
            }
            set
            {
                this.paymentstoAcquireHeldToMaturityInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? PaymentstoAcquireAvailableForSaleFinancialAssets
        {
            get
            {
                return this.paymentstoAcquireAvailableForSaleFinancialAssetsField;
            }
            set
            {
                this.paymentstoAcquireAvailableForSaleFinancialAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? PaymentstoAcquireFinancialAssetsDesignatedasFairValue
        {
            get
            {
                return this.paymentstoAcquireFinancialAssetsDesignatedasFairValueField;
            }
            set
            {
                this.paymentstoAcquireFinancialAssetsDesignatedasFairValueField = value;
            }
        }

        /// <remarks/>
        public decimal? ProceedsfromDisposalofHeldToMaturityInvestments
        {
            get
            {
                return this.proceedsfromDisposalofHeldToMaturityInvestmentsField;
            }
            set
            {
                this.proceedsfromDisposalofHeldToMaturityInvestmentsField = value;
            }
        }

        /// <remarks/>
        public decimal? ProceedsfromDisposalofAvailableForSaleFinancialAssets
        {
            get
            {
                return this.proceedsfromDisposalofAvailableForSaleFinancialAssetsField;
            }
            set
            {
                this.proceedsfromDisposalofAvailableForSaleFinancialAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? ProceedsfromDisposalofFinancialAssetsDesignatedasFairValue
        {
            get
            {
                return this.proceedsfromDisposalofFinancialAssetsDesignatedasFairValueField;
            }
            set
            {
                this.proceedsfromDisposalofFinancialAssetsDesignatedasFairValueField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinFairValueofInvestmentProperties
        {
            get
            {
                return this.changeinFairValueofInvestmentPropertiesField;
            }
            set
            {
                this.changeinFairValueofInvestmentPropertiesField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinDepositsbyBanksandCustomers
        {
            get
            {
                return this.changeinDepositsbyBanksandCustomersField;
            }
            set
            {
                this.changeinDepositsbyBanksandCustomersField = value;
            }
        }

        /// <remarks/>
        public decimal? CashFlowsfromusedinOperatingActivitiesDirect
        {
            get
            {
                return this.cashFlowsfromusedinOperatingActivitiesDirectField;
            }
            set
            {
                this.cashFlowsfromusedinOperatingActivitiesDirectField = value;
            }
        }

        /// <remarks/>
        public decimal? ClassesofCashReceiptsfromOperatingActivities
        {
            get
            {
                return this.classesofCashReceiptsfromOperatingActivitiesField;
            }
            set
            {
                this.classesofCashReceiptsfromOperatingActivitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherCashReceiptsfromOperatingActivities
        {
            get
            {
                return this.otherCashReceiptsfromOperatingActivitiesField;
            }
            set
            {
                this.otherCashReceiptsfromOperatingActivitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? ClassesofCashPayments
        {
            get
            {
                return this.classesofCashPaymentsField;
            }
            set
            {
                this.classesofCashPaymentsField = value;
            }
        }

        /// <remarks/>
        public decimal? PaymentstoSuppliersforGoodsandServices
        {
            get
            {
                return this.paymentstoSuppliersforGoodsandServicesField;
            }
            set
            {
                this.paymentstoSuppliersforGoodsandServicesField = value;
            }
        }

        /// <remarks/>
        public decimal? PaymentsfromContractsHeldforDealingorTradingPurpose
        {
            get
            {
                return this.paymentsfromContractsHeldforDealingorTradingPurposeField;
            }
            set
            {
                this.paymentsfromContractsHeldforDealingorTradingPurposeField = value;
            }
        }

        /// <remarks/>
        public decimal? PaymentsonBehalfofEmployees
        {
            get
            {
                return this.paymentsonBehalfofEmployeesField;
            }
            set
            {
                this.paymentsonBehalfofEmployeesField = value;
            }
        }

        /// <remarks/>
        public decimal? PaymentsforPremiumsandClaimsAnnuitiesandOtherPolicyBenefits
        {
            get
            {
                return this.paymentsforPremiumsandClaimsAnnuitiesandOtherPolicyBenefitsField;
            }
            set
            {
                this.paymentsforPremiumsandClaimsAnnuitiesandOtherPolicyBenefitsField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherCashPaymentsfromOperatingActivities
        {
            get
            {
                return this.otherCashPaymentsfromOperatingActivitiesField;
            }
            set
            {
                this.otherCashPaymentsfromOperatingActivitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? DividendsPaidDirect
        {
            get
            {
                return this.dividendsPaidDirectField;
            }
            set
            {
                this.dividendsPaidDirectField = value;
            }
        }

        /// <remarks/>
        public decimal? DividendsReceivedDirect
        {
            get
            {
                return this.dividendsReceivedDirectField;
            }
            set
            {
                this.dividendsReceivedDirectField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestPaidDirect
        {
            get
            {
                return this.interestPaidDirectField;
            }
            set
            {
                this.interestPaidDirectField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestReceivedDirect
        {
            get
            {
                return this.interestReceivedDirectField;
            }
            set
            {
                this.interestReceivedDirectField = value;
            }
        }

        /// <remarks/>
        public decimal? TaxesRefundPaidDirect
        {
            get
            {
                return this.taxesRefundPaidDirectField;
            }
            set
            {
                this.taxesRefundPaidDirectField = value;
            }
        }

        /// <remarks/>
        public decimal? TotalAdjustmentsforNonCashItems
        {
            get
            {
                return this.totalAdjustmentsforNonCashItemsField;
            }
            set
            {
                this.totalAdjustmentsforNonCashItemsField = value;
            }
        }

        /// <remarks/>
        public decimal? ImpairmentLossReversalRecognizedinProfitorLoss
        {
            get
            {
                return this.impairmentLossReversalRecognizedinProfitorLossField;
            }
            set
            {
                this.impairmentLossReversalRecognizedinProfitorLossField = value;
            }
        }

        /// <remarks/>
        public decimal? AdjustmentsforUndistributedProfitsofAssociates
        {
            get
            {
                return this.adjustmentsforUndistributedProfitsofAssociatesField;
            }
            set
            {
                this.adjustmentsforUndistributedProfitsofAssociatesField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherAdjustmentsforWhichCashEffectsAreInvestingorFinancingCashFlow
        {
            get
            {
                return this.otherAdjustmentsforWhichCashEffectsAreInvestingorFinancingCashFlowField;
            }
            set
            {
                this.otherAdjustmentsforWhichCashEffectsAreInvestingorFinancingCashFlowField = value;
            }
        }

        /// <remarks/>
        public decimal? DividendPaidCFO
        {
            get
            {
                return this.dividendPaidCFOField;
            }
            set
            {
                this.dividendPaidCFOField = value;
            }
        }

        /// <remarks/>
        public decimal? DividendReceivedCFO
        {
            get
            {
                return this.dividendReceivedCFOField;
            }
            set
            {
                this.dividendReceivedCFOField = value;
            }
        }

        /// <remarks/>
        public decimal? TaxesRefundPaid
        {
            get
            {
                return this.taxesRefundPaidField;
            }
            set
            {
                this.taxesRefundPaidField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherOperatingInflowsOutflowsofCash
        {
            get
            {
                return this.otherOperatingInflowsOutflowsofCashField;
            }
            set
            {
                this.otherOperatingInflowsOutflowsofCashField = value;
            }
        }

        /// <remarks/>
        public decimal? ProceedsfromGovernmentGrantsCFI
        {
            get
            {
                return this.proceedsfromGovernmentGrantsCFIField;
            }
            set
            {
                this.proceedsfromGovernmentGrantsCFIField = value;
            }
        }

        /// <remarks/>
        public decimal? CashAdvancesandLoansMadetoOtherParties
        {
            get
            {
                return this.cashAdvancesandLoansMadetoOtherPartiesField;
            }
            set
            {
                this.cashAdvancesandLoansMadetoOtherPartiesField = value;
            }
        }

        /// <remarks/>
        public decimal? CashReceiptsfromRepaymentofAdvancesandLoansMadetoOtherParties
        {
            get
            {
                return this.cashReceiptsfromRepaymentofAdvancesandLoansMadetoOtherPartiesField;
            }
            set
            {
                this.cashReceiptsfromRepaymentofAdvancesandLoansMadetoOtherPartiesField = value;
            }
        }

        /// <remarks/>
        public decimal? CashReceiptsfromPaymentsforFinancialDerivativeContracts
        {
            get
            {
                return this.cashReceiptsfromPaymentsforFinancialDerivativeContractsField;
            }
            set
            {
                this.cashReceiptsfromPaymentsforFinancialDerivativeContractsField = value;
            }
        }

        /// <remarks/>
        public decimal? DividendsReceivedCFI
        {
            get
            {
                return this.dividendsReceivedCFIField;
            }
            set
            {
                this.dividendsReceivedCFIField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestReceivedCFI
        {
            get
            {
                return this.interestReceivedCFIField;
            }
            set
            {
                this.interestReceivedCFIField = value;
            }
        }

        /// <remarks/>
        public decimal? IncomeTaxesRefundPaidCFI
        {
            get
            {
                return this.incomeTaxesRefundPaidCFIField;
            }
            set
            {
                this.incomeTaxesRefundPaidCFIField = value;
            }
        }

        /// <remarks/>
        public decimal? IssuancePaymentofOtherEquityInstrumentsNet
        {
            get
            {
                return this.issuancePaymentofOtherEquityInstrumentsNetField;
            }
            set
            {
                this.issuancePaymentofOtherEquityInstrumentsNetField = value;
            }
        }

        /// <remarks/>
        public decimal? PaymentsofOtherEquityInstruments
        {
            get
            {
                return this.paymentsofOtherEquityInstrumentsField;
            }
            set
            {
                this.paymentsofOtherEquityInstrumentsField = value;
            }
        }

        /// <remarks/>
        public decimal? ProceedsfromIssuingOtherEquityInstruments
        {
            get
            {
                return this.proceedsfromIssuingOtherEquityInstrumentsField;
            }
            set
            {
                this.proceedsfromIssuingOtherEquityInstrumentsField = value;
            }
        }

        /// <remarks/>
        public decimal? ProceedsfromGovernmentGrantsCFF
        {
            get
            {
                return this.proceedsfromGovernmentGrantsCFFField;
            }
            set
            {
                this.proceedsfromGovernmentGrantsCFFField = value;
            }
        }

        /// <remarks/>
        public decimal? InterestPaidCFF
        {
            get
            {
                return this.interestPaidCFFField;
            }
            set
            {
                this.interestPaidCFFField = value;
            }
        }

        /// <remarks/>
        public decimal? IncomeTaxesRefundPaidCFF
        {
            get
            {
                return this.incomeTaxesRefundPaidCFFField;
            }
            set
            {
                this.incomeTaxesRefundPaidCFFField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinAccruedIncome
        {
            get
            {
                return this.changeinAccruedIncomeField;
            }
            set
            {
                this.changeinAccruedIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinDeferredIncome
        {
            get
            {
                return this.changeinDeferredIncomeField;
            }
            set
            {
                this.changeinDeferredIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinFinancialAssets
        {
            get
            {
                return this.changeinFinancialAssetsField;
            }
            set
            {
                this.changeinFinancialAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinAdvancesfromCentralBanks
        {
            get
            {
                return this.changeinAdvancesfromCentralBanksField;
            }
            set
            {
                this.changeinAdvancesfromCentralBanksField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinFinancialLiabilities
        {
            get
            {
                return this.changeinFinancialLiabilitiesField;
            }
            set
            {
                this.changeinFinancialLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinInsuranceContractAssets
        {
            get
            {
                return this.changeinInsuranceContractAssetsField;
            }
            set
            {
                this.changeinInsuranceContractAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinReinsuranceReceivables
        {
            get
            {
                return this.changeinReinsuranceReceivablesField;
            }
            set
            {
                this.changeinReinsuranceReceivablesField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinDeferredAcquisitionCostsNet
        {
            get
            {
                return this.changeinDeferredAcquisitionCostsNetField;
            }
            set
            {
                this.changeinDeferredAcquisitionCostsNetField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinInsuranceFunds
        {
            get
            {
                return this.changeinInsuranceFundsField;
            }
            set
            {
                this.changeinInsuranceFundsField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinReinsurancePayables
        {
            get
            {
                return this.changeinReinsurancePayablesField;
            }
            set
            {
                this.changeinReinsurancePayablesField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinInvestmentContractLiabilities
        {
            get
            {
                return this.changeinInvestmentContractLiabilitiesField;
            }
            set
            {
                this.changeinInvestmentContractLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinInsuranceContractLiabilities
        {
            get
            {
                return this.changeinInsuranceContractLiabilitiesField;
            }
            set
            {
                this.changeinInsuranceContractLiabilitiesField = value;
            }
        }

        /// <remarks/>
        public decimal? ProvisionandWriteOffofAssets
        {
            get
            {
                return this.provisionandWriteOffofAssetsField;
            }
            set
            {
                this.provisionandWriteOffofAssetsField = value;
            }
        }

        /// <remarks/>
        public decimal? ReceiptsfromCustomers
        {
            get
            {
                return this.receiptsfromCustomersField;
            }
            set
            {
                this.receiptsfromCustomersField = value;
            }
        }

        /// <remarks/>
        public decimal? ReceiptsfromGovernmentGrants
        {
            get
            {
                return this.receiptsfromGovernmentGrantsField;
            }
            set
            {
                this.receiptsfromGovernmentGrantsField = value;
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
        public decimal? CashDividendsForMinorities
        {
            get
            {
                return this.cashDividendsForMinoritiesField;
            }
            set
            {
                this.cashDividendsForMinoritiesField = value;
            }
        }

        /// <remarks/>
        public decimal? FundFromOperation
        {
            get
            {
                return this.fundFromOperationField;
            }
            set
            {
                this.fundFromOperationField = value;
            }
        }

        /// <remarks/>
        public int FiscalYearChange
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
        public decimal? NetInvestmentPropertiesPurchaseAndSale
        {
            get
            {
                return this.netInvestmentPropertiesPurchaseAndSaleField;
            }
            set
            {
                this.netInvestmentPropertiesPurchaseAndSaleField = value;
            }
        }

        /// <remarks/>
        public decimal? PurchaseOfInvestmentProperties
        {
            get
            {
                return this.purchaseOfInvestmentPropertiesField;
            }
            set
            {
                this.purchaseOfInvestmentPropertiesField = value;
            }
        }

        /// <remarks/>
        public decimal? SaleOfInvestmentProperties
        {
            get
            {
                return this.saleOfInvestmentPropertiesField;
            }
            set
            {
                this.saleOfInvestmentPropertiesField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherCashAdjustIncludedIntoChangeinCash
        {
            get
            {
                return this.otherCashAdjustIncludedIntoChangeinCashField;
            }
            set
            {
                this.otherCashAdjustIncludedIntoChangeinCashField = value;
            }
        }

        /// <remarks/>
        public decimal? OtherCashAdjustExcludeFromChangeinCash
        {
            get
            {
                return this.otherCashAdjustExcludeFromChangeinCashField;
            }
            set
            {
                this.otherCashAdjustExcludeFromChangeinCashField = value;
            }
        }

        /// <remarks/>
        public decimal? ChangeinCashSupplementalAsReported
        {
            get
            {
                return this.changeinCashSupplementalAsReportedField;
            }
            set
            {
                this.changeinCashSupplementalAsReportedField = value;
            }
        }

        /// <remarks/>
        public decimal? CashGeneratedfromOperatingActivities
        {
            get
            {
                return this.cashGeneratedfromOperatingActivitiesField;
            }
            set
            {
                this.cashGeneratedfromOperatingActivitiesField = value;
            }
        }
    }
}
