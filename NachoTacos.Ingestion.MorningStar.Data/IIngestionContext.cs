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
        DbSet<TBalanceSheet> TBalanceSheets { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}