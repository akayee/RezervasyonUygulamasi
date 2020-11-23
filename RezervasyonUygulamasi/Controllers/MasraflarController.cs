using DAL.Entities;
using DAL.Repository;
using System;
using System.Web.Http;

namespace RezervasyonUygulamasi.Controllers
{
    public class MasraflarController : BaseRepository<Masraflar>
    {
        public IHttpActionResult Get()
        {
            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, Masraflar model)
        {
            Masraflar guncellenecek = GetById(x => x.Id == id);
            guncellenecek.IslemTarihi = model.IslemTarihi;
            guncellenecek.Aciklama = model.Aciklama;
            guncellenecek.DokumanKonumu = model.DokumanKonumu;
            guncellenecek.OdemeBilgisi = model.OdemeBilgisi;
            guncellenecek.OdemeTarihi = model.OdemeTarihi;
            guncellenecek.Tutar = model.Tutar;
            guncellenecek.KDVOrani = model.KDVOrani;
            guncellenecek.MasrafKalemi = model.MasrafKalemi;
            Save();
            return Ok();
        }
        public IHttpActionResult Post(Masraflar model)
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
