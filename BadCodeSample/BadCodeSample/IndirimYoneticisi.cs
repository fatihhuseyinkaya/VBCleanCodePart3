using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCodeSample
{
    public class IndirimYoneticisi
    {
        private const int maksimumCalismaYili = 5;
        public decimal IndirimUygula(decimal toplamFiyat, MusteriDurumu musteriDurumu, int toplamCalismaYili)
        {
            decimal indirimliTutar = 0;
            decimal ekstraYilIndirimi = toplamCalismaYili > maksimumCalismaYili ? maksimumCalismaYili / 100 : toplamCalismaYili / 100;

            switch (musteriDurumu)
            {
                case MusteriDurumu.KayitliDegil:
                    indirimliTutar = toplamFiyat;
                    break;
                case MusteriDurumu.StandartMusteri:
                    indirimliTutar = indirimliTutarHesapla(toplamFiyat, ekstraYilIndirimi, 0.1M);
                    break;
                case MusteriDurumu.SilverMusteri:
                    indirimliTutar = indirimliTutarHesapla(toplamFiyat, ekstraYilIndirimi, 0.3M);
                    break;
                case MusteriDurumu.GoldMusteri:
                    indirimliTutar = indirimliTutarHesapla(toplamFiyat, ekstraYilIndirimi, 0.5M);
                    break;
                default:
                    break;
            }

            return indirimliTutar;
        }

        static decimal indirimliTutarHesapla(decimal fiyat, decimal ekstaIndirimOrani, decimal indirimOrani)
        {
            decimal indirimliFiyat = fiyat - (fiyat * indirimOrani);
            indirimliFiyat = indirimliFiyat - (ekstaIndirimOrani * indirimliFiyat);
            return indirimliFiyat;
        }
    }

    public enum MusteriDurumu
    {
        KayitliDegil,
        StandartMusteri,
        SilverMusteri,
        GoldMusteri

    }
}
