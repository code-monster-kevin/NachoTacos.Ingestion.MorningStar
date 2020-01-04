using Microsoft.Extensions.Logging;
using NachoTacos.Ingestion.MorningStar.Data;
using NachoTacos.Ingestion.MorningStar.Domain;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.Services
{
    public class PersistenceService
    {
        private readonly ILogger _logger;
        private readonly IIngestionContext _ingestionContext;

        public PersistenceService(IIngestionContext ingestionContext, ILogger logger)
        {
            _ingestionContext = ingestionContext;
            _logger = logger;
        }

        public async Task SaveResultToDb(string source, string endPoint, string requestData, string responseData)
        {
            IngestionResult ingestionResult = IngestionResult.Create(source, endPoint, requestData, responseData);
            _ingestionContext.IngestionResults.Add(ingestionResult);
            await _ingestionContext.SaveChangesAsync();

            _logger.LogInformation("Saved to database: (0)", source);
        }
    }
}
