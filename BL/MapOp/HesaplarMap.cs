using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.MapOp
{
    public class HesaplarMap
    {
        public HesaplarVM HesapMap(int firmId)
        {
            HesaplarVM hesap = new HesaplarVM();
            RezervasyonContext context = new RezervasyonContext();
            List<Hesaplar> hesaplar = context.Hesaplar.Where(x => x.FimrId == firmId).ToList();
            List<MusteriVeTedarikciler> contak = context.MusteriVeTedarikciler.Where(x => x.FirmalarID == firmId).ToList();
            List<TahsilatlarOdemeler> Tahsilatlar = context.TahsilatlarOdemeler.Where(x => x.FirmalarID == firmId).ToList();
            hesap.Hesaplar = hesaplar;
            hesap.TahsilatlarOdemeler = Tahsilatlar;
            hesap.MusteriVeTedarikciler = contak;


            return hesap;
        }
    }
}
