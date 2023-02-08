using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.sınıflar
{
    public class Login
    {

        [Key]
        public int LoginID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public char Yetki { get; set; }
    }
}
