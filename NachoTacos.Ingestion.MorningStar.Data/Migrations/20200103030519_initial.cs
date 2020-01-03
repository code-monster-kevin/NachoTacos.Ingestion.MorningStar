using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NachoTacos.Ingestion.MorningStar.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientConfigurations",
                columns: table => new
                {
                    ClientConfigurationId = table.Column<Guid>(nullable: false),
                    AccountLogin = table.Column<string>(nullable: true),
                    AccountPassword = table.Column<string>(nullable: true),
                    LoginUrl = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientConfigurations", x => x.ClientConfigurationId);
                });

            migrationBuilder.CreateTable(
                name: "IngestionResults",
                columns: table => new
                {
                    IngestionResultId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    SourceType = table.Column<string>(nullable: true),
                    SourceUrl = table.Column<string>(nullable: true),
                    PostData = table.Column<string>(nullable: true),
                    ResponseData = table.Column<string>(nullable: true),
                    Processed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngestionResults", x => x.IngestionResultId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientConfigurations");

            migrationBuilder.DropTable(
                name: "IngestionResults");
        }
    }
}
