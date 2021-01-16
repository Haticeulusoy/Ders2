using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3_Methods
{
    class SepetManager
    {   //naming convention
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);

        }
        public void Ekle2(string urunAdi, string Aciklamasi,int fiyat,int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);

        }
    }
}
