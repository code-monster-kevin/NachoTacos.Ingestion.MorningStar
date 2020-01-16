using System.Collections.Generic;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.GrowthRatios
{
    public class Response : BaseResponse
    {
        public GeneralInfo GeneralInfo { get; set; }
        public List<GrowthEntity> GrowthEntityList { get; set; }
    }
}
