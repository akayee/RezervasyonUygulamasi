
using DAL.Entities;
using DAL.Repository;
using System;
using System.Web.Http;

namespace RezervasyonUygulamasi.Controllers
{
    public class SatilanUrunlerController : BaseRepository<Faturalar>
    {
        public IHttpActionResult Get()
        {
            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, Faturalar model)
        {
            Faturalar guncellenecek = GetById(x => x.SatislarId+x.UrunlerId == id);
            guncellenecek.UrunAdedi = model.UrunAdedi;
            guncellenecek.KDV = model.KDV;
            guncellenecek.Iskonto = model.Iskonto;

            Save();
            return Ok();
        }
        public IHttpActionResult Post(Faturalar model)
        {
            model.OlusturulmaTarihi = DateTime.Now;
            Add(model);
            Save();
            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            Remove(GetById(x => x.SatislarId + x.UrunlerId == id));
            return Ok();
        }
    }
}
