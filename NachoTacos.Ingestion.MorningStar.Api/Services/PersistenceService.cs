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

        private int ValidateEntities(dynamic entities)
        {
            if (entities == null) return 0;
            if (entities.Count == 0) return 0;
            return 1;
        }
    }
}
