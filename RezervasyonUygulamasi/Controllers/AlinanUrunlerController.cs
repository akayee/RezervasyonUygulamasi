using DAL.Entities;
using DAL.Repository;
using System;
using System.Web.Http;

namespace RezervasyonUygulamasi.Controllers
{
    public class AlinanUrunlerController : BaseRepository<AlinanUrunler>
    {
        public IHttpActionResult Get()
        {
            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, AlinanUrunler model)
        {
            AlinanUrunler guncellenecek = GetById(x => x.AlinanUrunId+x.UrunId == id);
            
            guncellenecek.IskontoOrani = model.IskontoOrani;
            guncellenecek.UrunMiktari = model.UrunMiktari;
            guncellenecek.KDVOrani = model.KDVOrani;
            guncellenecek.IskontoOrani = model.IskontoOrani;

            Save();
            return Ok();
        }
        public IHttpActionResult Post(AlinanUrunler model)
        {
            model.OlusturulmaTarihi = DateTime.Now;
            Add(model);
            Save();
            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            Remove(GetById(x => x.AlinanUrunId + x.UrunId == id));
            return Ok();
        }
    }
}
