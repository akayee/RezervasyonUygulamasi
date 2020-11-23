using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModals
{
    public class TahsilatlarVM
    {
        public int Id { get; set; }
        public bool IslemTipi { get; set; }
        public string DokumanKonum { get; set; }
        public int Tutar { get; set; }
        public int PageCount { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
        public DateTime SonIslemTarihi { get; set; }
        public Firmalar Firmalar{ get; set; }
        public MusteriVeTedarikciler MusteriVeTedarikciler { get; set; }
        public List<Hesaplar> Hesaplar { get; set; }
        public List<Krediler> Krediler { get; set; }
        public List<Masraflar> Masraflars { get; set; }

    }
}
