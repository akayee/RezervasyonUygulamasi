using DAL.Entities;
using DAL.Repository;
using System;
using System.Web.Http;

namespace RezervasyonUygulamasi.Controllers
{
    public class OzelFiyatListesiController : BaseRepository<OzelFiyatListesi>
    {
        public IHttpActionResult Get()
        {
            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, OzelFiyatListesi model)
        {
            OzelFiyatListesi guncellenecek = GetById(x => x.Id == id);
            guncellenecek.Adi = model.Adi;
            guncellenecek.OzelFiyat = model.OzelFiyat;
            Save();
            return Ok();
        }
        public IHttpActionResult Post(OzelFiyatListesi model)
        {
            model.OlusturulmaTarihi = DateTime.Now;
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
