using AutoMapper;
using Dasync.Collections;
using Flurl;
using Hangfire;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NachoTacos.Ingestion.MorningStar.Api.EquityApi;
using NachoTacos.Ingestion.MorningStar.Data;
using NachoTacos.Ingestion.MorningStar.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.Services
{
    public class PagingParameter
    {
        public int Page { get; set; }
        public int Skip { get; set; }
        public int PageSize { get; set; }
    }

   
    public class IngestionJobs
    {
        private readonly ILogger<IngestionJobs> _logger;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly IIngestionContext _ingestionContext;

        private readonly string[] _dataTypes = { "AOR", "Restated", "Preliminary" };

        public IngestionJobs(IIngestionContext ingestionContext, IConfiguration configuration, IMapper mapper, ILogger<IngestionJobs> logger)
        {
            _ingestionContext = ingestionContext;
            _configuration = configuration;
            _mapper = mapper;
            _logger = logger;
        }
        [AutomaticRetry(Attempts = 0)]
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
        [AutomaticRetry(Attempts = 0)]
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
        
        //[AutomaticRetry(Attempts = 0)]
        //public async Task<int> GetBalanceSheetAll(Guid id, string exchangeId, int year, int range, string symbol = null)
        //{
        //    try
        //    {
        //        int result = 0;
        //        TokenEntity tokenEntity = await GetTokenEntity(id);
        //        if (tokenEntity != null)
        //        {
        //            IQueryable<MCompanyFinancialAvailability> query = CreateCompanyFinancialQuery(exchangeId, symbol);

        //            int recordCount = query.Count();
        //            int pageSize = 20;
        //            int pageCount = (int)((recordCount + pageSize) / pageSize);

        //            for (int i = 0; i < pageCount; i++)
        //            {
        //                _logger.LogInformation(string.Format("[PagingParameter] ===> Page {0} Skip {1}", i, pageSize * i));

        //                result += await IngestBalanceSheet(tokenEntity.Token, query, year, range, pageSize, i);
        //            }
        //        }

        //        _logger.LogInformation(string.Format("[GetBalanceSheetAll] ===> {0} records saved", result));
        //        return result;
        //    }
        //    catch(Exception ex)
        //    {
        //        _logger.LogError(ex.Message, ex.InnerException);
        //        return 0;
        //    }
        //}

        [AutomaticRetry(Attempts = 0)]
        public async Task<int> GetCompanyFinancialReportAll(Guid id, string reportType, string exchangeId, int year, int range, string symbol = null)
        {
            try
            {
                int result = 0;
                TokenEntity tokenEntity = await GetTokenEntity(id);
                if (tokenEntity != null)
                {
                    IQueryable<MCompanyFinancialAvailability> query = CreateCompanyFinancialQuery(exchangeId, symbol);

                    int recordCount = query.Count();
                    int pageSize = 20;
                    int pageCount = (int)((recordCount + pageSize) / pageSize);

                    for (int i = 0; i < pageCount; i++)
                    {
                        _logger.LogInformation(string.Format("[PagingParameter] ===> Page {0} Skip {1}", i, pageSize * i));
                        switch(reportType)
                        {
                            case "BalanceSheet":
                                result += await IngestBalanceSheet(tokenEntity.Token, query, year, range, pageSize, i);
                                break;
                            case "CashFlow":
                                // TODO IngestCashFlow(tokenEntity.Token, query, year, range, pageSize, i);
                                break;
                            default:
                                break;
                        };
                    }
                }

                _logger.LogInformation(string.Format("[GetBalanceSheetAll] ===> {0} records saved", result));
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.InnerException);
                return 0;
            }
        }


        private async Task<int> IngestBalanceSheet(string token, IQueryable<MCompanyFinancialAvailability> query, int year, int range, int pageSize, int pageNumber)
        {
            List<MCompanyFinancialAvailability> stockList = query.Skip(pageSize * pageNumber)
                                                                 .Take(pageSize)
                                                                 .ToList();

            var listMain = new List<EquityApi.BalanceSheet.Response>();
            object _lock = new object();

            await stockList.ParallelForEachAsync(async (stock) =>
            {
                List<EquityApi.BalanceSheet.Response> listSymbol =
                            await GetBalanceSheetResponses(CreateBaseFinancialRequestList(token, stock.ExchangeId, stock.Symbol, year, range));

                lock (_lock) { listSymbol.ForEach(item => listMain.Add(item)); }
            },
            maxDegreeOfParallelism: 4);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            return await persistence.SaveAsync(listMain);
        }

        private async Task<List<EquityApi.BalanceSheet.Response>> GetBalanceSheetResponses(List<BaseFinancialRequest> requests)
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

        private List<BaseFinancialRequest> CreateBaseFinancialRequestList(string token, string exchangeId, string symbol, int year, int yearRange)
        {
            List<BaseFinancialRequest> requests = new List<BaseFinancialRequest>();

            int quarterlyYear = 2; // quarterly reports limited to only 3 years of data
            if (yearRange == 1) quarterlyYear = 1;
            int finalYear = year - yearRange;

            foreach (string dataType in _dataTypes)
            {
                string statementType = StatementType.Annual.Value;
                string startDate = string.Format("01/{0}", finalYear);
                string endDate = string.Format("01/{0}", year);

                requests.Add(BaseFinancialRequest.Create(token, exchangeId, "Symbol", symbol, statementType, dataType, startDate, endDate));

                statementType = StatementType.Quarterly.Value;
                int counter = 0;
                int startYear = year - quarterlyYear;
                int endYear = year;
                while (startYear > finalYear)
                {
                    startDate = string.Format("01/{0}", startYear);
                    endDate = string.Format("01/{0}", endYear);

                    requests.Add(BaseFinancialRequest.Create(token, exchangeId, "Symbol", symbol, statementType, dataType, startDate, endDate));

                    counter++;
                    startYear = year - ((counter + 1) * quarterlyYear);
                    endYear = year - ((counter * quarterlyYear));
                }
            }
            return requests;
        }

        private IQueryable<MCompanyFinancialAvailability> CreateCompanyFinancialQuery(string exchangeId, string symbol)
        {
            var companyFinancialQuery = _ingestionContext.MCompanyFinancialAvailabilities.AsQueryable()
                                                    .Where(x => x.ExchangeId == exchangeId);

            if (!string.IsNullOrEmpty(symbol))
            {
                companyFinancialQuery = companyFinancialQuery.AsQueryable().Where(x => x.Symbol == symbol);
            }

            return companyFinancialQuery;

        }
        private async Task<TokenEntity> GetTokenEntity(Guid id)
        {
            Authentication authentication = new Authentication(_ingestionContext, _logger);
            return await authentication.GetAccessTokenByClientConfigId(id);
        }

    }
}
