using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModals
{
    class AnaSayfaVM
    {
        public int FirmaID { get; set; }
        public List<Hesaplar> Hesaplar { get; set; }
        public List<Masraflar> Masraflar { get; set; }
        public List<UrunAlmaIslemleri> UrunAlmaIslemleri { get; set; }
        
    }
}
