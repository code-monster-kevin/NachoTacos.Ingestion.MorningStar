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

        public DbSet<ClientConfiguration> ClientConfigurations { get; set; }
        public DbSet<IngestionResult> IngestionResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
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
