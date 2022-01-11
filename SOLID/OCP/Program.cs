using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Open-Closed Principle:
             * Bir sınıf gelişime AÇIK -> değişime KAPALI olmaıdır!
             * 
             * Bir nesneye yeni bir özellik kazandırmak istediğinizde (davranış değiştirmek vs) değişiklik yapmak yerine bu nesneyi geliştirmelisiniz.
             */
            Console.WriteLine("Hello World!");

            Musteri musteri = new Musteri();
            musteri.ToplamCalisilanYil = 5;
            musteri.MusteriDurumu = new GoldMusteri();

            IndirimYoneticisi indirimYoneticisi = new IndirimYoneticisi();
            indirimYoneticisi.Musteri = musteri;
            var tutar = indirimYoneticisi.IndirimUygula(1000);
            Console.WriteLine(tutar);
        }
    }
}
