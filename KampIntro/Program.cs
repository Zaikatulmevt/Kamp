using System;

namespace KampIntro
{
    class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double fiyati { get; set; }
        public string Aciklama { get; set; }
        public int stokAdedi { get; set; }

    }


    class SepetManager
    {
        public void Ekle(Urun urun)
        {

            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");

            }





            Console.WriteLine("-----Metotlar------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("karpuz", "Diyarbakır karpuzu", 12, 8);











        }
    }
}
