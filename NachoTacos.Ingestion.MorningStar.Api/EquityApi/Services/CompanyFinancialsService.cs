using Flurl;
using NachoTacos.Ingestion.MorningStar.Api.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi
{
    /// <summary>
    /// https://equityapi.morningstar.com/DataCatalog.aspx?catalogid=47
    /// Company Financials Tabs
    /// </summary>
    public class CompanyFinancialsService
    {
        #region "GetBalanceSheet"
        /// <summary>
        /// https://equityapi.morningstar.com/DataCatalog.aspx?catalogid=47
        /// </summary>
        /// <param name="endPoint">http://equityapi.morningstar.com/Webservice/CompanyFinancialsService.asmx/GetBalanceSheet</param>
        /// <param name="token"></param>
        /// <param name="exchangeId"></param>
        /// <param name="identifierType"></param>
        /// <param name="identifier"></param>
        /// <param name="statementType"></param>
        /// <param name="dataType"></param>
        /// <param name="startDate">Format must be mm/yyyy</param>
        /// <param name="endDate">Format must be mm/yyyy</param>
        /// <param name="responseType"></param>
        /// <returns></returns>
        public static async Task<List<BalanceSheetEntity>> GetBalanceSheet(string endPoint, string token, string exchangeId, string identifierType, string identifier, string statementType, string dataType, string startDate, string endDate, string responseType = "Json")
        {
            BalanceSheet.Request request = BalanceSheet.Request.Create(token, exchangeId, identifierType, identifier, statementType, dataType, startDate, endDate, responseType);
            return await GetBalanceSheet(endPoint, request);
        }

        public static async Task<List<BalanceSheetEntity>> GetBalanceSheet(string endPoint, BalanceSheet.Request request)
        {
            string requestUrl = endPoint.SetQueryParams(request);

            BalanceSheet.Response response = await RestClient.GetDynamicResponseAsync<BalanceSheet.Response>(requestUrl);

            return response.BalanceSheetEntityList;
        }
        #endregion

        /// <summary>
        /// https://equityapi.morningstar.com/DataCatalog.aspx?catalogid=47
        /// </summary>
        /// <param name="endPoint">http://equityapi.morningstar.com/Webservice/CompanyFinancialsService.asmx/GetCashFlow</param>
        /// <returns></returns>
        public static void GetCashFlow(string endPoint)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// https://equityapi.morningstar.com/DataCatalog.aspx?catalogid=47
        /// </summary>
        /// <param name="endPoint">http://equityapi.morningstar.com/Webservice/CompanyFinancialsService.asmx/GetCashFlowTTM</param>
        /// <returns></returns>
        public static void GetCashFlowTTM(string endPoint)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endPoint">http://equityapi.morningstar.com/Webservice/CompanyFinancialsService.asmx/GetIncomeStatement</param>
        /// <returns></returns>
        public static void GetIncomeStatement(string endPoint)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// https://equityapi.morningstar.com/DataCatalog.aspx?catalogid=47
        /// </summary>
        /// <param name="endPoint">http://equityapi.morningstar.com/Webservice/CompanyFinancialsService.asmx/GetIncomeStatementTTM</param>
        /// <returns></returns>
        public static void GetIncomeStatementTTM(string endPoint)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endPoint">http://equityapi.morningstar.com/Webservice/CompanyFinancialsService.asmx/GetDebtReports</param>
        /// <returns></returns>
        public static void GetDebtReports(string endPoint)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endPoint">http://equityapi.morningstar.com/Webservice/CompanyFinancialsService.asmx/GetMiscellaneousInfos</param>
        /// <returns></returns>
        public static void GetMiscellaneousInfos(string endPoint)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endPoint">http://equityapi.morningstar.com/Webservice/CompanyFinancialsService.asmx/GetSegmentSheets</param>
        /// <returns></returns>
        public static void GetSegmentSheets(string endPoint)
        {
            throw new NotImplementedException();
        }
    }
}
