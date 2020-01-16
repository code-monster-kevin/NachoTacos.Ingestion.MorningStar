namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.ValuationRatio
{
#pragma warning disable IDE1006
    public class Request : BaseRequest
    {
        public string period { get; set; }

        public static Request Create(string token, string exchangeId, string identifierType, string identifier, string period, string responseType = "Json")
        {
            return new Request
            {
                exchangeId = exchangeId,
                identifier = identifier,
                identifierType = identifierType,
                period = period,
                Token = token,
                ResponseType = responseType
            };
        }
    }
}
