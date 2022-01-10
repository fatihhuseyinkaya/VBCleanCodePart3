using System;
using System.Collections.Generic;

namespace Naming
{
    class Program
    {
        static void Main(string[] args)
        {
            int kullaniciOlustugundanBeriGecenGun = 0;

            bool banuAlkan = false;
            int healthPoint = 100;
            string longFormat = "";//10.01.2022
                                  
            //burası bazen hata veriyor neden bilmem 

            
            

        }
        private static List<int[]> hucreler;
        private static List<int[]> isaretliHucreleriGetir()
        {
            List<int[]> isaretliHucreler = new List<int[]>();
            foreach (var hucre in hucreler)
            {
                if (hucre[0] == (int)HucreDurumu.Isaretli)
                {
                    isaretliHucreler.Add(hucre);
                }
            }
            return isaretliHucreler;
        }

    }

    public enum HucreDurumu
    {
        Bos=1,
        Isaretli=3
    }
}
