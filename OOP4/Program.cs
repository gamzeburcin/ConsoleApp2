using System;
using System.Collections.Generic;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();  //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKredimanager(); yazsaydıkta sonuç değişmezdi. İnterface onu implemente eden sınıfın referansını tutabilir.
            IKrediManager tasitKrediManager = new TasitKrediManager();  //TasitKrediManager tasitKrediManager = new TasitKrediManager(); aynı şey
            IKrediManager konutKrediManager = new KonutKrediManager();  //KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService(); //ilk loglama alternatifi mesela aşağıda bu loglama türünü seçip yazdık ama file loggerı da seçebilirdik bunlar loglama tercihi oldupundan herhangi birini seçiyoruz.
            ILoggerService fileLoggerService = new FileLoggerService(); //ikinci loglama alternatifi

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            //Bu işlem yazılımda sürdürülebilirliği sağlar 
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), loggers);  //loglamayı veritabanına yapıcak hale getirdik. //hangisini seçersek onun hesaplamasını yapar konut deyince konutun çıktısını verir

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};  //burada ihtiyaçKrediManager gibi kaç tane kredinin hesaplanmasını istiyorsak seçim yapıyoruz.

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        
        }
    }
}
