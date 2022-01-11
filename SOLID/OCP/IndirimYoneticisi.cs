using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{

    public class Musteri
    {
        public string Ad { get; set; }
        public MusteriDurumu MusteriDurumu { get; set; }
        public int ToplamCalisilanYil { get; set; }

        private const int maksimumCalismaYili = 5;
        public decimal EkstraSadakatIndirimi
        {
            get { return ToplamCalisilanYil > maksimumCalismaYili ? (decimal)maksimumCalismaYili / 100 : (decimal)ToplamCalisilanYil / 100; }
        }
    }
    public class IndirimYoneticisi
    {
        private const int maksimumCalismaYili = 5;
        public Musteri Musteri { get; set; }
        public decimal IndirimUygula(decimal toplamFiyat)
        {
           // decimal indirimliTutar = 0;
           

            var durumaGoreIndirim = Musteri.MusteriDurumu.IndirimHesapla(toplamFiyat);
            var calisilanYilagore = durumaGoreIndirim * (1 - Musteri.EkstraSadakatIndirimi);
            return calisilanYilagore;
            //switch (Musteri.MusteriDurumu)
            //{
            //    case MusteriDurumu.KayitliDegil:
            //        indirimliTutar = toplamFiyat;
            //        break;
            //    case MusteriDurumu.StandartMusteri:
            //        indirimliTutar = indirimliTutarHesapla(toplamFiyat, ekstraYilIndirimi, 0.1M);
            //        break;
            //    case MusteriDurumu.SilverMusteri:
            //        indirimliTutar = indirimliTutarHesapla(toplamFiyat, ekstraYilIndirimi, 0.3M);
            //        break;
            //    case MusteriDurumu.GoldMusteri:
            //        indirimliTutar = indirimliTutarHesapla(toplamFiyat, ekstraYilIndirimi, 0.5M);
            //        break;
            //    case MusteriDurumu.PremiumMusteri:
            //        break;
            //    default:
            //        break;
            //}

            //return indirimliTutar;
        }

        static decimal indirimliTutarHesapla(decimal fiyat, decimal ekstaIndirimOrani, decimal indirimOrani)
        {
            decimal indirimliFiyat = fiyat - (fiyat * indirimOrani);
            indirimliFiyat = indirimliFiyat - (ekstaIndirimOrani * indirimliFiyat);
            return indirimliFiyat;
        }
    }

    //public enum MusteriDurumu
    //{
    //    KayitliDegil,
    //    StandartMusteri,
    //    SilverMusteri,
    //    GoldMusteri,
    //    PremiumMusteri

    //}

    public abstract class MusteriDurumu
    {
        public abstract decimal IndirimHesapla(decimal tutar);
      
    }
    public class StandartMusteri : MusteriDurumu
    {
        public override decimal IndirimHesapla(decimal tutar)
        {
            return tutar * 0.9M;
        }
    }

    public class SilverMusteri : MusteriDurumu
    {
        public override decimal IndirimHesapla(decimal tutar)
        {
            return tutar * 0.85M;
        }
    }

    public class GoldMusteri : MusteriDurumu
    {
        public override decimal IndirimHesapla(decimal tutar)
        {
            return tutar * 0.80M;
        }
    }

    //public class PremiumMusteri : MusteriDurumu
    //{
    //    public override decimal IndirimHesapla(decimal tutar)
    //    {
    //        return tutar * 0.50M;
    //    }
    //}
}
