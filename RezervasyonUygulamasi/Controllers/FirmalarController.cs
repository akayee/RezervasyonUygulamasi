using DAL.Entities;
using DAL.Repository;
using System;
using System.Web.Http;

namespace RezervasyonUygulamasi.Controllers
{
    public class FirmalarController : BaseRepository<Firmalar>
    {
        public IHttpActionResult Get()
        {
            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, Firmalar model)
        {
            Firmalar guncellenecek = GetById(x => x.Id == id);
            guncellenecek.FirmaAdi = model.FirmaAdi;
            Save();
            return Ok();
        }
        public IHttpActionResult Post(Firmalar model)
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
