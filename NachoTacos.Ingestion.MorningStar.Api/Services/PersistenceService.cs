using AutoMapper;
using Microsoft.Extensions.Logging;
using NachoTacos.Ingestion.MorningStar.Api.EquityApi;
using NachoTacos.Ingestion.MorningStar.Data;
using NachoTacos.Ingestion.MorningStar.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.Services
{
    public class PersistenceService
    {
        private readonly ILogger _logger;
        private readonly IIngestionContext _ingestionContext;
        private readonly IMapper _mapper;

        public PersistenceService(IIngestionContext ingestionContext, IMapper mapper, ILogger logger)
        {
            _ingestionContext = ingestionContext;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<int> SaveAsync(Guid ingestionTaskId, EquityApi.StockExchangeSecurity.Response response)
        {
            try
            {
                List<StockExchangeSecurityEntity> entities = response.StockExchangeSecurityEntityList;
                if (ValidateEntities(entities) == 0) return 0;

                List<TStockExchangeSecurity> list = new List<TStockExchangeSecurity>();
                foreach(var entity in entities)
                {
                    TStockExchangeSecurity item = _mapper.Map<TStockExchangeSecurity>(entity);
                    item.Id = Guid.NewGuid();
                    item.IngestionTaskId = ingestionTaskId;

                    list.Add(item);
                }
                _ingestionContext.TStockExchangeSecurities.AddRange(list);
                return await _ingestionContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public async Task<int> SaveAsync(Guid ingestionTaskId, EquityApi.CompanyFinancials.Response response)
        {
            List<CompanyFinancialAvailabilityEntity> entities = response.CompanyFinancialAvailabilityEntityList;
            if (ValidateEntities(entities) == 0) return 0;

            List<TCompanyFinancialAvailability> list = new List<TCompanyFinancialAvailability>();
            foreach(var entity in entities)
            {
                TCompanyFinancialAvailability item = _mapper.Map<TCompanyFinancialAvailability>(entity);
                item.Id = Guid.NewGuid();
                item.IngestionTaskId = ingestionTaskId;
                list.Add(item);
            }
            _ingestionContext.TCompanyFinancialAvailabilities.AddRange(list);
            return await _ingestionContext.SaveChangesAsync();
        }

        public async Task<int> SaveAsync(List<EquityApi.BalanceSheet.Response> responses)
        {
            foreach (var response in responses)
            {
                List<BalanceSheetEntity> entities = response.BalanceSheetEntityList;
                if(ValidateEntities(entities) != 0)
                {                    
                    GeneralInfo generalInfo = response.GeneralInfo;
                    _logger.LogInformation("IngestionTask ==> Symbol: {0}", generalInfo.Symbol);

                    IngestionTask ingestionTask = IngestionTask.Create(string.Format("Balance Sheet {0}", generalInfo.ExchangeId), string.Format("Symbol: {0}", generalInfo.Symbol));
                    _ingestionContext.IngestionTasks.Add(ingestionTask);

                    TGeneralInfo tGeneralInfo = _mapper.Map<TGeneralInfo>(generalInfo);
                    tGeneralInfo.Id = Guid.NewGuid();
                    tGeneralInfo.IngestionTaskId = ingestionTask.IngestionTaskId;
                    _ingestionContext.TGeneralInfo.Add(tGeneralInfo);

                    foreach (var entity in entities)
                    {
                        TBalanceSheet item = _mapper.Map<TBalanceSheet>(entity);
                        item.Id = Guid.NewGuid();
                        item.IngestionTaskId = ingestionTask.IngestionTaskId;
                        _ingestionContext.TBalanceSheets.Add(item);
                    }
                }
            }
            return await _ingestionContext.SaveChangesAsync();
        }

        public async Task<int> SaveAsync(List<EquityApi.CashFlow.Response> responses, bool isTTM = false)
        {
            foreach (var response in responses)
            {
                List<CashFlowEntity> entities = response.CashFlowEntityList;
                if (ValidateEntities(entities) != 0)
                {
                    GeneralInfo generalInfo = response.GeneralInfo;
                    _logger.LogInformation("IngestionTask ==> Symbol: {0}", generalInfo.Symbol);

                    IngestionTask ingestionTask = IngestionTask.Create(string.Format("Cash Flow {0}", generalInfo.ExchangeId), string.Format("Symbol: {0}", generalInfo.Symbol));
                    _ingestionContext.IngestionTasks.Add(ingestionTask);

                    TGeneralInfo tGeneralInfo = _mapper.Map<TGeneralInfo>(generalInfo);
                    tGeneralInfo.Id = Guid.NewGuid();
                    tGeneralInfo.IngestionTaskId = ingestionTask.IngestionTaskId;
                    _ingestionContext.TGeneralInfo.Add(tGeneralInfo);

                    foreach (var entity in entities)
                    {
                        if (isTTM)
                        {
                            TCashFlowTTM item = _mapper.Map<TCashFlowTTM>(entity);
                            item.Id = Guid.NewGuid();
                            item.IngestionTaskId = ingestionTask.IngestionTaskId;
                            _ingestionContext.TCashFlowTTMs.Add(item);
                        }
                        else
                        {
                            TCashFlow item = _mapper.Map<TCashFlow>(entity);
                            item.Id = Guid.NewGuid();
                            item.IngestionTaskId = ingestionTask.IngestionTaskId;
                            _ingestionContext.TCashFlows.Add(item);
                        }
                    }
                }
            }
            return await _ingestionContext.SaveChangesAsync();
        }

        public async Task<int> SaveAsync(List<EquityApi.IncomeStatement.Response> responses, bool isTTM = false)
        {
            foreach (var response in responses)
            {
                List<IncomeStatementEntity> entities = response.IncomeStatementEntityList;
                if (ValidateEntities(entities) != 0)
                {
                    GeneralInfo generalInfo = response.GeneralInfo;
                    _logger.LogInformation("IngestionTask ==> Symbol: {0}", generalInfo.Symbol);

                    IngestionTask ingestionTask = IngestionTask.Create(string.Format("Income Statement {0}", generalInfo.ExchangeId), string.Format("Symbol: {0}", generalInfo.Symbol));
                    _ingestionContext.IngestionTasks.Add(ingestionTask);

                    TGeneralInfo tGeneralInfo = _mapper.Map<TGeneralInfo>(generalInfo);
                    tGeneralInfo.Id = Guid.NewGuid();
                    tGeneralInfo.IngestionTaskId = ingestionTask.IngestionTaskId;
                    _ingestionContext.TGeneralInfo.Add(tGeneralInfo);

                    foreach (var entity in entities)
                    {
                        if (isTTM)
                        {
                            TIncomeStatementTTM item = _mapper.Map<TIncomeStatementTTM>(entity);
                            item.Id = Guid.NewGuid();
                            item.IngestionTaskId = ingestionTask.IngestionTaskId;
                            _ingestionContext.TIncomeStatementTTMs.Add(item);
                        }
                        else
                        {
                            TIncomeStatement item = _mapper.Map<TIncomeStatement>(entity);
                            item.Id = Guid.NewGuid();
                            item.IngestionTaskId = ingestionTask.IngestionTaskId;
                            _ingestionContext.TIncomeStatements.Add(item);
                        }
                    }
                }
            }
            return await _ingestionContext.SaveChangesAsync();
        }
        
        public async Task<int> SaveAsync(List<EquityApi.EfficiencyRatios.Response> responses, bool isTTM = false)
        {
            foreach (var response in responses)
            {
                List<EfficiencyEntity> entities = response.EfficiencyEntityList;
                if (ValidateEntities(entities) != 0)
                {
                    GeneralInfo generalInfo = response.GeneralInfo;
                    _logger.LogInformation("IngestionTask ==> Symbol: {0}", generalInfo.Symbol);

                    IngestionTask ingestionTask = IngestionTask.Create(string.Format("EfficiencyRatios {0}", generalInfo.ExchangeId), string.Format("Symbol: {0}", generalInfo.Symbol));
                    _ingestionContext.IngestionTasks.Add(ingestionTask);

                    TGeneralInfo tGeneralInfo = _mapper.Map<TGeneralInfo>(generalInfo);
                    tGeneralInfo.Id = Guid.NewGuid();
                    tGeneralInfo.IngestionTaskId = ingestionTask.IngestionTaskId;
                    _ingestionContext.TGeneralInfo.Add(tGeneralInfo);

                    foreach (var entity in entities)
                    {
                        if (isTTM)
                        {
                            TEfficiencyRatioTTM item = _mapper.Map<TEfficiencyRatioTTM>(entity);
                            item.Id = Guid.NewGuid();
                            item.IngestionTaskId = ingestionTask.IngestionTaskId;
                            _ingestionContext.TEfficiencyRatioTTMs.Add(item);
                        }
                        else
                        {
                            TEfficiencyRatio item = _mapper.Map<TEfficiencyRatio>(entity);
                            item.Id = Guid.NewGuid();
                            item.IngestionTaskId = ingestionTask.IngestionTaskId;
                            _ingestionContext.TEfficiencyRatios.Add(item);
                        }
                    }
                }
            }
            return await _ingestionContext.SaveChangesAsync();
        }
        public async Task<int> SaveAsync(List<EquityApi.ProfitabilityRatios.Response> responses, bool isTTM = false)
        {
            foreach (var response in responses)
            {
                List<ProfitabilityEntity> entities = response.ProfitabilityEntityList;
                if (ValidateEntities(entities) != 0)
                {
                    GeneralInfo generalInfo = response.GeneralInfo;
                    _logger.LogInformation("IngestionTask ==> Symbol: {0}", generalInfo.Symbol);

                    IngestionTask ingestionTask = IngestionTask.Create(string.Format("ProfitabilityRatios {0}", generalInfo.ExchangeId), string.Format("Symbol: {0}", generalInfo.Symbol));
                    _ingestionContext.IngestionTasks.Add(ingestionTask);

                    TGeneralInfo tGeneralInfo = _mapper.Map<TGeneralInfo>(generalInfo);
                    tGeneralInfo.Id = Guid.NewGuid();
                    tGeneralInfo.IngestionTaskId = ingestionTask.IngestionTaskId;
                    _ingestionContext.TGeneralInfo.Add(tGeneralInfo);

                    foreach (var entity in entities)
                    {
                        if (isTTM)
                        {
                            TProfitabilityRatioTTM item = _mapper.Map<TProfitabilityRatioTTM>(entity);
                            item.Id = Guid.NewGuid();
                            item.IngestionTaskId = ingestionTask.IngestionTaskId;
                            _ingestionContext.TProfitabilityRatioTTMs.Add(item);
                        }
                        else
                        {
                            TProfitabilityRatio item = _mapper.Map<TProfitabilityRatio>(entity);
                            item.Id = Guid.NewGuid();
                            item.IngestionTaskId = ingestionTask.IngestionTaskId;
                            _ingestionContext.TProfitabilityRatios.Add(item);
                        }
                    }
                }
            }
            return await _ingestionContext.SaveChangesAsync();
        }

        private int ValidateEntities(dynamic entities)
        {
            if (entities == null) return 0;
            if (entities.Count == 0) return 0;
            return 1;
        }
    }
}
