using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.sınıflar
{
    public class TurTarih
    {
        [Key]
        public int tarihID { get; set; }
        public string tarih { get; set; }
        
        [ForeignKey("Turlar")]
        public int turID { get; set; }
        public virtual Turlar Turlar { get; set; }
    }
}
