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
    public class UrunlerController : BaseRepository<Urunler>
    {
        public IHttpActionResult Get()
        {
            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, Urunler model)
        {
            Urunler guncellenecek = GetById(x => x.Id == id);
            guncellenecek.StokluUrun = model.StokluUrun;
            guncellenecek.SatisFiyatBirimi = model.SatisFiyatBirimi;
            guncellenecek.SatisFiyat = model.SatisFiyat;
            guncellenecek.SatisKDVOrani = model.SatisKDVOrani;
            guncellenecek.SatisFiyatinaKDVDahil = model.SatisFiyatinaKDVDahil;
            guncellenecek.IOVVar = model.IOVVar;
            guncellenecek.IOVOrani = model.IOVOrani;
            guncellenecek.AlisFiyati = model.AlisFiyati;
            guncellenecek.AlisFiyatBirimi = model.AlisFiyatBirimi;
            guncellenecek.AlisKDVOrani = model.AlisKDVOrani;
            guncellenecek.AlisFiyatinaKDVDahil = model.AlisFiyatinaKDVDahil;
            guncellenecek.AlisIskontoOrani = model.AlisIskontoOrani;
            guncellenecek.UrunKodu = model.UrunKodu;
            guncellenecek.UrunAciklama = model.UrunAciklama;
            guncellenecek.BarkodKodu = model.BarkodKodu;
            guncellenecek.StokTakibi = model.StokTakibi;
            guncellenecek.KritikStokMiktari = model.KritikStokMiktari;
            guncellenecek.UrunImage = model.UrunImage;
            guncellenecek.SatisIskontoOrani = model.SatisIskontoOrani;
            guncellenecek.SatisAktif = model.SatisAktif;
            Save();
            return Ok();
        }
        public IHttpActionResult Post(Urunler model)
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
