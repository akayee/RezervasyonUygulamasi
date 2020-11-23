using DAL.Entities;
using DAL.Repository;
using System;
using System.Web.Http;

namespace RezervasyonUygulamasi.Controllers
{
    public class UrunAlmaIslemleriController : BaseRepository<UrunAlmaIslemleri>
    {
        public IHttpActionResult Get()
        {
            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, UrunAlmaIslemleri model)
        {
            UrunAlmaIslemleri guncellenecek = GetById(x => x.Id == id);
            guncellenecek.BelgeNo = model.BelgeNo;
            guncellenecek.AlinmaTarihi = model.AlinmaTarihi;
            guncellenecek.VadeTarihi = model.VadeTarihi;
            guncellenecek.MasrafKalemleri = model.MasrafKalemleri;
            guncellenecek.Aciklama = model.Aciklama;
            guncellenecek.FaturaAltiIskontoOrani = model.FaturaAltiIskontoOrani;
            guncellenecek.Taslakmi = model.Taslakmi;
            guncellenecek.BelgenImage = model.BelgenImage;
            guncellenecek.Iptal = model.Iptal;
            guncellenecek.IslemDurumu = model.IslemDurumu;
            Save();
            return Ok();
        }
        public IHttpActionResult Post(UrunAlmaIslemleri model)
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
