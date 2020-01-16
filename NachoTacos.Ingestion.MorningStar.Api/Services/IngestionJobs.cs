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

        private readonly string[] _companyFinancialDataTypes = { "AOR", "Restated", "Preliminary" };
        private readonly string[] _financialRatioDataTypes = { "AOR", "Restated" };
        private readonly string[] _periodTypes = { "Snapshot", "Year_End_5Year", "Year_End_10Year", "Year_End_10FiscalYear", "Month_End_1YTD" };

        public IngestionJobs(IIngestionContext ingestionContext, IConfiguration configuration, IMapper mapper, ILogger<IngestionJobs> logger)
        {
            _ingestionContext = ingestionContext;
            _configuration = configuration;
            _mapper = mapper;
            _logger = logger;
        }

        #region "Background jobs"
        [AutomaticRetry(Attempts = 0)]
        public async Task<string> GetStockExchangeSecurity(Guid id, string exchangeId, string stockStatus)
        {
            try
            {
                TokenEntity tokenEntity = await GetTokenEntity(id);
                if (tokenEntity != null)
                {
                    string endPoint = _configuration.GetValue<string>(EndPoint.StockExchangeSecurityList);

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
                    string endPoint = _configuration.GetValue<string>(EndPoint.FinancialsCoverageList);
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
        
        [AutomaticRetry(Attempts = 0)]
        public async Task<int> GetCompanyFinancialReportAll(Guid id, string reportType, string exchangeId, int year, int range, string symbol = null, bool isDiffOnly = false)
        {
            try
            {
                int result = 0;
                TokenEntity tokenEntity = await GetTokenEntity(id);
                if (tokenEntity != null)
                {
                    IQueryable<MCompanyFinancialAvailability> query = CreateCompanyFinancialQuery(exchangeId, symbol, reportType, isDiffOnly);

                    int recordCount = query.Count();
                    int pageSize = 20;
                    int pageCount = (int)((recordCount + pageSize) / pageSize);

                    for (int i = 0; i < pageCount; i++)
                    {
                        switch(reportType)
                        {
                            case "BalanceSheet":
                                result += await IngestBalanceSheet(tokenEntity.Token, query, year, range, pageSize, i);
                                break;
                            case "CashFlow":
                                result += await IngestCashFlow(tokenEntity.Token, query, year, range, pageSize, i);
                                break;
                            case "CashFlowTTM":
                                result += await IngestCashFlowTTM(tokenEntity.Token, query, year, range, pageSize, i);
                                break;
                            case "IncomeStatement":
                                result += await IngestIncomeStatement(tokenEntity.Token, query, year, range, pageSize, i);
                                break;
                            case "IncomeStatementTTM":
                                result += await IngestIncomeStatementTTM(tokenEntity.Token, query, year, range, pageSize, i);
                                break;
                            default:
                                break;
                        };
                    }
                }

                _logger.LogInformation(string.Format("[GetCompanyFinancialReportAll] ===> {0} records saved", result));
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.InnerException);
                return 0;
            }
        }

        [AutomaticRetry(Attempts = 0)]
        public async Task<int> GetFinancialRatioReportAll(Guid id, string reportType, string exchangeId, int year, int range, string symbol = null, bool isDiffOnly = false)
        {
            try
            {
                int result = 0;
                TokenEntity tokenEntity = await GetTokenEntity(id);
                if (tokenEntity != null)
                {
                    IQueryable<MCompanyFinancialAvailability> query = CreateCompanyFinancialQuery(exchangeId, symbol, reportType, isDiffOnly);

                    int recordCount = query.Count();
                    int pageSize = 20;
                    int pageCount = (int)((recordCount + pageSize) / pageSize);
                    for (int i = 0; i < pageCount; i++)
                    {
                        switch (reportType)
                        {
                            case "EfficiencyRatio":
                                result += await IngestEfficiencyRatio(tokenEntity.Token, query, year, range, pageSize, i);
                                break;
                            case "EfficiencyRatioTTM":
                                result += await IngestEfficiencyRatioTTM(tokenEntity.Token, query, year, range, pageSize, i);
                                break;
                            case "ProfitabilityRatio":
                                result += await IngestProfitabilityRatio(tokenEntity.Token, query, year, range, pageSize, i);
                                break;
                            case "ProfitabilityRatioTTM":
                                result += await IngestProfitabilityRatioTTM(tokenEntity.Token, query, year, range, pageSize, i);
                                break;
                            case "FinancialHealthRatio":
                                result += await IngestFinancialHealthRatio(tokenEntity.Token, query, year, range, pageSize, i);
                                break;
                            case "GrowthRatio":
                                result += await IngestGrowthRatio(tokenEntity.Token, query, year, range, pageSize, i);
                                break;
                            case "ValuationRatio":
                                result += await IngestValuationRatio(tokenEntity.Token, query, pageSize, i);
                                break;
                            case "QuantitativeRating":
                                result += await IngestQuantitativeRating(tokenEntity.Token, query, year, range, pageSize, i);
                                break;
                            case "MarketCapitalization":
                                result += await IngestMarketCapitalization(tokenEntity.Token, query, year, range, pageSize, i);
                                break;
                            case "EODPriceHistory":
                                result += await IngestEODPrice(tokenEntity.Token, query, year, range, pageSize, i);
                                break;
                            default:
                                break;
                        };
                    }
                }

                _logger.LogInformation(string.Format("[GetFinancialRatioReportAll] ===> {0} records saved", result));
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.InnerException);
                return 0;
            }
        }

        /// <summary>
        /// Executes Merge Stored Procedures until all unprocessed ingestion tasks are completed        /// 
        /// </summary>
        /// <param name="reportType"></param>
        [AutomaticRetry(Attempts = 0)]
        public void MergeFinancialTempToMaster(string reportType)
        {
            int max = 0;
            while(max < 2000)
            {
                List<ChangeTable> changes = new List<ChangeTable>();
                switch (reportType)
                {
                    case "BalanceSheet":
                        changes = _ingestionContext.ChangeTables.FromSqlRaw("EXECUTE MergeBalanceSheet").ToList();
                        break;
                    case "CashFlow":
                        changes = _ingestionContext.ChangeTables.FromSqlRaw("EXECUTE MergeCashFlow").ToList();
                        break;
                    case "CashFlowTTM":
                        changes = _ingestionContext.ChangeTables.FromSqlRaw("EXECUTE MergeCashFlowTTM").ToList();
                        break;
                    case "IncomeStatement":
                        changes = _ingestionContext.ChangeTables.FromSqlRaw("EXECUTE MergeIncomeStatement").ToList();
                        break;
                    case "IncomeStatementTTM":
                        changes = _ingestionContext.ChangeTables.FromSqlRaw("EXECUTE MergeIncomeStatementTTM").ToList();
                        break;
                    case "EfficiencyRatio":
                        changes = _ingestionContext.ChangeTables.FromSqlRaw("EXECUTE MergeEfficiencyRatio").ToList();
                        break;
                    case "EfficiencyRatioTTM":
                        changes = _ingestionContext.ChangeTables.FromSqlRaw("EXECUTE MergeEfficiencyRatioTTM").ToList();
                        break;
                    case "ProfitabilityRatio":
                        changes = _ingestionContext.ChangeTables.FromSqlRaw("EXECUTE MergeProfitabilityRatio").ToList();
                        break;
                    case "ProfitabilityRatioTTM":
                        changes = _ingestionContext.ChangeTables.FromSqlRaw("EXECUTE MergeProfitabilityRatioTTM").ToList();
                        break;
                    default:
                        break;
                };
                if (changes.Count == 0)
                {
                    max = 2001;
                }
                max++;
            }
        }

        #endregion

        #region "Ingest Company Financials"
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
                            await GetBalanceSheetResponses(CreateBaseFinancialRequestList(token, stock.ExchangeId, stock.Symbol, _companyFinancialDataTypes, year, range));

                lock (_lock) { listSymbol.ForEach(item => listMain.Add(item)); }
            },
            maxDegreeOfParallelism: 4);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            return await persistence.SaveAsync(listMain);
        }
        private async Task<int> IngestCashFlow(string token, IQueryable<MCompanyFinancialAvailability> query, int year, int range, int pageSize, int pageNumber)
        {
            List<MCompanyFinancialAvailability> stockList = query.Skip(pageSize * pageNumber)
                                                                 .Take(pageSize)
                                                                 .ToList();

            var listMain = new List<EquityApi.CashFlow.Response>();
            object _lock = new object();

            await stockList.ParallelForEachAsync(async (stock) =>
            {
                List<EquityApi.CashFlow.Response> listSymbol =
                            await GetCashFlowResponses(CreateBaseFinancialRequestList(token, stock.ExchangeId, stock.Symbol, _companyFinancialDataTypes, year, range));

                lock (_lock) { listSymbol.ForEach(item => listMain.Add(item)); }
            },
            maxDegreeOfParallelism: 4);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            return await persistence.SaveAsync(listMain);
        }
        private async Task<int> IngestCashFlowTTM(string token, IQueryable<MCompanyFinancialAvailability> query, int year, int range, int pageSize, int pageNumber)
        {
            List<MCompanyFinancialAvailability> stockList = query.Skip(pageSize * pageNumber)
                                                                 .Take(pageSize)
                                                                 .ToList();

            var listMain = new List<EquityApi.CashFlow.Response>();
            object _lock = new object();

            await stockList.ParallelForEachAsync(async (stock) =>
            {
                EquityApi.CashFlow.Response listSymbol =
                            await GetCashFlowResponses(CreateBaseFinancialTTMRequestList(token, stock.ExchangeId, stock.Symbol, year, range));

                lock (_lock) { listMain.Add(listSymbol); }
            },
            maxDegreeOfParallelism: 4);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            return await persistence.SaveAsync(listMain, true);
        }
        private async Task<int> IngestIncomeStatement(string token, IQueryable<MCompanyFinancialAvailability> query, int year, int range, int pageSize, int pageNumber)
        {
            List<MCompanyFinancialAvailability> stockList = query.Skip(pageSize * pageNumber)
                                                                 .Take(pageSize)
                                                                 .ToList();

            var listMain = new List<EquityApi.IncomeStatement.Response>();
            object _lock = new object();
            await stockList.ParallelForEachAsync(async (stock) =>
            {
                List<EquityApi.IncomeStatement.Response> listSymbol =
                            await GetIncomeStatementResponses(CreateBaseFinancialRequestList(token, stock.ExchangeId, stock.Symbol, _companyFinancialDataTypes, year, range));

                lock (_lock) { listSymbol.ForEach(item => listMain.Add(item)); }
            },
            maxDegreeOfParallelism: 4);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            return await persistence.SaveAsync(listMain);
        }
        private async Task<int> IngestIncomeStatementTTM(string token, IQueryable<MCompanyFinancialAvailability> query, int year, int range, int pageSize, int pageNumber)
        {
            List<MCompanyFinancialAvailability> stockList = query.Skip(pageSize * pageNumber)
                                                                 .Take(pageSize)
                                                                 .ToList();

            var listMain = new List<EquityApi.IncomeStatement.Response>();
            object _lock = new object();
            await stockList.ParallelForEachAsync(async (stock) =>
            {
                EquityApi.IncomeStatement.Response listSymbol =
                            await GetIncomeStatementResponses(CreateBaseFinancialTTMRequestList(token, stock.ExchangeId, stock.Symbol, year, range));

                lock (_lock) { listMain.Add(listSymbol); }
            },
            maxDegreeOfParallelism: 4);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            return await persistence.SaveAsync(listMain, true);
        }
        
        private async Task<int> IngestEfficiencyRatio(string token, IQueryable<MCompanyFinancialAvailability> query, int year, int range, int pageSize, int pageNumber)
        {
            List<MCompanyFinancialAvailability> stockList = query.Skip(pageSize * pageNumber)
                                                                 .Take(pageSize)
                                                                 .ToList();

            var listMain = new List<EquityApi.EfficiencyRatios.Response>();
            object _lock = new object();

            await stockList.ParallelForEachAsync(async (stock) =>
            {
                List<EquityApi.EfficiencyRatios.Response> listSymbol =
                            await GetEfficiencyRatiosResponses(CreateBaseFinancialRequestList(token, stock.ExchangeId, stock.Symbol, _financialRatioDataTypes, year, range));

                lock (_lock) { listSymbol.ForEach(item => listMain.Add(item)); }
            },
            maxDegreeOfParallelism: 4);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            return await persistence.SaveAsync(listMain);
        }
        private async Task<int> IngestEfficiencyRatioTTM(string token, IQueryable<MCompanyFinancialAvailability> query, int year, int range, int pageSize, int pageNumber)
        {
            List<MCompanyFinancialAvailability> stockList = query.Skip(pageSize * pageNumber)
                                                                 .Take(pageSize)
                                                                 .ToList();

            var listMain = new List<EquityApi.EfficiencyRatios.Response>();
            object _lock = new object();

            await stockList.ParallelForEachAsync(async (stock) =>
            {
                EquityApi.EfficiencyRatios.Response listSymbol =
                            await GetEfficiencyRatiosResponses(CreateBaseFinancialTTMRequestList(token, stock.ExchangeId, stock.Symbol, year, range));

                lock (_lock) { listMain.Add(listSymbol); }
            },
            maxDegreeOfParallelism: 4);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            return await persistence.SaveAsync(listMain, true);
        }
        private async Task<int> IngestProfitabilityRatio(string token, IQueryable<MCompanyFinancialAvailability> query, int year, int range, int pageSize, int pageNumber)
        {
            List<MCompanyFinancialAvailability> stockList = query.Skip(pageSize * pageNumber)
                                                                 .Take(pageSize)
                                                                 .ToList();

            var listMain = new List<EquityApi.ProfitabilityRatios.Response>();
            object _lock = new object();

            await stockList.ParallelForEachAsync(async (stock) =>
            {
                List<EquityApi.ProfitabilityRatios.Response> listSymbol =
                            await GetProfitabilityRatiosResponses(CreateBaseFinancialRequestList(token, stock.ExchangeId, stock.Symbol, _financialRatioDataTypes, year, range));

                lock (_lock) { listSymbol.ForEach(item => listMain.Add(item)); }
            },
            maxDegreeOfParallelism: 4);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            return await persistence.SaveAsync(listMain);
        }
        private async Task<int> IngestProfitabilityRatioTTM(string token, IQueryable<MCompanyFinancialAvailability> query, int year, int range, int pageSize, int pageNumber)
        {
            List<MCompanyFinancialAvailability> stockList = query.Skip(pageSize * pageNumber)
                                                                 .Take(pageSize)
                                                                 .ToList();

            var listMain = new List<EquityApi.ProfitabilityRatios.Response>();
            object _lock = new object();

            await stockList.ParallelForEachAsync(async (stock) =>
            {
                EquityApi.ProfitabilityRatios.Response listSymbol =
                            await GetProfitabilityRatiosResponses(CreateBaseFinancialTTMRequestList(token, stock.ExchangeId, stock.Symbol, year, range));

                lock (_lock) { listMain.Add(listSymbol); }
            },
            maxDegreeOfParallelism: 4);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            return await persistence.SaveAsync(listMain, true);
        }

        private async Task<int> IngestFinancialHealthRatio(string token, IQueryable<MCompanyFinancialAvailability> query, int year, int range, int pageSize, int pageNumber)
        {
            List<MCompanyFinancialAvailability> stockList = query.Skip(pageSize * pageNumber)
                                                                 .Take(pageSize)
                                                                 .ToList();

            var listMain = new List<EquityApi.FinancialHealthRatios.Response>();
            object _lock = new object();

            await stockList.ParallelForEachAsync(async (stock) =>
            {
                List<EquityApi.FinancialHealthRatios.Response> listSymbol =
                            await GetFinancialHealthRatiosResponses(CreateBaseFinancialRequestList(token, stock.ExchangeId, stock.Symbol, _financialRatioDataTypes, year, range));

                lock (_lock) { listSymbol.ForEach(item => listMain.Add(item)); }
            },
            maxDegreeOfParallelism: 4);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            return await persistence.SaveAsync(listMain);
        }

        private async Task<int> IngestGrowthRatio(string token, IQueryable<MCompanyFinancialAvailability> query, int year, int range, int pageSize, int pageNumber)
        {
            List<MCompanyFinancialAvailability> stockList = query.Skip(pageSize * pageNumber)
                                                                 .Take(pageSize)
                                                                 .ToList();

            var listMain = new List<EquityApi.GrowthRatios.Response>();
            object _lock = new object();

            await stockList.ParallelForEachAsync(async (stock) =>
            {
                List<EquityApi.GrowthRatios.Response> listSymbol =
                            await GetGrowthRatiosResponses(CreateBaseFinancialRequestList(token, stock.ExchangeId, stock.Symbol, _financialRatioDataTypes, year, range));

                lock (_lock) { listSymbol.ForEach(item => listMain.Add(item)); }
            },
            maxDegreeOfParallelism: 4);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            return await persistence.SaveAsync(listMain);
        }

        private async Task<int> IngestValuationRatio(string token, IQueryable<MCompanyFinancialAvailability> query, int pageSize, int pageNumber)
        {
            List<MCompanyFinancialAvailability> stockList = query.Skip(pageSize * pageNumber)
                                                                 .Take(pageSize)
                                                                 .ToList();

            var listMain = new List<EquityApi.ValuationRatio.Response>();
            object _lock = new object();

            await stockList.ParallelForEachAsync(async (stock) =>
            {
                List<EquityApi.ValuationRatio.Response> listSymbol =
                            await GetValuationRatioResponses(CreateValuationRequestList(token, stock.ExchangeId, stock.Symbol, _periodTypes));

                lock (_lock) { listSymbol.ForEach(item => listMain.Add(item)); }
            },
            maxDegreeOfParallelism: 4);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            return await persistence.SaveAsync(listMain);
        }

        private async Task<int> IngestQuantitativeRating(string token, IQueryable<MCompanyFinancialAvailability> query, int year, int range, int pageSize, int pageNumber)
        {
            List<MCompanyFinancialAvailability> stockList = query.Skip(pageSize * pageNumber)
                                                                 .Take(pageSize)
                                                                 .ToList();

            var listMain = new List<EquityApi.QuantitativeRating.Response>();
            object _lock = new object();

            await stockList.ParallelForEachAsync(async (stock) =>
            {
                List<EquityApi.QuantitativeRating.Response> listSymbol =
                            await GetQuantitativeRatingResponses(CreateBaseFinancialRequestList(token, stock.ExchangeId, stock.Symbol, _financialRatioDataTypes, year, range));

                lock (_lock) { listSymbol.ForEach(item => listMain.Add(item)); }
            },
            maxDegreeOfParallelism: 4);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            return await persistence.SaveAsync(listMain);
        }

        private async Task<int> IngestMarketCapitalization(string token, IQueryable<MCompanyFinancialAvailability> query, int year, int range, int pageSize, int pageNumber)
        {
            List<MCompanyFinancialAvailability> stockList = query.Skip(pageSize * pageNumber)
                                                                 .Take(pageSize)
                                                                 .ToList();

            var listMain = new List<EquityApi.MarketCapitalization.Response>();
            object _lock = new object();

            await stockList.ParallelForEachAsync(async (stock) =>
            {
                List<EquityApi.MarketCapitalization.Response> listSymbol =
                            await GetMarketCapitalizationResponses(CreateBaseFinancialRequestList(token, stock.ExchangeId, stock.Symbol, _financialRatioDataTypes, year, range));

                lock (_lock) { listSymbol.ForEach(item => listMain.Add(item)); }
            },
            maxDegreeOfParallelism: 4);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            return await persistence.SaveAsync(listMain);
        }

        private async Task<int> IngestEODPrice(string token, IQueryable<MCompanyFinancialAvailability> query, int year, int range, int pageSize, int pageNumber)
        {
            List<MCompanyFinancialAvailability> stockList = query.Skip(pageSize * pageNumber)
                                                                 .Take(pageSize)
                                                                 .ToList();

            var listMain = new List<EquityApi.EODPrice.Response>();
            object _lock = new object();

            await stockList.ParallelForEachAsync(async (stock) =>
            {
                List<EquityApi.EODPrice.Response> listSymbol =
                            await GetEODPriceResponses(CreateBaseFinancialRequestList(token, stock.ExchangeId, stock.Symbol, _financialRatioDataTypes, year, range));

                lock (_lock) { listSymbol.ForEach(item => listMain.Add(item)); }
            },
            maxDegreeOfParallelism: 4);

            PersistenceService persistence = new PersistenceService(_ingestionContext, _mapper, _logger);
            return await persistence.SaveAsync(listMain);
        }
        #endregion

        #region "Get MorningStar API Responses"
        private async Task<List<EquityApi.BalanceSheet.Response>> GetBalanceSheetResponses(List<BaseFinancialRequest> requests)
        {
            List<EquityApi.BalanceSheet.Response> responses = new List<EquityApi.BalanceSheet.Response>();
            string endPoint = _configuration.GetValue<string>(EndPoint.BalanceSheet);
            foreach (var request in requests)
            {
                responses.Add(await RestClient.GetDynamicResponseAsync<EquityApi.BalanceSheet.Response>(endPoint.SetQueryParams(request)));
            }
            return responses;
        }

        private async Task<List<EquityApi.CashFlow.Response>> GetCashFlowResponses(List<BaseFinancialRequest> requests)
        {
            List<EquityApi.CashFlow.Response> responses = new List<EquityApi.CashFlow.Response>();
            string endPoint = _configuration.GetValue<string>(EndPoint.CashFlow);

            foreach (var request in requests)
            {
                responses.Add(await RestClient.GetDynamicResponseAsync<EquityApi.CashFlow.Response>(endPoint.SetQueryParams(request)));
            }
            return responses;
        }

        private async Task<EquityApi.CashFlow.Response> GetCashFlowResponses(BaseFinancialTTMRequest request)
        {
            string endPoint = _configuration.GetValue<string>(EndPoint.CashFlowTTM);
            return await RestClient.GetDynamicResponseAsync<EquityApi.CashFlow.Response>(endPoint.SetQueryParams(request));
        }

        private async Task<List<EquityApi.IncomeStatement.Response>> GetIncomeStatementResponses(List<BaseFinancialRequest> requests)
        {
            List<EquityApi.IncomeStatement.Response> responses = new List<EquityApi.IncomeStatement.Response>();
            string endPoint = _configuration.GetValue<string>(EndPoint.IncomeStatement); 
            foreach (var request in requests)
            {
                responses.Add(await RestClient.GetDynamicResponseAsync<EquityApi.IncomeStatement.Response>(endPoint.SetQueryParams(request)));
            }
            return responses;
        }

        private async Task<EquityApi.IncomeStatement.Response> GetIncomeStatementResponses(BaseFinancialTTMRequest request)
        {
            string endPoint = _configuration.GetValue<string>(EndPoint.IncomeStatementTTM);
            return await RestClient.GetDynamicResponseAsync<EquityApi.IncomeStatement.Response>(endPoint.SetQueryParams(request));
        }
        private async Task<List<EquityApi.EfficiencyRatios.Response>> GetEfficiencyRatiosResponses(List<BaseFinancialRequest> requests)
        {
            List<EquityApi.EfficiencyRatios.Response> responses = new List<EquityApi.EfficiencyRatios.Response>();
            string endPoint = _configuration.GetValue<string>(EndPoint.EfficiencyRatios);
            foreach (var request in requests)
            {
                responses.Add(await RestClient.GetDynamicResponseAsync<EquityApi.EfficiencyRatios.Response>(endPoint.SetQueryParams(request)));
            }
            return responses;
        }
        private async Task<List<EquityApi.ProfitabilityRatios.Response>> GetProfitabilityRatiosResponses(List<BaseFinancialRequest> requests)
        {
            List<EquityApi.ProfitabilityRatios.Response> responses = new List<EquityApi.ProfitabilityRatios.Response>();
            string endPoint = _configuration.GetValue<string>(EndPoint.ProfitabilityRatios);
            foreach (var request in requests)
            {
                responses.Add(await RestClient.GetDynamicResponseAsync<EquityApi.ProfitabilityRatios.Response>(endPoint.SetQueryParams(request)));
            }
            return responses;
        }
        private async Task<EquityApi.EfficiencyRatios.Response> GetEfficiencyRatiosResponses(BaseFinancialTTMRequest request)
        {
            string endPoint = _configuration.GetValue<string>(EndPoint.EfficiencyRatiosTTM);
            return await RestClient.GetDynamicResponseAsync<EquityApi.EfficiencyRatios.Response>(endPoint.SetQueryParams(request));
        }
        private async Task<EquityApi.ProfitabilityRatios.Response> GetProfitabilityRatiosResponses(BaseFinancialTTMRequest request)
        {
            string endPoint = _configuration.GetValue<string>(EndPoint.ProfitabilityRatiosTTM);
            return await RestClient.GetDynamicResponseAsync<EquityApi.ProfitabilityRatios.Response>(endPoint.SetQueryParams(request));
        }

        private async Task<List<EquityApi.FinancialHealthRatios.Response>> GetFinancialHealthRatiosResponses(List<BaseFinancialRequest> requests)
        {
            List<EquityApi.FinancialHealthRatios.Response> responses = new List<EquityApi.FinancialHealthRatios.Response>();
            string endPoint = _configuration.GetValue<string>(EndPoint.FinancialHealthRatios);
            foreach (var request in requests)
            {
                responses.Add(await RestClient.GetDynamicResponseAsync<EquityApi.FinancialHealthRatios.Response>(endPoint.SetQueryParams(request)));
            }
            return responses;
        }

        private async Task<List<EquityApi.GrowthRatios.Response>> GetGrowthRatiosResponses(List<BaseFinancialRequest> requests)
        {
            List<EquityApi.GrowthRatios.Response> responses = new List<EquityApi.GrowthRatios.Response>();
            string endPoint = _configuration.GetValue<string>(EndPoint.GrowthRatios);
            foreach (var request in requests)
            {
                responses.Add(await RestClient.GetDynamicResponseAsync<EquityApi.GrowthRatios.Response>(endPoint.SetQueryParams(request)));
            }
            return responses;
        }

        private async Task<List<EquityApi.ValuationRatio.Response>> GetValuationRatioResponses(List<EquityApi.ValuationRatio.Request> requests)
        {
            List<EquityApi.ValuationRatio.Response> responses = new List<EquityApi.ValuationRatio.Response>();
            string endPoint = _configuration.GetValue<string>(EndPoint.ValuationRatio);
            foreach (var request in requests)
            {
                responses.Add(await RestClient.GetDynamicResponseAsync<EquityApi.ValuationRatio.Response>(endPoint.SetQueryParams(request)));
            }
            return responses;
        }

        private async Task<List<EquityApi.QuantitativeRating.Response>> GetQuantitativeRatingResponses(List<BaseFinancialRequest> requests)
        {
            List<EquityApi.QuantitativeRating.Response> responses = new List<EquityApi.QuantitativeRating.Response>();
            string endPoint = _configuration.GetValue<string>(EndPoint.QuantitativeRating);
            foreach (var request in requests)
            {
                responses.Add(await RestClient.GetDynamicResponseAsync<EquityApi.QuantitativeRating.Response>(endPoint.SetQueryParams(request)));
            }
            return responses;
        }

        private async Task<List<EquityApi.MarketCapitalization.Response>> GetMarketCapitalizationResponses(List<BaseFinancialRequest> requests)
        {
            List<EquityApi.MarketCapitalization.Response> responses = new List<EquityApi.MarketCapitalization.Response>();
            string endPoint = _configuration.GetValue<string>(EndPoint.MarketCapitalization);
            foreach (var request in requests)
            {
                responses.Add(await RestClient.GetDynamicResponseAsync<EquityApi.MarketCapitalization.Response>(endPoint.SetQueryParams(request)));
            }
            return responses;
        }

        private async Task<List<EquityApi.EODPrice.Response>> GetEODPriceResponses(List<BaseFinancialRequest> requests)
        {
            List<EquityApi.EODPrice.Response> responses = new List<EquityApi.EODPrice.Response>();
            string endPoint = _configuration.GetValue<string>(EndPoint.EODPrice);
            foreach (var request in requests)
            {
                responses.Add(await RestClient.GetDynamicResponseAsync<EquityApi.EODPrice.Response>(endPoint.SetQueryParams(request)));
            }
            return responses;
        }

        #endregion

        #region Data Queries
        private IQueryable<MCompanyFinancialAvailability> CreateCompanyFinancialQuery(string exchangeId, string symbol, string reportType, bool isDiffOnly)
        {
            if (isDiffOnly == true)
            {
                switch(reportType)
                {
                    case "BalanceSheet":
                        return CreateCompanyFinancialBalanceSheetDiffQuery(exchangeId);
                    case "CashFlow":
                        return CreateCompanyFinancialCashFlowDiffQuery(exchangeId);
                    case "CashFlowTTM":
                        return CreateCompanyFinancialCashFlowTTMDiffQuery(exchangeId);
                    case "IncomeStatement":
                        return CreateCompanyFinancialIncomeStatementDiffQuery(exchangeId);
                    case "IncomeStatementTTM":
                        return CreateCompanyFinancialIncomeStatementTTMDiffQuery(exchangeId);
                    default:
                        return CreateStandardCompanyFinancialQuery(exchangeId, symbol);
                }
            }
            else
            {
                return CreateStandardCompanyFinancialQuery(exchangeId, symbol);
            }
        }

        private IQueryable<MCompanyFinancialAvailability> CreateStandardCompanyFinancialQuery(string exchangeId, string symbol)
        {
            var companyFinancialQuery = _ingestionContext.MCompanyFinancialAvailabilities.AsQueryable()
                                                    .Where(x => x.ExchangeId == exchangeId);

            if (!string.IsNullOrEmpty(symbol))
            {
                companyFinancialQuery = companyFinancialQuery.AsQueryable().Where(x => x.Symbol == symbol);
            }

            return companyFinancialQuery;
        }

        private IQueryable<MCompanyFinancialAvailability> CreateCompanyFinancialBalanceSheetDiffQuery(string exchangeId)
        {
            var existingSymbols = _ingestionContext.MBalanceSheets.AsQueryable()
                                                    .Where(x => x.ExchangeId == exchangeId)
                                                    .Select(x => x.Symbol).Distinct();

            var companyFinancialQuery = _ingestionContext.MCompanyFinancialAvailabilities.AsQueryable()
                                                         .Where(x => !existingSymbols.Contains(x.Symbol));

            return companyFinancialQuery;
        }

        private IQueryable<MCompanyFinancialAvailability> CreateCompanyFinancialCashFlowDiffQuery(string exchangeId)
        {
            var existingSymbols = _ingestionContext.MCashFlows.AsQueryable()
                                                    .Where(x => x.ExchangeId == exchangeId)
                                                    .Select(x => x.Symbol).Distinct();

            var companyFinancialQuery = _ingestionContext.MCompanyFinancialAvailabilities.AsQueryable()
                                                         .Where(x => !existingSymbols.Contains(x.Symbol));

            return companyFinancialQuery;
        }

        private IQueryable<MCompanyFinancialAvailability> CreateCompanyFinancialCashFlowTTMDiffQuery(string exchangeId)
        {
            var existingSymbols = _ingestionContext.MCashFlowTTMs.AsQueryable()
                                                    .Where(x => x.ExchangeId == exchangeId)
                                                    .Select(x => x.Symbol).Distinct();

            var companyFinancialQuery = _ingestionContext.MCompanyFinancialAvailabilities.AsQueryable()
                                                         .Where(x => !existingSymbols.Contains(x.Symbol));

            return companyFinancialQuery;
        }

        private IQueryable<MCompanyFinancialAvailability> CreateCompanyFinancialIncomeStatementDiffQuery(string exchangeId)
        {
            var existingSymbols = _ingestionContext.MIncomeStatements.AsQueryable()
                                                    .Where(x => x.ExchangeId == exchangeId)
                                                    .Select(x => x.Symbol).Distinct();

            var companyFinancialQuery = _ingestionContext.MCompanyFinancialAvailabilities.AsQueryable()
                                                         .Where(x => !existingSymbols.Contains(x.Symbol));

            return companyFinancialQuery;
        }

        private IQueryable<MCompanyFinancialAvailability> CreateCompanyFinancialIncomeStatementTTMDiffQuery(string exchangeId)
        {
            var existingSymbols = _ingestionContext.MIncomeStatementTTMs.AsQueryable()
                                                    .Where(x => x.ExchangeId == exchangeId)
                                                    .Select(x => x.Symbol).Distinct();

            var companyFinancialQuery = _ingestionContext.MCompanyFinancialAvailabilities.AsQueryable()
                                                         .Where(x => !existingSymbols.Contains(x.Symbol));

            return companyFinancialQuery;
        }
        #endregion

        #region Utility functions
        private List<BaseFinancialRequest> CreateBaseFinancialRequestList(string token, string exchangeId, string symbol, string[] dataTypes, int year, int yearRange)
        {
            List<BaseFinancialRequest> requests = new List<BaseFinancialRequest>();

            int quarterlyYear = 2; // quarterly reports limited to only 3 years of data
            if (yearRange == 1) quarterlyYear = 1;
            int finalYear = year - yearRange;

            foreach (string dataType in dataTypes)
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

        private BaseFinancialTTMRequest CreateBaseFinancialTTMRequestList(string token, string exchangeId, string symbol, int year, int yearRange)
        {
            int finalYear = year - yearRange;
            string startDate = string.Format("01/{0}", finalYear);
            string endDate = string.Format("01/{0}", year);

            return BaseFinancialTTMRequest.Create(token, exchangeId, "Symbol", symbol, startDate, endDate);
        }

        private List<EquityApi.ValuationRatio.Request> CreateValuationRequestList(string token, string exchangeId, string symbol, string[] periodTypes)
        {
            List<EquityApi.ValuationRatio.Request> requests = new List<EquityApi.ValuationRatio.Request>();

            foreach (string period in periodTypes)
            {
                requests.Add(EquityApi.ValuationRatio.Request.Create(token, exchangeId, "Symbol", symbol, period));
            }
            return requests;
        }

        private async Task<TokenEntity> GetTokenEntity(Guid id)
        {
            Authentication authentication = new Authentication(_ingestionContext, _logger);
            return await authentication.GetAccessTokenByClientConfigId(id);
        }

        #endregion

    }
}
