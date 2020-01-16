CREATE TABLE [MStar].[MEfficiencyRatio] (
    [MEfficiencyRatioId] uniqueidentifier NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [UpdatedDate] datetime2 NOT NULL,
    [ExchangeId] nvarchar(max) NULL,
    [CompanyName] nvarchar(max) NULL,
    [Symbol] nvarchar(max) NULL,
    [CUSIP] nvarchar(max) NULL,
    [CIK] nvarchar(max) NULL,
    [ISIN] nvarchar(max) NULL,
    [SEDOL] nvarchar(max) NULL,
    [ShareClassId] nvarchar(max) NULL,
    [ReportDate] nvarchar(max) NULL,
    [PeriodEndingDate] nvarchar(max) NULL,
    [FileDate] nvarchar(max) NULL,
    [StatementType] nvarchar(max) NULL,
    [DataType] nvarchar(max) NULL,
    [Interim] nvarchar(max) NULL,
    [FiscalYearEnd] nvarchar(max) NULL,
    [DaysInSales] nvarchar(max) NULL,
    [DaysInInventory] nvarchar(max) NULL,
    [DaysInPayment] nvarchar(max) NULL,
    [CashConversionCycle] nvarchar(max) NULL,
    [ReceivableTurnover] nvarchar(max) NULL,
    [InventoryTurnover] nvarchar(max) NULL,
    [PayableTurnover] nvarchar(max) NULL,
    [FixedAssetsTurnover] nvarchar(max) NULL,
    [AssetsTurnover] nvarchar(max) NULL,
    [ROE] nvarchar(max) NULL,
    [ROA] nvarchar(max) NULL,
    [ROIC] nvarchar(max) NULL,
    [FCFSalesRatio] nvarchar(max) NULL,
    [FCFNetIncomeRatio] nvarchar(max) NULL,
    [CapitalExpenditureSalesRatio] nvarchar(max) NULL,
    [AccessionNumber] nvarchar(max) NULL,
    [FormType] nvarchar(max) NULL,
    [ROE5YrAvg] nvarchar(max) NULL,
    [ROA5YrAvg] nvarchar(max) NULL,
    [AVG5YrsROIC] nvarchar(max) NULL,
    [NormalizedROIC] nvarchar(max) NULL,
    CONSTRAINT [PK_MEfficiencyRatio] PRIMARY KEY ([MEfficiencyRatioId])
);

GO

CREATE TABLE [MStar].[MEfficiencyRatioTTM] (
    [MEfficiencyRatioTTMId] uniqueidentifier NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [UpdatedDate] datetime2 NOT NULL,
    [ExchangeId] nvarchar(max) NULL,
    [CompanyName] nvarchar(max) NULL,
    [Symbol] nvarchar(max) NULL,
    [CUSIP] nvarchar(max) NULL,
    [CIK] nvarchar(max) NULL,
    [ISIN] nvarchar(max) NULL,
    [SEDOL] nvarchar(max) NULL,
    [ShareClassId] nvarchar(max) NULL,
    [ReportDate] nvarchar(max) NULL,
    [PeriodEndingDate] nvarchar(max) NULL,
    [FileDate] nvarchar(max) NULL,
    [StatementType] nvarchar(max) NULL,
    [DataType] nvarchar(max) NULL,
    [Interim] nvarchar(max) NULL,
    [FiscalYearEnd] nvarchar(max) NULL,
    [DaysInSales] nvarchar(max) NULL,
    [DaysInInventory] nvarchar(max) NULL,
    [DaysInPayment] nvarchar(max) NULL,
    [CashConversionCycle] nvarchar(max) NULL,
    [ReceivableTurnover] nvarchar(max) NULL,
    [InventoryTurnover] nvarchar(max) NULL,
    [PayableTurnover] nvarchar(max) NULL,
    [FixedAssetsTurnover] nvarchar(max) NULL,
    [AssetsTurnover] nvarchar(max) NULL,
    [ROE] nvarchar(max) NULL,
    [ROA] nvarchar(max) NULL,
    [ROIC] nvarchar(max) NULL,
    [FCFSalesRatio] nvarchar(max) NULL,
    [FCFNetIncomeRatio] nvarchar(max) NULL,
    [CapitalExpenditureSalesRatio] nvarchar(max) NULL,
    [AccessionNumber] nvarchar(max) NULL,
    [FormType] nvarchar(max) NULL,
    [ROE5YrAvg] nvarchar(max) NULL,
    [ROA5YrAvg] nvarchar(max) NULL,
    [AVG5YrsROIC] nvarchar(max) NULL,
    [NormalizedROIC] nvarchar(max) NULL,
    CONSTRAINT [PK_MEfficiencyRatioTTM] PRIMARY KEY ([MEfficiencyRatioTTMId])
);

