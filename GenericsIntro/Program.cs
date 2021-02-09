using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList<string> isimler = new MyList<string>(); //string yerine class ismi de yazabilirdik.
            isimler.Add("Gamze");
            Console.WriteLine(isimler.Length);

            isimler.Add("Ecrin");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
