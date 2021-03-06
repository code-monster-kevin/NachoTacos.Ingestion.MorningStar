﻿
/****** Object:  StoredProcedure [dbo].[MergeCashFlowTTM]    Script Date: 1/10/2020 3:17:45 PM ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'MergeCashFlowTTM')
DROP PROCEDURE [dbo].[MergeCashFlowTTM]
GO

/****** Object:  StoredProcedure [dbo].[MergeCashFlowTTM]    Script Date: 1/10/2020 3:17:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Kevin Wu
-- Create date: 10th Jan 2020
-- Description:	Merge data from temporary job table [MStar].[MergeCashFlowTTM]
--				to master table [MStar].[MergeCashFlowTTM]
-- Example: EXECUTE MergeCashFlowTTM
-- Changes: 10th Jan 2020
--          To prevent timeout due to exceessive records of changes to merge,
--          added a limit of merging only the last 50 ingestion task,
--          Will require a recurring job to run this merge function to check of unprocessed tasks
-- =============================================
CREATE PROCEDURE [dbo].[MergeCashFlowTTM]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SET NOCOUNT ON;

    DECLARE @SummaryOfChanges TABLE(Change VARCHAR(20));
	DECLARE @UnprocessedTasks TABLE (id uniqueidentifier, CreatedDate DateTime);

	INSERT INTO @UnprocessedTasks
	SELECT DISTINCT TOP 50 IT.[IngestionTaskId], IT.[CreatedDate]
	FROM [MStar].[TCashFlowTTM] CF
	JOIN [dbo].[IngestionTasks] IT ON IT.[IngestionTaskId] = CF.[IngestionTaskId]
	WHERE IT.[IsProcessed] = 0;

	MERGE INTO [MStar].[MCashFlowTTM] AS TargetTable
	USING
	(SELECT GI.[ExchangeId]
      ,GI.[CompanyName]
      ,GI.[Symbol]
      ,GI.[CUSIP]
      ,GI.[CIK]
      ,GI.[ISIN]
      ,GI.[SEDOL]
      ,GI.[ShareClassId]
	  ,CF.[ReportDate]
      ,CF.[PeriodEndingDate]
      ,CF.[FileDate]
      ,CF.[StatementType]
      ,CF.[DataType]
      ,CF.[Interim]
      ,CF.[CurrencyId]
      ,CF.[FiscalYearEnd]
      ,CF.[Amortization]
      ,CF.[AmortizationOfFinancingCostsAndDiscounts]
      ,CF.[AmortizationOfSecurities]
      ,CF.[AssetImpairmentCharge]
      ,CF.[CallsMaturitiesOfMaturitySecurities]
      ,CF.[CapitalExpenditure]
      ,CF.[NetCapitalExpenditureDisposals]
      ,CF.[CapitalExpenditureReported]
      ,CF.[CashDividendsPaid]
      ,CF.[CashFlowFromContinuingFinancingActivities]
      ,CF.[CashFlowFromContinuingInvestingActivities]
      ,CF.[CashFlowFromContinuingOperatingActivities]
      ,CF.[CashFlowFromDiscontinuedOperation]
      ,CF.[FinancingCashFlow]
      ,CF.[InvestingCashFlow]
      ,CF.[OperatingCashFlow]
      ,CF.[BeginningCashPosition]
      ,CF.[EndCashPosition]
      ,CF.[CashFromDiscontinuedFinancingActivities]
      ,CF.[CashFromDiscontinuedInvestingActivities]
      ,CF.[ChangeInAccountPayable]
      ,CF.[ChangeInDividendPayable]
      ,CF.[ChangeInTaxPayable]
      ,CF.[ChangeInAccruedExpense]
      ,CF.[ChangeInAccruedInvestmentIncome]
      ,CF.[ChangesInCash]
      ,CF.[ChangeInDeferredAcquisitionCosts]
      ,CF.[ChangeInDeferredCharges]
      ,CF.[ChangeInFederalFundsAndSecuritiesSoldForRepurchase]
      ,CF.[ChangeInFundsWithheld]
      ,CF.[ChangeInIncomeTaxPayable]
      ,CF.[ChangeInInterestPayable]
      ,CF.[ChangeInInventory]
      ,CF.[ChangeInLoans]
      ,CF.[ChangeInLossAndLossAdjustmentExpenseReserves]
      ,CF.[ChangeInOtherCurrentAssets]
      ,CF.[ChangeInOtherCurrentLiabilities]
      ,CF.[ChangeInOtherWorkingCapital]
      ,CF.[ChangeInPayable]
      ,CF.[ChangeInPayablesAndAccruedExpense]
      ,CF.[ChangeInPremiumsReceivable]
      ,CF.[ChangeInPrepaidAssets]
      ,CF.[ChangeInPrepaidReinsurancePremiums]
      ,CF.[ChangeInReceivables]
      ,CF.[ChangeInReinsuranceReceivableOnPaidLosses]
      ,CF.[ChangeInReinsuranceRecoverableOnPaidAndUnpaidLosses]
      ,CF.[ChangeInReinsuranceRecoverableOnUnpaidLosses]
      ,CF.[ChangeInRestrictedCash]
      ,CF.[ChangeInTradingAccountSecurities]
      ,CF.[ChangeInUnearnedPremiums]
      ,CF.[ChangeInUnearnedPremiumsCeded]
      ,CF.[ChangeInWorkingCapital]
      ,CF.[CommonStockDividendPaid]
      ,CF.[CumulativeEffectOfAccountingChange]
      ,CF.[DeferredIncomeTax]
      ,CF.[DeferredTax]
      ,CF.[Depletion]
      ,CF.[Depreciation]
      ,CF.[DepreciationAndAmortization]
      ,CF.[DepreciationAmortizationDepletion]
      ,CF.[EarningsLossesFromEquityInvestments]
      ,CF.[EffectOfExchangeRateChanges]
      ,CF.[ExcessTaxBenefitFromStockBasedCompensation]
      ,CF.[ExtraordinaryItems]
      ,CF.[GainLossOnInvestmentSecurities]
      ,CF.[GainLossOnSaleOfBusiness]
      ,CF.[GainLossOnSaleOfPPE]
      ,CF.[IncreaseDecreaseInDeposit]
      ,CF.[InterestCreditedOnPolicyholderDeposits]
      ,CF.[NetCommonStockIssuance]
      ,CF.[NetIssuancePaymentsOfDebt]
      ,CF.[NetLongTermDebtIssuance]
      ,CF.[NetPreferredStockIssuance]
      ,CF.[NetShortTermDebtIssuance]
      ,CF.[CashFromDiscontinuedOperatingActivities]
      ,CF.[NetForeignCurrencyExchangeGainLoss]
      ,CF.[NetIncome]
      ,CF.[NetIncomeFromContinuingOperations]
      ,CF.[NetIncomeFromDiscontinuedOperations]
      ,CF.[NetRealizedInvestmentGains]
      ,CF.[OperatingGainsLosses]
      ,CF.[NetOtherFinancingCharges]
      ,CF.[NetOtherInvestingChanges]
      ,CF.[OtherNonCashItems]
      ,CF.[PaymentForLoans]
      ,CF.[CommonStockPayments]
      ,CF.[PreferredStockPayments]
      ,CF.[LongTermDebtPayments]
      ,CF.[ShortTermDebtPayments]
      ,CF.[PensionAndEmployeeBenefitExpense]
      ,CF.[PreferredStockDividendPaid]
      ,CF.[ProceedsFromIssuanceOfWarrants]
      ,CF.[ProceedsFromLoans]
      ,CF.[ProceedsFromStockOptionExercised]
      ,CF.[CommonStockIssuance]
      ,CF.[LongTermDebtIssuance]
      ,CF.[PreferredStockIssuance]
      ,CF.[ShortTermDebtIssuance]
      ,CF.[ProceedsPaymentFederalFundsSoldAndSecuritiesPurchasedUnderAgreementToResell]
      ,CF.[NetProceedsPaymentForLoan]
      ,CF.[ProceedsPaymentInInterestBearingDepositsInBank]
      ,CF.[ProvisionForLoanLeaseAndOtherLosses]
      ,CF.[PurchaseOfEquitySecurities]
      ,CF.[PurchaseOfFixedMaturitySecurities]
      ,CF.[PurchaseOfIntangibles]
      ,CF.[PurchaseOfInvestment]
      ,CF.[PurchaseOfLongTermInvestments]
      ,CF.[PurchaseOfPPE]
      ,CF.[PurchaseOfShortTermInvestments]
      ,CF.[PurchaseOfTechnology]
      ,CF.[PurchaseOfBusiness]
      ,CF.[NetBusinessPurchaseAndSale]
      ,CF.[NetIntangiblesPurchaseAndSale]
      ,CF.[NetInvestmentPurchaseAndSale]
      ,CF.[NetPPEPurchaseAndSale]
      ,CF.[NetTechnologyPurchaseAndSale]
      ,CF.[RealizedGainLossOnSaleOfLoansAndLease]
      ,CF.[SaleOfBusiness]
      ,CF.[SaleOfIntangibles]
      ,CF.[SaleOfInvestment]
      ,CF.[SaleOfLongTermInvestments]
      ,CF.[SaleOfPPE]
      ,CF.[SaleOfShortTermInvestments]
      ,CF.[SaleOfTechnology]
      ,CF.[SalesOfEquitySecurities]
      ,CF.[SalesOfFixedMaturitySecurities]
      ,CF.[StockBasedCompensation]
      ,CF.[UnrealizedGainLossOnInvestmentSecurities]
      ,CF.[UnrealizedGainsLossesOnDerivatives]
      ,CF.[AmortizationOfIntangibles]
      ,CF.[AllowanceForFundsConstruction]
      ,CF.[ChangesInAccountReceivables]
      ,CF.[DomesticSales]
      ,CF.[ForeignSales]
      ,CF.[IncomeTaxPaidSupplementalData]
      ,CF.[InterestPaidSupplementalData]
      ,CF.[IssuanceOfCapitalStock]
      ,CF.[IssuanceOfDebt]
      ,CF.[RepaymentOfDebt]
      ,CF.[RepurchaseOfCapitalStock]
      ,CF.[FreeCashFlow]
      ,CF.[DirectCashFlowsFromOperatingActivities]
      ,CF.[AccessionNumber]
      ,CF.[FormType]
      ,CF.[DecreaseinInterestBearingDepositsinBank]
      ,CF.[IncreaseinInterestBearingDepositsinBank]
      ,CF.[AdjustedGeographySegmentData]
      ,CF.[InterestReceivedCFO]
      ,CF.[InterestPaidCFO]
      ,CF.[PurchaseofSubsidiaries]
      ,CF.[PurchaseofJointVentureAssociate]
      ,CF.[SaleofSubsidiaries]
      ,CF.[SaleofJointVentureAssociate]
      ,CF.[IncreaseDecreaseinLeaseFinancing]
      ,CF.[IncreaseinLeaseFinancing]
      ,CF.[RepaymentinLeaseFinancing]
      ,CF.[ShareofAssociates]
      ,CF.[ProfitonDisposals]
      ,CF.[ReorganizationOtherCosts]
      ,CF.[OtherFinancing]
      ,CF.[NetOutwardLoans]
      ,CF.[IssueExpenses]
      ,CF.[ChangeinCertificatesofDepositsandDebtSecuritiesIssued]
      ,CF.[PaymentstoAcquireHeldToMaturityInvestments]
      ,CF.[PaymentstoAcquireAvailableForSaleFinancialAssets]
      ,CF.[PaymentstoAcquireFinancialAssetsDesignatedasFairValue]
      ,CF.[ProceedsfromDisposalofHeldToMaturityInvestments]
      ,CF.[ProceedsfromDisposalofAvailableForSaleFinancialAssets]
      ,CF.[ProceedsfromDisposalofFinancialAssetsDesignatedasFairValue]
      ,CF.[ChangeinFairValueofInvestmentProperties]
      ,CF.[ChangeinDepositsbyBanksandCustomers]
      ,CF.[CashFlowsfromusedinOperatingActivitiesDirect]
      ,CF.[ClassesofCashReceiptsfromOperatingActivities]
      ,CF.[OtherCashReceiptsfromOperatingActivities]
      ,CF.[ClassesofCashPayments]
      ,CF.[PaymentstoSuppliersforGoodsandServices]
      ,CF.[PaymentsfromContractsHeldforDealingorTradingPurpose]
      ,CF.[PaymentsonBehalfofEmployees]
      ,CF.[PaymentsforPremiumsandClaimsAnnuitiesandOtherPolicyBenefits]
      ,CF.[OtherCashPaymentsfromOperatingActivities]
      ,CF.[DividendsPaidDirect]
      ,CF.[DividendsReceivedDirect]
      ,CF.[InterestPaidDirect]
      ,CF.[InterestReceivedDirect]
      ,CF.[TaxesRefundPaidDirect]
      ,CF.[TotalAdjustmentsforNonCashItems]
      ,CF.[ImpairmentLossReversalRecognizedinProfitorLoss]
      ,CF.[AdjustmentsforUndistributedProfitsofAssociates]
      ,CF.[OtherAdjustmentsforWhichCashEffectsAreInvestingorFinancingCashFlow]
      ,CF.[DividendPaidCFO]
      ,CF.[DividendReceivedCFO]
      ,CF.[TaxesRefundPaid]
      ,CF.[OtherOperatingInflowsOutflowsofCash]
      ,CF.[ProceedsfromGovernmentGrantsCFI]
      ,CF.[CashAdvancesandLoansMadetoOtherParties]
      ,CF.[CashReceiptsfromRepaymentofAdvancesandLoansMadetoOtherParties]
      ,CF.[CashReceiptsfromPaymentsforFinancialDerivativeContracts]
      ,CF.[DividendsReceivedCFI]
      ,CF.[InterestReceivedCFI]
      ,CF.[IncomeTaxesRefundPaidCFI]
      ,CF.[IssuancePaymentofOtherEquityInstrumentsNet]
      ,CF.[PaymentsofOtherEquityInstruments]
      ,CF.[ProceedsfromIssuingOtherEquityInstruments]
      ,CF.[ProceedsfromGovernmentGrantsCFF]
      ,CF.[InterestPaidCFF]
      ,CF.[IncomeTaxesRefundPaidCFF]
      ,CF.[ChangeinAccruedIncome]
      ,CF.[ChangeinDeferredIncome]
      ,CF.[ChangeinFinancialAssets]
      ,CF.[ChangeinAdvancesfromCentralBanks]
      ,CF.[ChangeinFinancialLiabilities]
      ,CF.[ChangeinInsuranceContractAssets]
      ,CF.[ChangeinReinsuranceReceivables]
      ,CF.[ChangeinDeferredAcquisitionCostsNet]
      ,CF.[ChangeinInsuranceFunds]
      ,CF.[ChangeinReinsurancePayables]
      ,CF.[ChangeinInvestmentContractLiabilities]
      ,CF.[ChangeinInsuranceContractLiabilities]
      ,CF.[ProvisionandWriteOffofAssets]
      ,CF.[ReceiptsfromCustomers]
      ,CF.[ReceiptsfromGovernmentGrants]
      ,CF.[MinorityInterest]
      ,CF.[CashDividendsForMinorities]
      ,CF.[FundFromOperation]
      ,CF.[FiscalYearChange]
      ,CF.[NetInvestmentPropertiesPurchaseAndSale]
      ,CF.[PurchaseOfInvestmentProperties]
      ,CF.[SaleOfInvestmentProperties]
      ,CF.[OtherCashAdjustIncludedIntoChangeinCash]
      ,CF.[OtherCashAdjustExcludeFromChangeinCash]
      ,CF.[ChangeinCashSupplementalAsReported]
      ,CF.[CashGeneratedfromOperatingActivities]
	  FROM [MStar].[TCashFlowTTM] CF
      JOIN (SELECT DISTINCT [IngestionTaskId]
							  ,[ExchangeId]
							  ,[CompanyName]
							  ,[Symbol]
							  ,[CUSIP]
							  ,[CIK]
							  ,[ISIN]
							  ,[SEDOL]
							  ,[ShareClassId] FROM [MStar].[TGeneralInfo]) GI 
		ON GI.[IngestionTaskId] = CF.[IngestionTaskId]
	  WHERE CF.[IngestionTaskId] IN (SELECT ID FROM @UnprocessedTasks))
	  AS SourceTable (
      [ExchangeId]
      ,[CompanyName]
      ,[Symbol]
      ,[CUSIP]
      ,[CIK]
      ,[ISIN]
      ,[SEDOL]
      ,[ShareClassId]
	  ,[ReportDate]
      ,[PeriodEndingDate]
      ,[FileDate]
      ,[StatementType]
      ,[DataType]
      ,[Interim]
      ,[CurrencyId]
      ,[FiscalYearEnd]
      ,[Amortization]
      ,[AmortizationOfFinancingCostsAndDiscounts]
      ,[AmortizationOfSecurities]
      ,[AssetImpairmentCharge]
      ,[CallsMaturitiesOfMaturitySecurities]
      ,[CapitalExpenditure]
      ,[NetCapitalExpenditureDisposals]
      ,[CapitalExpenditureReported]
      ,[CashDividendsPaid]
      ,[CashFlowFromContinuingFinancingActivities]
      ,[CashFlowFromContinuingInvestingActivities]
      ,[CashFlowFromContinuingOperatingActivities]
      ,[CashFlowFromDiscontinuedOperation]
      ,[FinancingCashFlow]
      ,[InvestingCashFlow]
      ,[OperatingCashFlow]
      ,[BeginningCashPosition]
      ,[EndCashPosition]
      ,[CashFromDiscontinuedFinancingActivities]
      ,[CashFromDiscontinuedInvestingActivities]
      ,[ChangeInAccountPayable]
      ,[ChangeInDividendPayable]
      ,[ChangeInTaxPayable]
      ,[ChangeInAccruedExpense]
      ,[ChangeInAccruedInvestmentIncome]
      ,[ChangesInCash]
      ,[ChangeInDeferredAcquisitionCosts]
      ,[ChangeInDeferredCharges]
      ,[ChangeInFederalFundsAndSecuritiesSoldForRepurchase]
      ,[ChangeInFundsWithheld]
      ,[ChangeInIncomeTaxPayable]
      ,[ChangeInInterestPayable]
      ,[ChangeInInventory]
      ,[ChangeInLoans]
      ,[ChangeInLossAndLossAdjustmentExpenseReserves]
      ,[ChangeInOtherCurrentAssets]
      ,[ChangeInOtherCurrentLiabilities]
      ,[ChangeInOtherWorkingCapital]
      ,[ChangeInPayable]
      ,[ChangeInPayablesAndAccruedExpense]
      ,[ChangeInPremiumsReceivable]
      ,[ChangeInPrepaidAssets]
      ,[ChangeInPrepaidReinsurancePremiums]
      ,[ChangeInReceivables]
      ,[ChangeInReinsuranceReceivableOnPaidLosses]
      ,[ChangeInReinsuranceRecoverableOnPaidAndUnpaidLosses]
      ,[ChangeInReinsuranceRecoverableOnUnpaidLosses]
      ,[ChangeInRestrictedCash]
      ,[ChangeInTradingAccountSecurities]
      ,[ChangeInUnearnedPremiums]
      ,[ChangeInUnearnedPremiumsCeded]
      ,[ChangeInWorkingCapital]
      ,[CommonStockDividendPaid]
      ,[CumulativeEffectOfAccountingChange]
      ,[DeferredIncomeTax]
      ,[DeferredTax]
      ,[Depletion]
      ,[Depreciation]
      ,[DepreciationAndAmortization]
      ,[DepreciationAmortizationDepletion]
      ,[EarningsLossesFromEquityInvestments]
      ,[EffectOfExchangeRateChanges]
      ,[ExcessTaxBenefitFromStockBasedCompensation]
      ,[ExtraordinaryItems]
      ,[GainLossOnInvestmentSecurities]
      ,[GainLossOnSaleOfBusiness]
      ,[GainLossOnSaleOfPPE]
      ,[IncreaseDecreaseInDeposit]
      ,[InterestCreditedOnPolicyholderDeposits]
      ,[NetCommonStockIssuance]
      ,[NetIssuancePaymentsOfDebt]
      ,[NetLongTermDebtIssuance]
      ,[NetPreferredStockIssuance]
      ,[NetShortTermDebtIssuance]
      ,[CashFromDiscontinuedOperatingActivities]
      ,[NetForeignCurrencyExchangeGainLoss]
      ,[NetIncome]
      ,[NetIncomeFromContinuingOperations]
      ,[NetIncomeFromDiscontinuedOperations]
      ,[NetRealizedInvestmentGains]
      ,[OperatingGainsLosses]
      ,[NetOtherFinancingCharges]
      ,[NetOtherInvestingChanges]
      ,[OtherNonCashItems]
      ,[PaymentForLoans]
      ,[CommonStockPayments]
      ,[PreferredStockPayments]
      ,[LongTermDebtPayments]
      ,[ShortTermDebtPayments]
      ,[PensionAndEmployeeBenefitExpense]
      ,[PreferredStockDividendPaid]
      ,[ProceedsFromIssuanceOfWarrants]
      ,[ProceedsFromLoans]
      ,[ProceedsFromStockOptionExercised]
      ,[CommonStockIssuance]
      ,[LongTermDebtIssuance]
      ,[PreferredStockIssuance]
      ,[ShortTermDebtIssuance]
      ,[ProceedsPaymentFederalFundsSoldAndSecuritiesPurchasedUnderAgreementToResell]
      ,[NetProceedsPaymentForLoan]
      ,[ProceedsPaymentInInterestBearingDepositsInBank]
      ,[ProvisionForLoanLeaseAndOtherLosses]
      ,[PurchaseOfEquitySecurities]
      ,[PurchaseOfFixedMaturitySecurities]
      ,[PurchaseOfIntangibles]
      ,[PurchaseOfInvestment]
      ,[PurchaseOfLongTermInvestments]
      ,[PurchaseOfPPE]
      ,[PurchaseOfShortTermInvestments]
      ,[PurchaseOfTechnology]
      ,[PurchaseOfBusiness]
      ,[NetBusinessPurchaseAndSale]
      ,[NetIntangiblesPurchaseAndSale]
      ,[NetInvestmentPurchaseAndSale]
      ,[NetPPEPurchaseAndSale]
      ,[NetTechnologyPurchaseAndSale]
      ,[RealizedGainLossOnSaleOfLoansAndLease]
      ,[SaleOfBusiness]
      ,[SaleOfIntangibles]
      ,[SaleOfInvestment]
      ,[SaleOfLongTermInvestments]
      ,[SaleOfPPE]
      ,[SaleOfShortTermInvestments]
      ,[SaleOfTechnology]
      ,[SalesOfEquitySecurities]
      ,[SalesOfFixedMaturitySecurities]
      ,[StockBasedCompensation]
      ,[UnrealizedGainLossOnInvestmentSecurities]
      ,[UnrealizedGainsLossesOnDerivatives]
      ,[AmortizationOfIntangibles]
      ,[AllowanceForFundsConstruction]
      ,[ChangesInAccountReceivables]
      ,[DomesticSales]
      ,[ForeignSales]
      ,[IncomeTaxPaidSupplementalData]
      ,[InterestPaidSupplementalData]
      ,[IssuanceOfCapitalStock]
      ,[IssuanceOfDebt]
      ,[RepaymentOfDebt]
      ,[RepurchaseOfCapitalStock]
      ,[FreeCashFlow]
      ,[DirectCashFlowsFromOperatingActivities]
      ,[AccessionNumber]
      ,[FormType]
      ,[DecreaseinInterestBearingDepositsinBank]
      ,[IncreaseinInterestBearingDepositsinBank]
      ,[AdjustedGeographySegmentData]
      ,[InterestReceivedCFO]
      ,[InterestPaidCFO]
      ,[PurchaseofSubsidiaries]
      ,[PurchaseofJointVentureAssociate]
      ,[SaleofSubsidiaries]
      ,[SaleofJointVentureAssociate]
      ,[IncreaseDecreaseinLeaseFinancing]
      ,[IncreaseinLeaseFinancing]
      ,[RepaymentinLeaseFinancing]
      ,[ShareofAssociates]
      ,[ProfitonDisposals]
      ,[ReorganizationOtherCosts]
      ,[OtherFinancing]
      ,[NetOutwardLoans]
      ,[IssueExpenses]
      ,[ChangeinCertificatesofDepositsandDebtSecuritiesIssued]
      ,[PaymentstoAcquireHeldToMaturityInvestments]
      ,[PaymentstoAcquireAvailableForSaleFinancialAssets]
      ,[PaymentstoAcquireFinancialAssetsDesignatedasFairValue]
      ,[ProceedsfromDisposalofHeldToMaturityInvestments]
      ,[ProceedsfromDisposalofAvailableForSaleFinancialAssets]
      ,[ProceedsfromDisposalofFinancialAssetsDesignatedasFairValue]
      ,[ChangeinFairValueofInvestmentProperties]
      ,[ChangeinDepositsbyBanksandCustomers]
      ,[CashFlowsfromusedinOperatingActivitiesDirect]
      ,[ClassesofCashReceiptsfromOperatingActivities]
      ,[OtherCashReceiptsfromOperatingActivities]
      ,[ClassesofCashPayments]
      ,[PaymentstoSuppliersforGoodsandServices]
      ,[PaymentsfromContractsHeldforDealingorTradingPurpose]
      ,[PaymentsonBehalfofEmployees]
      ,[PaymentsforPremiumsandClaimsAnnuitiesandOtherPolicyBenefits]
      ,[OtherCashPaymentsfromOperatingActivities]
      ,[DividendsPaidDirect]
      ,[DividendsReceivedDirect]
      ,[InterestPaidDirect]
      ,[InterestReceivedDirect]
      ,[TaxesRefundPaidDirect]
      ,[TotalAdjustmentsforNonCashItems]
      ,[ImpairmentLossReversalRecognizedinProfitorLoss]
      ,[AdjustmentsforUndistributedProfitsofAssociates]
      ,[OtherAdjustmentsforWhichCashEffectsAreInvestingorFinancingCashFlow]
      ,[DividendPaidCFO]
      ,[DividendReceivedCFO]
      ,[TaxesRefundPaid]
      ,[OtherOperatingInflowsOutflowsofCash]
      ,[ProceedsfromGovernmentGrantsCFI]
      ,[CashAdvancesandLoansMadetoOtherParties]
      ,[CashReceiptsfromRepaymentofAdvancesandLoansMadetoOtherParties]
      ,[CashReceiptsfromPaymentsforFinancialDerivativeContracts]
      ,[DividendsReceivedCFI]
      ,[InterestReceivedCFI]
      ,[IncomeTaxesRefundPaidCFI]
      ,[IssuancePaymentofOtherEquityInstrumentsNet]
      ,[PaymentsofOtherEquityInstruments]
      ,[ProceedsfromIssuingOtherEquityInstruments]
      ,[ProceedsfromGovernmentGrantsCFF]
      ,[InterestPaidCFF]
      ,[IncomeTaxesRefundPaidCFF]
      ,[ChangeinAccruedIncome]
      ,[ChangeinDeferredIncome]
      ,[ChangeinFinancialAssets]
      ,[ChangeinAdvancesfromCentralBanks]
      ,[ChangeinFinancialLiabilities]
      ,[ChangeinInsuranceContractAssets]
      ,[ChangeinReinsuranceReceivables]
      ,[ChangeinDeferredAcquisitionCostsNet]
      ,[ChangeinInsuranceFunds]
      ,[ChangeinReinsurancePayables]
      ,[ChangeinInvestmentContractLiabilities]
      ,[ChangeinInsuranceContractLiabilities]
      ,[ProvisionandWriteOffofAssets]
      ,[ReceiptsfromCustomers]
      ,[ReceiptsfromGovernmentGrants]
      ,[MinorityInterest]
      ,[CashDividendsForMinorities]
      ,[FundFromOperation]
      ,[FiscalYearChange]
      ,[NetInvestmentPropertiesPurchaseAndSale]
      ,[PurchaseOfInvestmentProperties]
      ,[SaleOfInvestmentProperties]
      ,[OtherCashAdjustIncludedIntoChangeinCash]
      ,[OtherCashAdjustExcludeFromChangeinCash]
      ,[ChangeinCashSupplementalAsReported]
      ,[CashGeneratedfromOperatingActivities])
	ON TargetTable.[ExchangeId] = SourceTable.[ExchangeId]
	AND TargetTable.[Symbol] = SourceTable.[Symbol]
    AND TargetTable.[ReportDate] = SourceTable.[ReportDate]
    AND TargetTable.[StatementType] = SourceTable.[StatementType]
    AND TargetTable.[DataType] = SourceTable.[DataType]
	AND ISNULL(TargetTable.[Interim],'') = ISNULL(SourceTable.[Interim],'')
    AND ISNULL(TargetTable.[FiscalYearEnd],'') = ISNULL(SourceTable.[FiscalYearEnd],'')

	WHEN NOT MATCHED BY TARGET THEN
	INSERT(
	  [MCashFlowTTMId]
      ,[CreatedDate]
      ,[UpdatedDate]
      ,[ExchangeId]
      ,[CompanyName]
      ,[Symbol]
      ,[CUSIP]
      ,[CIK]
      ,[ISIN]
      ,[SEDOL]
      ,[ShareClassId]
	  ,[ReportDate]
      ,[PeriodEndingDate]
      ,[FileDate]
      ,[StatementType]
      ,[DataType]
      ,[Interim]
      ,[CurrencyId]
      ,[FiscalYearEnd]
      ,[Amortization]
      ,[AmortizationOfFinancingCostsAndDiscounts]
      ,[AmortizationOfSecurities]
      ,[AssetImpairmentCharge]
      ,[CallsMaturitiesOfMaturitySecurities]
      ,[CapitalExpenditure]
      ,[NetCapitalExpenditureDisposals]
      ,[CapitalExpenditureReported]
      ,[CashDividendsPaid]
      ,[CashFlowFromContinuingFinancingActivities]
      ,[CashFlowFromContinuingInvestingActivities]
      ,[CashFlowFromContinuingOperatingActivities]
      ,[CashFlowFromDiscontinuedOperation]
      ,[FinancingCashFlow]
      ,[InvestingCashFlow]
      ,[OperatingCashFlow]
      ,[BeginningCashPosition]
      ,[EndCashPosition]
      ,[CashFromDiscontinuedFinancingActivities]
      ,[CashFromDiscontinuedInvestingActivities]
      ,[ChangeInAccountPayable]
      ,[ChangeInDividendPayable]
      ,[ChangeInTaxPayable]
      ,[ChangeInAccruedExpense]
      ,[ChangeInAccruedInvestmentIncome]
      ,[ChangesInCash]
      ,[ChangeInDeferredAcquisitionCosts]
      ,[ChangeInDeferredCharges]
      ,[ChangeInFederalFundsAndSecuritiesSoldForRepurchase]
      ,[ChangeInFundsWithheld]
      ,[ChangeInIncomeTaxPayable]
      ,[ChangeInInterestPayable]
      ,[ChangeInInventory]
      ,[ChangeInLoans]
      ,[ChangeInLossAndLossAdjustmentExpenseReserves]
      ,[ChangeInOtherCurrentAssets]
      ,[ChangeInOtherCurrentLiabilities]
      ,[ChangeInOtherWorkingCapital]
      ,[ChangeInPayable]
      ,[ChangeInPayablesAndAccruedExpense]
      ,[ChangeInPremiumsReceivable]
      ,[ChangeInPrepaidAssets]
      ,[ChangeInPrepaidReinsurancePremiums]
      ,[ChangeInReceivables]
      ,[ChangeInReinsuranceReceivableOnPaidLosses]
      ,[ChangeInReinsuranceRecoverableOnPaidAndUnpaidLosses]
      ,[ChangeInReinsuranceRecoverableOnUnpaidLosses]
      ,[ChangeInRestrictedCash]
      ,[ChangeInTradingAccountSecurities]
      ,[ChangeInUnearnedPremiums]
      ,[ChangeInUnearnedPremiumsCeded]
      ,[ChangeInWorkingCapital]
      ,[CommonStockDividendPaid]
      ,[CumulativeEffectOfAccountingChange]
      ,[DeferredIncomeTax]
      ,[DeferredTax]
      ,[Depletion]
      ,[Depreciation]
      ,[DepreciationAndAmortization]
      ,[DepreciationAmortizationDepletion]
      ,[EarningsLossesFromEquityInvestments]
      ,[EffectOfExchangeRateChanges]
      ,[ExcessTaxBenefitFromStockBasedCompensation]
      ,[ExtraordinaryItems]
      ,[GainLossOnInvestmentSecurities]
      ,[GainLossOnSaleOfBusiness]
      ,[GainLossOnSaleOfPPE]
      ,[IncreaseDecreaseInDeposit]
      ,[InterestCreditedOnPolicyholderDeposits]
      ,[NetCommonStockIssuance]
      ,[NetIssuancePaymentsOfDebt]
      ,[NetLongTermDebtIssuance]
      ,[NetPreferredStockIssuance]
      ,[NetShortTermDebtIssuance]
      ,[CashFromDiscontinuedOperatingActivities]
      ,[NetForeignCurrencyExchangeGainLoss]
      ,[NetIncome]
      ,[NetIncomeFromContinuingOperations]
      ,[NetIncomeFromDiscontinuedOperations]
      ,[NetRealizedInvestmentGains]
      ,[OperatingGainsLosses]
      ,[NetOtherFinancingCharges]
      ,[NetOtherInvestingChanges]
      ,[OtherNonCashItems]
      ,[PaymentForLoans]
      ,[CommonStockPayments]
      ,[PreferredStockPayments]
      ,[LongTermDebtPayments]
      ,[ShortTermDebtPayments]
      ,[PensionAndEmployeeBenefitExpense]
      ,[PreferredStockDividendPaid]
      ,[ProceedsFromIssuanceOfWarrants]
      ,[ProceedsFromLoans]
      ,[ProceedsFromStockOptionExercised]
      ,[CommonStockIssuance]
      ,[LongTermDebtIssuance]
      ,[PreferredStockIssuance]
      ,[ShortTermDebtIssuance]
      ,[ProceedsPaymentFederalFundsSoldAndSecuritiesPurchasedUnderAgreementToResell]
      ,[NetProceedsPaymentForLoan]
      ,[ProceedsPaymentInInterestBearingDepositsInBank]
      ,[ProvisionForLoanLeaseAndOtherLosses]
      ,[PurchaseOfEquitySecurities]
      ,[PurchaseOfFixedMaturitySecurities]
      ,[PurchaseOfIntangibles]
      ,[PurchaseOfInvestment]
      ,[PurchaseOfLongTermInvestments]
      ,[PurchaseOfPPE]
      ,[PurchaseOfShortTermInvestments]
      ,[PurchaseOfTechnology]
      ,[PurchaseOfBusiness]
      ,[NetBusinessPurchaseAndSale]
      ,[NetIntangiblesPurchaseAndSale]
      ,[NetInvestmentPurchaseAndSale]
      ,[NetPPEPurchaseAndSale]
      ,[NetTechnologyPurchaseAndSale]
      ,[RealizedGainLossOnSaleOfLoansAndLease]
      ,[SaleOfBusiness]
      ,[SaleOfIntangibles]
      ,[SaleOfInvestment]
      ,[SaleOfLongTermInvestments]
      ,[SaleOfPPE]
      ,[SaleOfShortTermInvestments]
      ,[SaleOfTechnology]
      ,[SalesOfEquitySecurities]
      ,[SalesOfFixedMaturitySecurities]
      ,[StockBasedCompensation]
      ,[UnrealizedGainLossOnInvestmentSecurities]
      ,[UnrealizedGainsLossesOnDerivatives]
      ,[AmortizationOfIntangibles]
      ,[AllowanceForFundsConstruction]
      ,[ChangesInAccountReceivables]
      ,[DomesticSales]
      ,[ForeignSales]
      ,[IncomeTaxPaidSupplementalData]
      ,[InterestPaidSupplementalData]
      ,[IssuanceOfCapitalStock]
      ,[IssuanceOfDebt]
      ,[RepaymentOfDebt]
      ,[RepurchaseOfCapitalStock]
      ,[FreeCashFlow]
      ,[DirectCashFlowsFromOperatingActivities]
      ,[AccessionNumber]
      ,[FormType]
      ,[DecreaseinInterestBearingDepositsinBank]
      ,[IncreaseinInterestBearingDepositsinBank]
      ,[AdjustedGeographySegmentData]
      ,[InterestReceivedCFO]
      ,[InterestPaidCFO]
      ,[PurchaseofSubsidiaries]
      ,[PurchaseofJointVentureAssociate]
      ,[SaleofSubsidiaries]
      ,[SaleofJointVentureAssociate]
      ,[IncreaseDecreaseinLeaseFinancing]
      ,[IncreaseinLeaseFinancing]
      ,[RepaymentinLeaseFinancing]
      ,[ShareofAssociates]
      ,[ProfitonDisposals]
      ,[ReorganizationOtherCosts]
      ,[OtherFinancing]
      ,[NetOutwardLoans]
      ,[IssueExpenses]
      ,[ChangeinCertificatesofDepositsandDebtSecuritiesIssued]
      ,[PaymentstoAcquireHeldToMaturityInvestments]
      ,[PaymentstoAcquireAvailableForSaleFinancialAssets]
      ,[PaymentstoAcquireFinancialAssetsDesignatedasFairValue]
      ,[ProceedsfromDisposalofHeldToMaturityInvestments]
      ,[ProceedsfromDisposalofAvailableForSaleFinancialAssets]
      ,[ProceedsfromDisposalofFinancialAssetsDesignatedasFairValue]
      ,[ChangeinFairValueofInvestmentProperties]
      ,[ChangeinDepositsbyBanksandCustomers]
      ,[CashFlowsfromusedinOperatingActivitiesDirect]
      ,[ClassesofCashReceiptsfromOperatingActivities]
      ,[OtherCashReceiptsfromOperatingActivities]
      ,[ClassesofCashPayments]
      ,[PaymentstoSuppliersforGoodsandServices]
      ,[PaymentsfromContractsHeldforDealingorTradingPurpose]
      ,[PaymentsonBehalfofEmployees]
      ,[PaymentsforPremiumsandClaimsAnnuitiesandOtherPolicyBenefits]
      ,[OtherCashPaymentsfromOperatingActivities]
      ,[DividendsPaidDirect]
      ,[DividendsReceivedDirect]
      ,[InterestPaidDirect]
      ,[InterestReceivedDirect]
      ,[TaxesRefundPaidDirect]
      ,[TotalAdjustmentsforNonCashItems]
      ,[ImpairmentLossReversalRecognizedinProfitorLoss]
      ,[AdjustmentsforUndistributedProfitsofAssociates]
      ,[OtherAdjustmentsforWhichCashEffectsAreInvestingorFinancingCashFlow]
      ,[DividendPaidCFO]
      ,[DividendReceivedCFO]
      ,[TaxesRefundPaid]
      ,[OtherOperatingInflowsOutflowsofCash]
      ,[ProceedsfromGovernmentGrantsCFI]
      ,[CashAdvancesandLoansMadetoOtherParties]
      ,[CashReceiptsfromRepaymentofAdvancesandLoansMadetoOtherParties]
      ,[CashReceiptsfromPaymentsforFinancialDerivativeContracts]
      ,[DividendsReceivedCFI]
      ,[InterestReceivedCFI]
      ,[IncomeTaxesRefundPaidCFI]
      ,[IssuancePaymentofOtherEquityInstrumentsNet]
      ,[PaymentsofOtherEquityInstruments]
      ,[ProceedsfromIssuingOtherEquityInstruments]
      ,[ProceedsfromGovernmentGrantsCFF]
      ,[InterestPaidCFF]
      ,[IncomeTaxesRefundPaidCFF]
      ,[ChangeinAccruedIncome]
      ,[ChangeinDeferredIncome]
      ,[ChangeinFinancialAssets]
      ,[ChangeinAdvancesfromCentralBanks]
      ,[ChangeinFinancialLiabilities]
      ,[ChangeinInsuranceContractAssets]
      ,[ChangeinReinsuranceReceivables]
      ,[ChangeinDeferredAcquisitionCostsNet]
      ,[ChangeinInsuranceFunds]
      ,[ChangeinReinsurancePayables]
      ,[ChangeinInvestmentContractLiabilities]
      ,[ChangeinInsuranceContractLiabilities]
      ,[ProvisionandWriteOffofAssets]
      ,[ReceiptsfromCustomers]
      ,[ReceiptsfromGovernmentGrants]
      ,[MinorityInterest]
      ,[CashDividendsForMinorities]
      ,[FundFromOperation]
      ,[FiscalYearChange]
      ,[NetInvestmentPropertiesPurchaseAndSale]
      ,[PurchaseOfInvestmentProperties]
      ,[SaleOfInvestmentProperties]
      ,[OtherCashAdjustIncludedIntoChangeinCash]
      ,[OtherCashAdjustExcludeFromChangeinCash]
      ,[ChangeinCashSupplementalAsReported]
      ,[CashGeneratedfromOperatingActivities]
	)
	VALUES (NEWID()
	  ,GETUTCDATE()
	  ,GETUTCDATE()
	  ,[ExchangeId]
	  ,[CompanyName]
	  ,[Symbol]
	  ,[CUSIP]
	  ,[CIK]
	  ,[ISIN]
	  ,[SEDOL]
	  ,[ShareClassId]
	  ,[ReportDate]
      ,[PeriodEndingDate]
      ,[FileDate]
      ,[StatementType]
      ,[DataType]
      ,[Interim]
      ,[CurrencyId]
      ,[FiscalYearEnd]
      ,[Amortization]
      ,[AmortizationOfFinancingCostsAndDiscounts]
      ,[AmortizationOfSecurities]
      ,[AssetImpairmentCharge]
      ,[CallsMaturitiesOfMaturitySecurities]
      ,[CapitalExpenditure]
      ,[NetCapitalExpenditureDisposals]
      ,[CapitalExpenditureReported]
      ,[CashDividendsPaid]
      ,[CashFlowFromContinuingFinancingActivities]
      ,[CashFlowFromContinuingInvestingActivities]
      ,[CashFlowFromContinuingOperatingActivities]
      ,[CashFlowFromDiscontinuedOperation]
      ,[FinancingCashFlow]
      ,[InvestingCashFlow]
      ,[OperatingCashFlow]
      ,[BeginningCashPosition]
      ,[EndCashPosition]
      ,[CashFromDiscontinuedFinancingActivities]
      ,[CashFromDiscontinuedInvestingActivities]
      ,[ChangeInAccountPayable]
      ,[ChangeInDividendPayable]
      ,[ChangeInTaxPayable]
      ,[ChangeInAccruedExpense]
      ,[ChangeInAccruedInvestmentIncome]
      ,[ChangesInCash]
      ,[ChangeInDeferredAcquisitionCosts]
      ,[ChangeInDeferredCharges]
      ,[ChangeInFederalFundsAndSecuritiesSoldForRepurchase]
      ,[ChangeInFundsWithheld]
      ,[ChangeInIncomeTaxPayable]
      ,[ChangeInInterestPayable]
      ,[ChangeInInventory]
      ,[ChangeInLoans]
      ,[ChangeInLossAndLossAdjustmentExpenseReserves]
      ,[ChangeInOtherCurrentAssets]
      ,[ChangeInOtherCurrentLiabilities]
      ,[ChangeInOtherWorkingCapital]
      ,[ChangeInPayable]
      ,[ChangeInPayablesAndAccruedExpense]
      ,[ChangeInPremiumsReceivable]
      ,[ChangeInPrepaidAssets]
      ,[ChangeInPrepaidReinsurancePremiums]
      ,[ChangeInReceivables]
      ,[ChangeInReinsuranceReceivableOnPaidLosses]
      ,[ChangeInReinsuranceRecoverableOnPaidAndUnpaidLosses]
      ,[ChangeInReinsuranceRecoverableOnUnpaidLosses]
      ,[ChangeInRestrictedCash]
      ,[ChangeInTradingAccountSecurities]
      ,[ChangeInUnearnedPremiums]
      ,[ChangeInUnearnedPremiumsCeded]
      ,[ChangeInWorkingCapital]
      ,[CommonStockDividendPaid]
      ,[CumulativeEffectOfAccountingChange]
      ,[DeferredIncomeTax]
      ,[DeferredTax]
      ,[Depletion]
      ,[Depreciation]
      ,[DepreciationAndAmortization]
      ,[DepreciationAmortizationDepletion]
      ,[EarningsLossesFromEquityInvestments]
      ,[EffectOfExchangeRateChanges]
      ,[ExcessTaxBenefitFromStockBasedCompensation]
      ,[ExtraordinaryItems]
      ,[GainLossOnInvestmentSecurities]
      ,[GainLossOnSaleOfBusiness]
      ,[GainLossOnSaleOfPPE]
      ,[IncreaseDecreaseInDeposit]
      ,[InterestCreditedOnPolicyholderDeposits]
      ,[NetCommonStockIssuance]
      ,[NetIssuancePaymentsOfDebt]
      ,[NetLongTermDebtIssuance]
      ,[NetPreferredStockIssuance]
      ,[NetShortTermDebtIssuance]
      ,[CashFromDiscontinuedOperatingActivities]
      ,[NetForeignCurrencyExchangeGainLoss]
      ,[NetIncome]
      ,[NetIncomeFromContinuingOperations]
      ,[NetIncomeFromDiscontinuedOperations]
      ,[NetRealizedInvestmentGains]
      ,[OperatingGainsLosses]
      ,[NetOtherFinancingCharges]
      ,[NetOtherInvestingChanges]
      ,[OtherNonCashItems]
      ,[PaymentForLoans]
      ,[CommonStockPayments]
      ,[PreferredStockPayments]
      ,[LongTermDebtPayments]
      ,[ShortTermDebtPayments]
      ,[PensionAndEmployeeBenefitExpense]
      ,[PreferredStockDividendPaid]
      ,[ProceedsFromIssuanceOfWarrants]
      ,[ProceedsFromLoans]
      ,[ProceedsFromStockOptionExercised]
      ,[CommonStockIssuance]
      ,[LongTermDebtIssuance]
      ,[PreferredStockIssuance]
      ,[ShortTermDebtIssuance]
      ,[ProceedsPaymentFederalFundsSoldAndSecuritiesPurchasedUnderAgreementToResell]
      ,[NetProceedsPaymentForLoan]
      ,[ProceedsPaymentInInterestBearingDepositsInBank]
      ,[ProvisionForLoanLeaseAndOtherLosses]
      ,[PurchaseOfEquitySecurities]
      ,[PurchaseOfFixedMaturitySecurities]
      ,[PurchaseOfIntangibles]
      ,[PurchaseOfInvestment]
      ,[PurchaseOfLongTermInvestments]
      ,[PurchaseOfPPE]
      ,[PurchaseOfShortTermInvestments]
      ,[PurchaseOfTechnology]
      ,[PurchaseOfBusiness]
      ,[NetBusinessPurchaseAndSale]
      ,[NetIntangiblesPurchaseAndSale]
      ,[NetInvestmentPurchaseAndSale]
      ,[NetPPEPurchaseAndSale]
      ,[NetTechnologyPurchaseAndSale]
      ,[RealizedGainLossOnSaleOfLoansAndLease]
      ,[SaleOfBusiness]
      ,[SaleOfIntangibles]
      ,[SaleOfInvestment]
      ,[SaleOfLongTermInvestments]
      ,[SaleOfPPE]
      ,[SaleOfShortTermInvestments]
      ,[SaleOfTechnology]
      ,[SalesOfEquitySecurities]
      ,[SalesOfFixedMaturitySecurities]
      ,[StockBasedCompensation]
      ,[UnrealizedGainLossOnInvestmentSecurities]
      ,[UnrealizedGainsLossesOnDerivatives]
      ,[AmortizationOfIntangibles]
      ,[AllowanceForFundsConstruction]
      ,[ChangesInAccountReceivables]
      ,[DomesticSales]
      ,[ForeignSales]
      ,[IncomeTaxPaidSupplementalData]
      ,[InterestPaidSupplementalData]
      ,[IssuanceOfCapitalStock]
      ,[IssuanceOfDebt]
      ,[RepaymentOfDebt]
      ,[RepurchaseOfCapitalStock]
      ,[FreeCashFlow]
      ,[DirectCashFlowsFromOperatingActivities]
      ,[AccessionNumber]
      ,[FormType]
      ,[DecreaseinInterestBearingDepositsinBank]
      ,[IncreaseinInterestBearingDepositsinBank]
      ,[AdjustedGeographySegmentData]
      ,[InterestReceivedCFO]
      ,[InterestPaidCFO]
      ,[PurchaseofSubsidiaries]
      ,[PurchaseofJointVentureAssociate]
      ,[SaleofSubsidiaries]
      ,[SaleofJointVentureAssociate]
      ,[IncreaseDecreaseinLeaseFinancing]
      ,[IncreaseinLeaseFinancing]
      ,[RepaymentinLeaseFinancing]
      ,[ShareofAssociates]
      ,[ProfitonDisposals]
      ,[ReorganizationOtherCosts]
      ,[OtherFinancing]
      ,[NetOutwardLoans]
      ,[IssueExpenses]
      ,[ChangeinCertificatesofDepositsandDebtSecuritiesIssued]
      ,[PaymentstoAcquireHeldToMaturityInvestments]
      ,[PaymentstoAcquireAvailableForSaleFinancialAssets]
      ,[PaymentstoAcquireFinancialAssetsDesignatedasFairValue]
      ,[ProceedsfromDisposalofHeldToMaturityInvestments]
      ,[ProceedsfromDisposalofAvailableForSaleFinancialAssets]
      ,[ProceedsfromDisposalofFinancialAssetsDesignatedasFairValue]
      ,[ChangeinFairValueofInvestmentProperties]
      ,[ChangeinDepositsbyBanksandCustomers]
      ,[CashFlowsfromusedinOperatingActivitiesDirect]
      ,[ClassesofCashReceiptsfromOperatingActivities]
      ,[OtherCashReceiptsfromOperatingActivities]
      ,[ClassesofCashPayments]
      ,[PaymentstoSuppliersforGoodsandServices]
      ,[PaymentsfromContractsHeldforDealingorTradingPurpose]
      ,[PaymentsonBehalfofEmployees]
      ,[PaymentsforPremiumsandClaimsAnnuitiesandOtherPolicyBenefits]
      ,[OtherCashPaymentsfromOperatingActivities]
      ,[DividendsPaidDirect]
      ,[DividendsReceivedDirect]
      ,[InterestPaidDirect]
      ,[InterestReceivedDirect]
      ,[TaxesRefundPaidDirect]
      ,[TotalAdjustmentsforNonCashItems]
      ,[ImpairmentLossReversalRecognizedinProfitorLoss]
      ,[AdjustmentsforUndistributedProfitsofAssociates]
      ,[OtherAdjustmentsforWhichCashEffectsAreInvestingorFinancingCashFlow]
      ,[DividendPaidCFO]
      ,[DividendReceivedCFO]
      ,[TaxesRefundPaid]
      ,[OtherOperatingInflowsOutflowsofCash]
      ,[ProceedsfromGovernmentGrantsCFI]
      ,[CashAdvancesandLoansMadetoOtherParties]
      ,[CashReceiptsfromRepaymentofAdvancesandLoansMadetoOtherParties]
      ,[CashReceiptsfromPaymentsforFinancialDerivativeContracts]
      ,[DividendsReceivedCFI]
      ,[InterestReceivedCFI]
      ,[IncomeTaxesRefundPaidCFI]
      ,[IssuancePaymentofOtherEquityInstrumentsNet]
      ,[PaymentsofOtherEquityInstruments]
      ,[ProceedsfromIssuingOtherEquityInstruments]
      ,[ProceedsfromGovernmentGrantsCFF]
      ,[InterestPaidCFF]
      ,[IncomeTaxesRefundPaidCFF]
      ,[ChangeinAccruedIncome]
      ,[ChangeinDeferredIncome]
      ,[ChangeinFinancialAssets]
      ,[ChangeinAdvancesfromCentralBanks]
      ,[ChangeinFinancialLiabilities]
      ,[ChangeinInsuranceContractAssets]
      ,[ChangeinReinsuranceReceivables]
      ,[ChangeinDeferredAcquisitionCostsNet]
      ,[ChangeinInsuranceFunds]
      ,[ChangeinReinsurancePayables]
      ,[ChangeinInvestmentContractLiabilities]
      ,[ChangeinInsuranceContractLiabilities]
      ,[ProvisionandWriteOffofAssets]
      ,[ReceiptsfromCustomers]
      ,[ReceiptsfromGovernmentGrants]
      ,[MinorityInterest]
      ,[CashDividendsForMinorities]
      ,[FundFromOperation]
      ,[FiscalYearChange]
      ,[NetInvestmentPropertiesPurchaseAndSale]
      ,[PurchaseOfInvestmentProperties]
      ,[SaleOfInvestmentProperties]
      ,[OtherCashAdjustIncludedIntoChangeinCash]
      ,[OtherCashAdjustExcludeFromChangeinCash]
      ,[ChangeinCashSupplementalAsReported]
      ,[CashGeneratedfromOperatingActivities])

	OUTPUT $action INTO @SummaryOfChanges;

	UPDATE [dbo].[IngestionTasks]
	SET IsProcessed = 1
	WHERE IngestionTaskId IN (SELECT ID FROM @UnprocessedTasks);

	-- Query the results of the table variable.  
	SELECT Change, COUNT(*) AS CountPerChange  
	FROM @SummaryOfChanges  
	GROUP BY Change;

END
GO


