using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NachoTacos.Ingestion.MorningStar.Data.Migrations
{
    public partial class addtablemstockexchangesecurity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MStockExchangeSecurity",
                schema: "MStar",
                columns: table => new
                {
                    MStockExchangeSecurityId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    ExchangeId = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true),
                    CUSIP = table.Column<string>(nullable: true),
                    CIK = table.Column<string>(nullable: true),
                    ISIN = table.Column<string>(nullable: true),
                    SEDOL = table.Column<string>(nullable: true),
                    InvestmentTypeId = table.Column<string>(nullable: true),
                    StockStatus = table.Column<string>(nullable: true),
                    DelistingDate = table.Column<DateTime>(nullable: false),
                    DelistingReason = table.Column<string>(nullable: true),
                    ExchangeSubMarketGlobalId = table.Column<string>(nullable: true),
                    ParValue = table.Column<decimal>(nullable: false),
                    SuspendedFlag = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MStockExchangeSecurity", x => x.MStockExchangeSecurityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MStockExchangeSecurity",
                schema: "MStar");
        }
    }
}
