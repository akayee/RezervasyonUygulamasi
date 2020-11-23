using DAL.Entities;
using DAL.Repository;
using System;
using System.Web.Http;

namespace RezervasyonUygulamasi.Controllers
{
    public class UretimController : BaseRepository<Uretim>
    {
        public IHttpActionResult Get()
        {
            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, Uretim model)
        {
            Uretim guncellenecek = GetById(x => x.Id == id);
            guncellenecek.UretimTarihi = model.UretimTarihi;
            guncellenecek.UretimAdedi = model.UretimAdedi;
            guncellenecek.UretimAciklama = model.UretimAciklama;
            guncellenecek.Maliyet = model.Maliyet;

            Save();
            return Ok();
        }
        public IHttpActionResult Post(Uretim model)
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
