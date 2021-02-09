using System;

namespace OOP4
{
    class FileLoggerService : ILoggerService   //dosyaya loglama işlemi
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}