GO

CREATE TABLE [MStar].[MProfitabilityRatio] (
    [MProfitabilityRatioId] uniqueidentifier NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [UpdatedDate] datetime2 NOT NULL,
    [ExchangeId] nvarchar(max) NULL,
    [CompanyName] nvarchar(max) NULL,
    [Symbol] nvarchar(max) NULL,
    [CUSIP] nvarchar(max) NULL,
    [CIK] nvarchar(max) NULL,
    [ISIN] nvarchar(max) NULL,
    [SEDOL] nvarchar(max) NULL,
    [ShareClassId] nvarchar(max) NULL,
    [ReportDate] datetime2 NOT NULL,
    [PeriodEndingDate] datetime2 NOT NULL,
    [FileDate] datetime2 NULL,
    [StatementType] nvarchar(max) NULL,
    [DataType] nvarchar(max) NULL,
    [Interim] nvarchar(max) NULL,
    [CurrencyId] nvarchar(max) NULL,
    [FiscalYearEnd] int NOT NULL,
    [GrossMargin] decimal(18, 2) NULL,
    [OperatingMargin] decimal(18, 2) NULL,
    [EBTMargin] decimal(18, 2) NULL,
    [TaxRate] decimal(18, 2) NULL,
    [NetMargin] decimal(18, 2) NULL,
    [SalesPerEmployee] decimal(18, 2) NULL,
    [EBITMargin] decimal(18, 2) NULL,
    [EBITDAMargin] decimal(18, 2) NULL,
    [NormalizedNetProfitMargin] decimal(18, 2) NULL,
    [InterestCoverage] decimal(18, 2) NULL,
    [NetIncomeperFullTimeEmployee] decimal(18, 2) NULL,
    [IncPerEmployeeTotOps] decimal(18, 2) NULL,
    [SolvencyRatio] decimal(18, 2) NULL,
    [ExpenseRatio] decimal(18, 2) NULL,
    [LossRatio] decimal(18, 2) NULL,
    [AccessionNumber] nvarchar(max) NULL,
    [FormType] nvarchar(max) NULL,
    CONSTRAINT [PK_MProfitabilityRatio] PRIMARY KEY ([MProfitabilityRatioId])
);

GO

CREATE TABLE [MStar].[MProfitabilityRatioTTM] (
    [MProfitabilityRatioTTMId] uniqueidentifier NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [UpdatedDate] datetime2 NOT NULL,
    [ExchangeId] nvarchar(max) NULL,
    [CompanyName] nvarchar(max) NULL,
    [Symbol] nvarchar(max) NULL,
    [CUSIP] nvarchar(max) NULL,
    [CIK] nvarchar(max) NULL,
    [ISIN] nvarchar(max) NULL,
    [SEDOL] nvarchar(max) NULL,
    [ShareClassId] nvarchar(max) NULL,
    [ReportDate] datetime2 NOT NULL,
    [PeriodEndingDate] datetime2 NOT NULL,
    [FileDate] datetime2 NULL,
    [StatementType] nvarchar(max) NULL,
    [DataType] nvarchar(max) NULL,
    [Interim] nvarchar(max) NULL,
    [CurrencyId] nvarchar(max) NULL,
    [FiscalYearEnd] int NOT NULL,
    [GrossMargin] decimal(18, 2) NULL,
    [OperatingMargin] decimal(18, 2) NULL,
    [EBTMargin] decimal(18, 2) NULL,
    [TaxRate] decimal(18, 2) NULL,
    [NetMargin] decimal(18, 2) NULL,
    [SalesPerEmployee] decimal(18, 2) NULL,
    [EBITMargin] decimal(18, 2) NULL,
    [EBITDAMargin] decimal(18, 2) NULL,
    [NormalizedNetProfitMargin] decimal(18, 2) NULL,
    [InterestCoverage] decimal(18, 2) NULL,
    [NetIncomeperFullTimeEmployee] decimal(18, 2) NULL,
    [IncPerEmployeeTotOps] decimal(18, 2) NULL,
    [SolvencyRatio] decimal(18, 2) NULL,
    [ExpenseRatio] decimal(18, 2) NULL,
    [LossRatio] decimal(18, 2) NULL,
    [AccessionNumber] nvarchar(max) NULL,
    [FormType] nvarchar(max) NULL,
    CONSTRAINT [PK_MProfitabilityRatioTTM] PRIMARY KEY ([MProfitabilityRatioTTMId])
);

