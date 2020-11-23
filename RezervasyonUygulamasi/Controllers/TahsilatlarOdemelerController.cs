using BL.MapOp;
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
    public class TahsilatlarOdemelerController : BaseRepository<TahsilatlarOdemeler>
    {
        public IHttpActionResult Get()
        {
            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, TahsilatlarOdemeler model)
        {
            TahsilatlarOdemeler guncellenecek = GetById(x => x.Id == id);
            guncellenecek.IslemTipi = model.IslemTipi;
            guncellenecek.DokumanKonum = model.DokumanKonum;
            guncellenecek.Tutar = model.Tutar;
            guncellenecek.IslemTarihi = model.IslemTarihi;
            Save();
            return Ok();
        }
        public IHttpActionResult Post(TahsilatlarOdemeler model)
        {
            model.OlusturulmaTarihi = DateTime.Now;
            Add(model);
            Save();
            return Ok();
        }
        public IHttpActionResult GetList1(int id)
        {
            TahsilarlarMap tahsilatMap = new TahsilarlarMap();


            return Ok(tahsilatMap.TahsilatlarMapleme(id));
        }
        public IHttpActionResult Delete(int id)
        {
            Remove(GetById(x => x.Id == id));
            return Ok();
        }
    }
}
