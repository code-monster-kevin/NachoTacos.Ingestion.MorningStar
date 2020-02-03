using System.Collections.Generic;

namespace NachoTacos.Ingestion.MorningStar.Api.ViewModels
{
    public class ScreenerFilter
    {
        public List<StringFilter> StringFilters { get; set; }
        public List<ValueFilter<double>> ValueFilters { get; set; }
    }

    public class Filter
    {
        public string PropertyName { get; set; }
        public string Operation { get; set; }
    }

    public class ValueFilter<T> : Filter
    {
        public T Value { get; set; }
    }

    public class StringFilter : Filter
    {
        public IEnumerable<string> Collection { get; set; }
    }
}
