using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class BasvuruManager
    {   //*******************DEPENDENCE INJECTION*************************  //loggerService İNJECİON işlemi yptık
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)   //buradaki method hem taşıt hem konut hemde ihtiyaç kredisini hesaplar hepsi için geçerli.
        {
            //Başvuran bilgilerini değerlendirme
            //
            //ÇOK ÖNEMLİ BÜTÜN DESİGN PATTERN'LAR BUNUN ÜZERİNE KURULUDUR
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)  //Birden fazla krediyi hesaplamak için bunu yazdık. Bana bi liste ver IKrediManager türünde olsun demektir bu.
        {
            foreach (var kredi in krediler) //döngü listeyi dolaşacak listede kaç kredi istenmişse hepsinin çıktısını vericek
            {
                kredi.Hesapla();  //bu döngüyü yazarak program cs'de liste içerisinde belirttiğimiz kredi tipininin çıktısını almak için burada çağırıyoruz.
            }
        }
    }
}
