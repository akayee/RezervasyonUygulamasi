using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Kategoriler
    {
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public String Adi { get; set; }
        [ForeignKey("Urunler")]
        public int UrunId { get; set; }
        public Urunler Urunler { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }

    }
}
