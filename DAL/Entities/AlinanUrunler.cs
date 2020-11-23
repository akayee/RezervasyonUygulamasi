using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class AlinanUrunler
    {
        [Key, Column(Order = 0)]
        public int AlinanUrunId { get; set; }
        [Key, Column(Order = 1)]
        public int UrunId { get; set; }
        public int UrunMiktari { get; set; }
        public int? KDVOrani { get; set; }
        /// <summary>
        /// KDV Orani Zorunlu Değil
        /// </summary>
        public int? IskontoOrani { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public UrunAlmaIslemleri UrunAlmaIslemleri { get; set; }
        public Urunler Urunler { get; set; }

    }
}
