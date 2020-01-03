using Flurl;
using NachoTacos.Ingestion.MorningStar.Api.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi
{
    /// <summary>
    /// source: https://equityapi.morningstar.com/DataCatalog.aspx
    /// </summary>
    public class GlobalMasterListsService
    {
        public static async Task<List<StockExchangeSecurity.StockExchangeSecurityEntity>> GetStockExchangeSecurityList(string endPoint, string token, string exchangeId, string identifier, string identifierType, string stockStatus, string responseType = "Json")
        {
            StockExchangeSecurity.Request request = new StockExchangeSecurity.Request
            {
                exchangeId = exchangeId,
                identifier = identifier,
                identifierType = identifierType,
                stockStatus = stockStatus,
                Token = token,
                ResponseType = responseType
            };

            return await GetStockExchangeSecurityList(endPoint, request);
        }
        public static async Task<List<StockExchangeSecurity.StockExchangeSecurityEntity>> GetStockExchangeSecurityList(string endPoint, StockExchangeSecurity.Request request)
        {
            string requestUrl = endPoint.SetQueryParams(request);

            StockExchangeSecurity.Response response = await RestClient.GetDynamicResponseAsync<StockExchangeSecurity.Response>(requestUrl);

            return response.StockExchangeSecurityEntityList;
        }
    }
}
