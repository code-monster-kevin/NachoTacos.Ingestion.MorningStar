using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NachoTacos.Ingestion.MorningStar.Api.EquityApi;
using NachoTacos.Ingestion.MorningStar.Api.Services;
using NachoTacos.Ingestion.MorningStar.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngestionController : ControllerBase
    {
        private readonly ILogger<IngestionController> _logger;
        private readonly IIngestionContext _ingestionContext;
        private readonly IConfiguration _configuration;

        public IngestionController(IConfiguration configuration, IIngestionContext ingestionContext, ILogger<IngestionController> logger)
        {
            _logger = logger;
            _ingestionContext = ingestionContext;
            _configuration = configuration;
        }


        #region "Controllers"
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> IngestExecute(Guid id)
        {
            Authentication authentication = new Authentication(_ingestionContext, _logger);
            TokenEntity tokenEntity = await authentication.GetAccessTokenByClientConfigId(id);

            if (tokenEntity != null)
            {
                var response = await CreateStockExchangeSecurityRequest(tokenEntity.Token);
                //var response = await CreateBalanceSheetRequest(tokenEntity.Token);

                return Ok(response);
            }

            return NotFound(id);
        }

        private async Task<List<StockExchangeSecurityEntity>> CreateStockExchangeSecurityRequest(string token)
        {
            IngestionService ingestion = new IngestionService(_logger);

            string endPoint = _configuration.GetValue<string>("MorningStar:EquityApi:StockExchangeSecurityList");
            EquityApi.StockExchangeSecurity.Request request =
                    EquityApi.StockExchangeSecurity.Request.Create(token, "KLS", "exchangeId", "KLS", "Active");

            var response = await ingestion.Get(endPoint, request);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _logger);

            await persistence.SaveResultToDb("StockExchangeSecurityList", 
                                                endPoint, 
                                                JsonConvert.SerializeObject(request), 
                                                JsonConvert.SerializeObject(response));
            return response;
        }

        private async Task<List<BalanceSheetEntity>> CreateBalanceSheetRequest(string token)
        {
            IngestionService ingestion = new IngestionService(_logger);
            string endPoint = _configuration.GetValue<string>("MorningStar:EquityApi:BalanceSheet");

            EquityApi.BalanceSheet.Request request =
                EquityApi.BalanceSheet.Request.Create(token, "NYS", "Symbol", "IBM", "Annual", "AOR", "1/2018", "1/2019", "Json");

            var response = await ingestion.Get(endPoint, request);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _logger);

            await persistence.SaveResultToDb("BalanceSheetEntityList",
                                                endPoint,
                                                JsonConvert.SerializeObject(request),
                                                JsonConvert.SerializeObject(response));
            return response;
        }
        #endregion
    }
}