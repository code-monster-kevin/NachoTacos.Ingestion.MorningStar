using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NachoTacos.Ingestion.MorningStar.Data.Migrations
{
    public partial class addtablefinratios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MEfficiencyRatio",
                schema: "MStar",
                columns: table => new
                {
                    MEfficiencyRatioId = table.Column<Guid>(nullable: false),
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
                    ReportDate = table.Column<string>(nullable: true),
                    PeriodEndingDate = table.Column<string>(nullable: true),
                    FileDate = table.Column<string>(nullable: true),
                    StatementType = table.Column<string>(nullable: true),
                    DataType = table.Column<string>(nullable: true),
                    Interim = table.Column<string>(nullable: true),
                    FiscalYearEnd = table.Column<string>(nullable: true),
                    DaysInSales = table.Column<string>(nullable: true),
                    DaysInInventory = table.Column<string>(nullable: true),
                    DaysInPayment = table.Column<string>(nullable: true),
                    CashConversionCycle = table.Column<string>(nullable: true),
                    ReceivableTurnover = table.Column<string>(nullable: true),
                    InventoryTurnover = table.Column<string>(nullable: true),
                    PayableTurnover = table.Column<string>(nullable: true),
                    FixedAssetsTurnover = table.Column<string>(nullable: true),
                    AssetsTurnover = table.Column<string>(nullable: true),
                    ROE = table.Column<string>(nullable: true),
                    ROA = table.Column<string>(nullable: true),
                    ROIC = table.Column<string>(nullable: true),
                    FCFSalesRatio = table.Column<string>(nullable: true),
                    FCFNetIncomeRatio = table.Column<string>(nullable: true),
                    CapitalExpenditureSalesRatio = table.Column<string>(nullable: true),
                    AccessionNumber = table.Column<string>(nullable: true),
                    FormType = table.Column<string>(nullable: true),
                    ROE5YrAvg = table.Column<string>(nullable: true),
                    ROA5YrAvg = table.Column<string>(nullable: true),
                    AVG5YrsROIC = table.Column<string>(nullable: true),
                    NormalizedROIC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEfficiencyRatio", x => x.MEfficiencyRatioId);
                });

            migrationBuilder.CreateTable(
                name: "MEfficiencyRatioTTM",
                schema: "MStar",
                columns: table => new
                {
                    MEfficiencyRatioTTMId = table.Column<Guid>(nullable: false),
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
                    ReportDate = table.Column<string>(nullable: true),
                    PeriodEndingDate = table.Column<string>(nullable: true),
                    FileDate = table.Column<string>(nullable: true),
                    StatementType = table.Column<string>(nullable: true),
                    DataType = table.Column<string>(nullable: true),
                    Interim = table.Column<string>(nullable: true),
                    FiscalYearEnd = table.Column<string>(nullable: true),
                    DaysInSales = table.Column<string>(nullable: true),
                    DaysInInventory = table.Column<string>(nullable: true),
                    DaysInPayment = table.Column<string>(nullable: true),
                    CashConversionCycle = table.Column<string>(nullable: true),
                    ReceivableTurnover = table.Column<string>(nullable: true),
                    InventoryTurnover = table.Column<string>(nullable: true),
                    PayableTurnover = table.Column<string>(nullable: true),
                    FixedAssetsTurnover = table.Column<string>(nullable: true),
                    AssetsTurnover = table.Column<string>(nullable: true),
                    ROE = table.Column<string>(nullable: true),
                    ROA = table.Column<string>(nullable: true),
                    ROIC = table.Column<string>(nullable: true),
                    FCFSalesRatio = table.Column<string>(nullable: true),
                    FCFNetIncomeRatio = table.Column<string>(nullable: true),
                    CapitalExpenditureSalesRatio = table.Column<string>(nullable: true),
                    AccessionNumber = table.Column<string>(nullable: true),
                    FormType = table.Column<string>(nullable: true),
                    ROE5YrAvg = table.Column<string>(nullable: true),
                    ROA5YrAvg = table.Column<string>(nullable: true),
                    AVG5YrsROIC = table.Column<string>(nullable: true),
                    NormalizedROIC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEfficiencyRatioTTM", x => x.MEfficiencyRatioTTMId);
                });

            migrationBuilder.CreateTable(
                name: "MProfitabilityRatio",
                schema: "MStar",
                columns: table => new
                {
                    MProfitabilityRatioId = table.Column<Guid>(nullable: false),
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
                    CurrencyId = table.Column<string>(nullable: true),
                    FiscalYearEnd = table.Column<int>(nullable: false),
                    GrossMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EBTMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TaxRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SalesPerEmployee = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EBITMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EBITDAMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedNetProfitMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    InterestCoverage = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeperFullTimeEmployee = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    IncPerEmployeeTotOps = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SolvencyRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ExpenseRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    LossRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AccessionNumber = table.Column<string>(nullable: true),
                    FormType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MProfitabilityRatio", x => x.MProfitabilityRatioId);
                });

            migrationBuilder.CreateTable(
                name: "MProfitabilityRatioTTM",
                schema: "MStar",
                columns: table => new
                {
                    MProfitabilityRatioTTMId = table.Column<Guid>(nullable: false),
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
                    CurrencyId = table.Column<string>(nullable: true),
                    FiscalYearEnd = table.Column<int>(nullable: false),
                    GrossMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EBTMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TaxRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SalesPerEmployee = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EBITMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EBITDAMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedNetProfitMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    InterestCoverage = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeperFullTimeEmployee = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    IncPerEmployeeTotOps = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SolvencyRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ExpenseRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    LossRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AccessionNumber = table.Column<string>(nullable: true),
                    FormType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MProfitabilityRatioTTM", x => x.MProfitabilityRatioTTMId);
                });

            migrationBuilder.CreateTable(
                name: "TEfficiencyRatio",
                schema: "MStar",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IngestionTaskId = table.Column<Guid>(nullable: false),
                    ReportDate = table.Column<string>(nullable: true),
                    PeriodEndingDate = table.Column<string>(nullable: true),
                    FileDate = table.Column<string>(nullable: true),
                    StatementType = table.Column<string>(nullable: true),
                    DataType = table.Column<string>(nullable: true),
                    Interim = table.Column<string>(nullable: true),
                    FiscalYearEnd = table.Column<string>(nullable: true),
                    DaysInSales = table.Column<string>(nullable: true),
                    DaysInInventory = table.Column<string>(nullable: true),
                    DaysInPayment = table.Column<string>(nullable: true),
                    CashConversionCycle = table.Column<string>(nullable: true),
                    ReceivableTurnover = table.Column<string>(nullable: true),
                    InventoryTurnover = table.Column<string>(nullable: true),
                    PayableTurnover = table.Column<string>(nullable: true),
                    FixedAssetsTurnover = table.Column<string>(nullable: true),
                    AssetsTurnover = table.Column<string>(nullable: true),
                    ROE = table.Column<string>(nullable: true),
                    ROA = table.Column<string>(nullable: true),
                    ROIC = table.Column<string>(nullable: true),
                    FCFSalesRatio = table.Column<string>(nullable: true),
                    FCFNetIncomeRatio = table.Column<string>(nullable: true),
                    CapitalExpenditureSalesRatio = table.Column<string>(nullable: true),
                    AccessionNumber = table.Column<string>(nullable: true),
                    FormType = table.Column<string>(nullable: true),
                    ROE5YrAvg = table.Column<string>(nullable: true),
                    ROA5YrAvg = table.Column<string>(nullable: true),
                    AVG5YrsROIC = table.Column<string>(nullable: true),
                    NormalizedROIC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEfficiencyRatio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TEfficiencyRatioTTM",
                schema: "MStar",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IngestionTaskId = table.Column<Guid>(nullable: false),
                    ReportDate = table.Column<string>(nullable: true),
                    PeriodEndingDate = table.Column<string>(nullable: true),
                    FileDate = table.Column<string>(nullable: true),
                    StatementType = table.Column<string>(nullable: true),
                    DataType = table.Column<string>(nullable: true),
                    Interim = table.Column<string>(nullable: true),
                    FiscalYearEnd = table.Column<string>(nullable: true),
                    DaysInSales = table.Column<string>(nullable: true),
                    DaysInInventory = table.Column<string>(nullable: true),
                    DaysInPayment = table.Column<string>(nullable: true),
                    CashConversionCycle = table.Column<string>(nullable: true),
                    ReceivableTurnover = table.Column<string>(nullable: true),
                    InventoryTurnover = table.Column<string>(nullable: true),
                    PayableTurnover = table.Column<string>(nullable: true),
                    FixedAssetsTurnover = table.Column<string>(nullable: true),
                    AssetsTurnover = table.Column<string>(nullable: true),
                    ROE = table.Column<string>(nullable: true),
                    ROA = table.Column<string>(nullable: true),
                    ROIC = table.Column<string>(nullable: true),
                    FCFSalesRatio = table.Column<string>(nullable: true),
                    FCFNetIncomeRatio = table.Column<string>(nullable: true),
                    CapitalExpenditureSalesRatio = table.Column<string>(nullable: true),
                    AccessionNumber = table.Column<string>(nullable: true),
                    FormType = table.Column<string>(nullable: true),
                    ROE5YrAvg = table.Column<string>(nullable: true),
                    ROA5YrAvg = table.Column<string>(nullable: true),
                    AVG5YrsROIC = table.Column<string>(nullable: true),
                    NormalizedROIC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEfficiencyRatioTTM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TProfitabilityRatio",
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
                    CurrencyId = table.Column<string>(nullable: true),
                    FiscalYearEnd = table.Column<int>(nullable: false),
                    GrossMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EBTMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TaxRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SalesPerEmployee = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EBITMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EBITDAMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedNetProfitMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    InterestCoverage = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeperFullTimeEmployee = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    IncPerEmployeeTotOps = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SolvencyRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ExpenseRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    LossRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AccessionNumber = table.Column<string>(nullable: true),
                    FormType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProfitabilityRatio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TProfitabilityRatioTTM",
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
                    CurrencyId = table.Column<string>(nullable: true),
                    FiscalYearEnd = table.Column<int>(nullable: false),
                    GrossMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OperatingMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EBTMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TaxRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SalesPerEmployee = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EBITMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EBITDAMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NormalizedNetProfitMargin = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    InterestCoverage = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    NetIncomeperFullTimeEmployee = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    IncPerEmployeeTotOps = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SolvencyRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ExpenseRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    LossRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AccessionNumber = table.Column<string>(nullable: true),
                    FormType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProfitabilityRatioTTM", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MEfficiencyRatio",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "MEfficiencyRatioTTM",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "MProfitabilityRatio",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "MProfitabilityRatioTTM",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "TEfficiencyRatio",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "TEfficiencyRatioTTM",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "TProfitabilityRatio",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "TProfitabilityRatioTTM",
                schema: "MStar");
        }
    }
}
