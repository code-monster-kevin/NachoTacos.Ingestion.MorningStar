using Microsoft.EntityFrameworkCore;
using NachoTacos.Ingestion.MorningStar.Domain;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Data
{
    public class IngestionContext : DbContext, IIngestionContext
    {
        public IngestionContext(DbContextOptions<IngestionContext> options) : base(options)
        {

        }

        #region "Main Tables"
        public DbSet<ClientConfiguration> ClientConfigurations { get; set; }
        public DbSet<IngestionTask> IngestionTasks { get; set; }
        public DbSet<ChangeTable> ChangeTables { get; set; }
        #endregion

        #region "MorningStar Task Tables"

        public DbSet<TStockExchangeSecurity> TStockExchangeSecurities { get; set; }
        public DbSet<TCompanyFinancialAvailability> TCompanyFinancialAvailabilities { get; set; }
        public DbSet<TGeneralInfo> TGeneralInfo { get; set; }
        public DbSet<TBalanceSheet> TBalanceSheets { get; set; }
        public DbSet<TCashFlow> TCashFlows { get; set; }
        public DbSet<TCashFlowTTM> TCashFlowTTMs { get; set; }
        public DbSet<TIncomeStatement> TIncomeStatements { get; set; }
        public DbSet<TIncomeStatementTTM> TIncomeStatementTTMs { get; set; }
        public DbSet<TEfficiencyRatio> TEfficiencyRatios { get; set; }
        public DbSet<TEfficiencyRatioTTM> TEfficiencyRatioTTMs { get; set; }
        public DbSet<TProfitabilityRatio> TProfitabilityRatios { get; set; }
        public DbSet<TProfitabilityRatioTTM> TProfitabilityRatioTTMs { get; set; }

        #endregion

        #region "MorningStar Master Tables"
        public DbSet<MStockExchangeSecurity> MStockExchangeSecurities { get; set; }
        public DbSet<MCompanyFinancialAvailability> MCompanyFinancialAvailabilities { get; set; }
        public DbSet<MBalanceSheet> MBalanceSheets { get; set; }
        public DbSet<MCashFlow> MCashFlows { get; set; }
        public DbSet<MCashFlowTTM> MCashFlowTTMs { get; set; }
        public DbSet<MIncomeStatement> MIncomeStatements { get; set; }
        public DbSet<MIncomeStatementTTM> MIncomeStatementTTMs { get; set; }
        public DbSet<MEfficiencyRatio> MEfficiencyRatios { get; set; }
        public DbSet<MEfficiencyRatioTTM> MEfficiencyRatioTTMs { get; set; }
        public DbSet<MProfitabilityRatio> MProfitabilityRatios { get; set; }
        public DbSet<MProfitabilityRatioTTM> MProfitabilityRatioTTMs { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ChangeTable>().HasNoKey();

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                    .SelectMany(t => t.GetProperties())
                    .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetColumnType("decimal(18, 2)");
            }
        }

        public override int SaveChanges()
        {
            UpdateEntityDates();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateEntityDates();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void UpdateEntityDates()
        {
            var now = DateTime.UtcNow;
            foreach (var changedEntity in ChangeTracker.Entries())
            {
                if (changedEntity.Entity is IUpdateable entity)
                {
                    switch (changedEntity.State)
                    {
                        case EntityState.Added:
                            entity.CreatedDate = now;
                            entity.UpdatedDate = now;
                            break;

                        case EntityState.Modified:
                            Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                            entity.UpdatedDate = now;
                            break;
                    }
                }
            }
        }
    }
}
