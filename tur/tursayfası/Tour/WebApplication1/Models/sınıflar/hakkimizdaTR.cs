using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.sınıflar
{
    public class hakkimizdaTR
    {
        [Key]
        public int hakkimizdaID { get; set; }
        public string hakkimizdabaslik { get; set; }
        public string hakkimizdaaciklama { get; set; }
        public string hakkimizdavideo { get; set; }
    }
}
