using AutoMapper;
using Flurl;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NachoTacos.Ingestion.MorningStar.Api.Services;
using NachoTacos.Ingestion.MorningStar.Data;
using NachoTacos.Ingestion.MorningStar.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.Controllers
{
    /// <summary>
    /// Manually calls the MorningStar API and saves the results to DB
    /// </summary>
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

        /// <summary>
        /// Starts to ingest the MorningStar API can saves the results into the database
        /// </summary>
        /// <param name="id">Client configuration id</param>
        /// <param name="exchangeId">Example "KLS"</param>
        /// <param name="stockStatus">Example "Active"</param>
        /// <returns></returns>
        [HttpGet]
        [Route("StockExchangeSecurity/{id}")]
        public async Task<IActionResult> StockExchangeSecurityRequest(Guid id, string exchangeId, string stockStatus)
        {
            Authentication authentication = new Authentication(_ingestionContext, _logger);
            TokenEntity tokenEntity = await authentication.GetAccessTokenByClientConfigId(id);

            if (tokenEntity != null)
            {
                string endPoint = _configuration.GetValue<string>("MorningStar:EquityApi:StockExchangeSecurityList");
                EquityApi.StockExchangeSecurity.Request request =
                    EquityApi.StockExchangeSecurity.Request.Create(tokenEntity.Token, exchangeId, "exchangeId", exchangeId, stockStatus);
                string requestUrl = endPoint.SetQueryParams(request);

                IngestionTask ingestionTask = IngestionTask.Create(endPoint, JsonConvert.SerializeObject(request));
                _ingestionContext.IngestionTasks.Add(ingestionTask);

                EquityApi.StockExchangeSecurity.Response response = await RestClient.GetDynamicResponseAsync<EquityApi.StockExchangeSecurity.Response>(requestUrl);

                PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
                int result = await persistence.SaveAsync(ingestionTask.IngestionTaskId, response);
                if (result > 0)
                {
                    List<ChangeTable> changes = _ingestionContext.ChangeTables.FromSqlRaw("EXECUTE MergeStockExchangeSecurity @TaskId={0}", ingestionTask.IngestionTaskId).ToList();
                    _logger.LogInformation("MergeStockExchangeSecurity: {0}", JsonConvert.SerializeObject(changes));
                }

                return Ok(result);
            }
            return NotFound(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Client configuration id</param>
        /// <param name="exchangeId">Example "KLS"</param>
        /// <returns></returns>
        [HttpGet]
        [Route("CompanyFinancials/{id}")]
        public async Task<IActionResult> CompanyFinancialsRequest(Guid id, string exchangeId)
        {
            Authentication authentication = new Authentication(_ingestionContext, _logger);
            TokenEntity tokenEntity = await authentication.GetAccessTokenByClientConfigId(id);

            if (tokenEntity != null)
            {
                string endPoint = _configuration.GetValue<string>("MorningStar:EquityApi:CompanyFinancialAvailabilityList");
                EquityApi.CompanyFinancials.Request request =
                    EquityApi.CompanyFinancials.Request.Create(tokenEntity.Token, exchangeId, "exchangeId", exchangeId);
                string requestUrl = endPoint.SetQueryParams(request);

                IngestionTask ingestionTask = IngestionTask.Create(endPoint, JsonConvert.SerializeObject(request));
                _ingestionContext.IngestionTasks.Add(ingestionTask);

                EquityApi.CompanyFinancials.Response response = await RestClient.GetDynamicResponseAsync<EquityApi.CompanyFinancials.Response>(requestUrl);

                PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
                int result = await persistence.SaveAsync(ingestionTask.IngestionTaskId, response);
                if (result > 0)
                {
                    List<ChangeTable> changes = _ingestionContext.ChangeTables.FromSqlRaw("EXECUTE MergeCompanyFinancials @TaskId={0}", ingestionTask.IngestionTaskId).ToList();
                    _logger.LogInformation("MergeCompanyFinancials: {0}", JsonConvert.SerializeObject(changes));
                }
                return Ok(result);
            }
            return NotFound(id);
        }


        [HttpGet]
        [Route("CompanyFinancials/BalanceSheet/Count")]
        public IActionResult BalanceSheet(string exchangeId)
        {
            List<MCompanyFinancialAvailability> stockList =
                    _ingestionContext.MCompanyFinancialAvailabilities
                        .AsQueryable().Where(x => x.ExchangeId == exchangeId)
                        .ToList();

            return Ok(stockList.Count);
        }

        [HttpGet]
        [Route("CompanyFinancials/CashFlow/Difference")]
        public IActionResult CashFlowDifference(string exchangeId)
        {
            var existingSymbols = _ingestionContext.MCashFlows.AsQueryable()
                                                    .Where(x => x.ExchangeId == exchangeId)
                                                    .Select(x => x.Symbol).Distinct();

            var companyFinancialQuery = _ingestionContext.MCompanyFinancialAvailabilities.AsQueryable()
                                                         .Where(x => !existingSymbols.Contains(x.Symbol));

            return Ok(companyFinancialQuery.ToList());
        }
        #endregion
    }
}