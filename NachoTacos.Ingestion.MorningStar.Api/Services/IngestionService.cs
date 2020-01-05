using Microsoft.Extensions.Logging;
using NachoTacos.Ingestion.MorningStar.Api.EquityApi;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.Services
{
    public class IngestionService
    {
        private readonly ILogger _logger;

        public IngestionService(ILogger logger)
        {
            _logger = logger;
        }

        public async Task<List<StockExchangeSecurityEntity>> Get(string endPoint, EquityApi.StockExchangeSecurity.Request request)
        {
            try
            {
                List<StockExchangeSecurityEntity> stockExchangeSecurityEntityList = 
                    await GlobalMasterListsService.GetStockExchangeSecurityList(endPoint, request);

                return stockExchangeSecurityEntityList;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<BalanceSheetEntity>> Get(string endPoint, EquityApi.BalanceSheet.Request request)
        {
            try
            {
                List<BalanceSheetEntity> balanceSheetEntities =
                await CompanyFinancialsService.GetBalanceSheet(endPoint, request);

                return balanceSheetEntities;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
