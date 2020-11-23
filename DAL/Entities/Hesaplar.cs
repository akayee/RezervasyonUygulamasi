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
    public class Hesaplar
    {
        public virtual int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public virtual string Tanim { get; set; }
        public virtual ParaBirimi ParaBirimi { get; set; }
        public virtual int? HesapNo { get; set; }
        public virtual int GuncelBakiye { get; set; }
        public virtual int? HarcamaLimiti { get; set; }
        public virtual HesapTuru HesapTuru { get; set; }
        [ForeignKey("Firmalar")]
        public virtual int FirmaId { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public virtual DateTime? Tarih { get; set; }
        public virtual Firmalar Firmalar { get; set; }

        public virtual ICollection<TahsilatlarOdemeler> TahsilatlarOdemelers { get; set; }

    }
}
