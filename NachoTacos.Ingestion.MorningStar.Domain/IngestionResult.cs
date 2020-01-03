using System;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    /// <summary>
    /// This model stores the data retrieved
    /// </summary>
    public class IngestionResult : Updateable
    {
        public Guid IngestionResultId { get; protected set; }
        public string SourceType { get; protected set; }
        public string SourceUrl { get; protected set; }
        public string PostData { get; protected set; }
        public string ResponseData { get; protected set; }
        public bool Processed { get; set; }

        public static IngestionResult Create(string sourcetype, string sourceurl, string postdata, string responsedata)
        {
            return new IngestionResult
            {
                IngestionResultId = Guid.NewGuid(),
                SourceType = sourcetype,
                SourceUrl = sourceurl,
                PostData = postdata,
                ResponseData = responsedata,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            };
        }
    }
}
