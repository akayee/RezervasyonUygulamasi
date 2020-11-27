using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class BirimKullanici
    {
        [Key][Column(Order = 0)]
        [ForeignKey("Kullanicilar")]
        public int KullaniciId { get; set; }
        [Key][Column(Order = 1)]
        [ForeignKey("Birimler")]
        public int BirimId { get; set; }
        public bool Yetki { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public Kullanicilar Kullanicilar { get; set; }
        public Birimler Birimler { get; set; }
    }
}
