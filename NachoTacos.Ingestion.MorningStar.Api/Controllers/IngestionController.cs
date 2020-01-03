using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NachoTacos.Ingestion.MorningStar.Api.Services;
using NachoTacos.Ingestion.MorningStar.Data;
using NachoTacos.Ingestion.MorningStar.Domain.MorningStar;
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

        public IngestionController(IIngestionContext ingestionContext, ILogger<IngestionController> logger)
        {
            _logger = logger;
            _ingestionContext = ingestionContext;
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
                IngestionService ingestionService = new IngestionService(_ingestionContext, _logger);
                StockExchangeSecurityResponse response = await ingestionService.IngestionMain(tokenEntity.Token);

                return Ok(response);
            }

            return NotFound(id);
        }
        #endregion
    }
}