GO

CREATE TABLE [MStar].[TEfficiencyRatio] (
    [Id] uniqueidentifier NOT NULL,
    [IngestionTaskId] uniqueidentifier NOT NULL,
    [ReportDate] nvarchar(max) NULL,
    [PeriodEndingDate] nvarchar(max) NULL,
    [FileDate] nvarchar(max) NULL,
    [StatementType] nvarchar(max) NULL,
    [DataType] nvarchar(max) NULL,
    [Interim] nvarchar(max) NULL,
    [FiscalYearEnd] nvarchar(max) NULL,
    [DaysInSales] nvarchar(max) NULL,
    [DaysInInventory] nvarchar(max) NULL,
    [DaysInPayment] nvarchar(max) NULL,
    [CashConversionCycle] nvarchar(max) NULL,
    [ReceivableTurnover] nvarchar(max) NULL,
    [InventoryTurnover] nvarchar(max) NULL,
    [PayableTurnover] nvarchar(max) NULL,
    [FixedAssetsTurnover] nvarchar(max) NULL,
    [AssetsTurnover] nvarchar(max) NULL,
    [ROE] nvarchar(max) NULL,
    [ROA] nvarchar(max) NULL,
    [ROIC] nvarchar(max) NULL,
    [FCFSalesRatio] nvarchar(max) NULL,
    [FCFNetIncomeRatio] nvarchar(max) NULL,
    [CapitalExpenditureSalesRatio] nvarchar(max) NULL,
    [AccessionNumber] nvarchar(max) NULL,
    [FormType] nvarchar(max) NULL,
    [ROE5YrAvg] nvarchar(max) NULL,
    [ROA5YrAvg] nvarchar(max) NULL,
    [AVG5YrsROIC] nvarchar(max) NULL,
    [NormalizedROIC] nvarchar(max) NULL,
    CONSTRAINT [PK_TEfficiencyRatio] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [MStar].[TEfficiencyRatioTTM] (
    [Id] uniqueidentifier NOT NULL,
    [IngestionTaskId] uniqueidentifier NOT NULL,
    [ReportDate] nvarchar(max) NULL,
    [PeriodEndingDate] nvarchar(max) NULL,
    [FileDate] nvarchar(max) NULL,
    [StatementType] nvarchar(max) NULL,
    [DataType] nvarchar(max) NULL,
    [Interim] nvarchar(max) NULL,
    [FiscalYearEnd] nvarchar(max) NULL,
    [DaysInSales] nvarchar(max) NULL,
    [DaysInInventory] nvarchar(max) NULL,
    [DaysInPayment] nvarchar(max) NULL,
    [CashConversionCycle] nvarchar(max) NULL,
    [ReceivableTurnover] nvarchar(max) NULL,
    [InventoryTurnover] nvarchar(max) NULL,
    [PayableTurnover] nvarchar(max) NULL,
    [FixedAssetsTurnover] nvarchar(max) NULL,
    [AssetsTurnover] nvarchar(max) NULL,
    [ROE] nvarchar(max) NULL,
    [ROA] nvarchar(max) NULL,
    [ROIC] nvarchar(max) NULL,
    [FCFSalesRatio] nvarchar(max) NULL,
    [FCFNetIncomeRatio] nvarchar(max) NULL,
    [CapitalExpenditureSalesRatio] nvarchar(max) NULL,
    [AccessionNumber] nvarchar(max) NULL,
    [FormType] nvarchar(max) NULL,
    [ROE5YrAvg] nvarchar(max) NULL,
    [ROA5YrAvg] nvarchar(max) NULL,
    [AVG5YrsROIC] nvarchar(max) NULL,
    [NormalizedROIC] nvarchar(max) NULL,
    CONSTRAINT [PK_TEfficiencyRatioTTM] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [MStar].[TProfitabilityRatio] (
    [Id] uniqueidentifier NOT NULL,
    [IngestionTaskId] uniqueidentifier NOT NULL,
    [ReportDate] datetime2 NOT NULL,
    [PeriodEndingDate] datetime2 NOT NULL,
    [FileDate] datetime2 NULL,
    [StatementType] nvarchar(max) NULL,
    [DataType] nvarchar(max) NULL,
    [Interim] nvarchar(max) NULL,
    [CurrencyId] nvarchar(max) NULL,
    [FiscalYearEnd] int NOT NULL,
    [GrossMargin] decimal(18, 2) NULL,
    [OperatingMargin] decimal(18, 2) NULL,
    [EBTMargin] decimal(18, 2) NULL,
    [TaxRate] decimal(18, 2) NULL,
    [NetMargin] decimal(18, 2) NULL,
    [SalesPerEmployee] decimal(18, 2) NULL,
    [EBITMargin] decimal(18, 2) NULL,
    [EBITDAMargin] decimal(18, 2) NULL,
    [NormalizedNetProfitMargin] decimal(18, 2) NULL,
    [InterestCoverage] decimal(18, 2) NULL,
    [NetIncomeperFullTimeEmployee] decimal(18, 2) NULL,
    [IncPerEmployeeTotOps] decimal(18, 2) NULL,
    [SolvencyRatio] decimal(18, 2) NULL,
    [ExpenseRatio] decimal(18, 2) NULL,
    [LossRatio] decimal(18, 2) NULL,
    [AccessionNumber] nvarchar(max) NULL,
    [FormType] nvarchar(max) NULL,
    CONSTRAINT [PK_TProfitabilityRatio] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [MStar].[TProfitabilityRatioTTM] (
    [Id] uniqueidentifier NOT NULL,
    [IngestionTaskId] uniqueidentifier NOT NULL,
    [ReportDate] datetime2 NOT NULL,
    [PeriodEndingDate] datetime2 NOT NULL,
    [FileDate] datetime2 NULL,
    [StatementType] nvarchar(max) NULL,
    [DataType] nvarchar(max) NULL,
    [Interim] nvarchar(max) NULL,
    [CurrencyId] nvarchar(max) NULL,
    [FiscalYearEnd] int NOT NULL,
    [GrossMargin] decimal(18, 2) NULL,
    [OperatingMargin] decimal(18, 2) NULL,
    [EBTMargin] decimal(18, 2) NULL,
    [TaxRate] decimal(18, 2) NULL,
    [NetMargin] decimal(18, 2) NULL,
    [SalesPerEmployee] decimal(18, 2) NULL,
    [EBITMargin] decimal(18, 2) NULL,
    [EBITDAMargin] decimal(18, 2) NULL,
    [NormalizedNetProfitMargin] decimal(18, 2) NULL,
    [InterestCoverage] decimal(18, 2) NULL,
    [NetIncomeperFullTimeEmployee] decimal(18, 2) NULL,
    [IncPerEmployeeTotOps] decimal(18, 2) NULL,
    [SolvencyRatio] decimal(18, 2) NULL,
    [ExpenseRatio] decimal(18, 2) NULL,
    [LossRatio] decimal(18, 2) NULL,
    [AccessionNumber] nvarchar(max) NULL,
    [FormType] nvarchar(max) NULL,
    CONSTRAINT [PK_TProfitabilityRatioTTM] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200115121610_add-table-finratios', N'3.1.0');

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'ReportDate');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [ReportDate] datetime2 NOT NULL;

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'ReceivableTurnover');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [ReceivableTurnover] decimal(18, 2) NULL;

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'ROIC');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [ROIC] decimal(18, 2) NULL;

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'ROE5YrAvg');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [ROE5YrAvg] decimal(18, 2) NULL;

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'ROE');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [ROE] decimal(18, 2) NULL;

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'ROA5YrAvg');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [ROA5YrAvg] decimal(18, 2) NULL;

GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'ROA');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [ROA] decimal(18, 2) NULL;

GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'PeriodEndingDate');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [PeriodEndingDate] datetime2 NOT NULL;

GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'PayableTurnover');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [PayableTurnover] decimal(18, 2) NULL;

GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'NormalizedROIC');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [NormalizedROIC] decimal(18, 2) NULL;

GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'InventoryTurnover');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [InventoryTurnover] decimal(18, 2) NULL;

GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'FixedAssetsTurnover');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [FixedAssetsTurnover] decimal(18, 2) NULL;

GO

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'FiscalYearEnd');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [FiscalYearEnd] int NOT NULL;

GO

DECLARE @var13 sysname;
SELECT @var13 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'FileDate');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var13 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [FileDate] datetime2 NULL;

GO

DECLARE @var14 sysname;
SELECT @var14 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'FCFSalesRatio');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var14 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [FCFSalesRatio] decimal(18, 2) NULL;

GO

DECLARE @var15 sysname;
SELECT @var15 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'FCFNetIncomeRatio');
IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var15 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [FCFNetIncomeRatio] decimal(18, 2) NULL;

GO

DECLARE @var16 sysname;
SELECT @var16 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'DaysInSales');
IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var16 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [DaysInSales] decimal(18, 2) NULL;

GO

