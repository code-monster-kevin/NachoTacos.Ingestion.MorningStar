using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NachoTacos.Ingestion.MorningStar.Api.Services;
using NachoTacos.Ingestion.MorningStar.Data;
using System;
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
        private readonly IMapper _mapper;

        public IngestionController(IConfiguration configuration, IIngestionContext ingestionContext, IMapper mapper, ILogger<IngestionController> logger)
        {
            _logger = logger;
            _ingestionContext = ingestionContext;
            _mapper = mapper;
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

        private async Task<int> CreateStockExchangeSecurityRequest(string token)
        {
            string endPoint = _configuration.GetValue<string>("MorningStar:EquityApi:StockExchangeSecurityList");
            EquityApi.StockExchangeSecurity.Request request =
                    EquityApi.StockExchangeSecurity.Request.Create(token, "KLS", "exchangeId", "KLS", "Active");

            return await IngestPersist(endPoint, request);
        }

        private async Task<int> CreateBalanceSheetRequest(string token)
        {
            string endPoint = _configuration.GetValue<string>("MorningStar:EquityApi:BalanceSheet");

            EquityApi.BalanceSheet.Request request =
                EquityApi.BalanceSheet.Request.Create(token, "NYS", "Symbol", "IBM", "Annual", "AOR", "1/2018", "1/2019", "Json");

            return await IngestPersist(endPoint, request);
        }

        private async Task<int> IngestPersist(string endPoint, dynamic request)
        {
            IngestionService ingestion = new IngestionService(_logger);
            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            var response = await ingestion.Get(endPoint, request);
            return await persistence.Save(request, response);
        }
        #endregion
    }
}