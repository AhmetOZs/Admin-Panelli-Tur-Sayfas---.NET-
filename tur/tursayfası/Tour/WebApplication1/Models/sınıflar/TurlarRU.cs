using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.sınıflar
{
    public class TurlarRU
    {
        [Key]
        public int turID { get; set; }

        [ForeignKey("bolgeRU")]
        public int bolgeID { get; set; }
        public virtual bolgeRU bolgeRU { get; set; }
        public string Bolgesicaklik { get; set; }
        public string sehir { get; set; }
        public string girisresim { get; set; }
        public string turismi { get; set; }
        public List<turdetayRU> turdetayRUs { get; set; }
        public List<DetayGorselRU> detayGorselRUs { get; set; }
       
        public List<hizmetRU> hizmetRUs { get; set; }
       
        public List<TurTarihRU> turTarihRUs { get; set; }

        public string turtarihi { get; set; }
        public string ucret { get; set; }
        public int kontejyan { get; set; }
    }
}
