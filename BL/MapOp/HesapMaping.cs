using DAL.Context;
using DAL.Entities;
using DAL.ViewModals;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace BL.MapOp
{
    public class HesapMaping
    {
        public List<HesaplarVM> HesapMap(int firmId)
        {
            List<HesaplarVM> hesap = new List<HesaplarVM>();
            using (var context = new RezervasyonContext())
            {
                List<Hesaplar> hesaplar = context.Hesaplar.Include(i => i.TahsilatlarOdemelers)
                                                          .Include(i => i.TahsilatlarOdemelers.Select(x => x.MusteriVeTedarikciler))
                                                          .Where(x => x.FirmaId == firmId).ToList();
                

                foreach (var item in hesaplar)
                {
                    HesaplarVM eklenecek = new HesaplarVM();
                    eklenecek.FirmID = item.FirmaId;
                    eklenecek.Id = item.Id;
                    eklenecek.Tanim = item.Tanim;
                    eklenecek.HesapNo = item.HesapNo;
                    eklenecek.ParaBirimi = item.ParaBirimi;
                    eklenecek.GuncelBakiye = item.GuncelBakiye;
                    eklenecek.HarcamaLimiti = item.HarcamaLimiti;
                    eklenecek.HesapTuru = item.HesapTuru;
                    eklenecek.PageCount = item.PageCount;
                    eklenecek.OlusturulmaTarihi = item.OlusturulmaTarihi;
                    eklenecek.TahsilatlarOdemeler = item.TahsilatlarOdemelers.ToList();
                    
                    //böle böle teker teker eklenecek
                    
                    

                    hesap.Add(eklenecek);

                }
            }
            
               
            

            return hesap;
        }
    }
}
