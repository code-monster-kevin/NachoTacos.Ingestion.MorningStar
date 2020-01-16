/****** Object:  StoredProcedure [dbo].[MergeProfitabilityRatio]    Script Date: 1/9/2020 5:02:15 PM ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'MergeProfitabilityRatio')
DROP PROCEDURE [dbo].[MergeProfitabilityRatio]
GO

/****** Object:  StoredProcedure [dbo].[MergeProfitabilityRatio]    Script Date: 1/9/2020 5:02:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Kevin Wu
-- Create date: 16th Jan 2020
-- Description:	Merge data from temporary job table [MStar].[TProfitabilityRatio]
--				to master table [MStar].[MProfitabilityRatio]
-- Example: EXECUTE MergeProfitabilityRatio
--          To prevent timeout due to exceessive records of changes to merge,
--          added a limit of merging only the last 50 ingestion task,
--          Will require a recurring job to run this merge function to check of unprocessed tasks
-- =============================================
CREATE PROCEDURE MergeProfitabilityRatio
AS
BEGIN
	SET NOCOUNT ON;

    DECLARE @SummaryOfChanges TABLE(Change VARCHAR(20));
	DECLARE @UnprocessedTasks TABLE (id uniqueidentifier, CreatedDate DateTime);

	INSERT INTO @UnprocessedTasks
	SELECT DISTINCT TOP 50 IT.[IngestionTaskId], IT.[CreatedDate]
	FROM [MStar].[TProfitabilityRatio] CF
	JOIN [dbo].[IngestionTasks] IT ON IT.[IngestionTaskId] = CF.[IngestionTaskId]
	WHERE IT.[IsProcessed] = 0;


	MERGE INTO [MStar].[MProfitabilityRatio] AS TargetTable
	USING
	(SELECT GI.[ExchangeId]
      ,GI.[CompanyName]
      ,GI.[Symbol]
      ,GI.[CUSIP]
      ,GI.[CIK]
      ,GI.[ISIN]
      ,GI.[SEDOL]
      ,GI.[ShareClassId]
	  ,PR.[ReportDate]
      ,PR.[PeriodEndingDate]
      ,PR.[FileDate]
      ,PR.[StatementType]
      ,PR.[DataType]
      ,PR.[Interim]
      ,PR.[CurrencyId]
      ,PR.[FiscalYearEnd]
      ,PR.[GrossMargin]
      ,PR.[OperatingMargin]
      ,PR.[EBTMargin]
      ,PR.[TaxRate]
      ,PR.[NetMargin]
      ,PR.[SalesPerEmployee]
      ,PR.[EBITMargin]
      ,PR.[EBITDAMargin]
      ,PR.[NormalizedNetProfitMargin]
      ,PR.[InterestCoverage]
      ,PR.[NetIncomeperFullTimeEmployee]
      ,PR.[IncPerEmployeeTotOps]
      ,PR.[SolvencyRatio]
      ,PR.[ExpenseRatio]
      ,PR.[LossRatio]
      ,PR.[AccessionNumber]
      ,PR.[FormType]
	  FROM [MStar].[TProfitabilityRatio] PR
	  JOIN (SELECT DISTINCT [IngestionTaskId]
							  ,[ExchangeId]
							  ,[CompanyName]
							  ,[Symbol]
							  ,[CUSIP]
							  ,[CIK]
							  ,[ISIN]
							  ,[SEDOL]
							  ,[ShareClassId] FROM [MStar].[TGeneralInfo]) GI 
		ON GI.[IngestionTaskId] = PR.[IngestionTaskId]
	  WHERE PR.[IngestionTaskId] IN (SELECT ID FROM @UnprocessedTasks))
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
      ,[GrossMargin]
      ,[OperatingMargin]
      ,[EBTMargin]
      ,[TaxRate]
      ,[NetMargin]
      ,[SalesPerEmployee]
      ,[EBITMargin]
      ,[EBITDAMargin]
      ,[NormalizedNetProfitMargin]
      ,[InterestCoverage]
      ,[NetIncomeperFullTimeEmployee]
      ,[IncPerEmployeeTotOps]
      ,[SolvencyRatio]
      ,[ExpenseRatio]
      ,[LossRatio]
      ,[AccessionNumber]
      ,[FormType])
	ON TargetTable.[ExchangeId] = SourceTable.[ExchangeId]
	AND TargetTable.[Symbol] = SourceTable.[Symbol]
    AND TargetTable.[ReportDate] = SourceTable.[ReportDate]
    AND TargetTable.[StatementType] = SourceTable.[StatementType]
    AND TargetTable.[DataType] = SourceTable.[DataType]
	AND ISNULL(TargetTable.[Interim],'') = ISNULL(SourceTable.[Interim],'')
    AND ISNULL(TargetTable.[FiscalYearEnd],'') = ISNULL(SourceTable.[FiscalYearEnd],'')

	

	WHEN NOT MATCHED BY TARGET THEN
	INSERT(
      [MProfitabilityRatioId]
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
      ,[GrossMargin]
      ,[OperatingMargin]
      ,[EBTMargin]
      ,[TaxRate]
      ,[NetMargin]
      ,[SalesPerEmployee]
      ,[EBITMargin]
      ,[EBITDAMargin]
      ,[NormalizedNetProfitMargin]
      ,[InterestCoverage]
      ,[NetIncomeperFullTimeEmployee]
      ,[IncPerEmployeeTotOps]
      ,[SolvencyRatio]
      ,[ExpenseRatio]
      ,[LossRatio]
      ,[AccessionNumber]
      ,[FormType]
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
		  ,[GrossMargin]
		  ,[OperatingMargin]
		  ,[EBTMargin]
		  ,[TaxRate]
		  ,[NetMargin]
		  ,[SalesPerEmployee]
		  ,[EBITMargin]
		  ,[EBITDAMargin]
		  ,[NormalizedNetProfitMargin]
		  ,[InterestCoverage]
		  ,[NetIncomeperFullTimeEmployee]
		  ,[IncPerEmployeeTotOps]
		  ,[SolvencyRatio]
		  ,[ExpenseRatio]
		  ,[LossRatio]
		  ,[AccessionNumber]
		  ,[FormType])

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
