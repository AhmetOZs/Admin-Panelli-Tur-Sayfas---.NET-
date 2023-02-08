using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication1.Models.sınıflar

{
    public class bolgeTR
    {
        [Key]
        public int bolgeID { get; set; }
        public string bolgeismi { get; set; }

        public List<TurlarTR> TurlarTRs { get; set; }
    }
}
