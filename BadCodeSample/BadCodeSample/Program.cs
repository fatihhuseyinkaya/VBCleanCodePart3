using System;

namespace BadCodeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            var sonuc = class1.Hesapla(1000, 4, 5);
            Console.WriteLine(sonuc);
            Console.ReadLine();

            IndirimYoneticisi indirimYoneticisi = new IndirimYoneticisi();
            var tutar = indirimYoneticisi.IndirimUygula(1000, MusteriDurumu.GoldMusteri, 5);
            Console.WriteLine(tutar);
            Console.ReadLine();
        }
    }
}
