using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.sınıflar
{
    public class TurlarTR
    {
        [Key]
        public int turID { get; set; }

        [ForeignKey("bolgeTR")]
        public int bolgeID { get; set; }
        public virtual bolgeTR bolgeTR { get; set; }
        public string Bolgesicaklik { get; set; }
        public string sehir { get; set; }
        public string girisresim { get; set; }
        public string turismi { get; set; }
        public List<turdetayTR> turdetayTRs { get; set; }
        public List<hizmetTR> hizmetTRs { get; set; }
        public List<DetayGorselTR> detayGorselTRs { get; set; }
        public List<TurTarihTR> turTarihTRs { get; set; }

        public string turtarihi { get; set; }
        public string ucret { get; set; }
        public int kontejyan { get; set; }
    }
}
