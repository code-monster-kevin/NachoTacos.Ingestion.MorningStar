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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Client Configuration ID</param>
        /// <param name="exchangeId">Exchange ie KLS</param>
        /// <returns></returns>
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

        /// <summary>
        /// Retrieves the Annual and Quarterly balance sheet for all counters
        /// including types "AOR", "Restated", "Preliminary"
        /// </summary>
        /// <param name="id">Client Configuration ID</param>
        /// <param name="exchangeId">Exchange ie KLS</param>
        /// <param name="year">ie 2019</param>
        /// <param name="range">1 to 9</param>
        /// <param name="symbol">Ticker code i.e. 1155</param>
        /// <returns></returns>
        [HttpGet]
        [Route("BalanceSheet/{id}")]
        public IActionResult BalanceSheetAllRequest(Guid id, string exchangeId, int year, int range, string symbol = null)
        {
            try
            {
                if (range > 0 && range <= 9)
                {
                        BackgroundJob.Enqueue<IngestionJobs>(x => x.GetCompanyFinancialReportAll(id, "BalanceSheet", exchangeId, year, range, symbol));
                        return Ok();
                }
                else 
                { 
                    return BadRequest("Report range must be between 1 to 9"); 
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.InnerException);
                return Problem(ex.Message);
            }
        }

    }
}