using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Aciklama = "amasya elması";
            urun1.Fiyati = 15;

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Aciklama = "diyarbakır karpuzu";
            urun2.Fiyati = 80;

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("---------Metotlar-------------");

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("armut" , "yeşil armut" , 12 , 6);
            sepetmanager.Ekle2("elma", "yeşil elma", 11 , 5);
            sepetmanager.Ekle2("karpuz", "diyarbakır karpuzu", 10 , 3);

        }
    }
}
