﻿using AutoMapper;
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
            CreateMap<EfficiencyEntity, TEfficiencyRatio>();
            CreateMap<EfficiencyEntity, TEfficiencyRatioTTM>();
            CreateMap<ProfitabilityEntity, TProfitabilityRatio>();
            CreateMap<ProfitabilityEntity, TProfitabilityRatioTTM>();

            CreateMap<FinancialHealthEntity, TFinancialHealthRatio>();
            CreateMap<GrowthEntity, TGrowthRatio>();
            CreateMap<ValuationRatioEntity, TValuationRatio>();
            CreateMap<QuantitativeRatingEntity, TQuantitativeRating>();
            CreateMap<MarketCapitalizationEntity, TMonthlyMarketCapitalizationHistory>();
            CreateMap<EODPriceEntity, TEODPriceHistory>();
        }
    }
}
