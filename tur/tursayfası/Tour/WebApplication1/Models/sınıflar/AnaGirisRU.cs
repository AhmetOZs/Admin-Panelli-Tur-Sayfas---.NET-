using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.sınıflar
{
    public class AnaGirisRU
    {
        [Key]
        public int ID { get; set; }
        public string arkaplan { get; set; }
        public string üstsatır { get; set; }
        public string yer { get; set; }
        public string altsatır { get; set; }
        public string ucret { get; set; }
    }
}
