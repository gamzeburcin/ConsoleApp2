using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Gamze";
            int yas = 24;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Gamze Aydın";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 80;

            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[]{ //dizi oluşturdu
      kurs1, kurs2, kurs3, kurs4
    };
            foreach (Kurs kurs in kurslar)
            { //dizi için döngü
                Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen);

            }




            Console.WriteLine("Hello World");
        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }
    }
    }

