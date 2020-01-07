using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.BalanceSheet
{
#pragma warning disable IDE1006
    /// <summary>
    /// Source: https://equityapi.morningstar.com/DataCatalog.aspx?catalogid=47
    /// Endpoint: http://equityapi.morningstar.com/Webservice/CompanyFinancialsService.asmx/GetBalanceSheet
    /// Request parameters are case sensitive
    /// </summary>
    public class Request : BaseFinancialRequest
    {
        
    }
}
