using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class IsEmirleri
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Hedefler")]
        public int HedefId { get; set; }
        [Key]
        [Column(Order = 1)]
        [ForeignKey("IsTurleri")]
        public int IsturuId { get; set; }
        public int Deger { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public Hedefler Hedefler { get; set; }
        public IsTurleri IsTurleri { get; set; }
    }
}
