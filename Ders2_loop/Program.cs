using System;

namespace Ders2_loop
{
    class Program
    {
        static void Main(string[] args)
        { /*
            string kurs1 = "Yzılım Geliştirici yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç";
            string kurs3 = "Java";
         */
            // array - dizi

            string[] kurslar = new string[] { "Yzılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç Kursu", "Java" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
