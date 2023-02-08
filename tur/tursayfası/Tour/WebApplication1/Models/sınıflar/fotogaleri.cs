using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.sınıflar
{
    public class fotogaleri
    {
        [Key]
        public int galeriID { get; set; }
        public string galeriResim { get; set; }
    }
}
