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
    class TahsilatlarUpdateMap
    {
        public bool TahsilatlarUpdateMapleme(TahsilatlarVM eklenecek)
        {
            /// Tahsilatlar, Hesaplar ve Müsteri/Tedarikçisi Mapleme işlemi yapar. Firma id gönderilmesi gerekmektedir.   ///
            TahsilatlarVM hesap = new TahsilatlarVM();
            using (var context = new RezervasyonContext())
            {

                TahsilatlarOdemeler hesaplar = context.TahsilatlarOdemelers.Include(x => x.MusteriVeTedarikciler)
                                                            .Include(y => y.Hesaplars)
                                                            .Include(z => z.Kredilers)
                                                            .Include(k => k.Masraflars)
                                                            .Include(k => k.Firmalar)
                                                            .FirstOrDefault(x=> x.Id==eklenecek.Id);
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
                if (hesaplar.Equals(eklenecek))
                    return true;
                else
                    return false;
            }

            
        }



    }
}
