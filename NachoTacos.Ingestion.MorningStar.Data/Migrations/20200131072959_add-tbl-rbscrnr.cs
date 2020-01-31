using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NachoTacos.Ingestion.MorningStar.Data.Migrations
{
    public partial class addtblrbscrnr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RBaseScreener",
                schema: "MStar",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true),
                    SectorName = table.Column<string>(nullable: true),
                    IndustryGroupName = table.Column<string>(nullable: true),
                    IndustryName = table.Column<string>(nullable: true),
                    MarketCapDate = table.Column<DateTime>(nullable: true),
                    MarketCap = table.Column<long>(nullable: true),
                    SharesOutStanding = table.Column<long>(nullable: true),
                    SharesDate = table.Column<DateTime>(nullable: true),
                    EnterpriseValue = table.Column<long>(nullable: true),
                    ValuationRatioDate = table.Column<DateTime>(nullable: true),
                    TotalAssetPerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TangibleBookValuePerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    BookValuePerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SalesPerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CFPerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    FCFPerShare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PriceToBook = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PriceToSales = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PriceToCashFlow = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PriceToFreeCashFlow = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PriceToEPS = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PEGRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PricetoCashRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DividendYield = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ForwardDividend = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PayoutRatio = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SustainableGrowthRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EVToEBITDA = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuantRatingDate = table.Column<DateTime>(nullable: true),
                    QuantitativeMoat = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuantitativeValuation = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    QuantitativeValuationUpdateTime = table.Column<DateTime>(nullable: true),
                    QuantitativeValuationLabelUpdateTime = table.Column<DateTime>(nullable: true),
                    QuantitativeStarRatingUpdateTime = table.Column<DateTime>(nullable: true),
                    QuantitativeFairValueUpdateTime = table.Column<DateTime>(nullable: true),
                    QuantitativeMoatLabel = table.Column<string>(nullable: true),
                    QuantitativeValuationLabel = table.Column<string>(nullable: true),
                    QuantitativeValuationUncertaintyLabel = table.Column<string>(nullable: true),
                    QuantitativeFinancialHealthLabel = table.Column<string>(nullable: true),
                    QuantitativeStarRating = table.Column<int>(nullable: true),
                    QuantitativeFairValue = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RBaseScreener", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RBaseScreener",
                schema: "MStar");
        }
    }
}
