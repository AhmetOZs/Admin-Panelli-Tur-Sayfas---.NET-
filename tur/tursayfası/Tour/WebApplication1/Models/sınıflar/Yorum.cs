using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.sınıflar
{
    public class Yorum
    {
        [Key]
        public int YorumID { get; set; }
        public string tur { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string yorum { get; set; }
        public string resim { get; set; }
        public string puan { get; set; }
    }
}
