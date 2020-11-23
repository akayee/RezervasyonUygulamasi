using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Depolar
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        [ForeignKey("Firmalar")]
        public int FirmalarID { get; set; }
        public Firmalar Firmalar { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public ICollection<Stok> Stoks { get; set; }
        public ICollection<Urunler> Urunlers{ get; set; }

    }
}
