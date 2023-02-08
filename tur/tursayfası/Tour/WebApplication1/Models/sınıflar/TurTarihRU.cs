using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.sınıflar
{
    public class TurTarihRU
    {
        [Key]
        public int tarihID { get; set; }
        public string tarih { get; set; }

        [ForeignKey("TurlarRU")]
        public int turID { get; set; }
        public virtual TurlarRU TurlarRU { get; set; }
    }
}
