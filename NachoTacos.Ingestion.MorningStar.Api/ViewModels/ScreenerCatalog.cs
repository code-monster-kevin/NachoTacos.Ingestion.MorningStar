using System.Collections.Generic;

namespace NachoTacos.Ingestion.MorningStar.Api.ViewModels
{
    public class ScreenerCatalog
    {
        public string Name { get; set; }
        public ScreenerProp Properties { get; set; }
        public string Type { get; set; }
    }

    public class ScreenerProp
    {
        public string Max { get; set; }
        public string Min { get; set; }
        public List<ScreenerCollection> Collection { get; set; }
        public bool IsAvailable { get; set; }
    }

    public class ScreenerCollection
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }
}
