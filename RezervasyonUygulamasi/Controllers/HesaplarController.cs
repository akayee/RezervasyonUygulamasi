using DAL.Entities;
using BL.MapOp;
using DAL.Repository;
using System;
using System.Web.Http;
using DAL.ViewModals;

namespace RezervasyonUygulamasi.Controllers
{
    public class HesaplarController : BaseRepository<Hesaplar>
    {
        public IHttpActionResult Get()
        {
            var response = GetList();
            return Ok(response);
        }
        public IHttpActionResult Put(int id, HesaplarVM model)
        {
            HesapUpdateMaping hesap = new HesapUpdateMaping();
            return Ok(hesap.HesapUpdateMap(model));
        }
        public IHttpActionResult GetList(int id)
        {

            HesapMaping hesapMap = new HesapMaping();


            return Ok(hesapMap.HesapMap(id));
        }
        
        public IHttpActionResult GetListTahsilatlar(int id)
        {
            TahsilarlarMap tahsilatMap = new TahsilarlarMap();


            return Ok(tahsilatMap.TahsilatlarMapleme(id));
        }
        public IHttpActionResult Post(HesaplarVM model)
        {
            model.OlusturulmaTarihi = DateTime.Today;
            model.PageCount = 0;

            HesapCreateMaping hesapcreate = new HesapCreateMaping();

            return Ok(hesapcreate.HesapCreateMap(model));

        }
        public IHttpActionResult Delete(int id)
        {
            HesapDeleteMaping hesap = new HesapDeleteMaping();

            return Ok(hesap.SatisDeleteMaping(id));
        }
    }
}
