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
    public class YetkilerController : BaseRepository<Yetkiler>
    {
        public IHttpActionResult Get()
        {

            
            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, Yetkiler model)
        {
            Yetkiler guncellenecek = GetById(x => x.Id == id);
            guncellenecek.FaturaGirisi = model.FaturaGirisi;
            guncellenecek.FaturaIptali = model.FaturaIptali;
            guncellenecek.TahsilatGirisi = model.TahsilatGirisi;
            guncellenecek.TahsilatIptali = model.TahsilatIptali;
            guncellenecek.BorcAlacakFisleri = model.BorcAlacakFisleri;
            guncellenecek.EskiTarihliKasaIslemi = model.EskiTarihliKasaIslemi;
            guncellenecek.KullaniciTanimlama = model.KullaniciTanimlama;
            guncellenecek.MusteriEkstreleri = model.MusteriEkstreleri;
            guncellenecek.MusteriKaydetme = model.MusteriKaydetme;
            guncellenecek.MusteriSilme = model.MusteriSilme;
            guncellenecek.UrunTanimlama = model.UrunTanimlama;
            guncellenecek.FiyatDegistirme = model.FiyatDegistirme;
            guncellenecek.StokSayimi = model.StokSayimi;
            guncellenecek.Raporlar = model.Raporlar;
            guncellenecek.KullaniciIslemFormu = model.KullaniciIslemFormu;
            guncellenecek.DepoOlusturma = model.DepoOlusturma;
            guncellenecek.SatisGoruntuleme = model.SatisGoruntuleme;
            guncellenecek.MusteriGoruntuleme = model.MusteriGoruntuleme;
            guncellenecek.MasrafGoruntuleme = model.MasrafGoruntuleme;

            Save();
            return Ok();
        }
        public IHttpActionResult Post(Yetkiler model)
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
