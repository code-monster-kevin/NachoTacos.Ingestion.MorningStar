﻿/****** Object:  StoredProcedure [dbo].[MergeGrowthRatio]    Script Date: 1/17/2020 9:45:44 AM ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'MergeGrowthRatio')
DROP PROCEDURE [dbo].[MergeGrowthRatio]
GO

/****** Object:  StoredProcedure [dbo].[MergeGrowthRatio]    Script Date: 1/17/2020 9:45:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Kevin Wu
-- Create date: 17th Jan 2020
-- Description:	Merge data from temporary job table [MStar].[TGrowthRatio]
--				to master table [MStar].[MGrowthRatio]
-- Example: EXECUTE MergeGrowthRatio
--          To prevent timeout due to exceessive records of changes to merge,
--          added a limit of merging only the last 50 ingestion task,
--          Will require a recurring job to run this merge function to check of unprocessed tasks
-- =============================================
CREATE PROCEDURE [dbo].[MergeGrowthRatio]
AS
BEGIN
	SET NOCOUNT ON;

    DECLARE @SummaryOfChanges TABLE(Change VARCHAR(20));
	DECLARE @UnprocessedTasks TABLE (id uniqueidentifier, CreatedDate DateTime);

	INSERT INTO @UnprocessedTasks
	SELECT DISTINCT TOP 50 IT.[IngestionTaskId], IT.[CreatedDate]
	FROM [MStar].[TGrowthRatio] GR
	JOIN [dbo].[IngestionTasks] IT ON IT.[IngestionTaskId] = GR.[IngestionTaskId]
	WHERE IT.[IsProcessed] = 0;


	MERGE INTO [MStar].[MGrowthRatio] AS TargetTable
	USING
	(SELECT GI.[ExchangeId]
      ,GI.[CompanyName]
      ,GI.[Symbol]
      ,GI.[CUSIP]
      ,GI.[CIK]
      ,GI.[ISIN]
      ,GI.[SEDOL]
      ,GI.[ShareClassId]
	  ,GR.[ReportDate]
      ,GR.[PeriodEndingDate]
      ,GR.[FileDate]
      ,GR.[StatementType]
      ,GR.[DataType]
      ,GR.[Interim]
      ,GR.[FiscalYearEnd]
      ,GR.[DilutedEPS3MonthSamePeriodGrowth]
      ,GR.[DilutedEPS6MonthSamePeriodGrowth]
      ,GR.[DilutedEPS9MonthSamePeriodGrowth]
      ,GR.[DilutedEPSSequentialGrowth]
      ,GR.[DilutedEPS1YearGrowth]
      ,GR.[DilutedEPS3YearGrowth]
      ,GR.[DilutedEPS5YearGrowth]
      ,GR.[DilutedEPS10YearGrowth]
      ,GR.[DilutedContinuousEPS3MonthSamePeriodGrowth]
      ,GR.[DilutedContinuousEPS6MonthSamePeriodGrowth]
      ,GR.[DilutedContinuousEPS9MonthSamePeriodGrowth]
      ,GR.[DilutedContinuousEPSSequentialGrowth]
      ,GR.[DilutedContinuousEPS1YearGrowth]
      ,GR.[DilutedContinuousEPS3YearGrowth]
      ,GR.[DilutedContinuousEPS5YearGrowth]
      ,GR.[DilutedContinuousEPS10YearGrowth]
      ,GR.[Dividend3MonthSamePeriodGrowth]
      ,GR.[Dividend6MonthSamePeriodGrowth]
      ,GR.[Dividend9MonthSamePeriodGrowth]
      ,GR.[DividendSequentialGrowth]
      ,GR.[Dividend1YearGrowth]
      ,GR.[Dividend3YearGrowth]
      ,GR.[Dividend5YearGrowth]
      ,GR.[Dividend10YearGrowth]
      ,GR.[EquityPerShare3MonthSamePeriodGrowth]
      ,GR.[EquityPerShare6MonthSamePeriodGrowth]
      ,GR.[EquityPerShare9MonthSamePeriodGrowth]
      ,GR.[EquityPerShareSequentialGrowth]
      ,GR.[EquityPerShare1YearGrowth]
      ,GR.[EquityPerShare3YearGrowth]
      ,GR.[EquityPerShare5YearGrowth]
      ,GR.[EquityPerShare10YearGrowth]
      ,GR.[Revenue3MonthSamePeriodGrowth]
      ,GR.[Revenue6MonthSamePeriodGrowth]
      ,GR.[Revenue9MonthSamePeriodGrowth]
      ,GR.[RevenueSequentialGrowth]
      ,GR.[Revenue1YearGrowth]
      ,GR.[Revenue3YearGrowth]
      ,GR.[Revenue5YearGrowth]
      ,GR.[Revenue10YearGrowth]
      ,GR.[OperatingIncome3MonthSamePeriodGrowth]
      ,GR.[OperatingIncome6MonthSamePeriodGrowth]
      ,GR.[OperatingIncome9MonthSamePeriodGrowth]
      ,GR.[OperatingIncomeSequentialGrowth]
      ,GR.[OperatingIncome1YearGrowth]
      ,GR.[OperatingIncome3YearGrowth]
      ,GR.[OperatingIncome5YearGrowth]
      ,GR.[OperatingIncome10YearGrowth]
      ,GR.[NetIncome3MonthSamePeriodGrowth]
      ,GR.[NetIncome6MonthSamePeriodGrowth]
      ,GR.[NetIncome9MonthSamePeriodGrowth]
      ,GR.[NetIncomeSequentialGrowth]
      ,GR.[NetIncome1YearGrowth]
      ,GR.[NetIncome3YearGrowth]
      ,GR.[NetIncome5YearGrowth]
      ,GR.[NetIncome10YearGrowth]
      ,GR.[NetIncomeContOps3MonthSamePeriodGrowth]
      ,GR.[NetIncomeContOps6MonthSamePeriodGrowth]
      ,GR.[NetIncomeContOps9MonthSamePeriodGrowth]
      ,GR.[NetIncomeContOpsSequentialGrowth]
      ,GR.[NetIncomeContOps1YearGrowth]
      ,GR.[NetIncomeContOps3YearGrowth]
      ,GR.[NetIncomeContOps5YearGrowth]
      ,GR.[NetIncomeContOps10YearGrowth]
      ,GR.[CFO3MonthSamePeriodGrowth]
      ,GR.[CFO6MonthSamePeriodGrowth]
      ,GR.[CFO9MonthSamePeriodGrowth]
      ,GR.[CFOSequentialGrowth]
      ,GR.[CFO1YearGrowth]
      ,GR.[CFO3YearGrowth]
      ,GR.[CFO5YearGrowth]
      ,GR.[CFO10YearGrowth]
      ,GR.[FCF3MonthSamePeriodGrowth]
      ,GR.[FCF6MonthSamePeriodGrowth]
      ,GR.[FCF9MonthSamePeriodGrowth]
      ,GR.[FCFSequentialGrowth]
      ,GR.[FCF1YearGrowth]
      ,GR.[FCF3YearGrowth]
      ,GR.[FCF5YearGrowth]
      ,GR.[FCF10YearGrowth]
      ,GR.[OperatingRevenue3MonthSamePeriodGrowth]
      ,GR.[OperatingRevenue6MonthSamePeriodGrowth]
      ,GR.[OperatingRevenue9MonthSamePeriodGrowth]
      ,GR.[OperatingRevenueSequentialGrowth]
      ,GR.[OperatingRevenue1YearGrowth]
      ,GR.[OperatingRevenue3YearGrowth]
      ,GR.[OperatingRevenue5YearGrowth]
      ,GR.[OperatingRevenue10YearGrowth]
      ,GR.[GrowthAnnCapitalSpending5Year]
      ,GR.[GrowthAnnGrossProfit5Year]
      ,GR.[AvgGrossMargin5Year]
      ,GR.[AvgPostTaxMargin5Year]
      ,GR.[AvgPreTaxMargin5Year]
      ,GR.[AvgNetProfitMargin5Year]
      ,GR.[AvgRetCommonEquity5Year]
      ,GR.[AvgRetAssets5Year]
      ,GR.[AvgRetInvestedCapital5Year]
      ,GR.[AccessionNumber]
      ,GR.[FormType]
      ,GR.[RegressionGrowthOperatingRevenue5Years]
      ,GR.[NormalizedDilutedEPSGrowth1year]
      ,GR.[NormalizedDilutedEPSGrowth3year]
      ,GR.[NormalizedDilutedEPSGrowth5year]
      ,GR.[NormalizedDilutedEPSGrowth10year]
      ,GR.[NormalizedDilutedEPSSamePeriodGrowth3months]
      ,GR.[NormalizedDilutedEPSSamePeriodGrowth6months]
      ,GR.[NormalizedDilutedEPSSamePeriodGrowth9months]
      ,GR.[NormalizedDilutedEPSSequentialGrowth]
      ,GR.[NormalizedBasicEPSGrowth1year]
      ,GR.[NormalizedBasicEPSGrowth3year]
      ,GR.[NormalizedBasicEPSGrowth5year]
      ,GR.[NormalizedBasicEPSGrowth10year]
      ,GR.[NormalizedBasicEPSSamePeriodGrowth3months]
      ,GR.[NormalizedBasicEPSSamePeriodGrowth6months]
      ,GR.[NormalizedBasicEPSSamePeriodGrowth9months]
      ,GR.[NormalizedBasicEPSSequentialGrowth]
	  FROM [MStar].[TGrowthRatio] GR
	  JOIN (SELECT DISTINCT [IngestionTaskId]
							  ,[ExchangeId]
							  ,[CompanyName]
							  ,[Symbol]
							  ,[CUSIP]
							  ,[CIK]
							  ,[ISIN]
							  ,[SEDOL]
							  ,[ShareClassId] FROM [MStar].[TGeneralInfo]) GI 
		ON GI.[IngestionTaskId] = GR.[IngestionTaskId]
	  WHERE GR.[IngestionTaskId] IN (SELECT ID FROM @UnprocessedTasks))
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
      ,[FiscalYearEnd]
      ,[DilutedEPS3MonthSamePeriodGrowth]
      ,[DilutedEPS6MonthSamePeriodGrowth]
      ,[DilutedEPS9MonthSamePeriodGrowth]
      ,[DilutedEPSSequentialGrowth]
      ,[DilutedEPS1YearGrowth]
      ,[DilutedEPS3YearGrowth]
      ,[DilutedEPS5YearGrowth]
      ,[DilutedEPS10YearGrowth]
      ,[DilutedContinuousEPS3MonthSamePeriodGrowth]
      ,[DilutedContinuousEPS6MonthSamePeriodGrowth]
      ,[DilutedContinuousEPS9MonthSamePeriodGrowth]
      ,[DilutedContinuousEPSSequentialGrowth]
      ,[DilutedContinuousEPS1YearGrowth]
      ,[DilutedContinuousEPS3YearGrowth]
      ,[DilutedContinuousEPS5YearGrowth]
      ,[DilutedContinuousEPS10YearGrowth]
      ,[Dividend3MonthSamePeriodGrowth]
      ,[Dividend6MonthSamePeriodGrowth]
      ,[Dividend9MonthSamePeriodGrowth]
      ,[DividendSequentialGrowth]
      ,[Dividend1YearGrowth]
      ,[Dividend3YearGrowth]
      ,[Dividend5YearGrowth]
      ,[Dividend10YearGrowth]
      ,[EquityPerShare3MonthSamePeriodGrowth]
      ,[EquityPerShare6MonthSamePeriodGrowth]
      ,[EquityPerShare9MonthSamePeriodGrowth]
      ,[EquityPerShareSequentialGrowth]
      ,[EquityPerShare1YearGrowth]
      ,[EquityPerShare3YearGrowth]
      ,[EquityPerShare5YearGrowth]
      ,[EquityPerShare10YearGrowth]
      ,[Revenue3MonthSamePeriodGrowth]
      ,[Revenue6MonthSamePeriodGrowth]
      ,[Revenue9MonthSamePeriodGrowth]
      ,[RevenueSequentialGrowth]
      ,[Revenue1YearGrowth]
      ,[Revenue3YearGrowth]
      ,[Revenue5YearGrowth]
      ,[Revenue10YearGrowth]
      ,[OperatingIncome3MonthSamePeriodGrowth]
      ,[OperatingIncome6MonthSamePeriodGrowth]
      ,[OperatingIncome9MonthSamePeriodGrowth]
      ,[OperatingIncomeSequentialGrowth]
      ,[OperatingIncome1YearGrowth]
      ,[OperatingIncome3YearGrowth]
      ,[OperatingIncome5YearGrowth]
      ,[OperatingIncome10YearGrowth]
      ,[NetIncome3MonthSamePeriodGrowth]
      ,[NetIncome6MonthSamePeriodGrowth]
      ,[NetIncome9MonthSamePeriodGrowth]
      ,[NetIncomeSequentialGrowth]
      ,[NetIncome1YearGrowth]
      ,[NetIncome3YearGrowth]
      ,[NetIncome5YearGrowth]
      ,[NetIncome10YearGrowth]
      ,[NetIncomeContOps3MonthSamePeriodGrowth]
      ,[NetIncomeContOps6MonthSamePeriodGrowth]
      ,[NetIncomeContOps9MonthSamePeriodGrowth]
      ,[NetIncomeContOpsSequentialGrowth]
      ,[NetIncomeContOps1YearGrowth]
      ,[NetIncomeContOps3YearGrowth]
      ,[NetIncomeContOps5YearGrowth]
      ,[NetIncomeContOps10YearGrowth]
      ,[CFO3MonthSamePeriodGrowth]
      ,[CFO6MonthSamePeriodGrowth]
      ,[CFO9MonthSamePeriodGrowth]
      ,[CFOSequentialGrowth]
      ,[CFO1YearGrowth]
      ,[CFO3YearGrowth]
      ,[CFO5YearGrowth]
      ,[CFO10YearGrowth]
      ,[FCF3MonthSamePeriodGrowth]
      ,[FCF6MonthSamePeriodGrowth]
      ,[FCF9MonthSamePeriodGrowth]
      ,[FCFSequentialGrowth]
      ,[FCF1YearGrowth]
      ,[FCF3YearGrowth]
      ,[FCF5YearGrowth]
      ,[FCF10YearGrowth]
      ,[OperatingRevenue3MonthSamePeriodGrowth]
      ,[OperatingRevenue6MonthSamePeriodGrowth]
      ,[OperatingRevenue9MonthSamePeriodGrowth]
      ,[OperatingRevenueSequentialGrowth]
      ,[OperatingRevenue1YearGrowth]
      ,[OperatingRevenue3YearGrowth]
      ,[OperatingRevenue5YearGrowth]
      ,[OperatingRevenue10YearGrowth]
      ,[GrowthAnnCapitalSpending5Year]
      ,[GrowthAnnGrossProfit5Year]
      ,[AvgGrossMargin5Year]
      ,[AvgPostTaxMargin5Year]
      ,[AvgPreTaxMargin5Year]
      ,[AvgNetProfitMargin5Year]
      ,[AvgRetCommonEquity5Year]
      ,[AvgRetAssets5Year]
      ,[AvgRetInvestedCapital5Year]
      ,[AccessionNumber]
      ,[FormType]
      ,[RegressionGrowthOperatingRevenue5Years]
      ,[NormalizedDilutedEPSGrowth1year]
      ,[NormalizedDilutedEPSGrowth3year]
      ,[NormalizedDilutedEPSGrowth5year]
      ,[NormalizedDilutedEPSGrowth10year]
      ,[NormalizedDilutedEPSSamePeriodGrowth3months]
      ,[NormalizedDilutedEPSSamePeriodGrowth6months]
      ,[NormalizedDilutedEPSSamePeriodGrowth9months]
      ,[NormalizedDilutedEPSSequentialGrowth]
      ,[NormalizedBasicEPSGrowth1year]
      ,[NormalizedBasicEPSGrowth3year]
      ,[NormalizedBasicEPSGrowth5year]
      ,[NormalizedBasicEPSGrowth10year]
      ,[NormalizedBasicEPSSamePeriodGrowth3months]
      ,[NormalizedBasicEPSSamePeriodGrowth6months]
      ,[NormalizedBasicEPSSamePeriodGrowth9months]
      ,[NormalizedBasicEPSSequentialGrowth])
	ON TargetTable.[ExchangeId] = SourceTable.[ExchangeId]
	AND TargetTable.[Symbol] = SourceTable.[Symbol]
    AND TargetTable.[ReportDate] = SourceTable.[ReportDate]
    AND TargetTable.[StatementType] = SourceTable.[StatementType]
    AND TargetTable.[DataType] = SourceTable.[DataType]
	AND ISNULL(TargetTable.[Interim],'') = ISNULL(SourceTable.[Interim],'')
    AND ISNULL(TargetTable.[FiscalYearEnd],'') = ISNULL(SourceTable.[FiscalYearEnd],'')

	

	WHEN NOT MATCHED BY TARGET THEN
	INSERT(
      [MGrowthRatioId]
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
      ,[FiscalYearEnd]
      ,[DilutedEPS3MonthSamePeriodGrowth]
      ,[DilutedEPS6MonthSamePeriodGrowth]
      ,[DilutedEPS9MonthSamePeriodGrowth]
      ,[DilutedEPSSequentialGrowth]
      ,[DilutedEPS1YearGrowth]
      ,[DilutedEPS3YearGrowth]
      ,[DilutedEPS5YearGrowth]
      ,[DilutedEPS10YearGrowth]
      ,[DilutedContinuousEPS3MonthSamePeriodGrowth]
      ,[DilutedContinuousEPS6MonthSamePeriodGrowth]
      ,[DilutedContinuousEPS9MonthSamePeriodGrowth]
      ,[DilutedContinuousEPSSequentialGrowth]
      ,[DilutedContinuousEPS1YearGrowth]
      ,[DilutedContinuousEPS3YearGrowth]
      ,[DilutedContinuousEPS5YearGrowth]
      ,[DilutedContinuousEPS10YearGrowth]
      ,[Dividend3MonthSamePeriodGrowth]
      ,[Dividend6MonthSamePeriodGrowth]
      ,[Dividend9MonthSamePeriodGrowth]
      ,[DividendSequentialGrowth]
      ,[Dividend1YearGrowth]
      ,[Dividend3YearGrowth]
      ,[Dividend5YearGrowth]
      ,[Dividend10YearGrowth]
      ,[EquityPerShare3MonthSamePeriodGrowth]
      ,[EquityPerShare6MonthSamePeriodGrowth]
      ,[EquityPerShare9MonthSamePeriodGrowth]
      ,[EquityPerShareSequentialGrowth]
      ,[EquityPerShare1YearGrowth]
      ,[EquityPerShare3YearGrowth]
      ,[EquityPerShare5YearGrowth]
      ,[EquityPerShare10YearGrowth]
      ,[Revenue3MonthSamePeriodGrowth]
      ,[Revenue6MonthSamePeriodGrowth]
      ,[Revenue9MonthSamePeriodGrowth]
      ,[RevenueSequentialGrowth]
      ,[Revenue1YearGrowth]
      ,[Revenue3YearGrowth]
      ,[Revenue5YearGrowth]
      ,[Revenue10YearGrowth]
      ,[OperatingIncome3MonthSamePeriodGrowth]
      ,[OperatingIncome6MonthSamePeriodGrowth]
      ,[OperatingIncome9MonthSamePeriodGrowth]
      ,[OperatingIncomeSequentialGrowth]
      ,[OperatingIncome1YearGrowth]
      ,[OperatingIncome3YearGrowth]
      ,[OperatingIncome5YearGrowth]
      ,[OperatingIncome10YearGrowth]
      ,[NetIncome3MonthSamePeriodGrowth]
      ,[NetIncome6MonthSamePeriodGrowth]
      ,[NetIncome9MonthSamePeriodGrowth]
      ,[NetIncomeSequentialGrowth]
      ,[NetIncome1YearGrowth]
      ,[NetIncome3YearGrowth]
      ,[NetIncome5YearGrowth]
      ,[NetIncome10YearGrowth]
      ,[NetIncomeContOps3MonthSamePeriodGrowth]
      ,[NetIncomeContOps6MonthSamePeriodGrowth]
      ,[NetIncomeContOps9MonthSamePeriodGrowth]
      ,[NetIncomeContOpsSequentialGrowth]
      ,[NetIncomeContOps1YearGrowth]
      ,[NetIncomeContOps3YearGrowth]
      ,[NetIncomeContOps5YearGrowth]
      ,[NetIncomeContOps10YearGrowth]
      ,[CFO3MonthSamePeriodGrowth]
      ,[CFO6MonthSamePeriodGrowth]
      ,[CFO9MonthSamePeriodGrowth]
      ,[CFOSequentialGrowth]
      ,[CFO1YearGrowth]
      ,[CFO3YearGrowth]
      ,[CFO5YearGrowth]
      ,[CFO10YearGrowth]
      ,[FCF3MonthSamePeriodGrowth]
      ,[FCF6MonthSamePeriodGrowth]
      ,[FCF9MonthSamePeriodGrowth]
      ,[FCFSequentialGrowth]
      ,[FCF1YearGrowth]
      ,[FCF3YearGrowth]
      ,[FCF5YearGrowth]
      ,[FCF10YearGrowth]
      ,[OperatingRevenue3MonthSamePeriodGrowth]
      ,[OperatingRevenue6MonthSamePeriodGrowth]
      ,[OperatingRevenue9MonthSamePeriodGrowth]
      ,[OperatingRevenueSequentialGrowth]
      ,[OperatingRevenue1YearGrowth]
      ,[OperatingRevenue3YearGrowth]
      ,[OperatingRevenue5YearGrowth]
      ,[OperatingRevenue10YearGrowth]
      ,[GrowthAnnCapitalSpending5Year]
      ,[GrowthAnnGrossProfit5Year]
      ,[AvgGrossMargin5Year]
      ,[AvgPostTaxMargin5Year]
      ,[AvgPreTaxMargin5Year]
      ,[AvgNetProfitMargin5Year]
      ,[AvgRetCommonEquity5Year]
      ,[AvgRetAssets5Year]
      ,[AvgRetInvestedCapital5Year]
      ,[AccessionNumber]
      ,[FormType]
      ,[RegressionGrowthOperatingRevenue5Years]
      ,[NormalizedDilutedEPSGrowth1year]
      ,[NormalizedDilutedEPSGrowth3year]
      ,[NormalizedDilutedEPSGrowth5year]
      ,[NormalizedDilutedEPSGrowth10year]
      ,[NormalizedDilutedEPSSamePeriodGrowth3months]
      ,[NormalizedDilutedEPSSamePeriodGrowth6months]
      ,[NormalizedDilutedEPSSamePeriodGrowth9months]
      ,[NormalizedDilutedEPSSequentialGrowth]
      ,[NormalizedBasicEPSGrowth1year]
      ,[NormalizedBasicEPSGrowth3year]
      ,[NormalizedBasicEPSGrowth5year]
      ,[NormalizedBasicEPSGrowth10year]
      ,[NormalizedBasicEPSSamePeriodGrowth3months]
      ,[NormalizedBasicEPSSamePeriodGrowth6months]
      ,[NormalizedBasicEPSSamePeriodGrowth9months]
      ,[NormalizedBasicEPSSequentialGrowth]) 
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
      ,[FiscalYearEnd]
      ,[DilutedEPS3MonthSamePeriodGrowth]
      ,[DilutedEPS6MonthSamePeriodGrowth]
      ,[DilutedEPS9MonthSamePeriodGrowth]
      ,[DilutedEPSSequentialGrowth]
      ,[DilutedEPS1YearGrowth]
      ,[DilutedEPS3YearGrowth]
      ,[DilutedEPS5YearGrowth]
      ,[DilutedEPS10YearGrowth]
      ,[DilutedContinuousEPS3MonthSamePeriodGrowth]
      ,[DilutedContinuousEPS6MonthSamePeriodGrowth]
      ,[DilutedContinuousEPS9MonthSamePeriodGrowth]
      ,[DilutedContinuousEPSSequentialGrowth]
      ,[DilutedContinuousEPS1YearGrowth]
      ,[DilutedContinuousEPS3YearGrowth]
      ,[DilutedContinuousEPS5YearGrowth]
      ,[DilutedContinuousEPS10YearGrowth]
      ,[Dividend3MonthSamePeriodGrowth]
      ,[Dividend6MonthSamePeriodGrowth]
      ,[Dividend9MonthSamePeriodGrowth]
      ,[DividendSequentialGrowth]
      ,[Dividend1YearGrowth]
      ,[Dividend3YearGrowth]
      ,[Dividend5YearGrowth]
      ,[Dividend10YearGrowth]
      ,[EquityPerShare3MonthSamePeriodGrowth]
      ,[EquityPerShare6MonthSamePeriodGrowth]
      ,[EquityPerShare9MonthSamePeriodGrowth]
      ,[EquityPerShareSequentialGrowth]
      ,[EquityPerShare1YearGrowth]
      ,[EquityPerShare3YearGrowth]
      ,[EquityPerShare5YearGrowth]
      ,[EquityPerShare10YearGrowth]
      ,[Revenue3MonthSamePeriodGrowth]
      ,[Revenue6MonthSamePeriodGrowth]
      ,[Revenue9MonthSamePeriodGrowth]
      ,[RevenueSequentialGrowth]
      ,[Revenue1YearGrowth]
      ,[Revenue3YearGrowth]
      ,[Revenue5YearGrowth]
      ,[Revenue10YearGrowth]
      ,[OperatingIncome3MonthSamePeriodGrowth]
      ,[OperatingIncome6MonthSamePeriodGrowth]
      ,[OperatingIncome9MonthSamePeriodGrowth]
      ,[OperatingIncomeSequentialGrowth]
      ,[OperatingIncome1YearGrowth]
      ,[OperatingIncome3YearGrowth]
      ,[OperatingIncome5YearGrowth]
      ,[OperatingIncome10YearGrowth]
      ,[NetIncome3MonthSamePeriodGrowth]
      ,[NetIncome6MonthSamePeriodGrowth]
      ,[NetIncome9MonthSamePeriodGrowth]
      ,[NetIncomeSequentialGrowth]
      ,[NetIncome1YearGrowth]
      ,[NetIncome3YearGrowth]
      ,[NetIncome5YearGrowth]
      ,[NetIncome10YearGrowth]
      ,[NetIncomeContOps3MonthSamePeriodGrowth]
      ,[NetIncomeContOps6MonthSamePeriodGrowth]
      ,[NetIncomeContOps9MonthSamePeriodGrowth]
      ,[NetIncomeContOpsSequentialGrowth]
      ,[NetIncomeContOps1YearGrowth]
      ,[NetIncomeContOps3YearGrowth]
      ,[NetIncomeContOps5YearGrowth]
      ,[NetIncomeContOps10YearGrowth]
      ,[CFO3MonthSamePeriodGrowth]
      ,[CFO6MonthSamePeriodGrowth]
      ,[CFO9MonthSamePeriodGrowth]
      ,[CFOSequentialGrowth]
      ,[CFO1YearGrowth]
      ,[CFO3YearGrowth]
      ,[CFO5YearGrowth]
      ,[CFO10YearGrowth]
      ,[FCF3MonthSamePeriodGrowth]
      ,[FCF6MonthSamePeriodGrowth]
      ,[FCF9MonthSamePeriodGrowth]
      ,[FCFSequentialGrowth]
      ,[FCF1YearGrowth]
      ,[FCF3YearGrowth]
      ,[FCF5YearGrowth]
      ,[FCF10YearGrowth]
      ,[OperatingRevenue3MonthSamePeriodGrowth]
      ,[OperatingRevenue6MonthSamePeriodGrowth]
      ,[OperatingRevenue9MonthSamePeriodGrowth]
      ,[OperatingRevenueSequentialGrowth]
      ,[OperatingRevenue1YearGrowth]
      ,[OperatingRevenue3YearGrowth]
      ,[OperatingRevenue5YearGrowth]
      ,[OperatingRevenue10YearGrowth]
      ,[GrowthAnnCapitalSpending5Year]
      ,[GrowthAnnGrossProfit5Year]
      ,[AvgGrossMargin5Year]
      ,[AvgPostTaxMargin5Year]
      ,[AvgPreTaxMargin5Year]
      ,[AvgNetProfitMargin5Year]
      ,[AvgRetCommonEquity5Year]
      ,[AvgRetAssets5Year]
      ,[AvgRetInvestedCapital5Year]
      ,[AccessionNumber]
      ,[FormType]
      ,[RegressionGrowthOperatingRevenue5Years]
      ,[NormalizedDilutedEPSGrowth1year]
      ,[NormalizedDilutedEPSGrowth3year]
      ,[NormalizedDilutedEPSGrowth5year]
      ,[NormalizedDilutedEPSGrowth10year]
      ,[NormalizedDilutedEPSSamePeriodGrowth3months]
      ,[NormalizedDilutedEPSSamePeriodGrowth6months]
      ,[NormalizedDilutedEPSSamePeriodGrowth9months]
      ,[NormalizedDilutedEPSSequentialGrowth]
      ,[NormalizedBasicEPSGrowth1year]
      ,[NormalizedBasicEPSGrowth3year]
      ,[NormalizedBasicEPSGrowth5year]
      ,[NormalizedBasicEPSGrowth10year]
      ,[NormalizedBasicEPSSamePeriodGrowth3months]
      ,[NormalizedBasicEPSSamePeriodGrowth6months]
      ,[NormalizedBasicEPSSamePeriodGrowth9months]
      ,[NormalizedBasicEPSSequentialGrowth])

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

