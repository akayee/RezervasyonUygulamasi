using DAL.Entities;
using DAL.Repository;
using System;
using System.Web.Http;

namespace RezervasyonUygulamasi.Controllers
{
    public class UrunDokumanlariController : BaseRepository<UrunDokumanlari>
    {
        public IHttpActionResult Get()
        {
            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, UrunDokumanlari model)
        {
            UrunDokumanlari guncellenecek = GetById(x => x.Id == id);
            guncellenecek.Aciklama = model.Aciklama;
            guncellenecek.DosyaKonumu = model.DosyaKonumu;

            Save();
            return Ok();
        }
        public IHttpActionResult Post(UrunDokumanlari model)
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
