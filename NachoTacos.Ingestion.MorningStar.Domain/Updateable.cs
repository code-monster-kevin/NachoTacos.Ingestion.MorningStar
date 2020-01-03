using System;
using System.Collections.Generic;
using System.Text;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    public class Updateable : IUpdateable
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
