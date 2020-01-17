/****** Object:  StoredProcedure [dbo].[MergeEODPriceHistory]    Script Date: 1/17/2020 9:45:44 AM ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'MergeEODPriceHistory')
DROP PROCEDURE [dbo].[MergeEODPriceHistory]
GO

/****** Object:  StoredProcedure [dbo].[MergeEODPriceHistory]    Script Date: 1/17/2020 9:45:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Kevin Wu
-- Create date: 17th Jan 2020
-- Description:	Merge data from temporary job table [MStar].[TEODPriceHistory]
--				to master table [MStar].[MEODPriceHistory]
-- Example: EXECUTE MergeEODPriceHistory
--          To prevent timeout due to exceessive records of changes to merge,
--          added a limit of merging only the last 50 ingestion task,
--          Will require a recurring job to run this merge function to check of unprocessed tasks
-- =============================================
CREATE PROCEDURE [dbo].[MergeEODPriceHistory]
AS
BEGIN
	SET NOCOUNT ON;

    DECLARE @SummaryOfChanges TABLE(Change VARCHAR(20));
	DECLARE @UnprocessedTasks TABLE (id uniqueidentifier, CreatedDate DateTime);

	INSERT INTO @UnprocessedTasks
	SELECT DISTINCT TOP 50 IT.[IngestionTaskId], IT.[CreatedDate]
	FROM [MStar].[TEODPriceHistory] PH
	JOIN [dbo].[IngestionTasks] IT ON IT.[IngestionTaskId] = PH.[IngestionTaskId]
	WHERE IT.[IsProcessed] = 0;


	MERGE INTO [MStar].[MEODPriceHistory] AS TargetTable
	USING
	(SELECT GI.[ExchangeId]
      ,GI.[CompanyName]
      ,GI.[Symbol]
      ,GI.[CUSIP]
      ,GI.[CIK]
      ,GI.[ISIN]
      ,GI.[SEDOL]
      ,GI.[ShareClassId]
	  ,PH.[TradingDate]
      ,PH.[OpenPrice]
      ,PH.[HighPrice]
      ,PH.[LowPrice]
      ,PH.[ClosePrice]
      ,PH.[Volume]
      ,PH.[PriceCurrencyId]
	  FROM [MStar].[TEODPriceHistory] PH
	  JOIN (SELECT DISTINCT [IngestionTaskId]
							  ,[ExchangeId]
							  ,[CompanyName]
							  ,[Symbol]
							  ,[CUSIP]
							  ,[CIK]
							  ,[ISIN]
							  ,[SEDOL]
							  ,[ShareClassId] FROM [MStar].[TGeneralInfo]) GI 
		ON GI.[IngestionTaskId] = PH.[IngestionTaskId]
	  WHERE PH.[IngestionTaskId] IN (SELECT ID FROM @UnprocessedTasks))
	  AS SourceTable (
      [ExchangeId]
      ,[CompanyName]
      ,[Symbol]
      ,[CUSIP]
      ,[CIK]
      ,[ISIN]
      ,[SEDOL]
      ,[ShareClassId]
	  ,[TradingDate]
      ,[OpenPrice]
      ,[HighPrice]
      ,[LowPrice]
      ,[ClosePrice]
      ,[Volume]
      ,[PriceCurrencyId])
	ON TargetTable.[ExchangeId] = SourceTable.[ExchangeId]
	AND TargetTable.[Symbol] = SourceTable.[Symbol]
    AND TargetTable.[TradingDate] = SourceTable.[TradingDate]

	

	WHEN NOT MATCHED BY TARGET THEN
	INSERT(
      [MEODPriceHistoryId]
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
	  ,[TradingDate]
      ,[OpenPrice]
      ,[HighPrice]
      ,[LowPrice]
      ,[ClosePrice]
      ,[Volume]
      ,[PriceCurrencyId]) 
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
		  ,[TradingDate]
		  ,[OpenPrice]
		  ,[HighPrice]
		  ,[LowPrice]
		  ,[ClosePrice]
		  ,[Volume]
		  ,[PriceCurrencyId])

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


