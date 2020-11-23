using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Faturalar
    {
        /// <summary>
        /// Faturalar Tablosunda Fatura konumu ürün adedi ve indirim oranları tutulur.
        /// </summary>
        [Key, Column(Order = 0)]
        [ForeignKey("Urunler")]
        public int UrunlerId { get; set; }
        [ForeignKey("Satislar")]
        [Key, Column(Order = 1)]
        public int SatislarId { get; set; }
        public int UrunAdedi { get; set; }
        public int KDV { get; set; }
        public int Iskonto { get; set; }
        public int PageCount { get; set; }
        public string FaturaKonumu { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        [ForeignKey("Firmalar")]
        public int FirmalarID { get; set; }
        [ForeignKey("MusteriVeTedarikciler")]
        public int MusteriTedarikciID { get; set; }
        public Urunler Urunler { get; set; }
        public Satislar Satislar { get; set; }
        public MusteriVeTedarikciler MusteriVeTedarikciler { get; set; }
        public Firmalar Firmalar { get; set; }


    }
}
