using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.sınıflar
{
    public class DetayGorselTR
    {
        [Key]
        public int DetayGorselID { get; set; }
        public string DetayResim { get; set; }

        [ForeignKey("TurlarTR")]
        public int turID { get; set; }
        public virtual TurlarTR TurlarTR { get; set; }
    }
}
