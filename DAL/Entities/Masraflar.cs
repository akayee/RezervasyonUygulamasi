using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Masraflar
    {
        public int Id { get; set; }
        public DateTime? IslemTarihi { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Aciklama { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string DokumanKonumu { get; set; }
        public bool OdemeBilgisi { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public DateTime? OdemeTarihi { get; set; }
        public int Tutar { get; set; }
        public int? KDVOrani { get; set; }
        [ForeignKey("Firmalar")]
        public int FirmaId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string MasrafKalemi { get; set; }//JavaScriptte liste hazırlanıp metin olarak buraya kaydedilecek

        public Firmalar Firmalar { get; set; }
        public ICollection<TahsilatlarOdemeler> TahsilatlarOdemelers { get; set; }

    }
}
