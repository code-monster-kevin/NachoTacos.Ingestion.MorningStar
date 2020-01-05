using AutoMapper;
using Microsoft.Extensions.Logging;
using NachoTacos.Ingestion.MorningStar.Api.EquityApi;
using NachoTacos.Ingestion.MorningStar.Data;
using NachoTacos.Ingestion.MorningStar.Domain;
using Newtonsoft.Json;
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
        public async Task<int> Save(EquityApi.StockExchangeSecurity.Request request, EquityApi.StockExchangeSecurity.Response response)
        {
            try
            {
                string entityName = "TStockExchangeSecurity";

                List<StockExchangeSecurityEntity> entities = response.StockExchangeSecurityEntityList;
                ValidateEntities(entities);

                IngestionTask ingestionTask = IngestionTask.Create(entityName, JsonConvert.SerializeObject(request));
                _ingestionContext.IngestionTasks.Add(ingestionTask);

                List<TStockExchangeSecurity> list = new List<TStockExchangeSecurity>();
                foreach(var entity in entities)
                {
                    TStockExchangeSecurity item = _mapper.Map<TStockExchangeSecurity>(entity);
                    item.Id = Guid.NewGuid();
                    item.IngestionTaskId = ingestionTask.IngestionTaskId;

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

        public async Task<int> Save(EquityApi.CompanyFinancials.Request request, EquityApi.CompanyFinancials.Response response)
        {
            string entityName = "TCompanyFinancialAvailability";
            List<CompanyFinancialAvailabilityEntity> entities = response.CompanyFinancialAvailabilityEntityList;
            ValidateEntities(entities);
            IngestionTask ingestionTask = IngestionTask.Create(entityName, JsonConvert.SerializeObject(request));
            _ingestionContext.IngestionTasks.Add(ingestionTask);

            List<TCompanyFinancialAvailability> list = new List<TCompanyFinancialAvailability>();
            foreach(var entity in entities)
            {
                TCompanyFinancialAvailability item = _mapper.Map<TCompanyFinancialAvailability>(entity);
                item.Id = Guid.NewGuid();
                item.IngestionTaskId = ingestionTask.IngestionTaskId;
                list.Add(item);
            }
            _ingestionContext.TCompanyFinancialAvailabilities.AddRange(list);
            return await _ingestionContext.SaveChangesAsync();
        }

        public async Task<int> Save(EquityApi.BalanceSheet.Request request, EquityApi.BalanceSheet.Response response)
        {
            try
            {
                string entityName = "TBalanceSheet";

                List<BalanceSheetEntity> entities = response.BalanceSheetEntityList;
                ValidateEntities(entities);

                IngestionTask ingestionTask = IngestionTask.Create(entityName, JsonConvert.SerializeObject(request));
                _ingestionContext.IngestionTasks.Add(ingestionTask);

                List<TBalanceSheet> list = new List<TBalanceSheet>();
                foreach (var entity in entities)
                {
                    TBalanceSheet item = _mapper.Map<TBalanceSheet>(entity);
                    item.Id = Guid.NewGuid();
                    item.IngestionTaskId = ingestionTask.IngestionTaskId;
                    list.Add(item);
                }
                _ingestionContext.TBalanceSheets.AddRange(list);

                GeneralInfo generalInfo = response.GeneralInfo;
                TGeneralInfo tGeneralInfo = _mapper.Map<TGeneralInfo>(generalInfo);
                tGeneralInfo.Id = Guid.NewGuid();
                tGeneralInfo.Id = ingestionTask.IngestionTaskId;
                _ingestionContext.TGeneralInfo.Add(tGeneralInfo);

                return await _ingestionContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        private void ValidateEntities(dynamic entities)
        {
            if (entities == null) throw new Exception("PersistenceService.Save() Entities is null");
            if (entities.Count == 0) throw new Exception("PersistenceService.Save() Entities is empty");
        }
    }
}