DECLARE @var17 sysname;
SELECT @var17 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'DaysInPayment');
IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var17 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [DaysInPayment] decimal(18, 2) NULL;

GO

DECLARE @var18 sysname;
SELECT @var18 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'DaysInInventory');
IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var18 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [DaysInInventory] decimal(18, 2) NULL;

GO

DECLARE @var19 sysname;
SELECT @var19 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'CashConversionCycle');
IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var19 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [CashConversionCycle] decimal(18, 2) NULL;

GO

DECLARE @var20 sysname;
SELECT @var20 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'CapitalExpenditureSalesRatio');
IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var20 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [CapitalExpenditureSalesRatio] decimal(18, 2) NULL;

GO

DECLARE @var21 sysname;
SELECT @var21 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'AssetsTurnover');
IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var21 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [AssetsTurnover] decimal(18, 2) NULL;

GO

DECLARE @var22 sysname;
SELECT @var22 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatioTTM]') AND [c].[name] = N'AVG5YrsROIC');
IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatioTTM] DROP CONSTRAINT [' + @var22 + '];');
ALTER TABLE [MStar].[TEfficiencyRatioTTM] ALTER COLUMN [AVG5YrsROIC] decimal(18, 2) NULL;

GO

DECLARE @var23 sysname;
SELECT @var23 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'ReportDate');
IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var23 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [ReportDate] datetime2 NOT NULL;

GO

DECLARE @var24 sysname;
SELECT @var24 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'ReceivableTurnover');
IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var24 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [ReceivableTurnover] decimal(18, 2) NULL;

GO

DECLARE @var25 sysname;
SELECT @var25 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'ROIC');
IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var25 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [ROIC] decimal(18, 2) NULL;

GO

DECLARE @var26 sysname;
SELECT @var26 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'ROE5YrAvg');
IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var26 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [ROE5YrAvg] decimal(18, 2) NULL;

GO

DECLARE @var27 sysname;
SELECT @var27 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'ROE');
IF @var27 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var27 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [ROE] decimal(18, 2) NULL;

GO

