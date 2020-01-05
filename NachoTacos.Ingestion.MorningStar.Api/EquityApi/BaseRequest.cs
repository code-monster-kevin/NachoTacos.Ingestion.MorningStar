using System.ComponentModel.DataAnnotations;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi
{
#pragma warning disable IDE1006
    public abstract class BaseRequest
    {
        [Required]
        public string exchangeId { get; set; }
        [Required]
        public string identifierType { get; set; }
        [Required]
        public string identifier { get; set; }
        [Required]
        public string Token { get; set; }
        [Required]
        public string ResponseType { get; set; }
    }
}
