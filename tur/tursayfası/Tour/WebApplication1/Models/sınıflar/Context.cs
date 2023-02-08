using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models.sınıflar
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=77.245.159.136; database=TourData; user=antalya55; password=Admin12345.!*;");
        }
        public DbSet<Turlar> Turlars { get; set; }
        public DbSet<TurlarTR> TurlarTRs { get; set; }
        public DbSet<TurlarRU> TurlarRUs { get; set; }
        public DbSet<turdetay> turdetays { get; set; }
        public DbSet<turdetayTR> turdetayTRs { get; set; }
        public DbSet<turdetayRU> turdetayRUs { get; set; }
        public DbSet<DetayGorsel> detayGorsels { get; set; }
        public DbSet<DetayGorselTR> detayGorselTRs { get; set; }
        public DbSet<DetayGorselRU> detayGorselRUs { get; set; }
        public DbSet<TurTarih> turTarihs { get; set; }
        public DbSet<TurTarihTR> turTarihTRs { get; set; }
        public DbSet<TurTarihRU> turTarihRUs { get; set; }
        public DbSet<hizmet> hizmets { get; set; }
        public DbSet<hizmetTR> hizmetTRs { get; set; }
        public DbSet<hizmetRU> hizmetRUs { get; set; }
        public DbSet<hakkimizdaen> hakkimizdaens { get; set; }
        public DbSet<hakkimizdaTR> hakkimizdaTRs { get; set; }
        public DbSet<hakkimizdaRU> hakkimizdaRUs { get; set; }
        public DbSet<fotogaleri> fotogaleris { get; set; }
        public DbSet<Iletisim> iletisims { get; set; }
        public DbSet<bolge> bolges { get; set; }
        public DbSet<bolgeTR> bolgeTRs { get; set; }
        public DbSet<bolgeRU> bolgeRUs { get; set; }
        public DbSet<Yorum> yorums { get; set; }
        public DbSet<Ana> Anas { get; set; }
        public DbSet<AnaGirisTR> AnaGirisTRs { get; set; }
        public DbSet<AnaGirisEN> AnaGirisENs { get; set; }
        public DbSet<AnaGirisRU> AnaGirisRUs { get; set; }
        public DbSet<Login> Logins { get; set; }


    }
}
