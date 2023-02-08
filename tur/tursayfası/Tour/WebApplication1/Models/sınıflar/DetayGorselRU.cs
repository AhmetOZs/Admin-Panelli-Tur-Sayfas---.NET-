using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.sınıflar
{
    public class DetayGorselRU
    {
        [Key]
        public int DetayGorselID { get; set; }
        public string DetayResim { get; set; }

        [ForeignKey("TurlarRU")]
        public int turID { get; set; }
        public virtual TurlarRU TurlarRU { get; set; }
    }
}
