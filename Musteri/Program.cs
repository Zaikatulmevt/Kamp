using System;

namespace Musteri
{
    class Musteri
    {
        public string Id { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
    }
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + musteri.MusteriSoyadi + "isimli müşteri eklendi");
        }

        public void sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + musteri.MusteriSoyadi + "isimli müşteri silindi");
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "1";
            musteri1.MusteriAdi = "Yalçın";
            musteri1.MusteriSoyadi = "Kaya";


            Musteri musteri2 = new Musteri();
            musteri2.Id = "2";
            musteri2.MusteriAdi = "Kudret";
            musteri2.MusteriSoyadi = "Yılmaz";


            Musteri musteri3 = new Musteri();
            musteri3.Id = "3";
            musteri3.MusteriAdi = "Kudret";
            musteri3.MusteriSoyadi = "Yılmaz";


            Musteri musteri4 = new Musteri();
            musteri4.Id = "4";
            musteri4.MusteriAdi = "Kudret";
            musteri4.MusteriSoyadi = "Yılmaz";


            Musteri[] musteris = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteri in musteris)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Musteri Id:  " + musteri.Id);
                Console.WriteLine("Musteri Adi: " + musteri.MusteriAdi);
                Console.WriteLine("Müşteri Soyad:   " + musteri.MusteriSoyadi);
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine("-----------------------");

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri2);

            musteriManager.sil(musteri3);




        }
    }
}
