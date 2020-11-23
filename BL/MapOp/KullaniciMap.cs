using DAL.Context;
using DAL.Entities;
using DAL.ViewModals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.MapOp
{
    class KullaniciMap
    {
        
        public KullanicilarFirmalarVM MapKul(string name, string password)
        {
            using (var context = new RezervasyonContext())
            {
                KullanicilarFirmalarVM kullanici = new KullanicilarFirmalarVM();                
                var query = context.Kullanicilars.Where(x => x.KullaniciAdi == name && x.Password == password).FirstOrDefault();
                List<Firmalar> firma = context.Firmalars.Where(x => x.KullaniciID == query.Id).ToList();
                kullanici.Firmalar = firma;
                // Yukarıyı dene bi. Çalışmama ihtimali var. Çalışırsa  hesaplara musteri tedarikçileri yukarıdaki gibi ekle
                kullanici.KullaniciID = query.Id;
                kullanici.KullaniciAdi = query.KullaniciAdi;
                kullanici.Email = query.Email;
                kullanici.Phone = query.Phone;
                kullanici.Aktiflik = query.Aktiflik;
                kullanici.MailAktivasyon = query.MailAktivasyon;
                kullanici.PaypalOdeme = query.PaypalOdeme;
                kullanici.Image = query.Image;
                kullanici.PageCount = query.PageCount;

                return kullanici;
            }
        }

    }
}
