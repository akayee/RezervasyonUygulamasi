using DAL.Entities;
using DAL.Repository;
using DAL.ViewModals;
using System;
using System.Web.Http;
using BL.MapOp;

namespace RezervasyonUygulamasi.Controllers
{
    public class SatislarController : BaseRepository<Satislar>
    {
        public IHttpActionResult Get()
        {
           

            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, SatisSiparisVM model)
        {
            SatislarUpdateMap satis = new SatislarUpdateMap();
            return Ok(satis.SatisUpdateMaping(model));
        }
        public IHttpActionResult GetList(int id)
        {

            SatislarMap Satislar = new SatislarMap();


            return Ok(Satislar.SatisMaping(id));
        }
        public IHttpActionResult Post(SatisSiparisVM model)
        {
            model.SatisTarihi = DateTime.Today;
            model.PageCount = 0;

            SatislarCreateMap satiscreate = new SatislarCreateMap();

            return Ok(satiscreate.SatisCreateMaping(model));
        }
        public IHttpActionResult Delete(int id)
        {
            SatislarDeleteMap satis = new SatislarDeleteMap();

            return Ok(satis.SatisDeleteMaping(id));
        }
    }
}
