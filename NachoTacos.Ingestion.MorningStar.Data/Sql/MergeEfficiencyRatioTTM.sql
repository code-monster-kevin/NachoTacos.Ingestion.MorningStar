/****** Object:  StoredProcedure [dbo].[MergeEfficiencyRatioTTM]    Script Date: 1/9/2020 5:02:15 PM ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'MergeEfficiencyRatioTTM')
DROP PROCEDURE [dbo].[MergeEfficiencyRatioTTM]
GO

/****** Object:  StoredProcedure [dbo].[MergeEfficiencyRatioTTM]    Script Date: 1/9/2020 5:02:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Kevin Wu
-- Create date: 16th Jan 2020
-- Description:	Merge data from temporary job table [MStar].[TEfficiencyRatioTTM]
--				to master table [MStar].[MEfficiencyRatioTTM]
-- Example: EXECUTE MergeEfficiencyRatioTTM
--          To prevent timeout due to exceessive records of changes to merge,
--          added a limit of merging only the last 50 ingestion task,
--          Will require a recurring job to run this merge function to check of unprocessed tasks
-- =============================================
CREATE PROCEDURE MergeEfficiencyRatioTTM
AS
BEGIN
	SET NOCOUNT ON;

    DECLARE @SummaryOfChanges TABLE(Change VARCHAR(20));
	DECLARE @UnprocessedTasks TABLE (id uniqueidentifier, CreatedDate DateTime);

	INSERT INTO @UnprocessedTasks
	SELECT DISTINCT TOP 50 IT.[IngestionTaskId], IT.[CreatedDate]
	FROM [MStar].[TEfficiencyRatioTTM] CF
	JOIN [dbo].[IngestionTasks] IT ON IT.[IngestionTaskId] = CF.[IngestionTaskId]
	WHERE IT.[IsProcessed] = 0;


	MERGE INTO [MStar].[MEfficiencyRatioTTM] AS TargetTable
	USING
	(SELECT GI.[ExchangeId]
      ,GI.[CompanyName]
      ,GI.[Symbol]
      ,GI.[CUSIP]
      ,GI.[CIK]
      ,GI.[ISIN]
      ,GI.[SEDOL]
      ,GI.[ShareClassId]
	  ,ER.[ReportDate]
      ,ER.[PeriodEndingDate]
      ,ER.[FileDate]
      ,ER.[StatementType]
      ,ER.[DataType]
      ,ER.[Interim]
      ,ER.[FiscalYearEnd]
      ,ER.[DaysInSales]
      ,ER.[DaysInInventory]
      ,ER.[DaysInPayment]
      ,ER.[CashConversionCycle]
      ,ER.[ReceivableTurnover]
      ,ER.[InventoryTurnover]
      ,ER.[PayableTurnover]
      ,ER.[FixedAssetsTurnover]
      ,ER.[AssetsTurnover]
      ,ER.[ROE]
      ,ER.[ROA]
      ,ER.[ROIC]
      ,ER.[FCFSalesRatio]
      ,ER.[FCFNetIncomeRatio]
      ,ER.[CapitalExpenditureSalesRatio]
      ,ER.[AccessionNumber]
      ,ER.[FormType]
      ,ER.[ROE5YrAvg]
      ,ER.[ROA5YrAvg]
      ,ER.[AVG5YrsROIC]
      ,ER.[NormalizedROIC]
	  FROM [MStar].[TEfficiencyRatioTTM] ER
	  JOIN (SELECT DISTINCT [IngestionTaskId]
							  ,[ExchangeId]
							  ,[CompanyName]
							  ,[Symbol]
							  ,[CUSIP]
							  ,[CIK]
							  ,[ISIN]
							  ,[SEDOL]
							  ,[ShareClassId] FROM [MStar].[TGeneralInfo]) GI 
		ON GI.[IngestionTaskId] = ER.[IngestionTaskId]
	  WHERE ER.[IngestionTaskId] IN (SELECT ID FROM @UnprocessedTasks))
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
      ,[DaysInSales]
      ,[DaysInInventory]
      ,[DaysInPayment]
      ,[CashConversionCycle]
      ,[ReceivableTurnover]
      ,[InventoryTurnover]
      ,[PayableTurnover]
      ,[FixedAssetsTurnover]
      ,[AssetsTurnover]
      ,[ROE]
      ,[ROA]
      ,[ROIC]
      ,[FCFSalesRatio]
      ,[FCFNetIncomeRatio]
      ,[CapitalExpenditureSalesRatio]
      ,[AccessionNumber]
      ,[FormType]
      ,[ROE5YrAvg]
      ,[ROA5YrAvg]
      ,[AVG5YrsROIC]
      ,[NormalizedROIC])
	ON TargetTable.[ExchangeId] = SourceTable.[ExchangeId]
	AND TargetTable.[Symbol] = SourceTable.[Symbol]
    AND TargetTable.[ReportDate] = SourceTable.[ReportDate]
    AND TargetTable.[StatementType] = SourceTable.[StatementType]
    AND TargetTable.[DataType] = SourceTable.[DataType]
	AND ISNULL(TargetTable.[Interim],'') = ISNULL(SourceTable.[Interim],'')
    AND ISNULL(TargetTable.[FiscalYearEnd],'') = ISNULL(SourceTable.[FiscalYearEnd],'')

	

	WHEN NOT MATCHED BY TARGET THEN
	INSERT(
      [MEfficiencyRatioTTMId]
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
      ,[DaysInSales]
      ,[DaysInInventory]
      ,[DaysInPayment]
      ,[CashConversionCycle]
      ,[ReceivableTurnover]
      ,[InventoryTurnover]
      ,[PayableTurnover]
      ,[FixedAssetsTurnover]
      ,[AssetsTurnover]
      ,[ROE]
      ,[ROA]
      ,[ROIC]
      ,[FCFSalesRatio]
      ,[FCFNetIncomeRatio]
      ,[CapitalExpenditureSalesRatio]
      ,[AccessionNumber]
      ,[FormType]
      ,[ROE5YrAvg]
      ,[ROA5YrAvg]
      ,[AVG5YrsROIC]
      ,[NormalizedROIC]) 
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
		  ,[DaysInSales]
		  ,[DaysInInventory]
		  ,[DaysInPayment]
		  ,[CashConversionCycle]
		  ,[ReceivableTurnover]
		  ,[InventoryTurnover]
		  ,[PayableTurnover]
		  ,[FixedAssetsTurnover]
		  ,[AssetsTurnover]
		  ,[ROE]
		  ,[ROA]
		  ,[ROIC]
		  ,[FCFSalesRatio]
		  ,[FCFNetIncomeRatio]
		  ,[CapitalExpenditureSalesRatio]
		  ,[AccessionNumber]
		  ,[FormType]
		  ,[ROE5YrAvg]
		  ,[ROA5YrAvg]
		  ,[AVG5YrsROIC]
		  ,[NormalizedROIC])

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
