namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_13 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.KullaniciHizmets", "Kullanici_Id", "dbo.Kullanicis");
            DropForeignKey("dbo.KullaniciHizmets", "Hizmet_Id", "dbo.Hizmets");
            DropForeignKey("dbo.Rezervasyons", "HizmetId", "dbo.Hizmets");
            DropForeignKey("dbo.Rezervasyons", "KullaniciId", "dbo.Kullanicis");
            DropForeignKey("dbo.Misafirs", "RezervasyonId", "dbo.Rezervasyons");
            DropIndex("dbo.Misafirs", new[] { "RezervasyonId" });
            DropIndex("dbo.Rezervasyons", new[] { "KullaniciId" });
            DropIndex("dbo.Rezervasyons", new[] { "HizmetId" });
            DropIndex("dbo.KullaniciHizmets", new[] { "Kullanici_Id" });
            DropIndex("dbo.KullaniciHizmets", new[] { "Hizmet_Id" });
            CreateTable(
                "dbo.AlinanUrunlers",
                c => new
                    {
                        AlinanUrunId = c.Int(nullable: false),
                        UrunId = c.Int(nullable: false),
                        UrunMiktari = c.Int(nullable: false),
                        KDVOrani = c.Int(),
                        IskontoOrani = c.Int(),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                        UrunAlmaIslemleri_Id = c.Int(),
                        Urunler_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.AlinanUrunId, t.UrunId })
                .ForeignKey("dbo.UrunAlmaIslemleris", t => t.UrunAlmaIslemleri_Id)
                .ForeignKey("dbo.Urunlers", t => t.Urunler_Id)
                .Index(t => t.UrunAlmaIslemleri_Id)
                .Index(t => t.Urunler_Id);
            
            CreateTable(
                "dbo.UrunAlmaIslemleris",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BelgeNo = c.Int(nullable: false),
                        AlinmaTarihi = c.DateTime(),
                        VadeTarihi = c.DateTime(),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                        MasrafKalemleri = c.String(),
                        Aciklama = c.String(),
                        FaturaAltiIskontoOrani = c.Int(nullable: false),
                        Taslakmi = c.Boolean(nullable: false),
                        BelgenImage = c.String(),
                        Iptal = c.Boolean(nullable: false),
                        IslemDurumu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TahsilatlarOdemelers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IslemTipi = c.Boolean(nullable: false),
                        DokumanKonum = c.String(),
                        Tutar = c.Int(nullable: false),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                        IslemTarihi = c.DateTime(),
                        FirmalarID = c.Int(nullable: false),
                        MusteriID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Firmalars", t => t.FirmalarID, cascadeDelete: false)
                .ForeignKey("dbo.MusteriVeTedarikcilers", t => t.MusteriID, cascadeDelete: false)
                .Index(t => t.FirmalarID)
                .Index(t => t.MusteriID);
            
            CreateTable(
                "dbo.Firmalars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirmaAdi = c.String(maxLength: 30, unicode: false),
                        KullaniciID = c.Int(nullable: false),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanicilars", t => t.KullaniciID, cascadeDelete: false)
                .Index(t => t.KullaniciID);
            
            CreateTable(
                "dbo.Calisanlars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                        Mail = c.String(),
                        Phone = c.Int(),
                        EmployeeImage = c.String(maxLength: 30, unicode: false),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                        ParaBirimi = c.Int(nullable: false),
                        IseGirisTarihi = c.DateTime(),
                        IstenAyrilisTarihi = c.DateTime(),
                        DogumTarihi = c.DateTime(),
                        TC = c.Int(),
                        NetMaas = c.Int(),
                        HesapNo = c.Int(),
                        Departman = c.String(maxLength: 20, unicode: false),
                        TicketNo = c.Int(),
                        Adres = c.String(maxLength: 30, unicode: false),
                        BankaBilgileri = c.String(maxLength: 30, unicode: false),
                        Not = c.String(maxLength: 50, unicode: false),
                        FirmaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Firmalars", t => t.FirmaId, cascadeDelete: false)
                .Index(t => t.FirmaId);
            
            CreateTable(
                "dbo.Depolars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                        FirmalarID = c.Int(nullable: false),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Firmalars", t => t.FirmalarID, cascadeDelete: false)
                .Index(t => t.FirmalarID);
            
            CreateTable(
                "dbo.Stoks",
                c => new
                    {
                        UrunId = c.Int(nullable: false),
                        DepoId = c.Int(nullable: false),
                        StokAdedi = c.Int(nullable: false),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                        IslemTarihi = c.DateTime(),
                        EkleCikar = c.Boolean(nullable: false),
                        Depolar_Id = c.Int(),
                        Urunler_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.UrunId, t.DepoId })
                .ForeignKey("dbo.Depolars", t => t.Depolar_Id)
                .ForeignKey("dbo.Urunlers", t => t.Urunler_Id)
                .Index(t => t.Depolar_Id)
                .Index(t => t.Urunler_Id);
            
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StokluUrun = c.Boolean(nullable: false),
                        SatisFiyatBirimi = c.Int(nullable: false),
                        SatisFiyat = c.Int(nullable: false),
                        SatisKDVOrani = c.Int(),
                        SatisFiyatinaKDVDahil = c.Boolean(),
                        IOVVar = c.Boolean(),
                        IOVOrani = c.Int(),
                        AlisFiyati = c.Int(),
                        AlisFiyatBirimi = c.Int(nullable: false),
                        AlisKDVOrani = c.Int(),
                        AlisFiyatinaKDVDahil = c.Boolean(),
                        AlisIskontoOrani = c.Int(),
                        UrunKodu = c.Int(),
                        UrunAciklama = c.String(maxLength: 50, unicode: false),
                        BarkodKodu = c.Int(),
                        StokTakibi = c.Boolean(nullable: false),
                        KritikStokMiktari = c.Int(),
                        UrunImage = c.String(maxLength: 40, unicode: false),
                        SatisIskontoOrani = c.Int(),
                        OlusturulmaTarihi = c.DateTime(),
                        PageCount = c.Int(nullable: false),
                        SatisAktif = c.Boolean(nullable: false),
                        FirmalarID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Firmalars", t => t.FirmalarID, cascadeDelete: false)
                .Index(t => t.FirmalarID);
            
            CreateTable(
                "dbo.Faturalars",
                c => new
                    {
                        UrunlerId = c.Int(nullable: false),
                        SatislarId = c.Int(nullable: false),
                        UrunAdedi = c.Int(nullable: false),
                        KDV = c.Int(nullable: false),
                        Iskonto = c.Int(nullable: false),
                        PageCount = c.Int(nullable: false),
                        FaturaKonumu = c.String(),
                        OlusturulmaTarihi = c.DateTime(),
                        FirmalarID = c.Int(nullable: false),
                        MusteriTedarikciID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UrunlerId, t.SatislarId })
                .ForeignKey("dbo.Firmalars", t => t.FirmalarID, cascadeDelete: false)
                .ForeignKey("dbo.MusteriVeTedarikcilers", t => t.MusteriTedarikciID, cascadeDelete: false)
                .ForeignKey("dbo.Satislars", t => t.SatislarId, cascadeDelete: false)
                .ForeignKey("dbo.Urunlers", t => t.UrunlerId, cascadeDelete: false)
                .Index(t => t.UrunlerId)
                .Index(t => t.SatislarId)
                .Index(t => t.FirmalarID)
                .Index(t => t.MusteriTedarikciID);
            
            CreateTable(
                "dbo.MusteriVeTedarikcilers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(maxLength: 30, unicode: false),
                        Email = c.String(maxLength: 30, unicode: false),
                        Telefon1 = c.Int(),
                        Telefon2 = c.Int(),
                        DigerErisimBilgileri = c.String(maxLength: 30, unicode: false),
                        YetkiliKisi = c.String(maxLength: 30, unicode: false),
                        MusteriAdresi = c.String(maxLength: 30, unicode: false),
                        VergiDairesi = c.String(maxLength: 30, unicode: false),
                        VergidenMuaf = c.Boolean(nullable: false),
                        BankaBilgileri = c.String(maxLength: 30, unicode: false),
                        ParaBirimi = c.Int(nullable: false),
                        AcikHesapRiskLimiti = c.Int(),
                        VadeGunuSayisi = c.Int(),
                        Iskonto = c.Int(),
                        GuncelBakiyesi = c.Int(nullable: false),
                        MuhasebeKodu = c.Int(),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                        Image = c.String(maxLength: 30, unicode: false),
                        VergiNo = c.Int(),
                        Not = c.String(maxLength: 50, unicode: false),
                        TedarikciOrMusteri = c.Int(nullable: false),
                        FirmalarID = c.Int(nullable: false),
                        OzelFiyatListesi_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Firmalars", t => t.FirmalarID, cascadeDelete: false)
                .ForeignKey("dbo.OzelFiyatListesis", t => t.OzelFiyatListesi_Id)
                .Index(t => t.FirmalarID)
                .Index(t => t.OzelFiyatListesi_Id);
            
            CreateTable(
                "dbo.OzelFiyatListesis",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Adi = c.String(),
                        OzelFiyat = c.Int(nullable: false),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                        MusteriVeTedarikciler_Id = c.Int(),
                        MusteriVeTedarikciler_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MusteriVeTedarikcilers", t => t.MusteriVeTedarikciler_Id)
                .ForeignKey("dbo.Urunlers", t => t.Id)
                .ForeignKey("dbo.MusteriVeTedarikcilers", t => t.MusteriVeTedarikciler_Id1)
                .Index(t => t.Id)
                .Index(t => t.MusteriVeTedarikciler_Id)
                .Index(t => t.MusteriVeTedarikciler_Id1);
            
            CreateTable(
                "dbo.Satislars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SatisTarihi = c.DateTime(),
                        Aciklama = c.String(),
                        ToplamTutar = c.Int(nullable: false),
                        FaturaAltiIskonto = c.Int(),
                        BelgeNo = c.Int(),
                        VadeTarihi = c.DateTime(),
                        IrsaliyeNo = c.Int(),
                        SiparisDurumu = c.Int(nullable: false),
                        ArsivBelgesi = c.String(),
                        Iptal = c.Boolean(),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                        GuncellemeTarihi = c.DateTime(),
                        FirmalarID = c.Int(nullable: false),
                        MusteriTedarikcilerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Firmalars", t => t.FirmalarID, cascadeDelete: false)
                .ForeignKey("dbo.MusteriVeTedarikcilers", t => t.MusteriTedarikcilerID, cascadeDelete: false)
                .Index(t => t.FirmalarID)
                .Index(t => t.MusteriTedarikcilerID);
            
            CreateTable(
                "dbo.Kategorilers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(maxLength: 30, unicode: false),
                        UrunId = c.Int(nullable: false),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Urunlers", t => t.UrunId, cascadeDelete: false)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.Uretims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UretimTarihi = c.DateTime(),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                        UretimAdedi = c.Int(nullable: false),
                        UretimAciklama = c.String(maxLength: 50, unicode: false),
                        Maliyet = c.Int(nullable: false),
                        FirmalarID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Firmalars", t => t.FirmalarID, cascadeDelete: false)
                .Index(t => t.FirmalarID);
            
            CreateTable(
                "dbo.UrunDokumanlaris",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(maxLength: 50, unicode: false),
                        DosyaKonumu = c.String(maxLength: 30, unicode: false),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                        UrunId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Urunlers", t => t.UrunId, cascadeDelete: false)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.Hesaplars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tanim = c.String(maxLength: 50, unicode: false),
                        ParaBirimi = c.Int(nullable: false),
                        HesapNo = c.Int(),
                        GuncelBakiye = c.Int(nullable: false),
                        HarcamaLimiti = c.Int(),
                        HesapTuru = c.Int(nullable: false),
                        FirmaId = c.Int(nullable: false),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                        Tarih = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Firmalars", t => t.FirmaId, cascadeDelete: false)
                .Index(t => t.FirmaId);
            
            CreateTable(
                "dbo.Kredilers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(maxLength: 30, unicode: false),
                        KalanTutar = c.Int(nullable: false),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                        IlkTaksit = c.DateTime(),
                        ParaBirimi = c.Int(nullable: false),
                        KalanTaksitSayisi = c.Int(),
                        OdemeTakvimi = c.Int(nullable: false),
                        Not = c.String(maxLength: 50, unicode: false),
                        HesapNumarasi = c.Int(),
                        FirmaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Firmalars", t => t.FirmaId, cascadeDelete: false)
                .Index(t => t.FirmaId);
            
            CreateTable(
                "dbo.Kullanicilars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(maxLength: 30, unicode: false),
                        Password = c.String(maxLength: 30, unicode: false),
                        Email = c.String(maxLength: 30, unicode: false),
                        Phone = c.Int(),
                        MailAktivasyon = c.Boolean(nullable: false),
                        Aktiflik = c.Boolean(nullable: false),
                        PaypalOdeme = c.Boolean(nullable: false),
                        Image = c.String(maxLength: 30, unicode: false),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Yetkilers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                        FaturaGirisi = c.Boolean(nullable: false),
                        FaturaIptali = c.Boolean(nullable: false),
                        TahsilatGirisi = c.Boolean(nullable: false),
                        TahsilatIptali = c.Boolean(nullable: false),
                        BorcAlacakFisleri = c.Boolean(nullable: false),
                        EskiTarihliKasaIslemi = c.Boolean(nullable: false),
                        KullaniciTanimlama = c.Boolean(nullable: false),
                        MusteriEkstreleri = c.Boolean(nullable: false),
                        MusteriKaydetme = c.Boolean(nullable: false),
                        MusteriSilme = c.Boolean(nullable: false),
                        UrunTanimlama = c.Boolean(nullable: false),
                        FiyatDegistirme = c.Boolean(nullable: false),
                        StokSayimi = c.Boolean(nullable: false),
                        Raporlar = c.Boolean(nullable: false),
                        KullaniciIslemFormu = c.Boolean(nullable: false),
                        DepoOlusturma = c.Boolean(nullable: false),
                        SatisGoruntuleme = c.Boolean(nullable: false),
                        MusteriGoruntuleme = c.Boolean(nullable: false),
                        MasrafGoruntuleme = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanicilars", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Masraflars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IslemTarihi = c.DateTime(),
                        Aciklama = c.String(maxLength: 50, unicode: false),
                        DokumanKonumu = c.String(maxLength: 30, unicode: false),
                        OdemeBilgisi = c.Boolean(nullable: false),
                        PageCount = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(),
                        OdemeTarihi = c.DateTime(),
                        Tutar = c.Int(nullable: false),
                        KDVOrani = c.Int(),
                        FirmaId = c.Int(nullable: false),
                        MasrafKalemi = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Firmalars", t => t.FirmaId, cascadeDelete: false)
                .Index(t => t.FirmaId);
            
            CreateTable(
                "dbo.UrunlerDepolars",
                c => new
                    {
                        Urunler_Id = c.Int(nullable: false),
                        Depolar_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Urunler_Id, t.Depolar_Id })
                .ForeignKey("dbo.Urunlers", t => t.Urunler_Id, cascadeDelete: false)
                .ForeignKey("dbo.Depolars", t => t.Depolar_Id, cascadeDelete: false)
                .Index(t => t.Urunler_Id)
                .Index(t => t.Depolar_Id);
            
            CreateTable(
                "dbo.SatislarTahsilatlarOdemelers",
                c => new
                    {
                        Satislar_Id = c.Int(nullable: false),
                        TahsilatlarOdemeler_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Satislar_Id, t.TahsilatlarOdemeler_Id })
                .ForeignKey("dbo.Satislars", t => t.Satislar_Id, cascadeDelete: false)
                .ForeignKey("dbo.TahsilatlarOdemelers", t => t.TahsilatlarOdemeler_Id, cascadeDelete: false)
                .Index(t => t.Satislar_Id)
                .Index(t => t.TahsilatlarOdemeler_Id);
            
            CreateTable(
                "dbo.SatislarUrunlers",
                c => new
                    {
                        Satislar_Id = c.Int(nullable: false),
                        Urunler_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Satislar_Id, t.Urunler_Id })
                .ForeignKey("dbo.Satislars", t => t.Satislar_Id, cascadeDelete: false)
                .ForeignKey("dbo.Urunlers", t => t.Urunler_Id, cascadeDelete: false)
                .Index(t => t.Satislar_Id)
                .Index(t => t.Urunler_Id);
            
            CreateTable(
                "dbo.MusteriVeTedarikcilerUrunlers",
                c => new
                    {
                        MusteriVeTedarikciler_Id = c.Int(nullable: false),
                        Urunler_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MusteriVeTedarikciler_Id, t.Urunler_Id })
                .ForeignKey("dbo.MusteriVeTedarikcilers", t => t.MusteriVeTedarikciler_Id, cascadeDelete: false)
                .ForeignKey("dbo.Urunlers", t => t.Urunler_Id, cascadeDelete: false)
                .Index(t => t.MusteriVeTedarikciler_Id)
                .Index(t => t.Urunler_Id);
            
            CreateTable(
                "dbo.UretimUrunlers",
                c => new
                    {
                        Uretim_Id = c.Int(nullable: false),
                        Urunler_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Uretim_Id, t.Urunler_Id })
                .ForeignKey("dbo.Uretims", t => t.Uretim_Id, cascadeDelete: false)
                .ForeignKey("dbo.Urunlers", t => t.Urunler_Id, cascadeDelete: false)
                .Index(t => t.Uretim_Id)
                .Index(t => t.Urunler_Id);
            
            CreateTable(
                "dbo.HesaplarTahsilatlarOdemelers",
                c => new
                    {
                        Hesaplar_Id = c.Int(nullable: false),
                        TahsilatlarOdemeler_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Hesaplar_Id, t.TahsilatlarOdemeler_Id })
                .ForeignKey("dbo.Hesaplars", t => t.Hesaplar_Id, cascadeDelete: false)
                .ForeignKey("dbo.TahsilatlarOdemelers", t => t.TahsilatlarOdemeler_Id, cascadeDelete: false)
                .Index(t => t.Hesaplar_Id)
                .Index(t => t.TahsilatlarOdemeler_Id);
            
            CreateTable(
                "dbo.KredilerTahsilatlarOdemelers",
                c => new
                    {
                        Krediler_Id = c.Int(nullable: false),
                        TahsilatlarOdemeler_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Krediler_Id, t.TahsilatlarOdemeler_Id })
                .ForeignKey("dbo.Kredilers", t => t.Krediler_Id, cascadeDelete: false)
                .ForeignKey("dbo.TahsilatlarOdemelers", t => t.TahsilatlarOdemeler_Id, cascadeDelete: false)
                .Index(t => t.Krediler_Id)
                .Index(t => t.TahsilatlarOdemeler_Id);
            
            CreateTable(
                "dbo.MasraflarTahsilatlarOdemelers",
                c => new
                    {
                        Masraflar_Id = c.Int(nullable: false),
                        TahsilatlarOdemeler_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Masraflar_Id, t.TahsilatlarOdemeler_Id })
                .ForeignKey("dbo.Masraflars", t => t.Masraflar_Id, cascadeDelete: false)
                .ForeignKey("dbo.TahsilatlarOdemelers", t => t.TahsilatlarOdemeler_Id, cascadeDelete: false)
                .Index(t => t.Masraflar_Id)
                .Index(t => t.TahsilatlarOdemeler_Id);
            
            CreateTable(
                "dbo.TahsilatlarOdemelerUrunAlmaIslemleris",
                c => new
                    {
                        TahsilatlarOdemeler_Id = c.Int(nullable: false),
                        UrunAlmaIslemleri_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TahsilatlarOdemeler_Id, t.UrunAlmaIslemleri_Id })
                .ForeignKey("dbo.TahsilatlarOdemelers", t => t.TahsilatlarOdemeler_Id, cascadeDelete: false)
                .ForeignKey("dbo.UrunAlmaIslemleris", t => t.UrunAlmaIslemleri_Id, cascadeDelete: false)
                .Index(t => t.TahsilatlarOdemeler_Id)
                .Index(t => t.UrunAlmaIslemleri_Id);
            
            DropTable("dbo.Hizmets");
            DropTable("dbo.Kullanicis");
            DropTable("dbo.Misafirs");
            DropTable("dbo.Rezervasyons");
            DropTable("dbo.KullaniciHizmets");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.KullaniciHizmets",
                c => new
                    {
                        Kullanici_Id = c.Int(nullable: false),
                        Hizmet_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Kullanici_Id, t.Hizmet_Id });
            
            CreateTable(
                "dbo.Rezervasyons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        HizmetId = c.Int(nullable: false),
                        RezervasyonNo = c.Int(nullable: false),
                        KisiSayisi = c.Int(nullable: false),
                        Durum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Misafirs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RezervasyonId = c.Int(nullable: false),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        Cinsiyet = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        Email = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hizmets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HizmetTuru = c.Int(nullable: false),
                        Adi = c.String(),
                        Tarih = c.DateTime(nullable: false),
                        Fiyat = c.Int(nullable: false),
                        KisiSayisi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.TahsilatlarOdemelerUrunAlmaIslemleris", "UrunAlmaIslemleri_Id", "dbo.UrunAlmaIslemleris");
            DropForeignKey("dbo.TahsilatlarOdemelerUrunAlmaIslemleris", "TahsilatlarOdemeler_Id", "dbo.TahsilatlarOdemelers");
            DropForeignKey("dbo.TahsilatlarOdemelers", "MusteriID", "dbo.MusteriVeTedarikcilers");
            DropForeignKey("dbo.TahsilatlarOdemelers", "FirmalarID", "dbo.Firmalars");
            DropForeignKey("dbo.MasraflarTahsilatlarOdemelers", "TahsilatlarOdemeler_Id", "dbo.TahsilatlarOdemelers");
            DropForeignKey("dbo.MasraflarTahsilatlarOdemelers", "Masraflar_Id", "dbo.Masraflars");
            DropForeignKey("dbo.Masraflars", "FirmaId", "dbo.Firmalars");
            DropForeignKey("dbo.Firmalars", "KullaniciID", "dbo.Kullanicilars");
            DropForeignKey("dbo.Yetkilers", "Id", "dbo.Kullanicilars");
            DropForeignKey("dbo.KredilerTahsilatlarOdemelers", "TahsilatlarOdemeler_Id", "dbo.TahsilatlarOdemelers");
            DropForeignKey("dbo.KredilerTahsilatlarOdemelers", "Krediler_Id", "dbo.Kredilers");
            DropForeignKey("dbo.Kredilers", "FirmaId", "dbo.Firmalars");
            DropForeignKey("dbo.HesaplarTahsilatlarOdemelers", "TahsilatlarOdemeler_Id", "dbo.TahsilatlarOdemelers");
            DropForeignKey("dbo.HesaplarTahsilatlarOdemelers", "Hesaplar_Id", "dbo.Hesaplars");
            DropForeignKey("dbo.Hesaplars", "FirmaId", "dbo.Firmalars");
            DropForeignKey("dbo.UrunDokumanlaris", "UrunId", "dbo.Urunlers");
            DropForeignKey("dbo.UretimUrunlers", "Urunler_Id", "dbo.Urunlers");
            DropForeignKey("dbo.UretimUrunlers", "Uretim_Id", "dbo.Uretims");
            DropForeignKey("dbo.Uretims", "FirmalarID", "dbo.Firmalars");
            DropForeignKey("dbo.Stoks", "Urunler_Id", "dbo.Urunlers");
            DropForeignKey("dbo.Kategorilers", "UrunId", "dbo.Urunlers");
            DropForeignKey("dbo.Urunlers", "FirmalarID", "dbo.Firmalars");
            DropForeignKey("dbo.Faturalars", "UrunlerId", "dbo.Urunlers");
            DropForeignKey("dbo.Faturalars", "SatislarId", "dbo.Satislars");
            DropForeignKey("dbo.Faturalars", "MusteriTedarikciID", "dbo.MusteriVeTedarikcilers");
            DropForeignKey("dbo.MusteriVeTedarikcilerUrunlers", "Urunler_Id", "dbo.Urunlers");
            DropForeignKey("dbo.MusteriVeTedarikcilerUrunlers", "MusteriVeTedarikciler_Id", "dbo.MusteriVeTedarikcilers");
            DropForeignKey("dbo.SatislarUrunlers", "Urunler_Id", "dbo.Urunlers");
            DropForeignKey("dbo.SatislarUrunlers", "Satislar_Id", "dbo.Satislars");
            DropForeignKey("dbo.SatislarTahsilatlarOdemelers", "TahsilatlarOdemeler_Id", "dbo.TahsilatlarOdemelers");
            DropForeignKey("dbo.SatislarTahsilatlarOdemelers", "Satislar_Id", "dbo.Satislars");
            DropForeignKey("dbo.Satislars", "MusteriTedarikcilerID", "dbo.MusteriVeTedarikcilers");
            DropForeignKey("dbo.Satislars", "FirmalarID", "dbo.Firmalars");
            DropForeignKey("dbo.OzelFiyatListesis", "MusteriVeTedarikciler_Id1", "dbo.MusteriVeTedarikcilers");
            DropForeignKey("dbo.OzelFiyatListesis", "Id", "dbo.Urunlers");
            DropForeignKey("dbo.MusteriVeTedarikcilers", "OzelFiyatListesi_Id", "dbo.OzelFiyatListesis");
            DropForeignKey("dbo.OzelFiyatListesis", "MusteriVeTedarikciler_Id", "dbo.MusteriVeTedarikcilers");
            DropForeignKey("dbo.MusteriVeTedarikcilers", "FirmalarID", "dbo.Firmalars");
            DropForeignKey("dbo.Faturalars", "FirmalarID", "dbo.Firmalars");
            DropForeignKey("dbo.UrunlerDepolars", "Depolar_Id", "dbo.Depolars");
            DropForeignKey("dbo.UrunlerDepolars", "Urunler_Id", "dbo.Urunlers");
            DropForeignKey("dbo.AlinanUrunlers", "Urunler_Id", "dbo.Urunlers");
            DropForeignKey("dbo.Stoks", "Depolar_Id", "dbo.Depolars");
            DropForeignKey("dbo.Depolars", "FirmalarID", "dbo.Firmalars");
            DropForeignKey("dbo.Calisanlars", "FirmaId", "dbo.Firmalars");
            DropForeignKey("dbo.AlinanUrunlers", "UrunAlmaIslemleri_Id", "dbo.UrunAlmaIslemleris");
            DropIndex("dbo.TahsilatlarOdemelerUrunAlmaIslemleris", new[] { "UrunAlmaIslemleri_Id" });
            DropIndex("dbo.TahsilatlarOdemelerUrunAlmaIslemleris", new[] { "TahsilatlarOdemeler_Id" });
            DropIndex("dbo.MasraflarTahsilatlarOdemelers", new[] { "TahsilatlarOdemeler_Id" });
            DropIndex("dbo.MasraflarTahsilatlarOdemelers", new[] { "Masraflar_Id" });
            DropIndex("dbo.KredilerTahsilatlarOdemelers", new[] { "TahsilatlarOdemeler_Id" });
            DropIndex("dbo.KredilerTahsilatlarOdemelers", new[] { "Krediler_Id" });
            DropIndex("dbo.HesaplarTahsilatlarOdemelers", new[] { "TahsilatlarOdemeler_Id" });
            DropIndex("dbo.HesaplarTahsilatlarOdemelers", new[] { "Hesaplar_Id" });
            DropIndex("dbo.UretimUrunlers", new[] { "Urunler_Id" });
            DropIndex("dbo.UretimUrunlers", new[] { "Uretim_Id" });
            DropIndex("dbo.MusteriVeTedarikcilerUrunlers", new[] { "Urunler_Id" });
            DropIndex("dbo.MusteriVeTedarikcilerUrunlers", new[] { "MusteriVeTedarikciler_Id" });
            DropIndex("dbo.SatislarUrunlers", new[] { "Urunler_Id" });
            DropIndex("dbo.SatislarUrunlers", new[] { "Satislar_Id" });
            DropIndex("dbo.SatislarTahsilatlarOdemelers", new[] { "TahsilatlarOdemeler_Id" });
            DropIndex("dbo.SatislarTahsilatlarOdemelers", new[] { "Satislar_Id" });
            DropIndex("dbo.UrunlerDepolars", new[] { "Depolar_Id" });
            DropIndex("dbo.UrunlerDepolars", new[] { "Urunler_Id" });
            DropIndex("dbo.Masraflars", new[] { "FirmaId" });
            DropIndex("dbo.Yetkilers", new[] { "Id" });
            DropIndex("dbo.Kredilers", new[] { "FirmaId" });
            DropIndex("dbo.Hesaplars", new[] { "FirmaId" });
            DropIndex("dbo.UrunDokumanlaris", new[] { "UrunId" });
            DropIndex("dbo.Uretims", new[] { "FirmalarID" });
            DropIndex("dbo.Kategorilers", new[] { "UrunId" });
            DropIndex("dbo.Satislars", new[] { "MusteriTedarikcilerID" });
            DropIndex("dbo.Satislars", new[] { "FirmalarID" });
            DropIndex("dbo.OzelFiyatListesis", new[] { "MusteriVeTedarikciler_Id1" });
            DropIndex("dbo.OzelFiyatListesis", new[] { "MusteriVeTedarikciler_Id" });
            DropIndex("dbo.OzelFiyatListesis", new[] { "Id" });
            DropIndex("dbo.MusteriVeTedarikcilers", new[] { "OzelFiyatListesi_Id" });
            DropIndex("dbo.MusteriVeTedarikcilers", new[] { "FirmalarID" });
            DropIndex("dbo.Faturalars", new[] { "MusteriTedarikciID" });
            DropIndex("dbo.Faturalars", new[] { "FirmalarID" });
            DropIndex("dbo.Faturalars", new[] { "SatislarId" });
            DropIndex("dbo.Faturalars", new[] { "UrunlerId" });
            DropIndex("dbo.Urunlers", new[] { "FirmalarID" });
            DropIndex("dbo.Stoks", new[] { "Urunler_Id" });
            DropIndex("dbo.Stoks", new[] { "Depolar_Id" });
            DropIndex("dbo.Depolars", new[] { "FirmalarID" });
            DropIndex("dbo.Calisanlars", new[] { "FirmaId" });
            DropIndex("dbo.Firmalars", new[] { "KullaniciID" });
            DropIndex("dbo.TahsilatlarOdemelers", new[] { "MusteriID" });
            DropIndex("dbo.TahsilatlarOdemelers", new[] { "FirmalarID" });
            DropIndex("dbo.AlinanUrunlers", new[] { "Urunler_Id" });
            DropIndex("dbo.AlinanUrunlers", new[] { "UrunAlmaIslemleri_Id" });
            DropTable("dbo.TahsilatlarOdemelerUrunAlmaIslemleris");
            DropTable("dbo.MasraflarTahsilatlarOdemelers");
            DropTable("dbo.KredilerTahsilatlarOdemelers");
            DropTable("dbo.HesaplarTahsilatlarOdemelers");
            DropTable("dbo.UretimUrunlers");
            DropTable("dbo.MusteriVeTedarikcilerUrunlers");
            DropTable("dbo.SatislarUrunlers");
            DropTable("dbo.SatislarTahsilatlarOdemelers");
            DropTable("dbo.UrunlerDepolars");
            DropTable("dbo.Masraflars");
            DropTable("dbo.Yetkilers");
            DropTable("dbo.Kullanicilars");
            DropTable("dbo.Kredilers");
            DropTable("dbo.Hesaplars");
            DropTable("dbo.UrunDokumanlaris");
            DropTable("dbo.Uretims");
            DropTable("dbo.Kategorilers");
            DropTable("dbo.Satislars");
            DropTable("dbo.OzelFiyatListesis");
            DropTable("dbo.MusteriVeTedarikcilers");
            DropTable("dbo.Faturalars");
            DropTable("dbo.Urunlers");
            DropTable("dbo.Stoks");
            DropTable("dbo.Depolars");
            DropTable("dbo.Calisanlars");
            DropTable("dbo.Firmalars");
            DropTable("dbo.TahsilatlarOdemelers");
            DropTable("dbo.UrunAlmaIslemleris");
            DropTable("dbo.AlinanUrunlers");
            CreateIndex("dbo.KullaniciHizmets", "Hizmet_Id");
            CreateIndex("dbo.KullaniciHizmets", "Kullanici_Id");
            CreateIndex("dbo.Rezervasyons", "HizmetId");
            CreateIndex("dbo.Rezervasyons", "KullaniciId");
            CreateIndex("dbo.Misafirs", "RezervasyonId");
            AddForeignKey("dbo.Misafirs", "RezervasyonId", "dbo.Rezervasyons", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Rezervasyons", "KullaniciId", "dbo.Kullanicis", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Rezervasyons", "HizmetId", "dbo.Hizmets", "Id", cascadeDelete: false);
            AddForeignKey("dbo.KullaniciHizmets", "Hizmet_Id", "dbo.Hizmets", "Id", cascadeDelete: false);
            AddForeignKey("dbo.KullaniciHizmets", "Kullanici_Id", "dbo.Kullanicis", "Id", cascadeDelete: false);
        }
    }
}
