﻿using DAL.Entities;
using DAL.Repository;
using System;
using System.Web.Http;

namespace RezervasyonUygulamasi.Controllers
{
    public class KategorilerController : BaseRepository<Kategoriler>
    {
        public IHttpActionResult Get()
        {
            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, Kategoriler model)
        {
            Kategoriler guncellenecek = GetById(x => x.Id == id);
            guncellenecek.Adi = model.Adi;
            Save();
            return Ok();
        }
        public IHttpActionResult Post(Kategoriler model)
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
