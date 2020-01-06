using Microsoft.EntityFrameworkCore;
using NachoTacos.Ingestion.MorningStar.Domain;
using System;
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

        #endregion

        #region "MorningStar Master Tables"
        public DbSet<MStockExchangeSecurity> MStockExchangeSecurities { get; set; }
        public DbSet<MCompanyFinancialAvailability> MCompanyFinancialAvailabilities { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ChangeTable>().HasNoKey();

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
