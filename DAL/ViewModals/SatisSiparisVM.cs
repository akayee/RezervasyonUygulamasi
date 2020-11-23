using DAL.Entities;
using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModals
{
    public class SatisSiparisVM
    {
        public int Id { get; set; }
        public DateTime? SatisTarihi { get; set; }
        public string Aciklama { get; set; }
        public int Tutar { get; set; }
        public int? Iskonto { get; set; }
        public int? BelgeNo { get; set; }
        public DateTime? VadeTarihi { get; set; }
        public int? IrsaliyeNo { get; set; }
        public SiparisDurumu SiparisDurumu { get; set; }
        public string ArsivBelgesi { get; set; }
        public bool? Iptal { get; set; }
        public int PageCount { get; set; }
        public DateTime? OluşturulmaTarihi { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
        public int MusteriOrTedarikcilerID { get; set; }
        public Firmalar Firmalar { get; set; }
        public MusteriVeTedarikciler MusteriVeTedarikciler { get; set; }
        public List<TahsilatlarOdemeler> TahsilatlarOdemelers { get; set; }
        public List<Urunler> Urunler { get; set; }
        public List<Faturalar> Faturalars { get; set; }
    }
}
