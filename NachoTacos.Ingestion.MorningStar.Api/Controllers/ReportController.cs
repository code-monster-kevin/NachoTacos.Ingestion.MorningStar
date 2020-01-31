using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        public ReportController(IIngestionContext ingestionDbContext, ILogger<ReportController> logger)
        {
            _ingestionDbContext = ingestionDbContext;
            _logger = logger;
        }

        [HttpGet]
        [Route("Screener")]
        public IActionResult Screener()
        {
            try
            {
                return Ok(GetRange());
            }
            catch(Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        [Route("Screener")]
        public IActionResult Screener(dynamic json)
        {
            try
            {
                string log = string.Format("screener: {0}", JsonConvert.SerializeObject(json));
                _logger.LogInformation(log);

                List<StringFilter> stringFilters = json.StringFilters.ToObject<List<StringFilter>>();
                List<ValueFilter<double>> valueFilters = json.ValueFilters.ToObject<List<ValueFilter<double>>>();

                var screener = _ingestionDbContext.RBaseScreeners.AsQueryable();

                foreach (var filter in valueFilters)
                {
                    var expression = GetPredicate(filter);
                    screener = screener.Where(expression);
                }

                foreach (var filter in stringFilters)
                {
                    var expression = GetPredicate(filter);
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

        private List<dynamic> GetRange()
        {
            var propertyInfos = typeof(RBaseScreener).GetProperties();
            var screener = _ingestionDbContext.RBaseScreeners.ToList();

            List<dynamic> ranges = new List<dynamic>();
            foreach (var pInfo in propertyInfos)
            {
                if (ScreenerProperties.Contains(pInfo.Name))
                {
                    dynamic range = new ExpandoObject();
                    range.Name = pInfo.Name;
                    range.Properties = new ExpandoObject() as dynamic;

                    var propertyValues =
                        screener.Select(m => typeof(RBaseScreener).GetProperty(pInfo.Name)?.GetValue(m, null)).Distinct()
                            .Where(m => m != null).ToList();

                    if (Nullable.GetUnderlyingType(pInfo.PropertyType) == typeof(double))
                    {
                        range.Type = "double";
                        if (propertyValues.Any())
                        {
                            List<double> values = propertyValues.OfType<double>().ToList();
                            range.Properties.Max = values.Max();
                            range.Properties.Min = values.Min();
                            range.IsAvailable = true;
                        }
                        else
                        {
                            range.IsAvailable = false;
                        }
                    }
                    else if (pInfo.PropertyType == typeof(string))
                    {
                        var kvPairs = propertyValues.Select(m => new { Text = m, Value = m }).ToList();
                        range.Properties.Collection = kvPairs;
                        range.Type = "string";
                        range.IsAvailable = true;
                    }

                    if (range.Type == null)
                    {
                        range.Type = "others";
                        range.IsAvailable = false;
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
            // m => codes.Contains(m.Code)
            // operation = "Contains"
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

        private class Filter
        {
            public string PropertyName { get; set; }
            public string Operation { get; set; }
        }

        private class ValueFilter<T> : Filter
        {
            public T Value { get; set; }
        }

        private class StringFilter : Filter
        {
            public IEnumerable<string> Collection { get; set; }
        }

        public static readonly List<string> ScreenerProperties = new List<string>()
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
            "DividendYieldPct",
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

    }
}