
/****** Object:  StoredProcedure [dbo].[PopulateRBaseScreener]   Script Date: 1/31/2020 12:14:01 PM ******/
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'PopulateRBaseScreener')
DROP PROCEDURE [dbo].[PopulateRBaseScreener]
GO

/****** Object:  StoredProcedure [dbo].[PopulateRBaseScreener]   Script Date: 1/31/2020 12:14:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Kevin Wu
-- Create date: 31 Jan 2020
-- Description:	Sumarize and generate a base screen table for easy search and screening
-- This SP is called daily by a background service
-- Example: EXECUTE [PopulateRBaseScreener]
-- =============================================
CREATE PROCEDURE [dbo].[PopulateRBaseScreener]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @CutOffMonth AS INT = 6;

	TRUNCATE TABLE [MStar].[RBaseScreener];

	SELECT [MMonthlyMarketCapitalizationHistoryId]
			,[Symbol]
			,[MarketCapDate]
			,[MarketCap]
			,[SharesOutStanding]
			,[SharesDate]
			,[EnterpriseValue]
	INTO #TEMP_MARKETCAP
	FROM [MStar].[MMonthlyMarketCapitalizationHistory] AS MC
	WHERE [MarketCapDate] = (SELECT MAX([MarketCapDate])
							 FROM [MStar].[MMonthlyMarketCapitalizationHistory]
							 WHERE [Symbol] = MC.[Symbol])
	AND [MarketCapDate] >= DATEADD(MONTH, -@CutOffMonth, GETUTCDATE())
	ORDER BY [Symbol];

	SELECT [MValuationRatioId]
			,[Symbol]
			,[AsOfDate] AS ValuationRatioDate
			,[TotalAssetPerShare]
			,[TangibleBookValuePerShare]
			,[BookValuePerShare]
			,[SalesPerShare]
			,[CFPerShare]
			,[FCFPerShare]
			,[PriceToBook]
			,[PriceToSales]
			,[PriceToCashFlow]
			,[PriceToFreeCashFlow]
			,[PriceToEPS]
			,[PEGRatio]
			,[PricetoCashRatio]
			,[DividendYield]
			,[ForwardDividend]
			,[PayoutRatio]
			,[SustainableGrowthRate]
			,[EVToEBITDA]
	INTO #TEMP_VALUATION
	FROM [MStar].[MValuationRatio] AS VR
	WHERE [AsOfDate] = (SELECT MAX([AsOfDate])
						FROM [MStar].[MValuationRatio]
						WHERE [Symbol] = VR.[Symbol])
	AND [AsOfDate] >= DATEADD(MONTH, -@CutOffMonth, GETUTCDATE())
	ORDER BY [Symbol];

	SELECT [MQuantitativeRatingId]
			,[Symbol]
			,[AsOfDate] AS QuantRatingDate
			,[QuantitativeMoat]
			,[QuantitativeValuation]
			,[QuantitativeValuationUpdateTime]
			,[QuantitativeValuationLabelUpdateTime]
			,[QuantitativeStarRatingUpdateTime]
			,[QuantitativeFairValueUpdateTime]
			,[QuantitativeMoatLabel]
			,[QuantitativeValuationLabel]
			,[QuantitativeValuationUncertaintyLabel]
			,[QuantitativeFinancialHealthLabel]
			,[QuantitativeStarRating]
			,[QuantitativeFairValue]
	INTO #TEMP_QUANTRATING
	FROM [MStar].[MQuantitativeRating] QR
	WHERE [AsOfDate] = (SELECT MAX([AsOfDate])
						FROM [MStar].[MQuantitativeRating]
						WHERE [Symbol] = QR.[Symbol])
	AND [AsOfDate] >= DATEADD(MONTH, -@CutOffMonth, GETUTCDATE())
	ORDER BY [Symbol];

	INSERT INTO [MStar].[RBaseScreener]
           ([Id]
           ,[CompanyName]
           ,[Symbol]
           ,[SectorName]
           ,[IndustryGroupName]
           ,[IndustryName]
           ,[MarketCapDate]
           ,[MarketCap]
           ,[SharesOutStanding]
           ,[SharesDate]
           ,[EnterpriseValue]
           ,[ValuationRatioDate]
           ,[TotalAssetPerShare]
           ,[TangibleBookValuePerShare]
           ,[BookValuePerShare]
           ,[SalesPerShare]
           ,[CFPerShare]
           ,[FCFPerShare]
           ,[PriceToBook]
           ,[PriceToSales]
           ,[PriceToCashFlow]
           ,[PriceToFreeCashFlow]
           ,[PriceToEPS]
           ,[PEGRatio]
           ,[PricetoCashRatio]
           ,[DividendYield]
           ,[ForwardDividend]
           ,[PayoutRatio]
           ,[SustainableGrowthRate]
           ,[EVToEBITDA]
           ,[QuantRatingDate]
           ,[QuantitativeMoat]
           ,[QuantitativeValuation]
           ,[QuantitativeValuationUpdateTime]
           ,[QuantitativeValuationLabelUpdateTime]
           ,[QuantitativeStarRatingUpdateTime]
           ,[QuantitativeFairValueUpdateTime]
           ,[QuantitativeMoatLabel]
           ,[QuantitativeValuationLabel]
           ,[QuantitativeValuationUncertaintyLabel]
           ,[QuantitativeFinancialHealthLabel]
           ,[QuantitativeStarRating]
           ,[QuantitativeFairValue])
	SELECT NEWID() AS [Id]
		   ,SEC.[CompanyName]
		   ,SEC.[Symbol]
		   ,CFA.[SectorName]
		   ,CFA.[IndustryGroupName]
		   ,CFA.[IndustryName]
		   ,MC.[MarketCapDate]
		   ,MC.[MarketCap]
		   ,MC.[SharesOutStanding]
		   ,MC.[SharesDate]
		   ,MC.[EnterpriseValue]
		   ,V.[ValuationRatioDate]
		   ,V.[TotalAssetPerShare]
		   ,V.[TangibleBookValuePerShare]
		   ,V.[BookValuePerShare]
		   ,V.[SalesPerShare]
		   ,V.[CFPerShare]
		   ,V.[FCFPerShare]
		   ,V.[PriceToBook]
		   ,V.[PriceToSales]
		   ,V.[PriceToCashFlow]
		   ,V.[PriceToFreeCashFlow]
		   ,V.[PriceToEPS]
		   ,V.[PEGRatio]
		   ,V.[PricetoCashRatio]
		   ,V.[DividendYield]
		   ,V.[ForwardDividend]
		   ,V.[PayoutRatio]
		   ,V.[SustainableGrowthRate]
		   ,V.[EVToEBITDA]
		   ,QR.[QuantRatingDate]
		   ,QR.[QuantitativeMoat]
		   ,QR.[QuantitativeValuation]
		   ,QR.[QuantitativeValuationUpdateTime]
		   ,QR.[QuantitativeValuationLabelUpdateTime]
		   ,QR.[QuantitativeStarRatingUpdateTime]
		   ,QR.[QuantitativeFairValueUpdateTime]
		   ,QR.[QuantitativeMoatLabel]
		   ,QR.[QuantitativeValuationLabel]
		   ,QR.[QuantitativeValuationUncertaintyLabel]
		   ,QR.[QuantitativeFinancialHealthLabel]
		   ,QR.[QuantitativeStarRating]
		   ,QR.[QuantitativeFairValue]
	FROM [MStar].[MStockExchangeSecurity] SEC
	LEFT JOIN [MStar].[MCompanyFinancialAvailability] CFA
		ON CFA.[Symbol] = SEC.[Symbol]
	LEFT JOIN #TEMP_MARKETCAP MC
		ON MC.[Symbol] = SEC.[Symbol]
	LEFT JOIN #TEMP_VALUATION V
		ON V.[Symbol] = SEC.[Symbol]
	LEFT JOIN #TEMP_QUANTRATING QR
		ON QR.[Symbol] = SEC.[Symbol]
	WHERE SEC.[StockStatus] = 'Active';

	DROP TABLE #TEMP_MARKETCAP;
	DROP TABLE #TEMP_VALUATION;
	DROP TABLE #TEMP_QUANTRATING;
END
GO
