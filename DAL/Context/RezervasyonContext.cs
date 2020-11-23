using DAL.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.Context
{
    public class RezervasyonContext : DbContext
    {
        public RezervasyonContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<AlinanUrunler> AlinanUrunlers{ get; set; }
        public DbSet<Calisanlar> Calisanlars{ get; set; }
        public DbSet<Depolar> Depolars{ get; set; }
        public DbSet<Firmalar> Firmalars{ get; set; }
        public DbSet<Kategoriler> Kategorilers{ get; set; }
        public DbSet<Kullanicilar> Kullanicilars { get; set; }
        public DbSet<Masraflar> Masraflars { get; set; }
        public DbSet<MusteriVeTedarikciler> MusteriVeTedarikcilers { get; set; }
        public DbSet<OzelFiyatListesi> OzelFiyatListesis { get; set; }
        public DbSet<Faturalar> Faturalars { get; set; }
        public DbSet<Satislar> Satislars { get; set; }
        public DbSet<Stok> Stoks { get; set; }
        public DbSet<TahsilatlarOdemeler> TahsilatlarOdemelers { get; set; }
        public DbSet<Uretim> Uretims { get; set; }
        public DbSet<UrunAlmaIslemleri> UrunAlmaIslemleris { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Yetkiler> Yetkilers { get; set; }
        public DbSet<Hesaplar> Hesaplar { get; set; }
    }
}
