/*
SQL Script to merge Temporary tables to Mastar Tables
*/

DECLARE @SummaryOfChanges TABLE(Change VARCHAR(20));
DECLARE @TaskId AS uniqueidentifier
SET @TaskId ='EA4098E0-3727-4ED3-91D8-2F34FB720D74';

MERGE INTO [IngestionDb].[MStar].[MStockExchangeSecurity] AS Target
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
  FROM [IngestionDb].[MStar].[TStockExchangeSecurity]
  WHERE IngestionTaskId=@TaskId)
  AS Source ([ExchangeId]
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
ON Target.[ExchangeId] = Source.[ExchangeId]
AND Target.[Symbol] = Source.[Symbol]

WHEN MATCHED THEN
UPDATE SET 
[StockStatus] = Source.[StockStatus],
[DelistingDate] = Source.[DelistingDate],
[DelistingReason] = Source.[DelistingReason],
[ParValue] = Source.[ParValue],
[SuspendedFlag] = Source.[SuspendedFlag],
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

-- Query the results of the table variable.  
SELECT Change, COUNT(*) AS CountPerChange  
FROM @SummaryOfChanges  
GROUP BY Change;