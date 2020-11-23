using DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Calisanlar
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Mail { get; set; }
        public int? Phone { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string EmployeeImage { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public ParaBirimi ParaBirimi { get; set; }
        public DateTime? IseGirisTarihi { get; set; }
        public DateTime? IstenAyrilisTarihi { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public int? TC { get; set; }
        public int? NetMaas { get; set; }
        public int? HesapNo { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string Departman { get; set; }
        public int? TicketNo { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Adres { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string BankaBilgileri { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Not { get; set; }
        [ForeignKey("Firmalar")]
        public int FirmaId { get; set; }
        public Firmalar Firmalar { get; set; }
    }
}
