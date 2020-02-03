CREATE TABLE [MStar].[RBaseScreener] (
    [Id] uniqueidentifier NOT NULL,
    [CompanyName] nvarchar(max) NULL,
    [Symbol] nvarchar(max) NULL,
    [SectorName] nvarchar(max) NULL,
    [IndustryGroupName] nvarchar(max) NULL,
    [IndustryName] nvarchar(max) NULL,
    [MarketCapDate] datetime2 NULL,
    [MarketCap] bigint NULL,
    [SharesOutStanding] bigint NULL,
    [SharesDate] datetime2 NULL,
    [EnterpriseValue] bigint NULL,
    [ValuationRatioDate] datetime2 NULL,
    [TotalAssetPerShare] decimal(18, 2) NULL,
    [TangibleBookValuePerShare] decimal(18, 2) NULL,
    [BookValuePerShare] decimal(18, 2) NULL,
    [SalesPerShare] decimal(18, 2) NULL,
    [CFPerShare] decimal(18, 2) NULL,
    [FCFPerShare] decimal(18, 2) NULL,
    [PriceToBook] decimal(18, 2) NULL,
    [PriceToSales] decimal(18, 2) NULL,
    [PriceToCashFlow] decimal(18, 2) NULL,
    [PriceToFreeCashFlow] decimal(18, 2) NULL,
    [PriceToEPS] decimal(18, 2) NULL,
    [PEGRatio] decimal(18, 2) NULL,
    [PricetoCashRatio] decimal(18, 2) NULL,
    [DividendYield] decimal(18, 2) NULL,
    [ForwardDividend] decimal(18, 2) NULL,
    [PayoutRatio] decimal(18, 2) NULL,
    [SustainableGrowthRate] decimal(18, 2) NULL,
    [EVToEBITDA] decimal(18, 2) NULL,
    [QuantRatingDate] datetime2 NULL,
    [QuantitativeMoat] decimal(18, 2) NULL,
    [QuantitativeValuation] decimal(18, 2) NULL,
    [QuantitativeValuationUpdateTime] datetime2 NULL,
    [QuantitativeValuationLabelUpdateTime] datetime2 NULL,
    [QuantitativeStarRatingUpdateTime] datetime2 NULL,
    [QuantitativeFairValueUpdateTime] datetime2 NULL,
    [QuantitativeMoatLabel] nvarchar(max) NULL,
    [QuantitativeValuationLabel] nvarchar(max) NULL,
    [QuantitativeValuationUncertaintyLabel] nvarchar(max) NULL,
    [QuantitativeFinancialHealthLabel] nvarchar(max) NULL,
    [QuantitativeStarRating] int NULL,
    [QuantitativeFairValue] decimal(18, 2) NULL,
    CONSTRAINT [PK_RBaseScreener] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200131072959_add-tbl-rbscrnr', N'3.1.0');

GO

