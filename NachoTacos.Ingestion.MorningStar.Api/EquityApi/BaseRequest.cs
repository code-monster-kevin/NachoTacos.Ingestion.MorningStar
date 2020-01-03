using System.ComponentModel.DataAnnotations;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi
{
    public class BaseRequest
    {
        [Required]
        public string Token { get; set; }
        public string ResponseType { get; set; }
    }
}
