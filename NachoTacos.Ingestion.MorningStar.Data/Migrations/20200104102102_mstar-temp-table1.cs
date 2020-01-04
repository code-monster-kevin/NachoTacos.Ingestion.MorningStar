using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NachoTacos.Ingestion.MorningStar.Data.Migrations
{
    public partial class mstartemptable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "MStar");

            migrationBuilder.CreateTable(
                name: "IngestionTasks",
                columns: table => new
                {
                    IngestionTaskId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Entity = table.Column<string>(nullable: true),
                    IsProcessed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngestionTasks", x => x.IngestionTaskId);
                });

            migrationBuilder.CreateTable(
                name: "TStockExchangeSecurity",
                schema: "MStar",
                columns: table => new
                {
                    ExchangeId = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(nullable: false),
                    Symbol = table.Column<string>(nullable: true),
                    CUSIP = table.Column<string>(nullable: true),
                    CIK = table.Column<string>(nullable: true),
                    ISIN = table.Column<string>(nullable: true),
                    SEDOL = table.Column<string>(nullable: true),
                    IngestionTaskId = table.Column<Guid>(nullable: false),
                    InvestmentTypeId = table.Column<string>(nullable: true),
                    StockStatus = table.Column<string>(nullable: false),
                    DelistingDate = table.Column<DateTime>(nullable: false),
                    DelistingReason = table.Column<string>(nullable: true),
                    ExchangeSubMarketGlobalId = table.Column<string>(nullable: false),
                    ParValue = table.Column<decimal>(nullable: false),
                    SuspendedFlag = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngestionTasks");

            migrationBuilder.DropTable(
                name: "TStockExchangeSecurity",
                schema: "MStar");
        }
    }
}
