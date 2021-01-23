using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            
            
            string adi = "Ayşu";
            int yas = 25;

            Kurs Kurs1 = new Kurs();
            Kurs1.KursAdi = "C#";
            Kurs1.Egitmen = "Engin";
            Kurs1.İzlenmeOrani = 68;

            Kurs Kurs2 = new Kurs();
            Kurs2.KursAdi = "Java";
            Kurs2.Egitmen = "Kerem";
            Kurs2.İzlenmeOrani = 64;

            Kurs Kurs3 = new Kurs();
            Kurs3.KursAdi = "Python";
            Kurs3.Egitmen = "Berkay";
            Kurs3.İzlenmeOrani = 80;

            Kurs Kurs4 = new Kurs();
            Kurs4.KursAdi = "C++";
            Kurs4.Egitmen = "Murat";
            Kurs4.İzlenmeOrani = 100;

            //Console.WriteLine(Kurs1.KursAdi + " " + Kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {Kurs1, Kurs2, Kurs3, Kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine (kurs.KursAdi + ": " + kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }


 









}
