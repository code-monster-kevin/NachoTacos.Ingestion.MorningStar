using System;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    public class IngestionTask : Updateable
    {
        public Guid IngestionTaskId { get; protected set; }
        public string Entity { get; protected set; }
        public string RequestJson { get; set; }
        public bool IsProcessed { get; set; }

        public static IngestionTask Create(string entity, string requestJson, bool IsProcessed=false)
        {
            return new IngestionTask
            {
                IngestionTaskId = Guid.NewGuid(),
                Entity = entity,
                RequestJson = requestJson,
                IsProcessed = IsProcessed,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            };
        }
    }
}
