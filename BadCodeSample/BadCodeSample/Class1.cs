using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCodeSample
{
   public class Class1
    {
        public decimal Hesapla(decimal fiyat, int tip, int yil)
        {
        
            decimal sonuc = 0;
            decimal ind = yil > 5 ? 5 / 100 : yil / 100;
            if (tip==1)
            {
                sonuc = fiyat;
            }
            else if (tip == 2)
            {
                sonuc = fiyat * 0.9M - ind * (fiyat * 0.9M); 
            }
            else if (tip ==3 )
            {
                sonuc = fiyat * 0.7M - ind * (fiyat * 0.7M);
            }
            else if (tip ==4)
            {
                sonuc = fiyat * 0.5M - ind * (fiyat * 0.5M);
            }
            return sonuc;
        }
    }
}
