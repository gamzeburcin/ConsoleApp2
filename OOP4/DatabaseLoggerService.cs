using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class DatabaseLoggerService : ILoggerService   //veritabanına loglama işlemi
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı");
        }
    }
}
