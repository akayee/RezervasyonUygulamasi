using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class UrunDokumanlari
    {
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Aciklama { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string DosyaKonumu { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        [ForeignKey("Urunler")]
        public int UrunId { get; set; }
        public Urunler Urunler { get; set; }

    }
}
