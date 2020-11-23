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
    public class SatislarUpdateMap
    {
        public bool SatisUpdateMaping(SatisSiparisVM eklenecek)
        {
            /// Satislar VM içeriğini update işlemi yapar. Güncellenecek veri gönderilmesi gerekir. ID hiçbir şekilde değiştirilemez
            using (var context = new RezervasyonContext())
            {
                Satislar satislar = context.Satislars.Include(x => x.Firmalar)
                                                            .Include(i => i.Urunlers)
                                                            .Include(z => z.MusteriVeTedarikciler)
                                                            .Include(x => x.TahsilatlarOdemelers)
                                                            .Include(k => k.Faturalars).FirstOrDefault(z => z.Id == eklenecek.Id);

                

                    satislar.SatisTarihi = eklenecek.SatisTarihi;
                    satislar.Aciklama = eklenecek.Aciklama;
                    satislar.ToplamTutar = eklenecek.Tutar;
                    satislar.FaturaAltiIskonto = eklenecek.Iskonto;
                    satislar.BelgeNo = eklenecek.BelgeNo;
                    satislar.VadeTarihi = eklenecek.VadeTarihi;
                    satislar.IrsaliyeNo = eklenecek.IrsaliyeNo;
                    satislar.SiparisDurumu = eklenecek.SiparisDurumu;
                    satislar.ArsivBelgesi = eklenecek.ArsivBelgesi;
                    satislar.Iptal = eklenecek.Iptal;
                    satislar.PageCount = eklenecek.PageCount;
                    satislar.OlusturulmaTarihi = eklenecek.OluşturulmaTarihi;
                    satislar.GuncellemeTarihi = eklenecek.GuncellenmeTarihi;
                    satislar.Firmalar = eklenecek.Firmalar;
                    satislar.MusteriVeTedarikciler = eklenecek.MusteriVeTedarikciler;
                    satislar.TahsilatlarOdemelers = eklenecek.TahsilatlarOdemelers;
                    satislar.Urunlers = eklenecek.Urunler;
                    satislar.Faturalars = eklenecek.Faturalars;

                context.SaveChanges();
                if (satislar.Equals(eklenecek))
                    return true;
                else
                    return false;


            }
            
        }
    }
}
