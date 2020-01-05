using Flurl.Http;
using System;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.Services
{
    public class RestClient
    {
        public static async Task<string> GetResponseAsync(string url)
        {
            try
            {
                IFlurlResponse response = await url.GetAsync();
                return await response.ResponseMessage.Content.ReadAsStringAsync();
            }
            catch (FlurlHttpTimeoutException)
            {
                throw new Exception("Response Time Out");
            }
            catch (FlurlHttpException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<dynamic> GetDynamicResponseAsync<T>(string url)
        {
            try
            {
                return await url.GetJsonAsync<T>();
            }
            catch (FlurlHttpTimeoutException)
            {
                throw new Exception("Response Time Out");
            }
            catch (FlurlHttpException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
