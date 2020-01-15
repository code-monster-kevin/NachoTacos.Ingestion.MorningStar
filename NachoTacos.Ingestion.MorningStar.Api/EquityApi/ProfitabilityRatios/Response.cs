using System.Collections.Generic;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.ProfitabilityRatios
{
    public class Response : BaseResponse
    {
        public GeneralInfo GeneralInfo { get; set; }
        public List<ProfitabilityEntity> ProfitabilityEntityList { get; set; }
    }
}
