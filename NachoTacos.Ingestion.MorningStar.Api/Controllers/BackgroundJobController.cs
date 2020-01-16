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

        /// <summary>
        /// Exchange Coverage List
        /// </summary>
        /// <param name="id">Client Configuration ID</param>
        /// <param name="exchangeId">i.e. KLS</param>
        /// <param name="stockStatus">Active, Delisted, All</param>
        /// <returns></returns>
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
        /// Financials Coverage List
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
        /// Retrieves the Annual and Quarterly Balance Sheet
        /// including types "AOR", "Restated", "Preliminary"
        /// </summary>
        /// <param name="id">Client Configuration ID</param>
        /// <param name="exchangeId">Exchange ie KLS</param>
        /// <param name="year">ie 2019</param>
        /// <param name="range">1 to 9</param>
        /// <param name="symbol">Ticker code i.e. 1155</param>
        /// <param name="isDifferenceOnly">To only pull missing data</param>
        /// <returns></returns>
        [HttpGet]
        [Route("CompanyFinancials/BalanceSheet/{id}")]
        public IActionResult BalanceSheetRequest(Guid id, string exchangeId, int year, int range, string symbol = null, bool isDifferenceOnly = false)
        {
            try
            {
                if (range > 0 && range <= 9)
                {
                    var jobId = BackgroundJob.Enqueue<IngestionJobs>(x => x.GetCompanyFinancialReportAll(id, "BalanceSheet", exchangeId, year, range, symbol, isDifferenceOnly));
                    BackgroundJob.ContinueJobWith<IngestionJobs>(jobId, x => x.MergeFinancialTempToMaster("BalanceSheet"));
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

        /// <summary>
        /// Retrieves the Annual and Quarterly Cash Flow
        /// including types "AOR", "Restated", "Preliminary"
        /// </summary>
        /// <param name="id">Client Configuration ID</param>
        /// <param name="exchangeId">Exchange ie KLS</param>
        /// <param name="year">ie 2019</param>
        /// <param name="range">1 to 9</param>
        /// <param name="symbol">Ticker code i.e. 1155</param>
        /// <param name="isDifferenceOnly">To only pull missing data</param>
        /// <returns></returns>
        [HttpGet]
        [Route("CompanyFinancials/CashFlow/{id}")]
        public IActionResult CashFlowRequest(Guid id, string exchangeId, int year, int range, string symbol = null, bool isDifferenceOnly = false)
        {
            try
            {
                if (range > 0 && range <= 9)
                {
                    var jobId = BackgroundJob.Enqueue<IngestionJobs>(x => x.GetCompanyFinancialReportAll(id, "CashFlow", exchangeId, year, range, symbol, isDifferenceOnly));
                    BackgroundJob.ContinueJobWith<IngestionJobs>(jobId, x => x.MergeFinancialTempToMaster("CashFlow"));
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

        /// <summary>
        /// Retrieves the Annual and Quarterly Income Statement
        /// including types "AOR", "Restated", "Preliminary"
        /// </summary>
        /// <param name="id">Client Configuration ID</param>
        /// <param name="exchangeId">Exchange ie KLS</param>
        /// <param name="year">ie 2019</param>
        /// <param name="range">1 to 9</param>
        /// <param name="symbol">Ticker code i.e. 1155</param>
        /// <param name="isDifferenceOnly">To only pull missing data</param>
        /// <returns></returns>
        [HttpGet]
        [Route("CompanyFinancials/IncomeStatement/{id}")]
        public IActionResult IncomeStatementRequest(Guid id, string exchangeId, int year, int range, string symbol = null, bool isDifferenceOnly = false)
        {
            try
            {
                if (range > 0 && range <= 9)
                {
                    var jobId = BackgroundJob.Enqueue<IngestionJobs>(x => x.GetCompanyFinancialReportAll(id, "IncomeStatement", exchangeId, year, range, symbol, isDifferenceOnly));
                    BackgroundJob.ContinueJobWith<IngestionJobs>(jobId, x => x.MergeFinancialTempToMaster("IncomeStatement"));
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

        /// <summary>
        /// Retrieves the Cash Flow Trailing 12 Months
        /// </summary>
        /// <param name="id">Client Configuration ID</param>
        /// <param name="exchangeId">Exchange ie KLS</param>
        /// <param name="year">ie 2019</param>
        /// <param name="range">1 to 9</param>
        /// <param name="symbol">Ticker code i.e. 1155</param>
        /// <param name="isDifferenceOnly">To only pull missing data</param>
        /// <returns></returns>
        [HttpGet]
        [Route("CompanyFinancials/CashFlowTTM/{id}")]
        public IActionResult CashFlowTTMRequest(Guid id, string exchangeId, int year, int range, string symbol = null, bool isDifferenceOnly = false)
        {
            try
            {
                if (range > 0 && range <= 9)
                {
                    var jobId = BackgroundJob.Enqueue<IngestionJobs>(x => x.GetCompanyFinancialReportAll(id, "CashFlowTTM", exchangeId, year, range, symbol, isDifferenceOnly));
                    BackgroundJob.ContinueJobWith<IngestionJobs>(jobId, x => x.MergeFinancialTempToMaster("CashFlowTTM"));
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

        /// <summary>
        /// Retrieves the Income Statement Trailing 12 Months
        /// </summary>
        /// <param name="id">Client Configuration ID</param>
        /// <param name="exchangeId">Exchange ie KLS</param>
        /// <param name="year">ie 2019</param>
        /// <param name="range">1 to 9</param>
        /// <param name="symbol">Ticker code i.e. 1155</param>
        /// <param name="isDifferenceOnly">To only pull missing data</param>
        /// <returns></returns>
        [HttpGet]
        [Route("CompanyFinancials/IncomeStatementTTM/{id}")]
        public IActionResult IncomeStatementTTMRequest(Guid id, string exchangeId, int year, int range, string symbol = null, bool isDifferenceOnly = false)
        {
            try
            {
                if (range > 0 && range <= 9)
                {
                    var jobId = BackgroundJob.Enqueue<IngestionJobs>(x => x.GetCompanyFinancialReportAll(id, "IncomeStatementTTM", exchangeId, year, range, symbol, isDifferenceOnly));
                    BackgroundJob.ContinueJobWith<IngestionJobs>(jobId, x => x.MergeFinancialTempToMaster("IncomeStatementTTM"));
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

        /// <summary>
        /// Retrieves the Efficiency Ratios
        /// </summary>
        /// <param name="id">Client Configuration ID</param>
        /// <param name="exchangeId">Exchange ie KLS</param>
        /// <param name="year">ie 2019</param>
        /// <param name="range">1 to 9</param>
        /// <param name="symbol">Ticker code i.e. 1155</param>
        /// <param name="isDifferenceOnly">To only pull missing data</param>
        /// <returns></returns>
        [HttpGet]
        [Route("FinancialRatio/EfficiencyRatio/{id}")]
        public IActionResult EfficiencyRatioRequest(Guid id, string exchangeId, int year, int range, string symbol = null, bool isDifferenceOnly = false)
        {
            try
            {
                if (range > 0 && range <= 9)
                {
                    var jobId = BackgroundJob.Enqueue<IngestionJobs>(x => x.GetFinancialRatioReportAll(id, "EfficiencyRatio", exchangeId, year, range, symbol, isDifferenceOnly));
                    BackgroundJob.ContinueJobWith<IngestionJobs>(jobId, x => x.MergeFinancialTempToMaster("EfficiencyRatio"));
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

        /// <summary>
        /// Retrieves the Efficiency Ratios trailing 12 months
        /// </summary>
        /// <param name="id">Client Configuration ID</param>
        /// <param name="exchangeId">Exchange ie KLS</param>
        /// <param name="year">ie 2019</param>
        /// <param name="range">1 to 9</param>
        /// <param name="symbol">Ticker code i.e. 1155</param>
        /// <param name="isDifferenceOnly">To only pull missing data</param>
        /// <returns></returns>
        [HttpGet]
        [Route("FinancialRatio/EfficiencyRatioTTM/{id}")]
        public IActionResult EfficiencyRatioTTMRequest(Guid id, string exchangeId, int year, int range, string symbol = null, bool isDifferenceOnly = false)
        {
            try
            {
                if (range > 0 && range <= 9)
                {
                    var jobId = BackgroundJob.Enqueue<IngestionJobs>(x => x.GetFinancialRatioReportAll(id, "EfficiencyRatioTTM", exchangeId, year, range, symbol, isDifferenceOnly));
                    BackgroundJob.ContinueJobWith<IngestionJobs>(jobId, x => x.MergeFinancialTempToMaster("EfficiencyRatioTTM"));
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

        /// <summary>
        /// Retrives the profitability ratios
        /// </summary>
        /// <param name="id">Client Configuration ID</param>
        /// <param name="exchangeId">Exchange ie KLS</param>
        /// <param name="year">ie 2019</param>
        /// <param name="range">1 to 9</param>
        /// <param name="symbol">Ticker code i.e. 1155</param>
        /// <param name="isDifferenceOnly">To only pull missing data</param>
        /// <returns></returns>
        [HttpGet]
        [Route("FinancialRatio/ProfitabilityRatio/{id}")]
        public IActionResult ProfitabilityRatioRequest(Guid id, string exchangeId, int year, int range, string symbol = null, bool isDifferenceOnly = false)
        {
            try
            {
                if (range > 0 && range <= 9)
                {
                    var jobId = BackgroundJob.Enqueue<IngestionJobs>(x => x.GetFinancialRatioReportAll(id, "ProfitabilityRatio", exchangeId, year, range, symbol, isDifferenceOnly));
                    BackgroundJob.ContinueJobWith<IngestionJobs>(jobId, x => x.MergeFinancialTempToMaster("ProfitabilityRatio"));
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

        /// <summary>
        /// Retrives the profitability ratios trailing 12 months
        /// </summary>
        /// <param name="id">Client Configuration ID</param>
        /// <param name="exchangeId">Exchange ie KLS</param>
        /// <param name="year">ie 2019</param>
        /// <param name="range">1 to 9</param>
        /// <param name="symbol">Ticker code i.e. 1155</param>
        /// <param name="isDifferenceOnly">To only pull missing data</param>
        /// <returns></returns>
        [HttpGet]
        [Route("FinancialRatio/ProfitabilityRatioTTM/{id}")]
        public IActionResult ProfitabilityRatioTTMRequest(Guid id, string exchangeId, int year, int range, string symbol = null, bool isDifferenceOnly = false)
        {
            try
            {
                if (range > 0 && range <= 9)
                {
                    var jobId = BackgroundJob.Enqueue<IngestionJobs>(x => x.GetFinancialRatioReportAll(id, "ProfitabilityRatioTTM", exchangeId, year, range, symbol, isDifferenceOnly));
                    BackgroundJob.ContinueJobWith<IngestionJobs>(jobId, x => x.MergeFinancialTempToMaster("ProfitabilityRatioTTM"));
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


        [HttpGet]
        [Route("FinancialRatio/FinancialHealthRatio/{id}")]
        public IActionResult FinancialHealthRatioRequest(Guid id, string exchangeId, int year, int range, string symbol = null, bool isDifferenceOnly = false)
        {
            try
            {
                if (range > 0 && range <= 9)
                {
                    var jobId = BackgroundJob.Enqueue<IngestionJobs>(x => x.GetFinancialRatioReportAll(id, "FinancialHealthRatio", exchangeId, year, range, symbol, isDifferenceOnly));
                    BackgroundJob.ContinueJobWith<IngestionJobs>(jobId, x => x.MergeFinancialTempToMaster("FinancialHealthRatio"));
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


        [HttpGet]
        [Route("FinancialRatio/GrowthRatio/{id}")]
        public IActionResult GrowthRatioRequest(Guid id, string exchangeId, int year, int range, string symbol = null, bool isDifferenceOnly = false)
        {
            try
            {
                if (range > 0 && range <= 9)
                {
                    var jobId = BackgroundJob.Enqueue<IngestionJobs>(x => x.GetFinancialRatioReportAll(id, "GrowthRatio", exchangeId, year, range, symbol, isDifferenceOnly));
                    BackgroundJob.ContinueJobWith<IngestionJobs>(jobId, x => x.MergeFinancialTempToMaster("GrowthRatio"));
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


        [HttpGet]
        [Route("FinancialRatio/ValuationRatio/{id}")]
        public IActionResult ValuationRatioRequest(Guid id, string exchangeId, int year, int range, string symbol = null, bool isDifferenceOnly = false)
        {
            try
            {
                if (range > 0 && range <= 9)
                {
                    var jobId = BackgroundJob.Enqueue<IngestionJobs>(x => x.GetFinancialRatioReportAll(id, "ValuationRatio", exchangeId, year, range, symbol, isDifferenceOnly));
                    BackgroundJob.ContinueJobWith<IngestionJobs>(jobId, x => x.MergeFinancialTempToMaster("ValuationRatio"));
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


        [HttpGet]
        [Route("FinancialRatio/QuantitativeRating/{id}")]
        public IActionResult QuantitativeRatingRequest(Guid id, string exchangeId, int year, int range, string symbol = null, bool isDifferenceOnly = false)
        {
            try
            {
                if (range > 0 && range <= 9)
                {
                    var jobId = BackgroundJob.Enqueue<IngestionJobs>(x => x.GetFinancialRatioReportAll(id, "QuantitativeRating", exchangeId, year, range, symbol, isDifferenceOnly));
                    BackgroundJob.ContinueJobWith<IngestionJobs>(jobId, x => x.MergeFinancialTempToMaster("QuantitativeRating"));
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

        [HttpGet]
        [Route("FinancialRatio/MonthlyMarketCap/{id}")]
        public IActionResult MonthlyMarketCapRequest(Guid id, string exchangeId, int year, int range, string symbol = null, bool isDifferenceOnly = false)
        {
            try
            {
                if (range > 0 && range <= 9)
                {
                    var jobId = BackgroundJob.Enqueue<IngestionJobs>(x => x.GetFinancialRatioReportAll(id, "MarketCapitalization", exchangeId, year, range, symbol, isDifferenceOnly));
                    BackgroundJob.ContinueJobWith<IngestionJobs>(jobId, x => x.MergeFinancialTempToMaster("MarketCapitalization"));
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

        [HttpGet]
        [Route("FinancialRatio/EODPriceHistory/{id}")]
        public IActionResult EODPriceHistoryRequest(Guid id, string exchangeId, int year, int range, string symbol = null, bool isDifferenceOnly = false)
        {
            try
            {
                if (range > 0 && range <= 9)
                {
                    var jobId = BackgroundJob.Enqueue<IngestionJobs>(x => x.GetFinancialRatioReportAll(id, "EODPriceHistory", exchangeId, year, range, symbol, isDifferenceOnly));
                    BackgroundJob.ContinueJobWith<IngestionJobs>(jobId, x => x.MergeFinancialTempToMaster("EODPriceHistory"));
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