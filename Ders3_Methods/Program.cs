﻿using System;

namespace Ders3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 20;

            Product urun2 = new Product();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 25;

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("------------");




            }

            Console.WriteLine("-------Metotlar---------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Elma","Yeşil elma", 12,32);
            sepetManager.Ekle2("Armut", "Yeşil armut", 12,15);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);



        }
    }
}
