using System;

namespace NachoTacos.Ingestion.MorningStar.Api.EquityApi
{
    /// <summary>
    /// Source: https://equityapi.morningstar.com/DataCatalog.aspx?catalogid=47
    /// Created Date: 4 Jan 2020
    /// </summary>
    public class CompanyFinancialAvailabilityEntity : Equity
    {
        public int Start { get; set; }
        public int End { get; set; }
        public string SectorId { get; set; }
        public string SectorName { get; set; }
        public string IndustryGroupId { get; set; }
        public string IndustryGroupName { get; set; }
        public string IndustryId { get; set; }
        public string IndustryName { get; set; }
        public DateTime LatestQuarterlyReportDate { get; set; }
        public DateTime LatestAnnualReportDate { get; set; }
        public DateTime LatestPreliminaryReportDate { get; set; }
        public DateTime LatestSemiAnnualReportDate { get; set; }
        public string TemplateCode { get; set; }
        public string GlobalTemplateCode { get; set; }
    }
}
