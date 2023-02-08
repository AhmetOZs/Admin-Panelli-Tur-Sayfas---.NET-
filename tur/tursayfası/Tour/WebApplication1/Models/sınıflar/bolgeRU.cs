using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.sınıflar
{
    public class bolgeRU
    {
        [Key]
        public int bolgeID { get; set; }
        public string bolgeismi { get; set; }

        public List<TurlarRU> TurlarRUs { get; set; }
    }
}
