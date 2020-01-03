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
                IngestionService ingestionService = new IngestionService(_configuration, _ingestionContext, _logger);
                var response = await ingestionService.IngestionMain(tokenEntity.Token);

                return Ok(response);
            }

            return NotFound(id);
        }
        #endregion
    }
}