using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Firmalar
    {
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string FirmaAdi { get; set; }
        [ForeignKey("Kullanicilar")]
        public int KullaniciID { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public Kullanicilar Kullanicilar { get; set; }
        public ICollection<Krediler> Kredilers { get; set; }
        public ICollection<Calisanlar> Calisanlars{ get; set; }
        public ICollection<Hesaplar> Hesaplars { get; set; }
        public ICollection<Masraflar> Masraflars { get; set; }
        //Sonradan Eklenen İlişkiler
        public ICollection<Urunler> Urunlers { get; set; }
        public ICollection<Satislar> Satislars{ get; set; }
        public ICollection<MusteriVeTedarikciler> MusteriVeTedarikcilers{ get; set; }
        public ICollection<TahsilatlarOdemeler> TahsilatlarOdemelers{ get; set; }
        public ICollection<Uretim> Uretims{ get; set; }
        public ICollection<Depolar> Depolars { get; set; }




    }
}
