using DAL.Entities;
using DAL.Repository;
using System;
using System.Web.Http;

namespace RezervasyonUygulamasi.Controllers
{
    public class KredilerController : BaseRepository<Krediler>
    {
        public IHttpActionResult Get()
        {
            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, Krediler model)
        {
            Krediler guncellenecek = GetById(x => x.Id == id);
            guncellenecek.Adi = model.Adi;
            guncellenecek.KalanTutar = model.KalanTutar;
            guncellenecek.IlkTaksit = model.IlkTaksit;
            guncellenecek.ParaBirimi = model.ParaBirimi;
            guncellenecek.KalanTaksitSayisi = model.KalanTaksitSayisi;
            guncellenecek.OdemeTakvimi = model.OdemeTakvimi;
            guncellenecek.Not = model.Not;
            guncellenecek.HesapNumarasi = model.HesapNumarasi;

            Save();
            return Ok();
        }
        public IHttpActionResult Post(Krediler model)
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
