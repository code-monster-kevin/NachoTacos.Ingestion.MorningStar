using System;
using System.Globalization;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi
{
#pragma warning disable IDE1006
    public class BaseFinancialTTMRequest : BaseRequest
    {
        /// <summary>
        /// mm/yyyy
        /// </summary>
        public string startDate { get; protected set; }
        /// <summary>
        /// mm/yyyy
        /// </summary>
        public string endDate { get; protected set; }

        public static BaseFinancialTTMRequest Create(string token, string exchangeId, string identifierType, string identifier, string startDate, string endDate, string responseType = "Json")
        {
            return new BaseFinancialTTMRequest
            {
                exchangeId = exchangeId,
                identifierType = identifierType,
                identifier = identifier,
                startDate = FormatDate(startDate),
                endDate = FormatDate(endDate),
                Token = token,
                ResponseType = responseType
            };
        }

        private static string FormatDate(string date)
        {
            string format = "MM/yyyy"; // format follows MorningStar request format
            string padDate = date.PadLeft(7, '0'); // ie. changes 1/2020 to 01/2020
            DateTime dummyDate;

            if (!DateTime.TryParseExact(padDate, format, new CultureInfo("en-US"), DateTimeStyles.None, out dummyDate))
            {
                throw new Exception(string.Format("BalanceSheet Request: Date must follow the format mm/yyyy: {0}", padDate));
            }
            return padDate;
        }
    }
}
