using System;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    public interface IUpdateable
    {
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}