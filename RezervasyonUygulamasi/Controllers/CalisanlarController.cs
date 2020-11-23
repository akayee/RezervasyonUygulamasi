using DAL.Entities;
using DAL.Repository;
using System;
using System.Web.Http;

namespace RezervasyonUygulamasi.Controllers
{
    public class CalisanlarController : BaseRepository<Calisanlar>
    {
        public IHttpActionResult Get()
        {
            return Ok(GetList());
        }
        public IHttpActionResult Put(int id, Calisanlar model)
        {
            Calisanlar guncellenecek = GetById(x => x.Id == id);
            guncellenecek.Adi = model.Adi;
            guncellenecek.Mail = model.Mail;
            guncellenecek.Phone = model.Phone;
            guncellenecek.EmployeeImage = model.EmployeeImage;
            guncellenecek.ParaBirimi = model.ParaBirimi;
            guncellenecek.IseGirisTarihi = model.IseGirisTarihi;
            guncellenecek.DogumTarihi = model.DogumTarihi;
            guncellenecek.TC = model.TC;
            guncellenecek.NetMaas = model.NetMaas;
            guncellenecek.HesapNo = model.HesapNo;
            guncellenecek.Departman = model.Departman;
            guncellenecek.TicketNo = model.TicketNo;
            guncellenecek.Adres = model.Adres;
            guncellenecek.BankaBilgileri = model.BankaBilgileri;
            guncellenecek.Not = model.Not;

            Save();
            return Ok();
        }
        public IHttpActionResult Post(Calisanlar model)
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
