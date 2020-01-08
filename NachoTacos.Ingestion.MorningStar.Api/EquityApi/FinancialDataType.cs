using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi
{
    public class FinancialDataType
    {
        private FinancialDataType(string value) { Value = value; }
        public string Value { get; set; }

        public static FinancialDataType AOR { get { return new FinancialDataType("AOR"); } }
        public static FinancialDataType Restated { get { return new FinancialDataType("Restated"); } }
        public static FinancialDataType Preliminary { get { return new FinancialDataType("Preliminary"); } }

    }
}
