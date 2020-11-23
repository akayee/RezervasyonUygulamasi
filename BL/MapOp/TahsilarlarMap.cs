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
    public class TahsilarlarMap
    {
        public List<TahsilatlarVM> TahsilatlarMapleme(int firmid){ 
            /// Tahsilatlar, Hesaplar ve Müsteri/Tedarikçisi Mapleme işlemi yapar. Firma id gönderilmesi gerekmektedir.   ///
        List<TahsilatlarVM> hesap = new List<TahsilatlarVM>();
            using (var context = new RezervasyonContext())
            {
                
                List<TahsilatlarOdemeler> hesaplar = context.TahsilatlarOdemelers.Include(x=>x.MusteriVeTedarikciler)
                                                            .Include(y=>y.Hesaplars)
                                                            .Include(z=>z.Kredilers)
                                                            .Include(k=>k.Masraflars)
                                                            .Include(k=>k.Firmalar)
                                                            .Where(s=>s.FirmalarID==firmid)
                                                            .ToList();
                

                foreach (var item in hesaplar)
                {
                    TahsilatlarVM eklenecek = new TahsilatlarVM();
                    eklenecek.Id = item.Id;
                    eklenecek.IslemTipi = item.IslemTipi;
                    eklenecek.DokumanKonum = item.DokumanKonum;
                    eklenecek.Tutar = item.Tutar;
                    eklenecek.PageCount = item.PageCount;
                    eklenecek.Firmalar = item.Firmalar;
                    eklenecek.MusteriVeTedarikciler = item.MusteriVeTedarikciler;
                    eklenecek.Hesaplar = item.Hesaplars.ToList();
                    eklenecek.Krediler = item.Kredilers.ToList();
                    eklenecek.Masraflars = item.Masraflars.ToList();

                    //Mapleme işlemi entitiden vme bu şekilde yapılıyor.
                    
                    

                    hesap.Add(eklenecek);

                }
            }
           
               
            

            return hesap;
    }
    }
}
