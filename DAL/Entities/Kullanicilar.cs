﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Kullanicilar
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string KullaniciAdi { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Password { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Email { get; set; }
        public bool Yetki { get; set; }
        public int? Phone { get; set; }
        public bool MailAktivasyon { get; set; }
        public bool Aktiflik { get; set; }
        public string Adress { get; set; }
        public string Unvan { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public ICollection<Firmalar> Firmalar { get; set; }
    }
}
