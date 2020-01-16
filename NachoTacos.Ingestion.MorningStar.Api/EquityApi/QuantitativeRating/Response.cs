using System.Collections.Generic;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.QuantitativeRating
{
    public class Response : BaseResponse
    {
        public GeneralInfo GeneralInfo { get; set; }
        public List<QuantitativeRatingEntity> QuantitativeRatingEntityList { get; set; }
    }
}
