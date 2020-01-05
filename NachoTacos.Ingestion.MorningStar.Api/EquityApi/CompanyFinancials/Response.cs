using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi.CompanyFinancials
{
    public class Response : BaseResponse
    {
        public List<CompanyFinancialAvailabilityEntity> CompanyFinancialAvailabilityEntityList { get; set; }
    }
}
