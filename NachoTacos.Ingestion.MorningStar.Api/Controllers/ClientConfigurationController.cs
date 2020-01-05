using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NachoTacos.Ingestion.MorningStar.Data;
using NachoTacos.Ingestion.MorningStar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientConfigurationController : ControllerBase
    {
        #region "Constructors"
        private readonly ILogger<ClientConfigurationController> _logger;
        private readonly IngestionContext _ingestionContext;
        public ClientConfigurationController(IngestionContext ingestionContext, ILogger<ClientConfigurationController> logger)
        {
            _ingestionContext = ingestionContext;
            _logger = logger;
        }
        #endregion

        #region "Controllers"
        [HttpGet]
        public IActionResult GetClientConfigurations()
        {
            try
            {
                List<ClientConfiguration> clientConfigurations = _ingestionContext.ClientConfigurations.ToList();
                if (clientConfigurations.Count == 0) return NotFound();

                return Ok(clientConfigurations);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return Problem(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetClientConfigurationById(Guid id)
        {
            try
            {
                ClientConfiguration clientConfiguration = _ingestionContext.ClientConfigurations.FirstOrDefault(x => x.ClientConfigurationId == id);
                if (clientConfiguration == null) return NotFound(id);

                return Ok(clientConfiguration);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return Problem(ex.Message);
            }
        }


        [HttpPost]
        public async Task<IActionResult> CreateClientConfiguration(string login, string password, string loginUrl)
        {
            try
            {
                _ingestionContext.ClientConfigurations.Add(ClientConfiguration.Create(login, password, loginUrl, true));
                int saveResult = await _ingestionContext.SaveChangesAsync();

                return Ok(saveResult);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        [Route("{id}")]
        public async Task<IActionResult> UpdateClientConfiguration(Guid id, string login, string password, string loginUrl, bool isActive)
        {
            try
            {
                ClientConfiguration clientConfiguration = _ingestionContext.ClientConfigurations.FirstOrDefault(x => x.ClientConfigurationId == id);
                if (clientConfiguration == null) return NotFound(id);

                clientConfiguration.AccountLogin = login;
                clientConfiguration.AccountPassword = password;
                clientConfiguration.LoginUrl = loginUrl;
                clientConfiguration.IsActive = isActive;

                _ingestionContext.Update(clientConfiguration);
                int saveResult = await _ingestionContext.SaveChangesAsync();

                return Ok(saveResult);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return Problem(ex.Message);
            }
        }

        #endregion
    }
}