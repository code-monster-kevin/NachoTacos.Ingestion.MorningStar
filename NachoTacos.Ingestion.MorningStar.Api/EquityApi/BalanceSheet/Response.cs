using System.Collections.Generic;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.BalanceSheet
{
    public class Response : BaseResponse
    {
        public GeneralInfo GeneralInfo { get; set; }
        public List<BalanceSheetEntity> BalanceSheetEntityList { get; set; }
    }
}
