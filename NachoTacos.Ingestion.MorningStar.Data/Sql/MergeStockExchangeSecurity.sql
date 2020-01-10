/****** Object:  StoredProcedure [dbo].[MergeStockExchangeSecurity]    Script Date: 1/9/2020 5:02:15 PM ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'MergeStockExchangeSecurity')
DROP PROCEDURE [dbo].MergeStockExchangeSecurity
GO

/****** Object:  StoredProcedure [dbo].[MergeStockExchangeSecurity]    Script Date: 1/9/2020 5:02:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Kevin Wu
-- Create date: 6th Jan 2020
-- Description:	Merge data from temporary job table [MStar].[TStockExchangeSecurity]
--				to master table [MStar].[MStockExchangeSecurity]
-- Example: EXECUTE MergeStockExchangeSecurity @TaskId='83156B67-F362-42C9-8E43-A9663FBA7E8E'
-- =============================================
CREATE PROCEDURE MergeStockExchangeSecurity 
	-- Add the parameters for the stored procedure here
	@TaskId AS UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;

    DECLARE @SummaryOfChanges TABLE(Change VARCHAR(20));

	MERGE INTO [MStar].[MStockExchangeSecurity] AS TargetTable
	USING
	(SELECT [ExchangeId]
		  ,[CompanyName]
		  ,[Symbol]
		  ,[CUSIP]
		  ,[CIK]
		  ,[ISIN]
		  ,[SEDOL]
		  ,[InvestmentTypeId]
		  ,[StockStatus]
		  ,[DelistingDate]
		  ,[DelistingReason]
		  ,[ExchangeSubMarketGlobalId]
		  ,[ParValue]
		  ,[SuspendedFlag]
	  FROM [MStar].[TStockExchangeSecurity]
	  WHERE IngestionTaskId=@TaskId)
	  AS SourceTable ([ExchangeId]
		  ,[CompanyName]
		  ,[Symbol]
		  ,[CUSIP]
		  ,[CIK]
		  ,[ISIN]
		  ,[SEDOL]
		  ,[InvestmentTypeId]
		  ,[StockStatus]
		  ,[DelistingDate]
		  ,[DelistingReason]
		  ,[ExchangeSubMarketGlobalId]
		  ,[ParValue]
		  ,[SuspendedFlag])
	ON TargetTable.[ExchangeId] = SourceTable.[ExchangeId]
	AND TargetTable.[Symbol] = SourceTable.[Symbol]

	WHEN MATCHED THEN
	UPDATE SET 
	[StockStatus] = SourceTable.[StockStatus],
	[DelistingDate] = SourceTable.[DelistingDate],
	[DelistingReason] = SourceTable.[DelistingReason],
	[ParValue] = SourceTable.[ParValue],
	[SuspendedFlag] = SourceTable.[SuspendedFlag],
	[UpdatedDate] = GETUTCDATE()

	WHEN NOT MATCHED BY TARGET THEN
	INSERT([MStockExchangeSecurityId]
		  ,[CreatedDate]
		  ,[UpdatedDate]
		  ,[ExchangeId]
		  ,[CompanyName]
		  ,[Symbol]
		  ,[CUSIP]
		  ,[CIK]
		  ,[ISIN]
		  ,[SEDOL]
		  ,[InvestmentTypeId]
		  ,[StockStatus]
		  ,[DelistingDate]
		  ,[DelistingReason]
		  ,[ExchangeSubMarketGlobalId]
		  ,[ParValue]
		  ,[SuspendedFlag]) 
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
		  ,[InvestmentTypeId]
		  ,[StockStatus]
		  ,[DelistingDate]
		  ,[DelistingReason]
		  ,[ExchangeSubMarketGlobalId]
		  ,[ParValue]
		  ,[SuspendedFlag])
	OUTPUT $action INTO @SummaryOfChanges;

	UPDATE [dbo].[IngestionTasks]
	SET IsProcessed = 1
	WHERE IngestionTaskId = @TaskId;

	-- Query the results of the table variable.  
	SELECT Change, COUNT(*) AS CountPerChange  
	FROM @SummaryOfChanges  
	GROUP BY Change;

END
GO
