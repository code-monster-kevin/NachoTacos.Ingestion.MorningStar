using System.Collections.Generic;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.FinancialHealthRatios
{
    public class Response : BaseResponse
    {
        public GeneralInfo GeneralInfo { get; set; }
        public List<FinancialHealthEntity> FinancialHealthEntityList { get; set; }
    }
}
