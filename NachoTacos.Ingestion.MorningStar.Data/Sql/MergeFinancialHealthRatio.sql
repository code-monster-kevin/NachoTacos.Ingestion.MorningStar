/****** Object:  StoredProcedure [dbo].[MergeFinancialHealthRatio]    Script Date: 1/17/2020 9:45:44 AM ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'MergeFinancialHealthRatio')
DROP PROCEDURE [dbo].[MergeFinancialHealthRatio]
GO

/****** Object:  StoredProcedure [dbo].[MergeFinancialHealthRatio]    Script Date: 1/17/2020 9:45:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Kevin Wu
-- Create date: 17th Jan 2020
-- Description:	Merge data from temporary job table [MStar].[TFinancialHealthRatio]
--				to master table [MStar].[MFinancialHealthRatio]
-- Example: EXECUTE MergeFinancialHealthRatio
--          To prevent timeout due to exceessive records of changes to merge,
--          added a limit of merging only the last 50 ingestion task,
--          Will require a recurring job to run this merge function to check of unprocessed tasks
-- =============================================
CREATE PROCEDURE [dbo].[MergeFinancialHealthRatio]
AS
BEGIN
	SET NOCOUNT ON;

    DECLARE @SummaryOfChanges TABLE(Change VARCHAR(20));
	DECLARE @UnprocessedTasks TABLE (id uniqueidentifier, CreatedDate DateTime);

	INSERT INTO @UnprocessedTasks
	SELECT DISTINCT TOP 50 IT.[IngestionTaskId], IT.[CreatedDate]
	FROM [MStar].[TFinancialHealthRatio] CF
	JOIN [dbo].[IngestionTasks] IT ON IT.[IngestionTaskId] = CF.[IngestionTaskId]
	WHERE IT.[IsProcessed] = 0;


	MERGE INTO [MStar].[MFinancialHealthRatio] AS TargetTable
	USING
	(SELECT GI.[ExchangeId]
      ,GI.[CompanyName]
      ,GI.[Symbol]
      ,GI.[CUSIP]
      ,GI.[CIK]
      ,GI.[ISIN]
      ,GI.[SEDOL]
      ,GI.[ShareClassId]
	  ,FHR.[ReportDate]
      ,FHR.[PeriodEndingDate]
      ,FHR.[FileDate]
      ,FHR.[StatementType]
      ,FHR.[DataType]
      ,FHR.[Interim]
      ,FHR.[FiscalYearEnd]
      ,FHR.[CurrentRatio]
      ,FHR.[QuickRatio]
      ,FHR.[DebtTotalCapitalRatio]
      ,FHR.[DebtEquityRatio]
      ,FHR.[FinancialLeverage]
      ,FHR.[TotalDebtToEquity]
      ,FHR.[AccessionNumber]
      ,FHR.[FormType]
      ,FHR.[DebttoAssets]
      ,FHR.[CommonEquityToAssets]
	  FROM [MStar].[TFinancialHealthRatio] FHR
	  JOIN (SELECT DISTINCT [IngestionTaskId]
							  ,[ExchangeId]
							  ,[CompanyName]
							  ,[Symbol]
							  ,[CUSIP]
							  ,[CIK]
							  ,[ISIN]
							  ,[SEDOL]
							  ,[ShareClassId] FROM [MStar].[TGeneralInfo]) GI 
		ON GI.[IngestionTaskId] = FHR.[IngestionTaskId]
	  WHERE FHR.[IngestionTaskId] IN (SELECT ID FROM @UnprocessedTasks))
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
      ,[CurrentRatio]
      ,[QuickRatio]
      ,[DebtTotalCapitalRatio]
      ,[DebtEquityRatio]
      ,[FinancialLeverage]
      ,[TotalDebtToEquity]
      ,[AccessionNumber]
      ,[FormType]
      ,[DebttoAssets]
      ,[CommonEquityToAssets])
	ON TargetTable.[ExchangeId] = SourceTable.[ExchangeId]
	AND TargetTable.[Symbol] = SourceTable.[Symbol]
    AND TargetTable.[ReportDate] = SourceTable.[ReportDate]
    AND TargetTable.[StatementType] = SourceTable.[StatementType]
    AND TargetTable.[DataType] = SourceTable.[DataType]
	AND ISNULL(TargetTable.[Interim],'') = ISNULL(SourceTable.[Interim],'')
    AND ISNULL(TargetTable.[FiscalYearEnd],'') = ISNULL(SourceTable.[FiscalYearEnd],'')

	

	WHEN NOT MATCHED BY TARGET THEN
	INSERT(
      [MFinancialHealthRatioId]
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
      ,[CurrentRatio]
      ,[QuickRatio]
      ,[DebtTotalCapitalRatio]
      ,[DebtEquityRatio]
      ,[FinancialLeverage]
      ,[TotalDebtToEquity]
      ,[AccessionNumber]
      ,[FormType]
      ,[DebttoAssets]
      ,[CommonEquityToAssets]) 
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
		  ,[CurrentRatio]
		  ,[QuickRatio]
		  ,[DebtTotalCapitalRatio]
		  ,[DebtEquityRatio]
		  ,[FinancialLeverage]
		  ,[TotalDebtToEquity]
		  ,[AccessionNumber]
		  ,[FormType]
		  ,[DebttoAssets]
		  ,[CommonEquityToAssets])

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


