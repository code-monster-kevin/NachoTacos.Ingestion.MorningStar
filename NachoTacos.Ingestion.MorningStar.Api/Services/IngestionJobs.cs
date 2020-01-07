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

        public async Task<string> GetBalanceSheet(Guid id, string exchangeId, string symbol, string statementType, string dataType, string startDate, string endDate)
        {
            try
            {
                TokenEntity tokenEntity = await GetTokenEntity(id);
                if (tokenEntity != null)
                {
                    int result = await PersistBalanceSheet(tokenEntity.Token, exchangeId, symbol, statementType, dataType, startDate, endDate);
                    return string.Format("{0} records saved", result);
                }

                return "Nothing was saved, invalid token";
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message, ex.InnerException);
                return ex.Message;
            }
        }

        public async Task<int> GetBalanceSheetAll(Guid id, string exchangeId, string stockStatus, int year)
        {
            try
            {
                string endPoint = _configuration.GetValue<string>("MorningStar:EquityApi:BalanceSheet");
                TokenEntity tokenEntity = await GetTokenEntity(id);

                int result = 0;
                if (tokenEntity != null)
                {
                    List<MStockExchangeSecurity> stockList =
                    _ingestionContext
                        .MStockExchangeSecurities.Where(x => x.ExchangeId == exchangeId && x.StockStatus == stockStatus)
                        .Take(10)
                        .ToList();

                    List<EquityApi.BalanceSheet.Response> listMain = new List<EquityApi.BalanceSheet.Response>();
                    IngestionTask ingestionTask = IngestionTask.Create(endPoint, string.Format("BalanceSheetAll {0}", exchangeId));
                    _ingestionContext.IngestionTasks.Add(ingestionTask);

                    foreach (MStockExchangeSecurity stock in stockList)
                    {
                        List<EquityApi.BalanceSheet.Response> listSymbol =
                            await GetBalanceSheetResponses(CreateBaseFinancialRequestList(tokenEntity.Token, exchangeId, stock.Symbol, year));

                        listMain = listMain.Union(listSymbol).ToList();
                    }

                    PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
                    result = await persistence.SaveAsync(ingestionTask.IngestionTaskId, listMain);
                }

                _logger.LogInformation(string.Format("[GetBalanceSheetAll] ===> {0} records saved", result));
                return result;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message, ex.InnerException);
                return 0;
            }
        }


        public async Task<int> GetBalanceSheetBySymbol(Guid id, string exchangeId, string symbol, int year)
        {
            try
            {
                string endPoint = _configuration.GetValue<string>("MorningStar:EquityApi:BalanceSheet");
                TokenEntity tokenEntity = await GetTokenEntity(id);
                int result = 0;

                if (tokenEntity != null)
                {
                    IngestionTask ingestionTask = IngestionTask.Create(endPoint, symbol);
                    _ingestionContext.IngestionTasks.Add(ingestionTask);

                    List<EquityApi.BalanceSheet.Response> responses =
                        await GetBalanceSheetResponses(CreateBaseFinancialRequestList(tokenEntity.Token, exchangeId, symbol, year));
                    
                    PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
                    int saveResult = await persistence.SaveAsync(ingestionTask.IngestionTaskId, responses);

                    if (saveResult > 0)
                    {
                        result += saveResult;
                        List<ChangeTable> changes = _ingestionContext.ChangeTables.FromSqlRaw("EXECUTE MergeBalanceSheet").ToList();
                        _logger.LogInformation("MergeBalanceSheet: {0}", JsonConvert.SerializeObject(changes));
                    }
                    result += saveResult;
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.InnerException);
                return 0;
            }
        }

        private async Task<List<EquityApi.BalanceSheet.Response>> GetBalanceSheetResponses(List<EquityApi.BaseFinancialRequest> requests)
        {
            List<EquityApi.BalanceSheet.Response> responses = new List<EquityApi.BalanceSheet.Response>();
            string endPoint = _configuration.GetValue<string>("MorningStar:EquityApi:BalanceSheet");
            foreach (var request in requests)
            {
                string requestUrl = endPoint.SetQueryParams(request);
                EquityApi.BalanceSheet.Response response = await RestClient.GetDynamicResponseAsync<EquityApi.BalanceSheet.Response>(requestUrl);
                responses.Add(response);
            }
            return responses;
        }

        private List<EquityApi.BaseFinancialRequest> CreateBaseFinancialRequestList(string token, string exchangeId, string symbol, int year)
        {
            List<EquityApi.BaseFinancialRequest> requests = new List<EquityApi.BaseFinancialRequest>();

            int yearRange = 9;  // get up to 9 years of historical data
            int quarterlyYear = 2; // quarterly reports limited to only 3 years of data
            int finalYear = year - yearRange;
            string[] dataTypes = { "AOR", "Restated", "Preliminary" };

            foreach (string dataType in dataTypes)
            {
                string statementType = "Annual";
                string startDate = string.Format("01/{0}", finalYear);
                string endDate = string.Format("01/{0}", year);

                requests.Add(EquityApi.BaseFinancialRequest.Create(token, exchangeId, "Symbol", symbol, statementType, dataType, startDate, endDate));

                statementType = "Quarterly";
                int counter = 0;
                int startYear = year - quarterlyYear;
                int endYear = year;
                while (startYear > finalYear)
                {
                    startDate = string.Format("01/{0}", startYear);
                    endDate = string.Format("01/{0}", endYear);

                    requests.Add(EquityApi.BaseFinancialRequest.Create(token, exchangeId, "Symbol", symbol, statementType, dataType, startDate, endDate));

                    counter++;
                    startYear = year - ((counter + 1) * quarterlyYear);
                    endYear = year - ((counter * quarterlyYear));
                }
            }
            return requests;
        }

        private async Task<int> PersistBalanceSheet(string token, string exchangeId, string symbol, string statementType, string dataType, string startDate, string endDate)
        {
            string endPoint = _configuration.GetValue<string>("MorningStar:EquityApi:BalanceSheet");

            EquityApi.BaseFinancialRequest request =
                        EquityApi.BaseFinancialRequest.Create(token, exchangeId, "Symbol", symbol, statementType, dataType, startDate, endDate);
            string requestUrl = endPoint.SetQueryParams(request);

            IngestionTask ingestionTask = IngestionTask.Create(endPoint, JsonConvert.SerializeObject(request));
            _ingestionContext.IngestionTasks.Add(ingestionTask);

            EquityApi.BalanceSheet.Response response = await RestClient.GetDynamicResponseAsync<EquityApi.BalanceSheet.Response>(requestUrl);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            int result = await persistence.SaveAsync(ingestionTask.IngestionTaskId, response);
            if (result > 0)
            {
                List<ChangeTable> changes = _ingestionContext.ChangeTables.FromSqlRaw("EXECUTE MergeBalanceSheet @TaskId={0}", ingestionTask.IngestionTaskId).ToList();
                _logger.LogInformation("MergeBalanceSheet: {0}", JsonConvert.SerializeObject(changes));
            }
            return result;
        }

        private async Task<TokenEntity> GetTokenEntity(Guid id)
        {
            Authentication authentication = new Authentication(_ingestionContext, _logger);
            return await authentication.GetAccessTokenByClientConfigId(id);
        }
    }
}
