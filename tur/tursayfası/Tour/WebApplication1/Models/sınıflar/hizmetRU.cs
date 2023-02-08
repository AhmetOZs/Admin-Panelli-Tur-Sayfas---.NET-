using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.sınıflar
{
    public class hizmetRU
    {
        [Key]
        public int hizmetID { get; set; }
        public string hizmetad { get; set; }
        public string hizmetaciklama { get; set; }
        public string ucret { get; set; }

        [ForeignKey("TurlarRu")]
        public int turID { get; set; }
        public virtual TurlarRU TurlarRU { get; set; }
    }
}
