using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.sınıflar
{
    public class bolge
    {
        [Key]
        public int bolgeID { get; set; }
        public string bolgeismi { get; set; }

        public List<Turlar> Turlars { get; set; }
    }
}
