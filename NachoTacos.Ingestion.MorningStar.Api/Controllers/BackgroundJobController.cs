using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NachoTacos.Ingestion.MorningStar.Api.Services;
using System;

namespace NachoTacos.Ingestion.MorningStar.Api.Controllers
{
    /// <summary>
    /// Similar to IngestionController, but uses HangFire to run as background job
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BackgroundJobController : ControllerBase
    {
        private readonly ILogger<BackgroundJobController> _logger;

        public BackgroundJobController(ILogger<BackgroundJobController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("StockExchangeSecurity/{id}")]
        public IActionResult StockExchangeSecurityRequest(Guid id, string exchangeId, string stockStatus)
        {
            try
            {
                BackgroundJob.Enqueue<IngestionJobs>(x => x.GetStockExchangeSecurity(id, exchangeId, stockStatus));
                return Ok();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message, ex.InnerException);
                return Problem(ex.Message);
            }
        }

        [HttpGet]
        [Route("CompanyFinancials/{id}")]
        public IActionResult CompanyFinancialsRequest(Guid id, string exchangeId)
        {
            try
            {
                BackgroundJob.Enqueue<IngestionJobs>(x => x.GetCompanyFinancials(id, exchangeId));
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.InnerException);
                return Problem(ex.Message);
            }
        }

        [HttpGet]
        [Route("BalanceSheet/{id}")]
        public IActionResult BalanceSheetAllRequest(Guid id, string exchangeId, string stockStatus, int year, int range)
        {
            try
            {
                BackgroundJob.Enqueue<IngestionJobs>(x => x.GetBalanceSheetAll(id, exchangeId, stockStatus, year, range));
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.InnerException);
                return Problem(ex.Message);
            }
        }

    }
}