using System.ComponentModel.DataAnnotations;

namespace NachoTacos.Ingestion.MorningStar.Domain.MorningStar
{
    public class BaseRequest
    {
        [Required]
        public string Token { get; set; }
        public string ResponseType { get; set; }
    }

    public class BaseResponse
    {
        public MessageInfo MessageInfo { get; set; }
    }

    public class MessageInfo
    {
        public string MessageCode { get; set; }
        public string MessageDetail { get; set; }
    }
}
