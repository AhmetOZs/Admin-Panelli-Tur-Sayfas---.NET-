using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.sınıflar
{
    public class Turlar
    {
        [Key]
        public int turID { get; set; }

        [ForeignKey("bolge")]
        public int bolgeID { get; set; }
        public virtual bolge Bolge { get; set; }
        public string Bolgesicaklik { get; set; }
        public string sehir { get; set; }
        public string girisresim { get; set; }
        public string turismi { get; set; }

        public List<turdetay> turdetays { get; set; }
        public List<hizmet> hizmets { get; set; }
        public List<DetayGorsel> detayGorsels { get; set; }
        public List<TurTarih> turTarihs { get; set; }

        
        public string turtarihi { get; set; }
        public string ucret { get; set; }
        public int kontejyan { get; set; }



    }
}