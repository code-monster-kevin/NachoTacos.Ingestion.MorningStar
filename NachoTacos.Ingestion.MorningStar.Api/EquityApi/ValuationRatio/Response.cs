using System.Collections.Generic;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.ValuationRatio
{
    public class Response : BaseResponse
    {
        public GeneralInfo GeneralInfo { get; set; }
        public List<ValuationRatioEntity> ValuationRatioEntityList { get; set; }
    }
}
