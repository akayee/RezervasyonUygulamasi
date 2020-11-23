using DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class TahsilatlarOdemeler
    {
        public int Id { get; set; }
        public bool IslemTipi { get; set; }//Tahsilat mı? Omdeme mi? 0 tahsilat 1 ödeme olacak şekilde kullanılacak
        public string DokumanKonum { get; set; }//Fatura yada para ödendiğine dair alınan belge

        public int Tutar { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public DateTime? IslemTarihi { get; set; }
        [ForeignKey("Firmalar")]
        public int FirmalarID { get; set; }
        public Firmalar Firmalar { get; set; }
        [ForeignKey("MusteriVeTedarikciler")]
        public int MusteriID { get; set; }
        public MusteriVeTedarikciler MusteriVeTedarikciler{ get; set; }

        public ICollection<Hesaplar> Hesaplars { get; set; }

        public ICollection<Krediler> Kredilers { get; set; }

        public ICollection<Masraflar> Masraflars { get; set; }

        public ICollection<Satislar> Satislars { get; set; }//En son bu tabloyu ekledim Alislar,Satilan Ürünler ve ürünler eklenecek. ÖNEMLİ Satislar ve Alislar tablosunun Depo ile ilişkisini tekrar gözden geçir
        
        public ICollection<UrunAlmaIslemleri> UrunAlmaIslemleris { get; set; }

    }
}
