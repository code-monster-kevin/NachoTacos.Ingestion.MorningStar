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
            CreateMap<CompanyFinancialAvailabilityEntity, TCompanyFinancialAvailability>();
            CreateMap<GeneralInfo, TGeneralInfo>();
            CreateMap<BalanceSheetEntity, TBalanceSheet>();
            CreateMap<CashFlowEntity, TCashFlow>();
            CreateMap<IncomeStatementEntity, TIncomeStatement>();
            CreateMap<CashFlowEntity, TCashFlowTTM>();
            CreateMap<IncomeStatementEntity, TIncomeStatementTTM>();
        }
    }
}
