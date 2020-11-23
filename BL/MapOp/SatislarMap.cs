using DAL.Context;
using DAL.Entities;
using DAL.ViewModals;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace BL.MapOp
{
    public class SatislarMap
    {
        public List<SatisSiparisVM> SatisMaping(int firmid)
        {
            List<SatisSiparisVM> satis = new List<SatisSiparisVM>();
            using (var context = new RezervasyonContext())
            {
                List<Satislar> satislar = context.Satislars.Include(i => i.Urunlers)
                                                            .Include(x => x.TahsilatlarOdemelers)
                                                            .Include(k => k.Faturalars)
                                                            .Where(l => l.FirmalarID == firmid)
                                                            .ToList();

                foreach (var item in satislar)
                {
                    SatisSiparisVM eklenecek = new SatisSiparisVM();
                    eklenecek.Id = item.Id;
                    eklenecek.SatisTarihi = item.SatisTarihi;
                    eklenecek.Aciklama = item.Aciklama;
                    eklenecek.Tutar = item.ToplamTutar;
                    eklenecek.Iskonto = item.FaturaAltiIskonto;
                    eklenecek.BelgeNo = item.BelgeNo;
                    eklenecek.VadeTarihi = item.VadeTarihi;
                    eklenecek.IrsaliyeNo = item.IrsaliyeNo;
                    eklenecek.SiparisDurumu = item.SiparisDurumu;
                    eklenecek.ArsivBelgesi = item.ArsivBelgesi;
                    eklenecek.Iptal = item.Iptal;
                    eklenecek.PageCount = item.PageCount;
                    eklenecek.OluşturulmaTarihi = item.OlusturulmaTarihi;
                    eklenecek.GuncellenmeTarihi = item.GuncellemeTarihi;
                    eklenecek.Firmalar = item.Firmalar;
                    eklenecek.MusteriVeTedarikciler = item.MusteriVeTedarikciler;
                    eklenecek.TahsilatlarOdemelers = item.TahsilatlarOdemelers.ToList();
                    eklenecek.Urunler = item.Urunlers.ToList();
                    eklenecek.Faturalars = item.Faturalars.ToList();

                    satis.Add(eklenecek);

                }

            }
            return satis;
        }
    }
}
