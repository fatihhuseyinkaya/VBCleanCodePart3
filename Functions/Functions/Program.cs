using System;
using System.Collections.Generic;
using System.Linq;

namespace Functions
{
    class Program
    {

        static string[] epostalar = { "abc@gmail.com", "turkay.urkmez@dinamikzihin.com", "turkay.urkmez@outlook.com", "kirikkalp81@yahoo.com", "abc@sahibinden.com" };
        static void Main(string[] args)
        {

            string[] sirketMailAdresleri = mailleriFitrele(epostalar);
            ekrandaGoster(sirketMailAdresleri);

            //1. epostalar içinde dön
            //2. @ işaretine göre ayır
            //3. domain'ler public değilse liste oluştur.
        }

        private static void ekrandaGoster(string[] sirketMailAdresleri)
        {
            //foreach (var mail in sirketMailAdresleri)
            //{
            //    Console.WriteLine(mail);
            //}

            sirketMailAdresleri.ToList().ForEach(mail => Console.WriteLine(mail));
        }

        private static string[] mailleriFitrele(string[] epostalar)
        {
            List<string> filtrelenmis = new List<string>();
            foreach (var eposta in epostalar)
            {
                listeyeEkle(filtrelenmis, eposta);
            }
            return filtrelenmis.ToArray();
        }

        private static void listeyeEkle(List<string> filtrelenmis, string eposta)
        {
            string[] genelDomainler = { "gmail", "outlook", "yahoo", "mynet", "hotmail" };
            if (!domainIceriyorMu(eposta, genelDomainler))
            {
                filtrelenmis.Add(eposta);
            }
        }

        private static bool domainIceriyorMu(string eposta, string[] genelDomainler)
        {

            //foreach (string domain in genelDomainler)
            //{
            //    
            //    if (epostaDomain.Contains(domain))
            //    {
            //        iceriyorMu = true;
            //        break;
            //    }

            //}
            string epostaDomain = eposta.Split('@')[1];
            var sonuc = genelDomainler.ToList().Any(publicDomain => epostaDomain.Contains(publicDomain));
            return sonuc;

        }

        static void urunEkle(Urun urun)
        {

        }

        static bool sayiCiftMi(int sayi)
        {
            return sayi % 2 == 0;
        }
    }
}
