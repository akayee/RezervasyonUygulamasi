using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Parametreler
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string ParametreAdi { get; set; }
        [ForeignKey("IsTurleri")]
        public int IsturuId { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public IsTurleri IsTurleri { get; set; }
    }
}
