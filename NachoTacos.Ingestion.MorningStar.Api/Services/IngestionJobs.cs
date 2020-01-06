using AutoMapper;
using Flurl;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NachoTacos.Ingestion.MorningStar.Data;
using NachoTacos.Ingestion.MorningStar.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.Services
{
    public class IngestionJobs
    {
        private readonly ILogger<IngestionJobs> _logger;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly IIngestionContext _ingestionContext;

        public IngestionJobs(IIngestionContext ingestionContext, IConfiguration configuration, IMapper mapper, ILogger<IngestionJobs> logger)
        {
            _ingestionContext = ingestionContext;
            _configuration = configuration;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<string> GetStockExchangeSecurity(Guid id, string exchangeId, string stockStatus)
        {
            try
            {
                TokenEntity tokenEntity = await GetTokenEntity(id);
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

                    return string.Format("{0} records saved", result);
                }

                return "Nothing was saved, invalid token";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.InnerException);
                return ex.Message;
            }
        }

        public async Task<string> GetCompanyFinancials(Guid id, string exchangeId)
        {
            try
            {
                TokenEntity tokenEntity = await GetTokenEntity(id);
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

                    return string.Format("{0} records saved", result);
                }

                return "Nothing was saved, invalid token";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.InnerException);
                return ex.Message;
            }
        }

        private async Task<TokenEntity> GetTokenEntity(Guid id)
        {
            Authentication authentication = new Authentication(_ingestionContext, _logger);
            return await authentication.GetAccessTokenByClientConfigId(id);
        }
    }
}
