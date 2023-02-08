using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.sınıflar
{
    public class turdetayRU
    {
        [Key]
        public int detayID { get; set; }
        public string detayresim { get; set; }
        public string detaybaslik { get; set; }
        public string detayaciklama { get; set; }

        [ForeignKey("TurlarRU")]
        public int turID { get; set; }
        public virtual TurlarRU TurlarRU { get; set; }
    }
}
