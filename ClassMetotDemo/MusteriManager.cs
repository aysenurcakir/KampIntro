using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("ID: " + musteri.Id);
            Console.WriteLine("Adı: " + musteri.Adi);
            Console.WriteLine("Soyadı: " + musteri.Soyadi);
            Console.WriteLine("-------------");
        }

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " eklendi.");
            Console.WriteLine("-------------");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " silindi.");
            Console.WriteLine("-------------");
        }
    }

}
