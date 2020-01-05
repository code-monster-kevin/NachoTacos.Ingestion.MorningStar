using System.ComponentModel.DataAnnotations.Schema;

namespace NachoTacos.Ingestion.MorningStar.Domain
{
    [Table("TGeneralInfo", Schema = "MStar")]
    public class TGeneralInfo : TEquity
    {
        public string ShareClassId { get; set; }
    }
}
