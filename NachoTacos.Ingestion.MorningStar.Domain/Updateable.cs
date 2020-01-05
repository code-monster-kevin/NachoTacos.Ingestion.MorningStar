using System;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    public class Updateable : IUpdateable
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
