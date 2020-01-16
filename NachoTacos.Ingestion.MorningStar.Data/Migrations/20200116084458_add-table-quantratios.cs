using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NachoTacos.Ingestion.MorningStar.Data.Migrations
{
    public partial class addtablequantratios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MEODPriceHistory",
                schema: "MStar",
                columns: table => new
                {
                    MEODPriceHistoryId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    ExchangeId = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true),
                    CUSIP = table.Column<string>(nullable: true),
                    CIK = table.Column<string>(nullable: true),
                    ISIN = table.Column<string>(nullable: true),
                    SEDOL = table.Column<string>(nullable: true),
                    ShareClassId = table.Column<string>(nullable: true),
                    TradingDate = table.Column<DateTime>(nullable: false),
                    OpenPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    HighPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    LowPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ClosePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Volume = table.Column<int>(nullable: false),
                    PriceCurrencyId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEODPriceHistory", x => x.MEODPriceHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "MFinancialHealthRatio",
                schema: "MStar",
                columns: table => new
                {
                    MFinancialHealthRatioId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    ExchangeId = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true),
                    CUSIP = table.Column<string>(nullable: true),
                    CIK = table.Column<string>(nullable: true),
                    ISIN = table.Column<string>(nullable: true),
                    SEDOL = table.Column<string>(nullable: true),
                    ShareClassId = table.Column<string>(nullable: true),
                    ReportDate = table.Column<DateTime>(nullable: false),
                    PeriodEndingDate = table.Column<DateTime>(nullable: false),
                    FileDate = table.Column<DateTime>(nullable: true),
                    StatementType = table.Column<string>(nullable: true),
                    DataType = table.Column<string>(nullable: true),
                    Interim = table.Column<string>(nullable: true),
                    FiscalYearEnd = table.Column<int>(nullable: false),
                    CurrentRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuickRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DebtTotalCapitalRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DebtEquityRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FinancialLeverage = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TotalDebtToEquity = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AccessionNumber = table.Column<string>(nullable: true),
                    FormType = table.Column<string>(nullable: true),
                    DebttoAssets = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CommonEquityToAssets = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MFinancialHealthRatio", x => x.MFinancialHealthRatioId);
                });

            migrationBuilder.CreateTable(
                name: "MGrowthRatio",
                schema: "MStar",
                columns: table => new
                {
                    MGrowthRatioId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    ExchangeId = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true),
                    CUSIP = table.Column<string>(nullable: true),
                    CIK = table.Column<string>(nullable: true),
                    ISIN = table.Column<string>(nullable: true),
                    SEDOL = table.Column<string>(nullable: true),
                    ShareClassId = table.Column<string>(nullable: true),
                    ReportDate = table.Column<DateTime>(nullable: false),
                    PeriodEndingDate = table.Column<DateTime>(nullable: false),
                    FileDate = table.Column<DateTime>(nullable: true),
                    StatementType = table.Column<string>(nullable: true),
                    DataType = table.Column<string>(nullable: true),
                    Interim = table.Column<string>(nullable: true),
                    FiscalYearEnd = table.Column<int>(nullable: false),
                    DilutedEPS3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedEPS6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedEPS9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedEPSSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedEPS1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedEPS3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedEPS5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedEPS10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedContinuousEPS3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedContinuousEPS6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedContinuousEPS9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedContinuousEPSSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedContinuousEPS1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedContinuousEPS3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedContinuousEPS5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedContinuousEPS10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Dividend3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Dividend6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Dividend9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DividendSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Dividend1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Dividend3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Dividend5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Dividend10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquityPerShare3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquityPerShare6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquityPerShare9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquityPerShareSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquityPerShare1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquityPerShare3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquityPerShare5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquityPerShare10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Revenue3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Revenue6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Revenue9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    RevenueSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Revenue1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Revenue3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Revenue5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Revenue10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingIncome3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingIncome6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingIncome9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingIncomeSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingIncome1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingIncome3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingIncome5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingIncome10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncome3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncome6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncome9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncome1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncome3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncome5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncome10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeContOps3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeContOps6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeContOps9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeContOpsSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeContOps1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeContOps3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeContOps5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeContOps10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFO3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFO6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFO9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFOSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFO1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFO3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFO5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFO10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCF3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCF6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCF9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCFSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCF1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCF3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCF5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCF10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingRevenue3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingRevenue6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingRevenue9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingRevenueSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingRevenue1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingRevenue3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingRevenue5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingRevenue10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    GrowthAnnCapitalSpending5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    GrowthAnnGrossProfit5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AvgGrossMargin5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AvgPostTaxMargin5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AvgPreTaxMargin5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AvgNetProfitMargin5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AvgRetCommonEquity5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AvgRetAssets5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AvgRetInvestedCapital5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AccessionNumber = table.Column<string>(nullable: true),
                    FormType = table.Column<string>(nullable: true),
                    RegressionGrowthOperatingRevenue5Years = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedDilutedEPSGrowth1year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedDilutedEPSGrowth3year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedDilutedEPSGrowth5year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedDilutedEPSGrowth10year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedDilutedEPSSamePeriodGrowth3months = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedDilutedEPSSamePeriodGrowth6months = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedDilutedEPSSamePeriodGrowth9months = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedDilutedEPSSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedBasicEPSGrowth1year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedBasicEPSGrowth3year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedBasicEPSGrowth5year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedBasicEPSGrowth10year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedBasicEPSSamePeriodGrowth3months = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedBasicEPSSamePeriodGrowth6months = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedBasicEPSSamePeriodGrowth9months = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedBasicEPSSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGrowthRatio", x => x.MGrowthRatioId);
                });

            migrationBuilder.CreateTable(
                name: "MMonthlyMarketCapitalizationHistory",
                schema: "MStar",
                columns: table => new
                {
                    MMonthlyMarketCapitalizationHistoryId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    ExchangeId = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true),
                    CUSIP = table.Column<string>(nullable: true),
                    CIK = table.Column<string>(nullable: true),
                    ISIN = table.Column<string>(nullable: true),
                    SEDOL = table.Column<string>(nullable: true),
                    ShareClassId = table.Column<string>(nullable: true),
                    MarketCapDate = table.Column<DateTime>(nullable: false),
                    MarketCap = table.Column<long>(nullable: false),
                    EnterpriseValue = table.Column<long>(nullable: false),
                    CurrencyId = table.Column<string>(nullable: true),
                    SharesOutstanding = table.Column<long>(nullable: false),
                    SharesDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MMonthlyMarketCapitalizationHistory", x => x.MMonthlyMarketCapitalizationHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "MQuantitativeRating",
                schema: "MStar",
                columns: table => new
                {
                    MQuantitativeRatingId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    ExchangeId = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true),
                    CUSIP = table.Column<string>(nullable: true),
                    CIK = table.Column<string>(nullable: true),
                    ISIN = table.Column<string>(nullable: true),
                    SEDOL = table.Column<string>(nullable: true),
                    ShareClassId = table.Column<string>(nullable: true),
                    AsOfDate = table.Column<DateTime>(nullable: false),
                    QuantitativeMoat = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuantitativeMoatLabel = table.Column<string>(nullable: true),
                    QuantitativeValuation = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuantitativeValuationUpdateTime = table.Column<DateTime>(nullable: false),
                    QuantitativeValuationLabel = table.Column<string>(nullable: true),
                    QuantitativeValuationLabelUpdateTime = table.Column<DateTime>(nullable: false),
                    QuantitativeValuationUncertainty = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuantitativeValuationUncertaintyLabel = table.Column<string>(nullable: true),
                    QuantitativeFinancialHealth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuantitativeFinancialHealthLabel = table.Column<string>(nullable: true),
                    SolvencyScore = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuantitativeFinancialHealthDecile = table.Column<int>(nullable: false),
                    QuantitativeStarRating = table.Column<int>(nullable: false),
                    QuantitativeStarRatingUpdateTime = table.Column<DateTime>(nullable: false),
                    QuantitativeFairValue = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuantitativeFairValueUpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MQuantitativeRating", x => x.MQuantitativeRatingId);
                });

            migrationBuilder.CreateTable(
                name: "MValuationRatio",
                schema: "MStar",
                columns: table => new
                {
                    MValuationRatioId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    ExchangeId = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true),
                    CUSIP = table.Column<string>(nullable: true),
                    CIK = table.Column<string>(nullable: true),
                    ISIN = table.Column<string>(nullable: true),
                    SEDOL = table.Column<string>(nullable: true),
                    ShareClassId = table.Column<string>(nullable: true),
                    AsOfDate = table.Column<DateTime>(nullable: false),
                    SalesPerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    GrowthAnnSalesPerShare5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    BookValuePerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFPerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCFPerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PriceToEPS = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    RatioPE5YearHigh = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    RatioPE5YearLow = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PriceToBook = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PriceToSales = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PriceToCashFlow = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PriceToFreeCashFlow = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DivRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DividendYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DivPayoutTotOps = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DivPayout5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DivYield5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PayoutRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SustainableGrowthRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CashReturn = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ForwardEarningYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PEGRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PEGPayback = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ForwardDividendYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ForwardPERatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TangibleBookValuePerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TangibleBVPerShare3YrAvg = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TangibleBVPerShare5YrAvg = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVToEBITDA = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    RatioPE5YearAverage = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedPERatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCFYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVToForwardEBIT = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVToForwardEBITDA = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVToForwardRevenue = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TwoYearsEVToForwardEBIT = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TwoYearsEVToForwardEBITDA = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FirstYearEstimatedEPSGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SecondYearEstimatedEPSGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedPEG = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EarningYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SalesYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    BookValueYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CashFlowYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ForwardDividend = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    WorkingCapitalPerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    WorkingCapitalPerShare3YrAvg = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    WorkingCapitalPerShare5YrAvg = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    BuyBackYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TotalYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PricetoEBITDA = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ForwardROE = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ForwardROA = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TwoYearsForwardEarningYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TwoYearsForwardPERatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TotalAssetPerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVtoRevenue = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVtoPreTaxIncome = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVtoTotalAssets = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVtoFCF = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVtoEBIT = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FFOPerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PricetoCashRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CAPERatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MValuationRatio", x => x.MValuationRatioId);
                });

            migrationBuilder.CreateTable(
                name: "TEODPriceHistory",
                schema: "MStar",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IngestionTaskId = table.Column<Guid>(nullable: false),
                    TradingDate = table.Column<DateTime>(nullable: false),
                    OpenPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    HighPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    LowPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ClosePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Volume = table.Column<int>(nullable: false),
                    PriceCurrencyId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEODPriceHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TFinancialHealthRatio",
                schema: "MStar",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IngestionTaskId = table.Column<Guid>(nullable: false),
                    ReportDate = table.Column<DateTime>(nullable: false),
                    PeriodEndingDate = table.Column<DateTime>(nullable: false),
                    FileDate = table.Column<DateTime>(nullable: true),
                    StatementType = table.Column<string>(nullable: true),
                    DataType = table.Column<string>(nullable: true),
                    Interim = table.Column<string>(nullable: true),
                    FiscalYearEnd = table.Column<int>(nullable: false),
                    CurrentRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuickRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DebtTotalCapitalRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DebtEquityRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FinancialLeverage = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TotalDebtToEquity = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AccessionNumber = table.Column<string>(nullable: true),
                    FormType = table.Column<string>(nullable: true),
                    DebttoAssets = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CommonEquityToAssets = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFinancialHealthRatio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TGrowthRatio",
                schema: "MStar",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IngestionTaskId = table.Column<Guid>(nullable: false),
                    ReportDate = table.Column<DateTime>(nullable: false),
                    PeriodEndingDate = table.Column<DateTime>(nullable: false),
                    FileDate = table.Column<DateTime>(nullable: true),
                    StatementType = table.Column<string>(nullable: true),
                    DataType = table.Column<string>(nullable: true),
                    Interim = table.Column<string>(nullable: true),
                    FiscalYearEnd = table.Column<int>(nullable: false),
                    DilutedEPS3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedEPS6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedEPS9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedEPSSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedEPS1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedEPS3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedEPS5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedEPS10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedContinuousEPS3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedContinuousEPS6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedContinuousEPS9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedContinuousEPSSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedContinuousEPS1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedContinuousEPS3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedContinuousEPS5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DilutedContinuousEPS10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Dividend3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Dividend6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Dividend9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DividendSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Dividend1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Dividend3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Dividend5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Dividend10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquityPerShare3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquityPerShare6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquityPerShare9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquityPerShareSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquityPerShare1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquityPerShare3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquityPerShare5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquityPerShare10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Revenue3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Revenue6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Revenue9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    RevenueSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Revenue1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Revenue3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Revenue5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Revenue10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingIncome3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingIncome6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingIncome9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingIncomeSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingIncome1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingIncome3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingIncome5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingIncome10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncome3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncome6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncome9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncome1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncome3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncome5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncome10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeContOps3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeContOps6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeContOps9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeContOpsSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeContOps1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeContOps3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeContOps5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeContOps10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFO3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFO6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFO9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFOSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFO1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFO3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFO5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFO10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCF3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCF6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCF9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCFSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCF1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCF3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCF5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCF10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingRevenue3MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingRevenue6MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingRevenue9MonthSamePeriodGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingRevenueSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingRevenue1YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingRevenue3YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingRevenue5YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingRevenue10YearGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    GrowthAnnCapitalSpending5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    GrowthAnnGrossProfit5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AvgGrossMargin5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AvgPostTaxMargin5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AvgPreTaxMargin5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AvgNetProfitMargin5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AvgRetCommonEquity5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AvgRetAssets5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AvgRetInvestedCapital5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AccessionNumber = table.Column<string>(nullable: true),
                    FormType = table.Column<string>(nullable: true),
                    RegressionGrowthOperatingRevenue5Years = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedDilutedEPSGrowth1year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedDilutedEPSGrowth3year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedDilutedEPSGrowth5year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedDilutedEPSGrowth10year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedDilutedEPSSamePeriodGrowth3months = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedDilutedEPSSamePeriodGrowth6months = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedDilutedEPSSamePeriodGrowth9months = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedDilutedEPSSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedBasicEPSGrowth1year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedBasicEPSGrowth3year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedBasicEPSGrowth5year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedBasicEPSGrowth10year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedBasicEPSSamePeriodGrowth3months = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedBasicEPSSamePeriodGrowth6months = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedBasicEPSSamePeriodGrowth9months = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedBasicEPSSequentialGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TGrowthRatio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TMonthlyMarketCapitalizationHistory",
                schema: "MStar",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IngestionTaskId = table.Column<Guid>(nullable: false),
                    MarketCapDate = table.Column<DateTime>(nullable: false),
                    MarketCap = table.Column<long>(nullable: false),
                    EnterpriseValue = table.Column<long>(nullable: false),
                    CurrencyId = table.Column<string>(nullable: true),
                    SharesOutstanding = table.Column<long>(nullable: false),
                    SharesDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMonthlyMarketCapitalizationHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TQuantitativeRating",
                schema: "MStar",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IngestionTaskId = table.Column<Guid>(nullable: false),
                    AsOfDate = table.Column<DateTime>(nullable: false),
                    QuantitativeMoat = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuantitativeMoatLabel = table.Column<string>(nullable: true),
                    QuantitativeValuation = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuantitativeValuationUpdateTime = table.Column<DateTime>(nullable: false),
                    QuantitativeValuationLabel = table.Column<string>(nullable: true),
                    QuantitativeValuationLabelUpdateTime = table.Column<DateTime>(nullable: false),
                    QuantitativeValuationUncertainty = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuantitativeValuationUncertaintyLabel = table.Column<string>(nullable: true),
                    QuantitativeFinancialHealth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuantitativeFinancialHealthLabel = table.Column<string>(nullable: true),
                    SolvencyScore = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuantitativeFinancialHealthDecile = table.Column<int>(nullable: false),
                    QuantitativeStarRating = table.Column<int>(nullable: false),
                    QuantitativeStarRatingUpdateTime = table.Column<DateTime>(nullable: false),
                    QuantitativeFairValue = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuantitativeFairValueUpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TQuantitativeRating", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TValuationRatio",
                schema: "MStar",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IngestionTaskId = table.Column<Guid>(nullable: false),
                    AsOfDate = table.Column<DateTime>(nullable: false),
                    SalesPerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    GrowthAnnSalesPerShare5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    BookValuePerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFPerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCFPerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PriceToEPS = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    RatioPE5YearHigh = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    RatioPE5YearLow = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PriceToBook = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PriceToSales = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PriceToCashFlow = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PriceToFreeCashFlow = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DivRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DividendYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DivPayoutTotOps = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DivPayout5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DivYield5Year = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PayoutRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SustainableGrowthRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CashReturn = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ForwardEarningYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PEGRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PEGPayback = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ForwardDividendYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ForwardPERatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TangibleBookValuePerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TangibleBVPerShare3YrAvg = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TangibleBVPerShare5YrAvg = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVToEBITDA = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    RatioPE5YearAverage = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedPERatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCFYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVToForwardEBIT = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVToForwardEBITDA = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVToForwardRevenue = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TwoYearsEVToForwardEBIT = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TwoYearsEVToForwardEBITDA = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FirstYearEstimatedEPSGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SecondYearEstimatedEPSGrowth = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedPEG = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EarningYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SalesYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    BookValueYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CashFlowYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ForwardDividend = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    WorkingCapitalPerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    WorkingCapitalPerShare3YrAvg = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    WorkingCapitalPerShare5YrAvg = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    BuyBackYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TotalYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PricetoEBITDA = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ForwardROE = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ForwardROA = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TwoYearsForwardEarningYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TwoYearsForwardPERatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TotalAssetPerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVtoRevenue = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVtoPreTaxIncome = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVtoTotalAssets = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVtoFCF = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVtoEBIT = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FFOPerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PricetoCashRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CAPERatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TValuationRatio", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MEODPriceHistory",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "MFinancialHealthRatio",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "MGrowthRatio",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "MMonthlyMarketCapitalizationHistory",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "MQuantitativeRating",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "MValuationRatio",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "TEODPriceHistory",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "TFinancialHealthRatio",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "TGrowthRatio",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "TMonthlyMarketCapitalizationHistory",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "TQuantitativeRating",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "TValuationRatio",
                schema: "MStar");
        }
    }
}
