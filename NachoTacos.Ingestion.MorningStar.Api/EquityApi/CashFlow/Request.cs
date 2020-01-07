using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.CashFlow
{
#pragma warning disable IDE1006
    public class Request : BaseRequest
    {
        [Required]
        public string statementType { get; protected set; }
        public string dataType { get; protected set; }
        public string startDate { get; protected set; }
        public string endDate { get; protected set; }

        public static Request Create(string token, string exchangeId, string identifierType, string identifier, string statementType, string dataType, string startDate, string endDate, string responseType = "Json")
        {
            return new Request
            {
                exchangeId = exchangeId,
                identifierType = identifierType,
                identifier = identifier,
                statementType = statementType,
                dataType = dataType,
                startDate = formatDate(startDate),
                endDate = formatDate(endDate),
                Token = token,
                ResponseType = responseType
            };
        }

        private static string formatDate(string date)
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
