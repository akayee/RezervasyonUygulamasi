using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class IsTurleri
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string IsTuruAdi { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Tur { get; set; }
        [ForeignKey("Birimler")]
        public int BirimId { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public Birimler Birimler { get; set; }
        public ICollection<IsEmirleri> IsEmirleris { get; set; }
        public ICollection<Parametreler> Parametreler { get; set; }
        public ICollection<Hedefler> Hedeflers { get; set; }
    }
}
