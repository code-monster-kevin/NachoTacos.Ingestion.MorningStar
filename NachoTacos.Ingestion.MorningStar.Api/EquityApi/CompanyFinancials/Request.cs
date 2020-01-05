namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.CompanyFinancials
{
    public class Request : BaseRequest
    {
        public static Request Create(string token, string exchangeId, string identifierType, string identifier, string responseType = "Json")
        {
            return new Request
            {
                exchangeId = exchangeId,
                identifierType = identifierType,
                identifier = identifier,
                Token = token,
                ResponseType = responseType
            };
        }
    }
}
