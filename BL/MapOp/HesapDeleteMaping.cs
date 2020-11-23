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
    public class HesapDeleteMaping
    {

        public bool SatisDeleteMaping(int id)
        {
            /// ÇALIŞMIYOR
            /// Satislar VM içeriğini update işlemi yapar. Güncellenecek veri gönderilmesi gerekir. ID hiçbir şekilde değiştirilemez
            HesaplarVM satis = new HesaplarVM();
            using (var context = new RezervasyonContext())
            {
                Hesaplar satislar = context.Hesaplar.FirstOrDefault(z => z.Id == id);


                context.Hesaplar.Remove(satislar);
                context.SaveChanges();

                if (satislar== null)
                    return true;
                else
                    return false;


            }

        }

    }
}
