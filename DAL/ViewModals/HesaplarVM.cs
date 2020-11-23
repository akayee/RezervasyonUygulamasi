using DAL.Entities;
using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModals
{
    public class HesaplarVM
    {

        public virtual int Id { get; set; }
        public virtual int FirmID { get; set; }
        public virtual string Tanim { get; set; }
        public virtual int? HesapNo { get; set; }
        public virtual ParaBirimi ParaBirimi { get; set; }
        public virtual int GuncelBakiye { get; set; }
        public virtual int? HarcamaLimiti { get; set; }
        public virtual HesapTuru HesapTuru { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public virtual DateTime? Tarih { get; set; }
        public List<TahsilatlarOdemeler> TahsilatlarOdemeler { get; set; }
        public MusteriVeTedarikciler MusteriVeTedarikciler{ get; set; }
    }
}
