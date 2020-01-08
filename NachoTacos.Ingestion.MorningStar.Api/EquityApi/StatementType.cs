using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi
{
    public class StatementType
    {
        private StatementType(string value) { Value = value; }
        public string Value { get; set; }

        public static StatementType Annual { get { return new StatementType("Annual"); } }
        public static StatementType Quarterly { get { return new StatementType("Quarterly"); } }
    }
}
