using DAL.Entities;
using DAL.Repository;
using System;
using System.Web.Http;

namespace RezervasyonUygulamasi.Controllers
{
    public class MusteriVeTedarikcilerController : BaseRepository<MusteriVeTedarikciler>
    {
        public IHttpActionResult Get()
        {
            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, MusteriVeTedarikciler model)
        {
            MusteriVeTedarikciler guncellenecek = GetById(x => x.Id == id);
            guncellenecek.Adi = model.Adi;
            guncellenecek.Email = model.Email;
            guncellenecek.Telefon1 = model.Telefon1;
            guncellenecek.Telefon2 = model.Telefon2;
            guncellenecek.DigerErisimBilgileri = model.DigerErisimBilgileri;
            guncellenecek.YetkiliKisi = model.YetkiliKisi;
            guncellenecek.MusteriAdresi = model.MusteriAdresi;
            guncellenecek.VergidenMuaf = model.VergidenMuaf;
            guncellenecek.BankaBilgileri = model.BankaBilgileri;
            guncellenecek.ParaBirimi = model.ParaBirimi;
            guncellenecek.AcikHesapRiskLimiti = model.AcikHesapRiskLimiti;
            guncellenecek.VadeGunuSayisi = model.VadeGunuSayisi;
            guncellenecek.Iskonto = model.Iskonto;
            guncellenecek.GuncelBakiyesi = model.GuncelBakiyesi;
            guncellenecek.MuhasebeKodu = model.MuhasebeKodu;
            guncellenecek.Image = model.Image;
            guncellenecek.VergiNo = model.VergiNo;
            guncellenecek.Not = model.Not;
            guncellenecek.TedarikciOrMusteri = model.TedarikciOrMusteri;
            guncellenecek.OzelFiyatListesis = model.OzelFiyatListesis;
            Save();
            return Ok();
        }
        public IHttpActionResult Post(MusteriVeTedarikciler model)
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
