using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Uretim
    {
        public int Id { get; set; }
        public DateTime? UretimTarihi { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public int UretimAdedi { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string UretimAciklama { get; set; }
        public int Maliyet { get; set; }
        [ForeignKey("Firmalar")]
        public int FirmalarID { get; set; }
        public Firmalar Firmalar { get; set; }

        public ICollection<Urunler> Urunlers { get; set; }
    }
}
