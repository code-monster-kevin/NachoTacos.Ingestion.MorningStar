using AutoMapper;
using NachoTacos.Ingestion.MorningStar.Api.EquityApi;
using NachoTacos.Ingestion.MorningStar.Domain;

namespace NachoTacos.Ingestion.MorningStar.Api
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<StockExchangeSecurityEntity, TStockExchangeSecurity>();
            CreateMap<BalanceSheetEntity, TBalanceSheet>();
        }
    }
}
