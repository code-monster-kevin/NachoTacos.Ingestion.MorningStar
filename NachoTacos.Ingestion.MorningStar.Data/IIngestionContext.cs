using Microsoft.EntityFrameworkCore;
using NachoTacos.Ingestion.MorningStar.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Data
{
    public interface IIngestionContext
    {
        DbSet<ClientConfiguration> ClientConfigurations { get; set; }
        DbSet<IngestionTask> IngestionTasks { get; set; }
        DbSet<TStockExchangeSecurity> TStockExchangeSecurities { get; set; }
        DbSet<TCompanyFinancialAvailability> TCompanyFinancialAvailabilities { get; set; }
        DbSet<TBalanceSheet> TBalanceSheets { get; set; }
        DbSet<TCashFlow> TCashFlows { get; set; }
        DbSet<TCashFlowTTM> TCashFlowTTMs { get; set; }
        DbSet<TIncomeStatement> TIncomeStatements { get; set; }
        DbSet<TIncomeStatementTTM> TIncomeStatementTTMs { get; set; }
        DbSet<TEfficiencyRatio> TEfficiencyRatios { get; set; }
        DbSet<TEfficiencyRatioTTM> TEfficiencyRatioTTMs { get; set; }
        DbSet<TProfitabilityRatio> TProfitabilityRatios { get; set; }
        DbSet<TProfitabilityRatioTTM> TProfitabilityRatioTTMs { get; set; }
        DbSet<TGeneralInfo> TGeneralInfo { get; set; }
        DbSet<ChangeTable> ChangeTables { get; set; }
        DbSet<MStockExchangeSecurity> MStockExchangeSecurities { get; set; }
        DbSet<MCompanyFinancialAvailability> MCompanyFinancialAvailabilities { get; set; }
        DbSet<MBalanceSheet> MBalanceSheets { get; set; }
        DbSet<MCashFlow> MCashFlows { get; set; }
        DbSet<MCashFlowTTM> MCashFlowTTMs { get; set; }
        DbSet<MIncomeStatement> MIncomeStatements { get; set; }
        DbSet<MIncomeStatementTTM> MIncomeStatementTTMs { get; set; }
        DbSet<MEfficiencyRatio> MEfficiencyRatios { get; set; }
        DbSet<MEfficiencyRatioTTM> MEfficiencyRatioTTMs { get; set; }
        DbSet<MProfitabilityRatio> MProfitabilityRatios { get; set; }
        DbSet<MProfitabilityRatioTTM> MProfitabilityRatioTTMs { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}