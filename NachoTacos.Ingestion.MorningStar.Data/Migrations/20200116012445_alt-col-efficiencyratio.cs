using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NachoTacos.Ingestion.MorningStar.Data.Migrations
{
    public partial class altcolefficiencyratio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReportDate",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ReceivableTurnover",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROIC",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROE5YrAvg",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROE",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROA5YrAvg",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROA",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PeriodEndingDate",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PayableTurnover",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NormalizedROIC",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InventoryTurnover",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FixedAssetsTurnover",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FiscalYearEnd",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FileDate",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FCFSalesRatio",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FCFNetIncomeRatio",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DaysInSales",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DaysInPayment",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DaysInInventory",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CashConversionCycle",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CapitalExpenditureSalesRatio",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AssetsTurnover",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AVG5YrsROIC",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReportDate",
                schema: "MStar",
                table: "TEfficiencyRatio",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ReceivableTurnover",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROIC",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROE5YrAvg",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROE",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROA5YrAvg",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROA",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PeriodEndingDate",
                schema: "MStar",
                table: "TEfficiencyRatio",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PayableTurnover",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NormalizedROIC",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InventoryTurnover",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FixedAssetsTurnover",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FiscalYearEnd",
                schema: "MStar",
                table: "TEfficiencyRatio",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FileDate",
                schema: "MStar",
                table: "TEfficiencyRatio",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FCFSalesRatio",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FCFNetIncomeRatio",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DaysInSales",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DaysInPayment",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DaysInInventory",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CashConversionCycle",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CapitalExpenditureSalesRatio",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AssetsTurnover",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AVG5YrsROIC",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReportDate",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ReceivableTurnover",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROIC",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROE5YrAvg",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROE",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROA5YrAvg",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROA",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PeriodEndingDate",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PayableTurnover",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NormalizedROIC",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InventoryTurnover",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FixedAssetsTurnover",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FiscalYearEnd",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FileDate",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FCFSalesRatio",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FCFNetIncomeRatio",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DaysInSales",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DaysInPayment",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DaysInInventory",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CashConversionCycle",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CapitalExpenditureSalesRatio",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AssetsTurnover",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AVG5YrsROIC",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReportDate",
                schema: "MStar",
                table: "MEfficiencyRatio",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ReceivableTurnover",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROIC",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROE5YrAvg",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROE",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROA5YrAvg",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ROA",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PeriodEndingDate",
                schema: "MStar",
                table: "MEfficiencyRatio",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PayableTurnover",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NormalizedROIC",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InventoryTurnover",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FixedAssetsTurnover",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FiscalYearEnd",
                schema: "MStar",
                table: "MEfficiencyRatio",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FileDate",
                schema: "MStar",
                table: "MEfficiencyRatio",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FCFSalesRatio",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FCFNetIncomeRatio",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DaysInSales",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DaysInPayment",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DaysInInventory",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CashConversionCycle",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CapitalExpenditureSalesRatio",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AssetsTurnover",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AVG5YrsROIC",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReportDate",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "ReceivableTurnover",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROIC",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROE5YrAvg",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROE",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROA5YrAvg",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROA",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PeriodEndingDate",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "PayableTurnover",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedROIC",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InventoryTurnover",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FixedAssetsTurnover",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FiscalYearEnd",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "FileDate",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FCFSalesRatio",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FCFNetIncomeRatio",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DaysInSales",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DaysInPayment",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DaysInInventory",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CashConversionCycle",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CapitalExpenditureSalesRatio",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssetsTurnover",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AVG5YrsROIC",
                schema: "MStar",
                table: "TEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReportDate",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "ReceivableTurnover",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROIC",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROE5YrAvg",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROE",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROA5YrAvg",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROA",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PeriodEndingDate",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "PayableTurnover",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedROIC",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InventoryTurnover",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FixedAssetsTurnover",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FiscalYearEnd",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "FileDate",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FCFSalesRatio",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FCFNetIncomeRatio",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DaysInSales",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DaysInPayment",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DaysInInventory",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CashConversionCycle",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CapitalExpenditureSalesRatio",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssetsTurnover",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AVG5YrsROIC",
                schema: "MStar",
                table: "TEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReportDate",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "ReceivableTurnover",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROIC",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROE5YrAvg",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROE",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROA5YrAvg",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROA",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PeriodEndingDate",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "PayableTurnover",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedROIC",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InventoryTurnover",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FixedAssetsTurnover",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FiscalYearEnd",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "FileDate",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FCFSalesRatio",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FCFNetIncomeRatio",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DaysInSales",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DaysInPayment",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DaysInInventory",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CashConversionCycle",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CapitalExpenditureSalesRatio",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssetsTurnover",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AVG5YrsROIC",
                schema: "MStar",
                table: "MEfficiencyRatioTTM",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReportDate",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "ReceivableTurnover",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROIC",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROE5YrAvg",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROE",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROA5YrAvg",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROA",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PeriodEndingDate",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "PayableTurnover",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedROIC",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InventoryTurnover",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FixedAssetsTurnover",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FiscalYearEnd",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "FileDate",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FCFSalesRatio",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FCFNetIncomeRatio",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DaysInSales",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DaysInPayment",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DaysInInventory",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CashConversionCycle",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CapitalExpenditureSalesRatio",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssetsTurnover",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AVG5YrsROIC",
                schema: "MStar",
                table: "MEfficiencyRatio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);
        }
    }
}
