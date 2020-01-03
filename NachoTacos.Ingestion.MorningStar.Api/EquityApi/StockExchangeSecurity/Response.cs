using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.StockExchangeSecurity
{
    /// <summary>
    /// Source: https://equityapi.morningstar.com/DataCatalog.aspx?catalogid=161
    /// Endpoint: http://equityapi.morningstar.com/Webservice/GlobalMasterListsService.asmx/GetStockExchangeSecurityList
    /// </summary>
    public class Response : BaseResponse
    {
        public List<StockExchangeSecurityEntity> StockExchangeSecurityEntityList { get; set; }
    }
}
