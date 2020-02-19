using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NachoTacos.Ingestion.MorningStar.Api.ViewModels;
using NachoTacos.Ingestion.MorningStar.Data;
using NachoTacos.Ingestion.MorningStar.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;

namespace NachoTacos.Ingestion.MorningStar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly ILogger<ReportController> _logger;
        private readonly IIngestionContext _ingestionDbContext;
        private static readonly ParameterExpression DefaultParam = Expression.Parameter(typeof(RBaseScreener), "m");
        private static readonly List<string> ScreenerProperties = new List<string>()
        {
            "SectorName",
            "IndustryGroupName",
            "IndustryName",
            "MarketCap",
            "EnterpriseValue",
            "TotalAssetPerShare",
            "TangibleBookValuePerShare",
            "BookValuePerShare",
            "SalesPerShare",
            "CFPerShare",
            "FCFPerShare",
            "PriceToBook",
            "PriceToSales",
            "PriceToCashFlow",
            "PriceToFreeCashFlow",
            "PriceToEPS",
            "PEGRatio",
            "PricetoCashRatio",
            "DividendYield",
            "ForwardDividend",
            "PayoutRatio",
            "SustainableGrowthRate",
            "EVToEBITDA",
            "QuantitativeMoatLabel",
            "QuantitativeValuationLabel",
            "QuantitativeValuationUncertaintyLabel",
            "QuantitativeFinancialHealthLabel",
            "QuantitativeStarRating",
            "QuantitativeFairValue",
        };

        public ReportController(IIngestionContext ingestionDbContext, ILogger<ReportController> logger)
        {
            _ingestionDbContext = ingestionDbContext;
            _logger = logger;
        }

        /// <summary>
        /// Returns the screener data catalog
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Screener")]
        public IActionResult Screener()
        {
            try
            {
                return Ok(AddCalculatedFields(GetRange()));
            }
            catch(Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        /// <summary>
        /// Returns the base screener for equity
        /// </summary>
        /// <param name="filters">The search filters for screening companies</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Screener")]
        public IActionResult Screener(ScreenerFilter filters)
        {
            try
            {
                string log = string.Format("screener: {0}", JsonConvert.SerializeObject(filters));
                _logger.LogInformation(log);

                List<StringFilter> stringFilters = filters.StringFilters;
                List<ValueFilter<double>> valueFilters = filters.ValueFilters;

                var screener = _ingestionDbContext.RBaseScreeners.AsQueryable();

                foreach (var item in valueFilters)
                {
                    var expression = GetPredicate(item);
                    screener = screener.Where(expression);
                }

                foreach (var item in stringFilters)
                {
                    var expression = GetPredicate(item);
                    screener = screener.Where(expression);
                }

                return Ok(screener.ToList());
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return Problem(ex.Message);
            }
        }

        private List<ScreenerCatalog> AddCalculatedFields(List<ScreenerCatalog> list)
        {
            var catalog = list.Where(x => x.Name == "DividendYield").FirstOrDefault();
            string max = (ParseDouble(catalog.Properties.Max) * 100).ToString();
            string min =(ParseDouble(catalog.Properties.Min) * 100).ToString();

            var divPctCatalog = new ScreenerCatalog
            {
                Name = "DividendYieldPct",
                Type = "int",
                Properties = new ScreenerProp
                {
                    Max = max,
                    Min = min,
                    IsAvailable = true
                }
            };
            list.Add(divPctCatalog);
            return list;
        }

        private List<ScreenerCatalog> GetRange()
        {
            var propertyInfos = typeof(RBaseScreener).GetProperties();
            var screener = _ingestionDbContext.RBaseScreeners.ToList();

            List<ScreenerCatalog> ranges = new List<ScreenerCatalog>();
            foreach (var pInfo in propertyInfos)
            {
                if (ScreenerProperties.Contains(pInfo.Name))
                {
                    ScreenerCatalog range = new ScreenerCatalog
                    {
                        Name = pInfo.Name,
                        Properties = new ScreenerProp()
                    };

                    var propertyValues =
                        screener.Select(m => typeof(RBaseScreener).GetProperty(pInfo.Name)?.GetValue(m, null)).Distinct()
                            .Where(m => m != null).ToList();

                    if (Nullable.GetUnderlyingType(pInfo.PropertyType) == typeof(decimal))
                    {
                        range.Type = "double";
                        if (propertyValues.Any())
                        {
                            List<decimal> values = propertyValues.OfType<decimal>().ToList();
                            range.Properties.Max = values.Max().ToString();
                            range.Properties.Min = values.Min().ToString();
                            range.Properties.IsAvailable = true;
                        }
                        else
                        {
                            range.Properties.IsAvailable = false;
                        }
                    }
                    else if (Nullable.GetUnderlyingType(pInfo.PropertyType) == typeof(int))
                    {
                        range.Type = "int";
                        if (propertyValues.Any())
                        {
                            List<int> values = propertyValues.OfType<int>().ToList();
                            range.Properties.Max = values.Max().ToString();
                            range.Properties.Min = values.Min().ToString();
                            range.Properties.IsAvailable = true;
                        }
                        else
                        {
                            range.Properties.IsAvailable = false;
                        }
                    }
                    else if(Nullable.GetUnderlyingType(pInfo.PropertyType) == typeof(long))
                    {
                        range.Type = "long";
                        if (propertyValues.Any())
                        {
                            List<long> values = propertyValues.OfType<long>().ToList();
                            range.Properties.Max = values.Max().ToString();
                            range.Properties.Min = values.Min().ToString();
                            range.Properties.IsAvailable = true;
                        }
                        else
                        {
                            range.Properties.IsAvailable = false;
                        }
                    }
                    else if (pInfo.PropertyType == typeof(string))
                    {
                        var kvPairs = propertyValues.Select(m => new ScreenerCollection { Text = m.ToString(), Value = m.ToString() }).ToList();
                        range.Properties.Collection = kvPairs;
                        range.Type = "string";
                        range.Properties.IsAvailable = true;
                    }

                    if (range.Type == null)
                    {
                        range.Type = "others";
                        range.Properties.IsAvailable = false;
                    }
                    ranges.Add(range);
                }
            }

            return ranges;
        }

        private Expression<Func<RBaseScreener, bool>> GetPredicate<T>(string propertyName, string operation, T value)
        {
            MemberExpression me = Expression.Property(DefaultParam, propertyName);
            BinaryExpression body = ExpressionBody(operation, me, value);
            var expression = Expression.Lambda<Func<RBaseScreener, bool>>(body, new[] { DefaultParam });

            return expression;
        }

        private Expression<Func<RBaseScreener, bool>> GetPredicate<T>(ValueFilter<T> filter)
        {
            return GetPredicate(filter.PropertyName, filter.Operation, filter.Value);
        }

        private static Expression<Func<RBaseScreener, bool>> GetPredicate(string propertyName, string operation, IEnumerable<string> collection)
        {

            var methodInfo = typeof(List<string>).GetMethod(operation,
                new Type[] { typeof(string) });

            var list = Expression.Constant(collection);

            MemberExpression value = Expression.Property(DefaultParam, propertyName);
            MethodCallExpression body = Expression.Call(list, methodInfo, value);

            return Expression.Lambda<Func<RBaseScreener, bool>>(body, DefaultParam);
        }
        
        private static Expression<Func<RBaseScreener, bool>> GetPredicate(StringFilter filter)
        {
            return GetPredicate(filter.PropertyName, filter.Operation, filter.Collection);
        }

        private static BinaryExpression ExpressionBody<T>(string operation, MemberExpression leftMemberExpression,
            T value)
        {
            return operation switch
            {
                "gt" => Expression.GreaterThan(leftMemberExpression, Expression.Convert(Expression.Constant(value), leftMemberExpression.Type)),
                "ge" => Expression.GreaterThanOrEqual(leftMemberExpression, Expression.Convert(Expression.Constant(value), leftMemberExpression.Type)),
                "lt" => Expression.LessThan(leftMemberExpression, Expression.Convert(Expression.Constant(value), leftMemberExpression.Type)),
                "le" => Expression.LessThanOrEqual(leftMemberExpression, Expression.Convert(Expression.Constant(value), leftMemberExpression.Type)),
                "eq" => Expression.Equal(leftMemberExpression, Expression.Convert(Expression.Constant(value), leftMemberExpression.Type)),
                "neq" => Expression.NotEqual(leftMemberExpression, Expression.Convert(Expression.Constant(value), leftMemberExpression.Type)),
                _ => null,
            };
        }

        private double ParseDouble(string value)
        {
            double result;
            if (double.TryParse(value, out result))
                return result;
            return 0.0;
        }
    }
}