using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.sınıflar
{
    public class turdetayTR
    {
        [Key]
        public int detayID { get; set; }
        public string detayresim { get; set; }
        public string detaybaslik { get; set; }
        public string detayaciklama { get; set; }

        [ForeignKey("TurlarTR")]
        public int turID { get; set; }
        public virtual TurlarTR TurlarTR { get; set; }
    }
}
