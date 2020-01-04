using Microsoft.EntityFrameworkCore.Migrations;

namespace NachoTacos.Ingestion.MorningStar.Data.Migrations
{
    public partial class mstartemptable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TStockExchangeSecurity_IngestionTaskId",
                schema: "MStar",
                table: "TStockExchangeSecurity",
                column: "IngestionTaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_TStockExchangeSecurity_IngestionTasks_IngestionTaskId",
                schema: "MStar",
                table: "TStockExchangeSecurity",
                column: "IngestionTaskId",
                principalTable: "IngestionTasks",
                principalColumn: "IngestionTaskId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TStockExchangeSecurity_IngestionTasks_IngestionTaskId",
                schema: "MStar",
                table: "TStockExchangeSecurity");

            migrationBuilder.DropIndex(
                name: "IX_TStockExchangeSecurity_IngestionTaskId",
                schema: "MStar",
                table: "TStockExchangeSecurity");
        }
    }
}
