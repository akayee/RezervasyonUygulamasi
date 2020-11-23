using DAL.Entities;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RezervasyonUygulamasi.Controllers
{
    public class StokController : BaseRepository<Stok>
    {
        public IHttpActionResult Get()
        {
            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, Stok model)
        {
            Stok guncellenecek = GetById(x => x.UrunId+x.DepoId == id);
            guncellenecek.StokAdedi = model.StokAdedi;
            guncellenecek.IslemTarihi = model.IslemTarihi;
            guncellenecek.EkleCikar = model.EkleCikar;

            Save();
            return Ok();
        }
        public IHttpActionResult Post(Stok model)
        {
            model.OlusturulmaTarihi = DateTime.Now;
            Add(model);
            Save();
            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            Remove(GetById(x => x.UrunId + x.DepoId == id));
            return Ok();
        }
    }
}
