using DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Urunler
    {
        [Key]
        public int Id { get; set; }
        public bool StokluUrun { get; set; }
        public ParaBirimi SatisFiyatBirimi { get; set; }
        public int SatisFiyat { get; set; }
        public int? SatisKDVOrani { get; set; }
        public bool? SatisFiyatinaKDVDahil { get; set; }
        public bool? IOVVar { get; set; }
        public int? IOVOrani { get; set; }
        public int? AlisFiyati { get; set; }
        public ParaBirimi AlisFiyatBirimi { get; set; }
        public int? AlisKDVOrani { get; set; }
        public bool? AlisFiyatinaKDVDahil { get; set; }
        public int? AlisIskontoOrani { get; set; }
        public int? UrunKodu { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string UrunAciklama { get; set; }
        public int? BarkodKodu { get; set; }
        public bool StokTakibi { get; set; }
        public int? KritikStokMiktari { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(40)]
        public string UrunImage { get; set; }
        public int? SatisIskontoOrani { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public int PageCount { get; set; }
        public bool SatisAktif { get; set; }
        [ForeignKey("Firmalar")]
        public int FirmalarID { get; set; }
        public Firmalar Firmalar { get; set; }
        public OzelFiyatListesi OzelFiyatListesi { get; set; }
       
        public ICollection<MusteriVeTedarikciler> MusteriVeTedarikcilers { get; set; }
        public ICollection<Depolar> Depolars { get; set; }
        public ICollection<Satislar> Satislars { get; set; }
        public ICollection<Faturalar> Faturalar { get; set; }
        public ICollection<Kategoriler> Kategorilers { get; set; }
        public ICollection<Uretim> Uretims { get; set; }
        public ICollection<Stok> Stoks { get; set; }
        public ICollection<AlinanUrunler> AlinanUrunlers { get; set; }
        public ICollection<UrunDokumanlari> UrunDokumanlaris { get; set; }


    }
}