DECLARE @var28 sysname;
SELECT @var28 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'ROA5YrAvg');
IF @var28 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var28 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [ROA5YrAvg] decimal(18, 2) NULL;

GO

DECLARE @var29 sysname;
SELECT @var29 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'ROA');
IF @var29 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var29 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [ROA] decimal(18, 2) NULL;

GO

DECLARE @var30 sysname;
SELECT @var30 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'PeriodEndingDate');
IF @var30 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var30 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [PeriodEndingDate] datetime2 NOT NULL;

GO

DECLARE @var31 sysname;
SELECT @var31 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'PayableTurnover');
IF @var31 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var31 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [PayableTurnover] decimal(18, 2) NULL;

GO

DECLARE @var32 sysname;
SELECT @var32 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'NormalizedROIC');
IF @var32 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var32 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [NormalizedROIC] decimal(18, 2) NULL;

GO

DECLARE @var33 sysname;
SELECT @var33 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'InventoryTurnover');
IF @var33 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var33 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [InventoryTurnover] decimal(18, 2) NULL;

GO

DECLARE @var34 sysname;
SELECT @var34 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'FixedAssetsTurnover');
IF @var34 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var34 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [FixedAssetsTurnover] decimal(18, 2) NULL;

GO

DECLARE @var35 sysname;
SELECT @var35 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'FiscalYearEnd');
IF @var35 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var35 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [FiscalYearEnd] int NOT NULL;

GO

DECLARE @var36 sysname;
SELECT @var36 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'FileDate');
IF @var36 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var36 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [FileDate] datetime2 NULL;

GO

DECLARE @var37 sysname;
SELECT @var37 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'FCFSalesRatio');
IF @var37 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var37 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [FCFSalesRatio] decimal(18, 2) NULL;

GO

DECLARE @var38 sysname;
SELECT @var38 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'FCFNetIncomeRatio');
IF @var38 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var38 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [FCFNetIncomeRatio] decimal(18, 2) NULL;

GO

DECLARE @var39 sysname;
SELECT @var39 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'DaysInSales');
IF @var39 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var39 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [DaysInSales] decimal(18, 2) NULL;

GO

DECLARE @var40 sysname;
SELECT @var40 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'DaysInPayment');
IF @var40 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var40 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [DaysInPayment] decimal(18, 2) NULL;

GO

DECLARE @var41 sysname;
SELECT @var41 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'DaysInInventory');
IF @var41 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var41 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [DaysInInventory] decimal(18, 2) NULL;

GO

DECLARE @var42 sysname;
SELECT @var42 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'CashConversionCycle');
IF @var42 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var42 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [CashConversionCycle] decimal(18, 2) NULL;

GO

DECLARE @var43 sysname;
SELECT @var43 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'CapitalExpenditureSalesRatio');
IF @var43 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var43 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [CapitalExpenditureSalesRatio] decimal(18, 2) NULL;

GO

DECLARE @var44 sysname;
SELECT @var44 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'AssetsTurnover');
IF @var44 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var44 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [AssetsTurnover] decimal(18, 2) NULL;

GO

DECLARE @var45 sysname;
SELECT @var45 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[TEfficiencyRatio]') AND [c].[name] = N'AVG5YrsROIC');
IF @var45 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[TEfficiencyRatio] DROP CONSTRAINT [' + @var45 + '];');
ALTER TABLE [MStar].[TEfficiencyRatio] ALTER COLUMN [AVG5YrsROIC] decimal(18, 2) NULL;

GO

DECLARE @var46 sysname;
SELECT @var46 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'ReportDate');
IF @var46 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var46 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [ReportDate] datetime2 NOT NULL;

GO

DECLARE @var47 sysname;
SELECT @var47 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'ReceivableTurnover');
IF @var47 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var47 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [ReceivableTurnover] decimal(18, 2) NULL;

GO

DECLARE @var48 sysname;
SELECT @var48 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'ROIC');
IF @var48 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var48 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [ROIC] decimal(18, 2) NULL;

GO

DECLARE @var49 sysname;
SELECT @var49 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'ROE5YrAvg');
IF @var49 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var49 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [ROE5YrAvg] decimal(18, 2) NULL;

