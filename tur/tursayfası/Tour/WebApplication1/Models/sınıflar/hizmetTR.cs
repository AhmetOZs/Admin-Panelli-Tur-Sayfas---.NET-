using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.sınıflar
{
    public class hizmetTR
    {
        [Key]
        public int hizmetID { get; set; }
        public string hizmetad { get; set; }
        public string hizmetaciklama { get; set; }
        public string ucret { get; set; }

        [ForeignKey("TurlarTR")]
        public int turID { get; set; }
        public virtual TurlarTR TurlarTR { get; set; }
    }
}
