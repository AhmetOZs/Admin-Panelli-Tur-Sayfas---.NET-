using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.sınıflar
{
    public class DetayGorsel
    {
        [Key]
        public int DetayGorselID { get; set; }
        public string DetayResim { get; set; }

        [ForeignKey("Turlar")]
        public int turID { get; set; }
        public virtual Turlar Turlar { get; set; }
    }
}
