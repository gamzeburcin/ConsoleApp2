using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gamze Aydın
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Gamze";
            musteri1.Soyadi = "Aydın";
            musteri1.TcNo = "11111111111";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";
            //Gerçek Müşteri  -  Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Console.WriteLine(musteri1.Adi+ "  " + musteri1.MusteriNo+"  " + musteri1.Soyadi+"  " + musteri1.TcNo);
        }
    }
}
