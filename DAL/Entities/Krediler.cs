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
    public class Krediler
    {
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Adi { get; set; }
        public int KalanTutar { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public DateTime? IlkTaksit { get; set; }
        public ParaBirimi ParaBirimi { get; set; }
        public int? KalanTaksitSayisi { get; set; }
        public OdemeTakvimi OdemeTakvimi { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Not { get; set; }
        public int? HesapNumarasi { get; set; }
        [ForeignKey("Firmalar")]
        public int FirmaId { get; set; }
        public Firmalar Firmalar { get; set; }

        public ICollection<TahsilatlarOdemeler> TahsilatlarOdemelers { get; set; }

    }
}
