using System.Collections.Generic;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.CashFlow
{
    public class Response : BaseResponse
    {
        public GeneralInfo GeneralInfo { get; set; }
        public List<CashFlowEntity> CashFlowEntityList { get; set; }
    }
}
