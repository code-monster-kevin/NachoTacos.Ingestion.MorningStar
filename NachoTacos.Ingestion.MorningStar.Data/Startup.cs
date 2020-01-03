using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace NachoTacos.Ingestion.MorningStar.Data
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection services,
            string connectionString)
        {
            services
                .AddDbContext<IngestionContext>(
                    options =>
                        options.UseSqlServer(connectionString)
                );
        }
    }
}
