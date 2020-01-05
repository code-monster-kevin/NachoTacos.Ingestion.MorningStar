using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NachoTacos.Ingestion.MorningStar.Data.Migrations
{
    public partial class companyfinancials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TCompanyFinancialAvailability",
                schema: "MStar",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IngestionTaskId = table.Column<Guid>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    ExchangeId = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true),
                    CUSIP = table.Column<string>(nullable: true),
                    CIK = table.Column<string>(nullable: true),
                    ISIN = table.Column<string>(nullable: true),
                    SEDOL = table.Column<string>(nullable: true),
                    Start = table.Column<int>(nullable: false),
                    End = table.Column<int>(nullable: false),
                    SectorId = table.Column<string>(nullable: true),
                    SectorName = table.Column<string>(nullable: true),
                    IndustryGroupId = table.Column<string>(nullable: true),
                    IndustryGroupName = table.Column<string>(nullable: true),
                    IndustryId = table.Column<string>(nullable: true),
                    IndustryName = table.Column<string>(nullable: true),
                    LatestQuarterlyReportDate = table.Column<DateTime>(nullable: false),
                    LatestAnnualReportDate = table.Column<DateTime>(nullable: false),
                    LatestPreliminaryReportDate = table.Column<DateTime>(nullable: false),
                    LatestSemiAnnualReportDate = table.Column<DateTime>(nullable: false),
                    TemplateCode = table.Column<string>(nullable: true),
                    GlobalTemplateCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCompanyFinancialAvailability", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TGeneralInfo",
                schema: "MStar",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IngestionTaskId = table.Column<Guid>(nullable: false),
                    ExchangeId = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true),
                    CUSIP = table.Column<string>(nullable: true),
                    CIK = table.Column<string>(nullable: true),
                    ISIN = table.Column<string>(nullable: true),
                    SEDOL = table.Column<string>(nullable: true),
                    ShareClassId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TGeneralInfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TCompanyFinancialAvailability",
                schema: "MStar");

            migrationBuilder.DropTable(
                name: "TGeneralInfo",
                schema: "MStar");
        }
    }
}
