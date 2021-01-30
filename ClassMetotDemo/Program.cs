using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123456;
            musteri1.Adi = "Ayşe Nur";
            musteri1.Soyadi = "Çakır";
            
            Musteri musteri2 = new Musteri();
            musteri2.Id = 654321;
            musteri2.Adi = "Mehmet Fatih";
            musteri2.Soyadi = "Çakır";
            
            Musteri musteri3 = new Musteri();
            musteri3.Id = 1111;
            musteri3.Adi = "Ömer Şamil";
            musteri3.Soyadi = "Çakır";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 2222;
            musteri4.Adi = "Ayşe Hümeyra";
            musteri4.Soyadi = "Çakır";

            Musteri[] Musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager musteriManager = new MusteriManager();
           
            foreach (Musteri musteri in Musteriler)
            {
                musteriManager.MusteriListele(musteri);
                musteriManager.MusteriEkle(musteri);
                musteriManager.MusteriSil(musteri);
            }






        }
    }
}
