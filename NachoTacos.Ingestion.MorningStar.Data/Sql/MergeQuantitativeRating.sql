/****** Object:  StoredProcedure [dbo].[MergeQuantitativeRating]    Script Date: 1/17/2020 9:45:44 AM ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'MergeQuantitativeRating')
DROP PROCEDURE [dbo].[MergeQuantitativeRating]
GO

/****** Object:  StoredProcedure [dbo].[MergeQuantitativeRating]    Script Date: 1/17/2020 9:45:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Kevin Wu
-- Create date: 17th Jan 2020
-- Description:	Merge data from temporary job table [MStar].[TQuantitativeRating]
--				to master table [MStar].[MQuantitativeRating]
-- Example: EXECUTE MergeQuantitativeRating
--          To prevent timeout due to exceessive records of changes to merge,
--          added a limit of merging only the last 50 ingestion task,
--          Will require a recurring job to run this merge function to check of unprocessed tasks
-- =============================================
CREATE PROCEDURE [dbo].[MergeQuantitativeRating]
AS
BEGIN
	SET NOCOUNT ON;

    DECLARE @SummaryOfChanges TABLE(Change VARCHAR(20));
	DECLARE @UnprocessedTasks TABLE (id uniqueidentifier, CreatedDate DateTime);

	INSERT INTO @UnprocessedTasks
	SELECT DISTINCT TOP 50 IT.[IngestionTaskId], IT.[CreatedDate]
	FROM [MStar].[TQuantitativeRating] QR
	JOIN [dbo].[IngestionTasks] IT ON IT.[IngestionTaskId] = QR.[IngestionTaskId]
	WHERE IT.[IsProcessed] = 0;


	MERGE INTO [MStar].[MQuantitativeRating] AS TargetTable
	USING
	(SELECT GI.[ExchangeId]
      ,GI.[CompanyName]
      ,GI.[Symbol]
      ,GI.[CUSIP]
      ,GI.[CIK]
      ,GI.[ISIN]
      ,GI.[SEDOL]
      ,GI.[ShareClassId]
	  ,QR.[AsOfDate]
      ,QR.[QuantitativeMoat]
      ,QR.[QuantitativeMoatLabel]
      ,QR.[QuantitativeValuation]
      ,QR.[QuantitativeValuationUpdateTime]
      ,QR.[QuantitativeValuationLabel]
      ,QR.[QuantitativeValuationLabelUpdateTime]
      ,QR.[QuantitativeValuationUncertainty]
      ,QR.[QuantitativeValuationUncertaintyLabel]
      ,QR.[QuantitativeFinancialHealth]
      ,QR.[QuantitativeFinancialHealthLabel]
      ,QR.[SolvencyScore]
      ,QR.[QuantitativeFinancialHealthDecile]
      ,QR.[QuantitativeStarRating]
      ,QR.[QuantitativeStarRatingUpdateTime]
      ,QR.[QuantitativeFairValue]
      ,QR.[QuantitativeFairValueUpdateTime]
	  FROM [MStar].[TQuantitativeRating] QR
	  JOIN (SELECT DISTINCT [IngestionTaskId]
							  ,[ExchangeId]
							  ,[CompanyName]
							  ,[Symbol]
							  ,[CUSIP]
							  ,[CIK]
							  ,[ISIN]
							  ,[SEDOL]
							  ,[ShareClassId] FROM [MStar].[TGeneralInfo]) GI 
		ON GI.[IngestionTaskId] = QR.[IngestionTaskId]
	  WHERE QR.[IngestionTaskId] IN (SELECT ID FROM @UnprocessedTasks))
	  AS SourceTable (
      [ExchangeId]
      ,[CompanyName]
      ,[Symbol]
      ,[CUSIP]
      ,[CIK]
      ,[ISIN]
      ,[SEDOL]
      ,[ShareClassId]
	  ,[AsOfDate]
      ,[QuantitativeMoat]
      ,[QuantitativeMoatLabel]
      ,[QuantitativeValuation]
      ,[QuantitativeValuationUpdateTime]
      ,[QuantitativeValuationLabel]
      ,[QuantitativeValuationLabelUpdateTime]
      ,[QuantitativeValuationUncertainty]
      ,[QuantitativeValuationUncertaintyLabel]
      ,[QuantitativeFinancialHealth]
      ,[QuantitativeFinancialHealthLabel]
      ,[SolvencyScore]
      ,[QuantitativeFinancialHealthDecile]
      ,[QuantitativeStarRating]
      ,[QuantitativeStarRatingUpdateTime]
      ,[QuantitativeFairValue]
      ,[QuantitativeFairValueUpdateTime])
	ON TargetTable.[ExchangeId] = SourceTable.[ExchangeId]
	AND TargetTable.[Symbol] = SourceTable.[Symbol]
    AND TargetTable.[AsOfDate] = SourceTable.[AsOfDate]
	

	WHEN NOT MATCHED BY TARGET THEN
	INSERT(
      [MQuantitativeRatingId]
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
	  ,[AsOfDate]
      ,[QuantitativeMoat]
      ,[QuantitativeMoatLabel]
      ,[QuantitativeValuation]
      ,[QuantitativeValuationUpdateTime]
      ,[QuantitativeValuationLabel]
      ,[QuantitativeValuationLabelUpdateTime]
      ,[QuantitativeValuationUncertainty]
      ,[QuantitativeValuationUncertaintyLabel]
      ,[QuantitativeFinancialHealth]
      ,[QuantitativeFinancialHealthLabel]
      ,[SolvencyScore]
      ,[QuantitativeFinancialHealthDecile]
      ,[QuantitativeStarRating]
      ,[QuantitativeStarRatingUpdateTime]
      ,[QuantitativeFairValue]
      ,[QuantitativeFairValueUpdateTime]) 
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
		  ,[AsOfDate]
		  ,[QuantitativeMoat]
		  ,[QuantitativeMoatLabel]
		  ,[QuantitativeValuation]
		  ,[QuantitativeValuationUpdateTime]
		  ,[QuantitativeValuationLabel]
		  ,[QuantitativeValuationLabelUpdateTime]
		  ,[QuantitativeValuationUncertainty]
		  ,[QuantitativeValuationUncertaintyLabel]
		  ,[QuantitativeFinancialHealth]
		  ,[QuantitativeFinancialHealthLabel]
		  ,[SolvencyScore]
		  ,[QuantitativeFinancialHealthDecile]
		  ,[QuantitativeStarRating]
		  ,[QuantitativeStarRatingUpdateTime]
		  ,[QuantitativeFairValue]
		  ,[QuantitativeFairValueUpdateTime])

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


