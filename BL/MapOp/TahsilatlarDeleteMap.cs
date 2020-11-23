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
    class TahsilatlarDeleteMap
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
                                                            .FirstOrDefault(x => x.Id == eklenecek.Id);

                hesaplar = null;
                if (hesaplar == null)
                    return true;
                else
                    return false;
            }
        }
    }
}
