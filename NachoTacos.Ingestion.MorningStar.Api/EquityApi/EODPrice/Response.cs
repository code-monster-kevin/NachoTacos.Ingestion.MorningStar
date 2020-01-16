using System.Collections.Generic;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.EODPrice
{
    public class Response : BaseResponse
    {
        public GeneralInfo GeneralInfo { get; set; }
        public List<EODPriceEntity> EODPriceEntityList { get; set; }
    }
}
