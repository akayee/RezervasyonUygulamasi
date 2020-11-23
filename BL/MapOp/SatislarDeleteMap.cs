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
    public class SatislarDeleteMap
    {
        public bool SatisDeleteMaping(int id)
        {

            using (var context = new RezervasyonContext())
            {
                Satislar satislar = context.Satislars.Include(x => x.Firmalar)
                                                            .Include(i => i.Urunlers)
                                                            .Include(z => z.MusteriVeTedarikciler)
                                                            .Include(x => x.TahsilatlarOdemelers)
                                                            .Include(k => k.Faturalars).FirstOrDefault(k=> k.Id == id);



                context.Satislars.Remove(satislar);
                context.SaveChanges();


                if (satislar == null)
                    return true;
                else
                    return false;
            }
        }
    }
}
