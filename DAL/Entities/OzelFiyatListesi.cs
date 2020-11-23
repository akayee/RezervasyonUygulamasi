using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class OzelFiyatListesi
    {
        [ForeignKey("Urunler")]
        public int Id { get; set; }
        public string Adi { get; set; }
        public int OzelFiyat { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public MusteriVeTedarikciler MusteriVeTedarikciler { get; set; }
        public Urunler Urunler { get; set; }

        public ICollection<MusteriVeTedarikciler> MusteriVeTedarikcilers { get; set; }

    }
}
