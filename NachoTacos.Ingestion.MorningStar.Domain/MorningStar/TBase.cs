using System;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    public abstract class TBase
    {
        public Guid Id { get; set; }
        public Guid IngestionTaskId { get; set; }
    }
}
