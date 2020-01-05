using Flurl;
using NachoTacos.Ingestion.MorningStar.Api.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi
{
    /// <summary>
    /// source: https://equityapi.morningstar.com/DataCatalog.aspx
    /// </summary>
    public class GlobalMasterListsService
    {
        /// <summary>
        /// https://equityapi.morningstar.com/DataCatalog.aspx
        /// </summary>
        /// <param name="endPoint">http://equityapi.morningstar.com/Webservice/GlobalMasterListsService.asmx/GetStockExchangeSecurityList</param>
        /// <param name="token"></param>
        /// <param name="exchangeId"></param>
        /// <param name="identifier"></param>
        /// <param name="identifierType"></param>
        /// <param name="stockStatus"></param>
        /// <param name="responseType"></param>
        /// <returns></returns>
        public static async Task<List<StockExchangeSecurityEntity>> GetStockExchangeSecurityList(string endPoint, string token, string exchangeId, string identifier, string identifierType, string stockStatus, string responseType = "Json")
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
        public static async Task<List<StockExchangeSecurityEntity>> GetStockExchangeSecurityList(string endPoint, StockExchangeSecurity.Request request)
        {
            string requestUrl = endPoint.SetQueryParams(request);

            StockExchangeSecurity.Response response = await RestClient.GetDynamicResponseAsync<StockExchangeSecurity.Response>(requestUrl);

            return response.StockExchangeSecurityEntityList;
        }

        /// <summary>
        /// https://equityapi.morningstar.com/DataCatalog.aspx?catalogid=47
        /// </summary>
        /// <param name="endPoint">http://equityapi.morningstar.com/Webservice/GlobalMasterListsService.asmx/GetCompanyFinancialAvailabilityList</param>
        /// <returns></returns>
        public static void GetCompanyFinancialAvailabilityList(string endPoint)
        {
            throw new NotImplementedException();
        }


    }
}
