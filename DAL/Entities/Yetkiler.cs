using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Yetkiler
    {
        [ForeignKey("Kullanicilar")]
        public int Id { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public bool FaturaGirisi { get; set; }
        public bool FaturaIptali { get; set; }
        public bool TahsilatGirisi { get; set; }
        public bool TahsilatIptali { get; set; }
        public bool BorcAlacakFisleri { get; set; }
        public bool EskiTarihliKasaIslemi { get; set; }
        public bool KullaniciTanimlama { get; set; }
        public bool MusteriEkstreleri { get; set; }
        public bool MusteriKaydetme { get; set; }
        public bool MusteriSilme { get; set; }
        public bool UrunTanimlama { get; set; }
        public bool FiyatDegistirme { get; set; }
        public bool StokSayimi { get; set; }
        public bool Raporlar { get; set; }
        public bool KullaniciIslemFormu { get; set; }
        public bool DepoOlusturma { get; set; }
        public bool SatisGoruntuleme { get; set; }
        public bool MusteriGoruntuleme { get; set; }
        public bool MasrafGoruntuleme { get; set; }
        public Kullanicilar Kullanicilar { get; set; }
    }
}
