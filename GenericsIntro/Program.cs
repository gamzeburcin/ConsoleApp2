using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList<string> isimler = new MyList<string>(); //string yerine class ismi de yazabilirdik.
            isimler.Add("Gamze");

            Console.WriteLine("Hello World!");
        }
    }
}
