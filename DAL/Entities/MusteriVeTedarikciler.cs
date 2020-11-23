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
    public class MusteriVeTedarikciler
    {
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Adi { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Email { get; set; }
        public int? Telefon1 { get; set; }
        public int? Telefon2 { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string DigerErisimBilgileri { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string YetkiliKisi { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string MusteriAdresi { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string VergiDairesi { get; set; }
        public bool VergidenMuaf { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string BankaBilgileri { get; set; }
        public ParaBirimi ParaBirimi { get; set; }
        public int? AcikHesapRiskLimiti { get; set; }
        public int? VadeGunuSayisi { get; set; }
        public int? Iskonto { get; set; }
        public int GuncelBakiyesi { get; set; }
        public int? MuhasebeKodu { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Image { get; set; }
        public int? VergiNo { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Not { get; set; }
        public TedarikciOrMusteri TedarikciOrMusteri { get; set; }
        [ForeignKey("Firmalar")]
        public int FirmalarID { get; set; }
        public Firmalar Firmalar{ get; set; }
        public ICollection<Satislar> Satislars { get; set; }
        public ICollection<TahsilatlarOdemeler> TahsilatlarOdemelers{ get; set; }

        public ICollection<OzelFiyatListesi> OzelFiyatListesis { get; set; }

        public ICollection<Urunler> Urunlers { get; set; }
    }
}
