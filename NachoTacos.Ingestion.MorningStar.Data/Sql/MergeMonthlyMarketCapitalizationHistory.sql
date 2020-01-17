/****** Object:  StoredProcedure [dbo].[MergeMonthlyMarketCapitalizationHistory]    Script Date: 1/17/2020 9:45:44 AM ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'MergeMonthlyMarketCapitalizationHistory')
DROP PROCEDURE [dbo].[MergeMonthlyMarketCapitalizationHistory]
GO

/****** Object:  StoredProcedure [dbo].[MergeMonthlyMarketCapitalizationHistory]    Script Date: 1/17/2020 9:45:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Kevin Wu
-- Create date: 17th Jan 2020
-- Description:	Merge data from temporary job table [MStar].[TMonthlyMarketCapitalizationHistory]
--				to master table [MStar].[MMonthlyMarketCapitalizationHistory]
-- Example: EXECUTE MergeMonthlyMarketCapitalizationHistory
--          To prevent timeout due to exceessive records of changes to merge,
--          added a limit of merging only the last 50 ingestion task,
--          Will require a recurring job to run this merge function to check of unprocessed tasks
-- =============================================
CREATE PROCEDURE [dbo].[MergeMonthlyMarketCapitalizationHistory]
AS
BEGIN
	SET NOCOUNT ON;

    DECLARE @SummaryOfChanges TABLE(Change VARCHAR(20));
	DECLARE @UnprocessedTasks TABLE (id uniqueidentifier, CreatedDate DateTime);

	INSERT INTO @UnprocessedTasks
	SELECT DISTINCT TOP 50 IT.[IngestionTaskId], IT.[CreatedDate]
	FROM [MStar].[TMonthlyMarketCapitalizationHistory] MC
	JOIN [dbo].[IngestionTasks] IT ON IT.[IngestionTaskId] = MC.[IngestionTaskId]
	WHERE IT.[IsProcessed] = 0;


	MERGE INTO [MStar].[MMonthlyMarketCapitalizationHistory] AS TargetTable
	USING
	(SELECT GI.[ExchangeId]
      ,GI.[CompanyName]
      ,GI.[Symbol]
      ,GI.[CUSIP]
      ,GI.[CIK]
      ,GI.[ISIN]
      ,GI.[SEDOL]
      ,GI.[ShareClassId]
	  ,MC.[MarketCapDate]
      ,MC.[MarketCap]
      ,MC.[EnterpriseValue]
      ,MC.[CurrencyId]
      ,MC.[SharesOutstanding]
      ,MC.[SharesDate]
	  FROM [MStar].[TMonthlyMarketCapitalizationHistory] MC
	  JOIN (SELECT DISTINCT [IngestionTaskId]
							  ,[ExchangeId]
							  ,[CompanyName]
							  ,[Symbol]
							  ,[CUSIP]
							  ,[CIK]
							  ,[ISIN]
							  ,[SEDOL]
							  ,[ShareClassId] FROM [MStar].[TGeneralInfo]) GI 
		ON GI.[IngestionTaskId] = MC.[IngestionTaskId]
	  WHERE MC.[IngestionTaskId] IN (SELECT ID FROM @UnprocessedTasks))
	  AS SourceTable (
      [ExchangeId]
      ,[CompanyName]
      ,[Symbol]
      ,[CUSIP]
      ,[CIK]
      ,[ISIN]
      ,[SEDOL]
      ,[ShareClassId]
	  ,[MarketCapDate]
      ,[MarketCap]
      ,[EnterpriseValue]
      ,[CurrencyId]
      ,[SharesOutstanding]
      ,[SharesDate])
	ON TargetTable.[ExchangeId] = SourceTable.[ExchangeId]
	AND TargetTable.[Symbol] = SourceTable.[Symbol]
    AND TargetTable.[MarketCapDate] = SourceTable.[MarketCapDate]
    AND TargetTable.[MarketCap] = SourceTable.[MarketCap]
	

	WHEN NOT MATCHED BY TARGET THEN
	INSERT(
      [MMonthlyMarketCapitalizationHistoryId]
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
	  ,[MarketCapDate]
      ,[MarketCap]
      ,[EnterpriseValue]
      ,[CurrencyId]
      ,[SharesOutstanding]
      ,[SharesDate]) 
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
		  ,[MarketCapDate]
		  ,[MarketCap]
		  ,[EnterpriseValue]
		  ,[CurrencyId]
		  ,[SharesOutstanding]
		  ,[SharesDate])

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


