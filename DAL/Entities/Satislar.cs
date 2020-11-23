using DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Satislar
    {
        /// <summary>
        /// Satislar Tablosu INVOICES olarak adlandırılır. Hem gider hem gelir olarak kullanılabilir. Bu durum MüşterilerVeTedarikçiler tablosundaki TedarikçiORMüşteri
        /// bilgisine bağlıdır.
        /// </summary>
        public int Id { get; set; }
        public DateTime? SatisTarihi { get; set; }
        public string Aciklama { get; set; }
        public int ToplamTutar { get; set; }
        public int? FaturaAltiIskonto { get; set; }
        public int? BelgeNo { get; set; }
        public DateTime? VadeTarihi { get; set; }
        public int? IrsaliyeNo { get; set; }
        public SiparisDurumu SiparisDurumu { get; set; }
        public string ArsivBelgesi { get; set; }//Fatura ve benzeri belgeler
        public bool? Iptal { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        [ForeignKey("Firmalar")]
        public int FirmalarID { get; set; }
        public Firmalar Firmalar{ get; set; }
        [ForeignKey("MusteriVeTedarikciler")]
        public int MusteriTedarikcilerID { get; set; }
        public MusteriVeTedarikciler MusteriVeTedarikciler { get; set; }

        public ICollection<TahsilatlarOdemeler> TahsilatlarOdemelers { get; set; }
        public ICollection<Urunler> Urunlers{ get; set; }

        public ICollection<Faturalar> Faturalars { get; set; }
    }
}