GO

DECLARE @var50 sysname;
SELECT @var50 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'ROE');
IF @var50 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var50 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [ROE] decimal(18, 2) NULL;

GO

DECLARE @var51 sysname;
SELECT @var51 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'ROA5YrAvg');
IF @var51 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var51 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [ROA5YrAvg] decimal(18, 2) NULL;

GO

DECLARE @var52 sysname;
SELECT @var52 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'ROA');
IF @var52 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var52 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [ROA] decimal(18, 2) NULL;

GO

DECLARE @var53 sysname;
SELECT @var53 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'PeriodEndingDate');
IF @var53 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var53 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [PeriodEndingDate] datetime2 NOT NULL;

GO

DECLARE @var54 sysname;
SELECT @var54 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'PayableTurnover');
IF @var54 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var54 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [PayableTurnover] decimal(18, 2) NULL;

GO

DECLARE @var55 sysname;
SELECT @var55 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'NormalizedROIC');
IF @var55 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var55 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [NormalizedROIC] decimal(18, 2) NULL;

GO

DECLARE @var56 sysname;
SELECT @var56 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'InventoryTurnover');
IF @var56 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var56 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [InventoryTurnover] decimal(18, 2) NULL;

GO

DECLARE @var57 sysname;
SELECT @var57 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'FixedAssetsTurnover');
IF @var57 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var57 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [FixedAssetsTurnover] decimal(18, 2) NULL;

GO

DECLARE @var58 sysname;
SELECT @var58 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'FiscalYearEnd');
IF @var58 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var58 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [FiscalYearEnd] int NOT NULL;

GO

DECLARE @var59 sysname;
SELECT @var59 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'FileDate');
IF @var59 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var59 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [FileDate] datetime2 NULL;

GO

DECLARE @var60 sysname;
SELECT @var60 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'FCFSalesRatio');
IF @var60 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var60 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [FCFSalesRatio] decimal(18, 2) NULL;

GO

DECLARE @var61 sysname;
SELECT @var61 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'FCFNetIncomeRatio');
IF @var61 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var61 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [FCFNetIncomeRatio] decimal(18, 2) NULL;

GO

DECLARE @var62 sysname;
SELECT @var62 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'DaysInSales');
IF @var62 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var62 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [DaysInSales] decimal(18, 2) NULL;

GO

DECLARE @var63 sysname;
SELECT @var63 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'DaysInPayment');
IF @var63 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var63 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [DaysInPayment] decimal(18, 2) NULL;

GO

DECLARE @var64 sysname;
SELECT @var64 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'DaysInInventory');
IF @var64 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var64 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [DaysInInventory] decimal(18, 2) NULL;

GO

DECLARE @var65 sysname;
SELECT @var65 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'CashConversionCycle');
IF @var65 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var65 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [CashConversionCycle] decimal(18, 2) NULL;

GO

DECLARE @var66 sysname;
SELECT @var66 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'CapitalExpenditureSalesRatio');
IF @var66 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var66 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [CapitalExpenditureSalesRatio] decimal(18, 2) NULL;

GO

DECLARE @var67 sysname;
SELECT @var67 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'AssetsTurnover');
IF @var67 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var67 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [AssetsTurnover] decimal(18, 2) NULL;

GO

DECLARE @var68 sysname;
SELECT @var68 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatioTTM]') AND [c].[name] = N'AVG5YrsROIC');
IF @var68 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatioTTM] DROP CONSTRAINT [' + @var68 + '];');
ALTER TABLE [MStar].[MEfficiencyRatioTTM] ALTER COLUMN [AVG5YrsROIC] decimal(18, 2) NULL;

GO

DECLARE @var69 sysname;
SELECT @var69 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'ReportDate');
IF @var69 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var69 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [ReportDate] datetime2 NOT NULL;

GO

DECLARE @var70 sysname;
SELECT @var70 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'ReceivableTurnover');
IF @var70 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var70 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [ReceivableTurnover] decimal(18, 2) NULL;

GO

