using Microsoft.EntityFrameworkCore.Migrations;

namespace NachoTacos.Ingestion.MorningStar.Data.Migrations
{
    public partial class chgcoltbalancesheet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "WorkingCapital",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "WorkInProcess",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "WaterProduction",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnrealizedGainLoss",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnpaidLossAndLossReserve",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnearnedPremiums",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnearnedIncome",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnclassifiedCurrentAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnbilledReceivables",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnallocatedSurplus",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TrustPreferredSecurities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TreasuryStock",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TreasurySharesNumber",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TreasuryBillsandOtherEligibleBills",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TradingandFinancialLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TradingSecurities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TradingLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TradingAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TradingAndOtherReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TradeandOtherPayablesNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TradeAndOtherReceivablesNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalTaxPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPolicyHoldersLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPartnershipCapital",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalNonCurrentLiabilitiesNetMinorityInterest",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalNonCurrentLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalNonCurrentAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalLiabilitiesNetMinorityInterest",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalLiabilitiesAsReported",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalFinancialLeaseObligations",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalEquityGrossMinorityInterest",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalEquityAsReported",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalEquity",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalDeposits",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalDeferredCreditsAndOtherNonCurrentLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalDebtInMaturitySchedule",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalDebt",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalCapitalization",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TimeDepositsPlaced",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TaxesReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TaxesAssetsCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TaxAssetsTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TangibleBookValue",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SubordinatedLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "StudentLoan",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "StockholdersEquity",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ShortTermInvestmentsTrading",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ShortTermInvestmentsHeldToMaturity",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ShortTermInvestmentsAvailableForSale",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ShortTermInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SeparateAccountLiability",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SeparateAccountAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SecuritySoldNotYetRepurchased",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SecurityBorrowed",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SecurityAgreeToBeResell",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SecuritiesLoaned",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SecuritiesLendingPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SecuritiesLendingCollateral",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SecuritiesAndInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RetainedEarnings",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RestrictedInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RestrictedCommonStock",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RestrictedCashAndInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RestrictedCashAndCashEquivalents",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RestrictedCash",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ReinsuranceShareofInsuranceContract",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ReinsuranceShareofAccruedPolicyholderClaims",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ReinsuranceRecoverableForUnpaidLosses",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ReinsuranceRecoverableForPaidLosses",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ReinsuranceRecoverable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ReinsuranceReceivables",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ReinsuranceBalancesPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ReinsuranceAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RegulatoryLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RegulatoryAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RedeemablePreferredStock",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RecievablesAdjustmentsAllowances",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Receivables",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RealEstateHeldForSale",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RealEstateAndRealEstateJointVenturesHeldForInvestment",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RealEstate",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RawMaterials",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PurchasedComponents",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ProvisionsTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Properties",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrepaidReinsurancePremiums",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrepaidAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PremiumsReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PreferredStocksAvailableForSale",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PreferredStockOfSubsidiary",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PreferredStockEquity",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PreferredStock",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PreferredSharesNumber",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PreferredSecuritiesOutsideStockEquity",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PolicyholderFunds",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PolicyLoans",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PlacementwithBanksandOtherFinancialInstitutions",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PensionandOtherPostRetirementBenefitPlansCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PensionAndOtherPostretirementBenefitPlansTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PaymentofBills",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PayablesAndAccruedExpenses",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Payables",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Patents",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ParticipatingPolicyholderEquity",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherReserves",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherReceivables",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherRealEstateOwned",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherProperties",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherNonCurrentLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherNonCurrentAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherLoansTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherLoansNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherLoansCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherLoanAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherInvestedAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherInventories",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherInterestEarningAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherIntangibleAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherFinancialLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherEquityInterest",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherEquityAdjustments",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherDeposits",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherDeferredCosts",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherCurrentLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherCurrentBorrowings",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherCurrentAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherCapitalStock",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherBorrowedFunds",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OrdinarySharesNumber",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OperatingLeaseAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NotesReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NonInterestBearingDeposits",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NonInterestBearingBorrowingsTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NonInterestBearingBorrowingsNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NonInterestBearingBorrowingsCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentPrepaidAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentPensionAndOtherPostretirementBenefitPlans",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentOtherFinancialLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentNoteReceivables",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentDeferredTaxesLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentDeferredTaxesAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentDeferredRevenue",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentDeferredLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentDeferredAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentAccruedExpenses",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentAccountsReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NetUtilityPlant",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NetUnrealizedGainLossInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NetUnrealizedGainLossForeignCurrency",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NetTangibleAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NetPPE",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NetOtherUnrealizedGainLoss",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NetLoan",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NetDebt",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NetAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NaturalResourceAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NaturalGasFuelAndOther",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MortgageLoan",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MortgageAndConsumerloans",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MoneyMarketInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MinorityInterest",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MinimumPensionLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MineralProperties",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MaterialsAndSupplies",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MachineryFurnitureEquipment",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LongTermProvisions",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LongTermEquityInvestment",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LongTermDebtAndCapitalLeaseObligation",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LongTermDebt",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LongTermContracts",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LongTermCapitalLeaseObligation",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LoansandAdvancestoCustomer",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LoansandAdvancestoBank",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LoansReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LoansHeldForSale",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LoanCapital",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LoanAndLoanReceivables",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LineOfCredit",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LimitedPartnershipCapital",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LimitedPartnership",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LiabilitiesRecognizedforFairValueChangesinPortfolioHedgeofInterestRateRisk",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LiabilitiesOfDiscontinuedOperations",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LiabilitiesHeldforSaleTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LiabilitiesHeldforSaleNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LiabilitiesHeldforSaleCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Leases",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LandAndImprovements",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemsinTheCourseofTransmissiontoOtherBanks",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentsinSubsidiariesatCost",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentsinJointVenturesatCost",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentsinAssociatesatCost",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentsInVariableInterestEntity",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentsInOtherVenturesUnderEquityMethod",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentsInAffiliatesSubsidiariesAssociatesAndJointVentures",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentsAndAdvances",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentinFinancialAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentTaxCredits",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentProperties",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentContractLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestedCapital",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Inventory",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InventoriesAdjustmentsAllowances",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InterestPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InterestBearingDepositsLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InterestBearingDepositsAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InterestBearingBorrowingsTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InterestBearingBorrowingsNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InterestBearingBorrowingsCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InsuranceReceivables",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InsurancePayables",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InsuranceFundsNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InsuranceFundsCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InsuranceContractLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InsuranceContractAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "IncomeTaxPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "HeldToMaturitySecurities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "HedgingLiabilitiesTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "HedgingLiabilitiesNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "HedgingLiabilitiesCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "HedgingAssetsTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "HedgingAssetsNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "HedgingAssetsCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GuaranteedInvestmentContract",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GrossPPE",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GrossNotesReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GrossLoan",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GrossAccountsReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GoodwillAndOtherIntangibleAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Goodwill",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GeneralPartnershipCapital",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GainsLossesNotAffectingRetainedEarnings",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FuturePolicyBenefits",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FuelAndNaturalGas",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ForeignCurrencyTranslationAdjustments",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ForeignComponent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ForeclosedAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FlightFleetVehicleAndRelatedEquipments",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FixedMaturityInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FixedMaturitiesTrading",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FixedMaturitiesHeldToMaturity",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FixedMaturitiesAvailableForSale",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FixedAssetsRevaluationReserve",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FiscalYearChange",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinishedGoods",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinancialOrDerivativeInvestmentCurrentLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinancialLiabilitiesNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinancialLiabilitiesMeasuredatAmortizedCostTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinancialLiabilitiesDesignatedasFairValueThroughProfitorLossTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinancialLiabilitiesCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinancialInstrumentsSoldUnderAgreementsToRepurchase",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinancialAssetsDesignatedasFairValueThroughProfitorLossTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinancialAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinanceLeaseReceivablesNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinanceLeaseReceivablesCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinanceLeaseReceivables",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FederalHomeLoanBankStock",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FederalFundsSoldAndSecuritiesPurchaseUnderAgreementsToResell",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FederalFundsSold",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FederalFundsPurchasedAndSecuritiesSoldUnderAgreementToRepurchase",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FederalFundsPurchased",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FacilitiesAndOther",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "EquitySharesInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "EquityInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "EmployeeBenefits",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ElectricUtilityPlant",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ESOPDebtGuarantee",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DuetoRelatedPartiesNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DuetoRelatedPartiesCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DuetoRelatedParties",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DuefromRelatedPartiesNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DuefromRelatedPartiesCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DividendsPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DerivativeProductLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DerivativeAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DepositsbyBank",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DepositsReceivedunderCededInsuranceContract",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DepositsMadeunderAssumedReinsuranceContract",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DepositCertificates",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DefinedPensionBenefit",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredTaxLiabilitiesTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredTaxAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredPolicyAcquisitionCosts",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredIncomeTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredFinancingCosts",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredCosts",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredCostCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredAcquisitionCosts",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DebtTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DebtSecuritiesinIssue",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DebtSecurities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DebtDueInYear5",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DebtDueInYear2",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DebtDueInYear1",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DebtDueBeyond",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DebenturesandDebtCertificates",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CustomerAccounts",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CustomerAcceptances",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentProvisions",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentOtherFinancialLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentNotesPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentDeferredTaxesLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentDeferredTaxesAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentDeferredRevenue",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentDeferredLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentDeferredAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentDebtAndCapitalLeaseObligation",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentDebt",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentCapitalLeaseObligation",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentAccruedExpenses",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ConvertibleLoansTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ConvertibleLoansNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ConvertibleLoansCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ConsumerLoan",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ConstructionInProgress",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ConstructionGrants",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CommonUtilityPlant",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CommonStocksAvailableForSale",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CommonStockEquity",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CommonStock",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CommercialPaper",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CommercialLoan",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ClaimsOutstanding",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CertificatesofDepositsandOtherDebtSecuritiesIssued",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CededUnearnedPremiums",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CasualtyClaims",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CashandBalanceswithCentralBanks",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CashValueOfLifeInsurance",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CashRestrictedOrPledged",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CashEquivalents",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CashCashEquivalentsAndShortTermInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CashCashEquivalentsAndFederalFundsSold",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CashAndDueFromBanks",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CashAndCashEquivalents",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cash",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CapitalStock",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CapitalLeaseObligations",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BuildingsAndImprovements",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BiologicalAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BankOwnedLifeInsurance",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BankLoansTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BankLoansNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BankLoansCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BankLoan",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BankIndebtedness",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BankAcceptanceExecutedAndOutstanding",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AvailableForSaleSecurities",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AssetsPledgedasCollateralSubjecttoSaleorRepledgingTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AssetsOfDiscontinuedOperations",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AssetsHeldForSaleNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AssetsHeldForSaleCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AssetsHeldForSale",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AllowanceForNotesReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AllowanceForLoansAndLeaseLosses",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AllowanceForDoubtfulAccountsReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AdvancesfromCentralBanks",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AdvanceFromFederalHomeLoanBanks",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AdditionalPaidInCapital",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccumulatedDepreciation",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccruedandDeferredIncomeNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccruedandDeferredIncomeCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccruedandDeferredIncome",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccruedLiabilitiesTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccruedInvestmentIncome",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccruedInterestReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccountsReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccountsPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "WorkingCapital",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "WorkInProcess",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "WaterProduction",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "UnrealizedGainLoss",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "UnpaidLossAndLossReserve",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "UnearnedPremiums",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "UnearnedIncome",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "UnclassifiedCurrentAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "UnbilledReceivables",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "UnallocatedSurplus",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TrustPreferredSecurities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TreasuryStock",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TreasurySharesNumber",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TreasuryBillsandOtherEligibleBills",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TradingandFinancialLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TradingSecurities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TradingLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TradingAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TradingAndOtherReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TradeandOtherPayablesNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TradeAndOtherReceivablesNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalTaxPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPolicyHoldersLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPartnershipCapital",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalNonCurrentLiabilitiesNetMinorityInterest",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalNonCurrentLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalNonCurrentAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalLiabilitiesNetMinorityInterest",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalLiabilitiesAsReported",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalFinancialLeaseObligations",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalEquityGrossMinorityInterest",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalEquityAsReported",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalEquity",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalDeposits",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalDeferredCreditsAndOtherNonCurrentLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalDebtInMaturitySchedule",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalDebt",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalCapitalization",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TimeDepositsPlaced",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TaxesReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TaxesAssetsCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TaxAssetsTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TangibleBookValue",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "SubordinatedLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StudentLoan",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StockholdersEquity",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ShortTermInvestmentsTrading",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ShortTermInvestmentsHeldToMaturity",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ShortTermInvestmentsAvailableForSale",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ShortTermInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "SeparateAccountLiability",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "SeparateAccountAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "SecuritySoldNotYetRepurchased",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "SecurityBorrowed",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "SecurityAgreeToBeResell",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "SecuritiesLoaned",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "SecuritiesLendingPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "SecuritiesLendingCollateral",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "SecuritiesAndInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RetainedEarnings",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RestrictedInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RestrictedCommonStock",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RestrictedCashAndInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RestrictedCashAndCashEquivalents",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RestrictedCash",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ReinsuranceShareofInsuranceContract",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ReinsuranceShareofAccruedPolicyholderClaims",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ReinsuranceRecoverableForUnpaidLosses",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ReinsuranceRecoverableForPaidLosses",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ReinsuranceRecoverable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ReinsuranceReceivables",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ReinsuranceBalancesPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ReinsuranceAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RegulatoryLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RegulatoryAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RedeemablePreferredStock",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RecievablesAdjustmentsAllowances",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Receivables",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RealEstateHeldForSale",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RealEstateAndRealEstateJointVenturesHeldForInvestment",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RealEstate",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RawMaterials",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PurchasedComponents",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ProvisionsTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Properties",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrepaidReinsurancePremiums",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrepaidAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PremiumsReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PreferredStocksAvailableForSale",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PreferredStockOfSubsidiary",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PreferredStockEquity",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PreferredStock",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PreferredSharesNumber",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PreferredSecuritiesOutsideStockEquity",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PolicyholderFunds",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PolicyLoans",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PlacementwithBanksandOtherFinancialInstitutions",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PensionandOtherPostRetirementBenefitPlansCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PensionAndOtherPostretirementBenefitPlansTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PaymentofBills",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PayablesAndAccruedExpenses",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Payables",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Patents",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ParticipatingPolicyholderEquity",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherReserves",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherReceivables",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherRealEstateOwned",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherProperties",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherNonCurrentLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherNonCurrentAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherLoansTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherLoansNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherLoansCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherLoanAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherInvestedAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherInventories",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherInterestEarningAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherIntangibleAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherFinancialLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherEquityInterest",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherEquityAdjustments",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherDeposits",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherDeferredCosts",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherCurrentLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherCurrentBorrowings",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherCurrentAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherCapitalStock",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherBorrowedFunds",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OrdinarySharesNumber",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OperatingLeaseAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NotesReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NonInterestBearingDeposits",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NonInterestBearingBorrowingsTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NonInterestBearingBorrowingsNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NonInterestBearingBorrowingsCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentPrepaidAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentPensionAndOtherPostretirementBenefitPlans",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentOtherFinancialLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentNoteReceivables",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentDeferredTaxesLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentDeferredTaxesAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentDeferredRevenue",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentDeferredLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentDeferredAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentAccruedExpenses",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NonCurrentAccountsReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NetUtilityPlant",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NetUnrealizedGainLossInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NetUnrealizedGainLossForeignCurrency",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NetTangibleAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NetPPE",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NetOtherUnrealizedGainLoss",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NetLoan",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NetDebt",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NetAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NaturalResourceAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NaturalGasFuelAndOther",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MortgageLoan",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MortgageAndConsumerloans",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MoneyMarketInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MinorityInterest",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MinimumPensionLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MineralProperties",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MaterialsAndSupplies",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MachineryFurnitureEquipment",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LongTermProvisions",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LongTermEquityInvestment",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LongTermDebtAndCapitalLeaseObligation",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LongTermDebt",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LongTermContracts",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LongTermCapitalLeaseObligation",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LoansandAdvancestoCustomer",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LoansandAdvancestoBank",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LoansReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LoansHeldForSale",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LoanCapital",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LoanAndLoanReceivables",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LineOfCredit",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LimitedPartnershipCapital",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LimitedPartnership",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LiabilitiesRecognizedforFairValueChangesinPortfolioHedgeofInterestRateRisk",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LiabilitiesOfDiscontinuedOperations",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LiabilitiesHeldforSaleTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LiabilitiesHeldforSaleNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LiabilitiesHeldforSaleCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Leases",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LandAndImprovements",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemsinTheCourseofTransmissiontoOtherBanks",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentsinSubsidiariesatCost",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentsinJointVenturesatCost",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentsinAssociatesatCost",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentsInVariableInterestEntity",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentsInOtherVenturesUnderEquityMethod",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentsInAffiliatesSubsidiariesAssociatesAndJointVentures",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentsAndAdvances",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentinFinancialAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentTaxCredits",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentProperties",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestmentContractLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InvestedCapital",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Inventory",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InventoriesAdjustmentsAllowances",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InterestPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InterestBearingDepositsLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InterestBearingDepositsAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InterestBearingBorrowingsTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InterestBearingBorrowingsNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InterestBearingBorrowingsCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InsuranceReceivables",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InsurancePayables",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InsuranceFundsNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InsuranceFundsCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InsuranceContractLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InsuranceContractAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "IncomeTaxPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "HeldToMaturitySecurities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "HedgingLiabilitiesTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "HedgingLiabilitiesNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "HedgingLiabilitiesCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "HedgingAssetsTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "HedgingAssetsNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "HedgingAssetsCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "GuaranteedInvestmentContract",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "GrossPPE",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "GrossNotesReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "GrossLoan",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "GrossAccountsReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "GoodwillAndOtherIntangibleAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Goodwill",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "GeneralPartnershipCapital",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "GainsLossesNotAffectingRetainedEarnings",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FuturePolicyBenefits",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FuelAndNaturalGas",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ForeignCurrencyTranslationAdjustments",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ForeignComponent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ForeclosedAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FlightFleetVehicleAndRelatedEquipments",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FixedMaturityInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FixedMaturitiesTrading",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FixedMaturitiesHeldToMaturity",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FixedMaturitiesAvailableForSale",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FixedAssetsRevaluationReserve",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FiscalYearChange",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FinishedGoods",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FinancialOrDerivativeInvestmentCurrentLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FinancialLiabilitiesNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FinancialLiabilitiesMeasuredatAmortizedCostTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FinancialLiabilitiesDesignatedasFairValueThroughProfitorLossTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FinancialLiabilitiesCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FinancialInstrumentsSoldUnderAgreementsToRepurchase",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FinancialAssetsDesignatedasFairValueThroughProfitorLossTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FinancialAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FinanceLeaseReceivablesNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FinanceLeaseReceivablesCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FinanceLeaseReceivables",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FederalHomeLoanBankStock",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FederalFundsSoldAndSecuritiesPurchaseUnderAgreementsToResell",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FederalFundsSold",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FederalFundsPurchasedAndSecuritiesSoldUnderAgreementToRepurchase",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FederalFundsPurchased",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FacilitiesAndOther",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "EquitySharesInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "EquityInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "EmployeeBenefits",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ElectricUtilityPlant",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ESOPDebtGuarantee",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DuetoRelatedPartiesNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DuetoRelatedPartiesCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DuetoRelatedParties",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DuefromRelatedPartiesNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DuefromRelatedPartiesCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DividendsPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DerivativeProductLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DerivativeAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DepositsbyBank",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DepositsReceivedunderCededInsuranceContract",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DepositsMadeunderAssumedReinsuranceContract",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DepositCertificates",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DefinedPensionBenefit",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredTaxLiabilitiesTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredTaxAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredPolicyAcquisitionCosts",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredIncomeTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredFinancingCosts",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredCosts",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredCostCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DeferredAcquisitionCosts",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DebtTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DebtSecuritiesinIssue",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DebtSecurities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DebtDueInYear5",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DebtDueInYear2",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DebtDueInYear1",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DebtDueBeyond",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DebenturesandDebtCertificates",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CustomerAccounts",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CustomerAcceptances",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentProvisions",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentOtherFinancialLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentNotesPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentDeferredTaxesLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentDeferredTaxesAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentDeferredRevenue",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentDeferredLiabilities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentDeferredAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentDebtAndCapitalLeaseObligation",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentDebt",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentCapitalLeaseObligation",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentAccruedExpenses",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ConvertibleLoansTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ConvertibleLoansNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ConvertibleLoansCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ConsumerLoan",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ConstructionInProgress",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ConstructionGrants",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CommonUtilityPlant",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CommonStocksAvailableForSale",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CommonStockEquity",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CommonStock",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CommercialPaper",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CommercialLoan",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ClaimsOutstanding",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CertificatesofDepositsandOtherDebtSecuritiesIssued",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CededUnearnedPremiums",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CasualtyClaims",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CashandBalanceswithCentralBanks",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CashValueOfLifeInsurance",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CashRestrictedOrPledged",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CashEquivalents",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CashCashEquivalentsAndShortTermInvestments",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CashCashEquivalentsAndFederalFundsSold",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CashAndDueFromBanks",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CashAndCashEquivalents",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cash",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CapitalStock",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CapitalLeaseObligations",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BuildingsAndImprovements",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BiologicalAssets",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BankOwnedLifeInsurance",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BankLoansTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BankLoansNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BankLoansCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BankLoan",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BankIndebtedness",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BankAcceptanceExecutedAndOutstanding",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AvailableForSaleSecurities",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AssetsPledgedasCollateralSubjecttoSaleorRepledgingTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AssetsOfDiscontinuedOperations",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AssetsHeldForSaleNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AssetsHeldForSaleCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AssetsHeldForSale",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AllowanceForNotesReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AllowanceForLoansAndLeaseLosses",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AllowanceForDoubtfulAccountsReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AdvancesfromCentralBanks",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AdvanceFromFederalHomeLoanBanks",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AdditionalPaidInCapital",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AccumulatedDepreciation",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AccruedandDeferredIncomeNonCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AccruedandDeferredIncomeCurrent",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AccruedandDeferredIncome",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AccruedLiabilitiesTotal",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AccruedInvestmentIncome",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AccruedInterestReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AccountsReceivable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AccountsPayable",
                schema: "MStar",
                table: "TBalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);
        }
    }
}
