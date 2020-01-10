using System.Collections.Generic;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.IncomeStatement
{
    public class Response : BaseResponse
    {
        public GeneralInfo GeneralInfo { get; set; }
        public List<IncomeStatementEntity> IncomeStatementEntityList { get; set; }
    }
}
