using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NachoTacos.Ingestion.MorningStar.Data.Migrations
{
    public partial class addtablemcompanyfinancial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MCompanyFinancialAvailability",
                schema: "MStar",
                columns: table => new
                {
                    MCompanyFinancialAvailabilityId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
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
                    table.PrimaryKey("PK_MCompanyFinancialAvailability", x => x.MCompanyFinancialAvailabilityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MCompanyFinancialAvailability",
                schema: "MStar");
        }
    }
}
