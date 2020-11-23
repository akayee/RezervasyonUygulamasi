using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModals
{
    public class KullanicilarFirmalarVM
    {
        public List<Firmalar> Firmalar{ get; set; }
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int? Phone { get; set; }
        public bool MailAktivasyon { get; set; }
        public bool Aktiflik { get; set; }
        public bool PaypalOdeme { get; set; }
        public string Image { get; set; }
        public int PageCount { get; set; }
        public Yetkiler Yetkiler { get; set; }
    }
}
