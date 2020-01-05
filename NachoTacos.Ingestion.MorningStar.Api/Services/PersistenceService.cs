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
        public async Task<int> Save(EquityApi.StockExchangeSecurity.Request request, List<StockExchangeSecurityEntity> entities)
        {
            try
            {
                ValidateEntities(entities);
                string entityName = "TStockExchangeSecurity";

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
        public async Task<int> Save(EquityApi.BalanceSheet.Request request, List<BalanceSheetEntity> entities)
        {
            try
            {
                ValidateEntities(entities);
                string entityName = "TBalanceSheet";

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
