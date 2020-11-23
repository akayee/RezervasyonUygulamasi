using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Stok
    {
        [Key, Column(Order = 0)]
        public int UrunId { get; set; }
        [Key, Column(Order = 1)]
        public int DepoId { get; set; }
        public int StokAdedi { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public DateTime? IslemTarihi { get; set; }
        public bool EkleCikar { get; set; }
        public Urunler Urunler { get; set; }
        public Depolar Depolar { get; set; }

    }
}
