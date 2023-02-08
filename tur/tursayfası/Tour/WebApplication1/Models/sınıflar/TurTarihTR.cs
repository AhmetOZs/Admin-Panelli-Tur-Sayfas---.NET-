using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.sınıflar
{
    public class TurTarihTR
    {
        [Key]
        public int tarihID { get; set; }
        public string tarih { get; set; }

        [ForeignKey("TurlarTR")]
        public int turID { get; set; }
        public virtual TurlarTR TurlarTR { get; set; }
    }
}
