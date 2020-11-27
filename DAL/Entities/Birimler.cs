using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Birimler
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string BirimAdi { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Butce { get; set; }
        public int? Phone { get; set; }
        public int? Adres { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public ICollection<BirimKullanici> BirimKullanicis { get; set; }
        public ICollection<Hedefler> Hedeflers { get; set; }
    }
}
