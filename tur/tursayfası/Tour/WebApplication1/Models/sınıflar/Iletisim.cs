using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.sınıflar
{
    public class Iletisim
    {
        [Key]
        public int iletisimID { get; set; }
        public string telefonsabit { get; set; }
        public string telefoncep { get; set; }
        public string mail { get; set; }
        public string adres { get; set; }
        public string konum { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string instagram { get; set; }
        public string linkedin { get; set; }
        public string metintr { get; set; }
        public string metinen { get; set; }
        public string metinru { get; set; }
        public string fotaciklamatr { get; set; }
        public string fotaciklamaen { get; set; }
        public string fotaciklamaru { get; set; }
        
    }
}
