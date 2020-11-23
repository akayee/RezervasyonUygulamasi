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
    class TahsilatlarCraeteMap
    {
        public bool TahsilatlarCreateMapleme(TahsilatlarVM eklenecek)
        {
            /// Tahsilatlar, Hesaplar ve Müsteri/Tedarikçisi Mapleme işlemi yapar. Firma id gönderilmesi gerekmektedir.   ///
            TahsilatlarVM hesap = new TahsilatlarVM();
            using (var context = new RezervasyonContext())
            {

                TahsilatlarOdemeler hesaplar = new TahsilatlarOdemeler();
                hesaplar.Id = eklenecek.Id;
                hesaplar.IslemTipi = eklenecek.IslemTipi;
                hesaplar.DokumanKonum = eklenecek.DokumanKonum;
                hesaplar.Tutar = eklenecek.Tutar;
                hesaplar.PageCount = eklenecek.PageCount;
                hesaplar.Firmalar = eklenecek.Firmalar;
                hesaplar.MusteriVeTedarikciler = eklenecek.MusteriVeTedarikciler;
                hesaplar.Hesaplars = eklenecek.Hesaplar.ToList();
                hesaplar.Kredilers = eklenecek.Krediler.ToList();
                hesaplar.Masraflars = eklenecek.Masraflars.ToList();

                context.TahsilatlarOdemelers.Add(hesaplar);
                if (hesaplar.Equals(eklenecek))
                    return true;
                else
                    return false;
            }


        }



    }
}
