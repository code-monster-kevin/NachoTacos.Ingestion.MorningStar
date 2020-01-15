using System.Collections.Generic;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.EfficiencyRatios
{
    public class Response : BaseResponse
    {
        public GeneralInfo GeneralInfo { get; set; }
        public List<EfficiencyEntity> EfficiencyEntityList { get; set; }
    }
}
