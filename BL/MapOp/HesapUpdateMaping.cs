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
    public class HesapUpdateMaping
    {

        public bool HesapUpdateMap(HesaplarVM eklenecek)
        {
            /// Hesaplar VM içeriğini update işlemi yapar. Güncellenecek veri gönderilmesi gerekir. ID hiçbir şekilde değiştirilemez
            HesaplarVM hesap = new HesaplarVM();
            using (var context = new RezervasyonContext())
            {
                Hesaplar hesaplar = context.Hesaplar.Include(i => i.TahsilatlarOdemelers)
                                                          .Include(i => i.TahsilatlarOdemelers.Select(x => x.MusteriVeTedarikciler))
                                                          .FirstOrDefault(x => x.Id == eklenecek.Id);


                hesaplar.Tanim = eklenecek.Tanim;
                hesaplar.HesapNo = eklenecek.HesapNo;
                hesaplar.ParaBirimi = eklenecek.ParaBirimi;
                hesaplar.GuncelBakiye = eklenecek.GuncelBakiye;
                hesaplar.HarcamaLimiti = eklenecek.HarcamaLimiti;
                hesaplar.HesapTuru = eklenecek.HesapTuru;
                hesaplar.PageCount = eklenecek.PageCount;
                hesaplar.OlusturulmaTarihi = eklenecek.OlusturulmaTarihi;
                hesaplar.TahsilatlarOdemelers = eklenecek.TahsilatlarOdemeler.ToList();

                context.SaveChanges();

                if (eklenecek.Equals(hesaplar))
                    return true;
                else
                    return false;



            }

        }





    }
}
