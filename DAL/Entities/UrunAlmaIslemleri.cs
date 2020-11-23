using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class UrunAlmaIslemleri
    {
        public int Id { get; set; }
        public int BelgeNo { get; set; }
        public DateTime? AlinmaTarihi { get; set; }
        public DateTime? VadeTarihi { get; set; }
        public int PageCount { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public string MasrafKalemleri { get; set; }
        public string Aciklama { get; set; }
        public int FaturaAltiIskontoOrani { get; set; }
        public bool Taslakmi { get; set; }
        public string BelgenImage { get; set; }
        public bool Iptal { get; set; }
        public int IslemDurumu { get; set; }
        public ICollection<AlinanUrunler> AlinanUrunlers { get; set; }

        public ICollection<TahsilatlarOdemeler> TahsilatlarOdemelers { get; set; }

    }
}
