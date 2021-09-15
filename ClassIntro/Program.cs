using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Mustafa Yazici";
            kurs1.KursAdi = "c#";
            kurs1.IzlenmeOrani = 65;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Mahmut Yazici";
            kurs2.KursAdi = "c++";
            kurs2.IzlenmeOrani = 68;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Muhammet Yazici";
            kurs3.KursAdi = "c";
            kurs3.IzlenmeOrani = 64;

            Kurs kurs4 = new Kurs();
            kurs4.Egitmen = "İsa Yazici";
            kurs4.KursAdi = "Python";
            kurs4.IzlenmeOrani = 20;

            

            //Console.WriteLine(kurs1.Egitmen +" : "+kurs1.KursAdi);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
               // Console.WriteLine(kurs.KursAdi);

                Console.WriteLine(kurs.Egitmen + " : " + kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
