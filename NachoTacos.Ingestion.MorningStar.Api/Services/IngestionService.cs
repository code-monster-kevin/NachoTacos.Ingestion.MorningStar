using Flurl;
using Microsoft.Extensions.Logging;
using NachoTacos.Ingestion.MorningStar.Data;
using NachoTacos.Ingestion.MorningStar.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using NachoTacos.Ingestion.MorningStar.Api.EquityApi;
using Microsoft.Extensions.Configuration;
using System;
using Newtonsoft.Json;

namespace NachoTacos.Ingestion.MorningStar.Api.Services
{
    public class IngestionService
    {
        private readonly ILogger _logger;
        private readonly IIngestionContext _ingestionContext;
        private readonly IConfiguration _configuration;

        public IngestionService(IConfiguration configuration, IIngestionContext ingestionContext, ILogger logger)
        {
            _configuration = configuration;
            _ingestionContext = ingestionContext;
            _logger = logger;
        }

        public async Task<List<EquityApi.StockExchangeSecurity.StockExchangeSecurityEntity>> IngestionMain(string token)
        {
            try
            {
                string endPoint = _configuration.GetValue<string>("MorningStar:EquityApi:StockExchangeSecurityList");
                _logger.LogInformation("IngestionMain endPoint: {0}", endPoint);

                EquityApi.StockExchangeSecurity.Request request = new EquityApi.StockExchangeSecurity.Request
                {
                    exchangeId = "KLS",
                    identifier = "KLS",
                    identifierType = "exchangeId",
                    stockStatus = "Active",
                    Token = token,
                    ResponseType = "Json"
                };

                List<EquityApi.StockExchangeSecurity.StockExchangeSecurityEntity> stockExchangeSecurityEntityList = await GlobalMasterListsService.GetStockExchangeSecurityList(endPoint, request);
                // List<StockExchangeSecurityEntity> stockExchangeSecurityEntityList = await GlobalMasterListsService.GetStockExchangeSecurityList(endPoint, token, "KLS", "KLS", "exchangeId", "Active");
                
                IngestionResult ingestionResult = IngestionResult.Create("StockExchangeSecurityList", endPoint, JsonConvert.SerializeObject(request), JsonConvert.SerializeObject(stockExchangeSecurityEntityList));
                _ingestionContext.IngestionResults.Add(ingestionResult);
                await _ingestionContext.SaveChangesAsync();

                return stockExchangeSecurityEntityList;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