DECLARE @var71 sysname;
SELECT @var71 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'ROIC');
IF @var71 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var71 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [ROIC] decimal(18, 2) NULL;

GO

DECLARE @var72 sysname;
SELECT @var72 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'ROE5YrAvg');
IF @var72 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var72 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [ROE5YrAvg] decimal(18, 2) NULL;

GO

DECLARE @var73 sysname;
SELECT @var73 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'ROE');
IF @var73 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var73 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [ROE] decimal(18, 2) NULL;

GO

DECLARE @var74 sysname;
SELECT @var74 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'ROA5YrAvg');
IF @var74 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var74 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [ROA5YrAvg] decimal(18, 2) NULL;

GO

DECLARE @var75 sysname;
SELECT @var75 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'ROA');
IF @var75 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var75 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [ROA] decimal(18, 2) NULL;

GO

DECLARE @var76 sysname;
SELECT @var76 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'PeriodEndingDate');
IF @var76 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var76 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [PeriodEndingDate] datetime2 NOT NULL;

GO

DECLARE @var77 sysname;
SELECT @var77 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'PayableTurnover');
IF @var77 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var77 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [PayableTurnover] decimal(18, 2) NULL;

GO

DECLARE @var78 sysname;
SELECT @var78 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'NormalizedROIC');
IF @var78 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var78 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [NormalizedROIC] decimal(18, 2) NULL;

GO

DECLARE @var79 sysname;
SELECT @var79 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'InventoryTurnover');
IF @var79 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var79 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [InventoryTurnover] decimal(18, 2) NULL;

GO

DECLARE @var80 sysname;
SELECT @var80 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'FixedAssetsTurnover');
IF @var80 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var80 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [FixedAssetsTurnover] decimal(18, 2) NULL;

GO

DECLARE @var81 sysname;
SELECT @var81 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'FiscalYearEnd');
IF @var81 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var81 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [FiscalYearEnd] int NOT NULL;

GO

DECLARE @var82 sysname;
SELECT @var82 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'FileDate');
IF @var82 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var82 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [FileDate] datetime2 NULL;

GO

DECLARE @var83 sysname;
SELECT @var83 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'FCFSalesRatio');
IF @var83 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var83 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [FCFSalesRatio] decimal(18, 2) NULL;

GO

DECLARE @var84 sysname;
SELECT @var84 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'FCFNetIncomeRatio');
IF @var84 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var84 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [FCFNetIncomeRatio] decimal(18, 2) NULL;

GO

DECLARE @var85 sysname;
SELECT @var85 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'DaysInSales');
IF @var85 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var85 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [DaysInSales] decimal(18, 2) NULL;

GO

DECLARE @var86 sysname;
SELECT @var86 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'DaysInPayment');
IF @var86 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var86 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [DaysInPayment] decimal(18, 2) NULL;

GO

DECLARE @var87 sysname;
SELECT @var87 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'DaysInInventory');
IF @var87 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var87 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [DaysInInventory] decimal(18, 2) NULL;

GO

DECLARE @var88 sysname;
SELECT @var88 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'CashConversionCycle');
IF @var88 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var88 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [CashConversionCycle] decimal(18, 2) NULL;

GO

DECLARE @var89 sysname;
SELECT @var89 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'CapitalExpenditureSalesRatio');
IF @var89 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var89 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [CapitalExpenditureSalesRatio] decimal(18, 2) NULL;

GO

DECLARE @var90 sysname;
SELECT @var90 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'AssetsTurnover');
IF @var90 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var90 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [AssetsTurnover] decimal(18, 2) NULL;

GO

DECLARE @var91 sysname;
SELECT @var91 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MStar].[MEfficiencyRatio]') AND [c].[name] = N'AVG5YrsROIC');
IF @var91 IS NOT NULL EXEC(N'ALTER TABLE [MStar].[MEfficiencyRatio] DROP CONSTRAINT [' + @var91 + '];');
ALTER TABLE [MStar].[MEfficiencyRatio] ALTER COLUMN [AVG5YrsROIC] decimal(18, 2) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200116012445_alt-col-efficiencyratio', N'3.1.0');

GO

