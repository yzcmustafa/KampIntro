using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştici Yetiştirme Kursu";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";


            string[] kurslar = new string[] { "Yazılım Geliştici Yetiştirme Kursu",
                "Programlamaya Başlangıç İçin Temel Kurs", 
                "java", "Pyhton" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Sonu");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");

        }
    }
}
