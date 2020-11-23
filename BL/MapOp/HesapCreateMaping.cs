using DAL.Context;
using DAL.Entities;
using DAL.ViewModals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BL.MapOp
{
    public class HesapCreateMaping
    {

        public bool HesapCreateMap(HesaplarVM eklenecek)
        {
            /// Hesaplar VM içeriğini update işlemi yapar. Güncellenecek veri gönderilmesi gerekir. ID hiçbir şekilde değiştirilemez
            HesaplarVM hesap = new HesaplarVM();
            using (var context = new RezervasyonContext())
            {
                Hesaplar hesaplar = new Hesaplar();

                hesaplar.FirmaId = eklenecek.FirmID;
                hesaplar.Tanim = eklenecek.Tanim;
                hesaplar.HesapNo = eklenecek.HesapNo;
                hesaplar.ParaBirimi = eklenecek.ParaBirimi;
                hesaplar.GuncelBakiye = eklenecek.GuncelBakiye;
                hesaplar.HarcamaLimiti = eklenecek.HarcamaLimiti;
                hesaplar.HesapTuru = eklenecek.HesapTuru;
                hesaplar.PageCount = eklenecek.PageCount;
                hesaplar.OlusturulmaTarihi = eklenecek.OlusturulmaTarihi;


                context.Hesaplar.Add(hesaplar);
                Firmalar firma =context.Firmalars.FirstOrDefault(x => x.Id == hesaplar.FirmaId);
                firma.Hesaplars.Add(hesaplar);
                context.SaveChanges();
                if (context.Hesaplar.FirstOrDefault(x=> x.Id==hesaplar.Id)!= null)
                    return true;
                else
                    return false;



            }

        }





    }
}
