using DAL.Entities;
using DAL.Repository;
using System;
using System.Web.Http;

namespace RezervasyonUygulamasi.Controllers
{
    public class HomeController : BaseRepository<Kullanicilar>
    {
        public IHttpActionResult Get()
        {
            return Ok(GetList());
        }
        public IHttpActionResult Get(int id)
        {
            return Ok(GetById(x=> x.Id==id));
        }
        
        public IHttpActionResult Put(int id, Kullanicilar model)
        {
            Kullanicilar guncellenecek = GetById(x => x.Id == id);
            guncellenecek.KullaniciAdi = model.KullaniciAdi;
            guncellenecek.Password = model.Password;
            guncellenecek.Email = model.Email;
            guncellenecek.Phone = model.Phone;
            guncellenecek.Image = model.Image;
            Save();
            return Ok();
        }
        public IHttpActionResult Post(Kullanicilar model)
        {
            
                model.OlusturulmaTarihi = DateTime.Today;
                model.PageCount = 0;
                model.Aktiflik = true;
                model.MailAktivasyon = true;
                model.PaypalOdeme = true;
                Add(model);
                Save();
                return Ok();
                    
                

           
            
        }
        public IHttpActionResult Delete(int id)
        {
            Remove(GetById(x => x.Id == id));
            return Ok();
        }

    }
}
