using System;
using System.Collections.Generic;

namespace Koleksiyonlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Toplu comment alma(yorum satırı) için yorum satırı yapacağımız kısımları seçip ctrl+k daha sonra ctrl+c yapıyoruz.
            //geri almak için de ctrl+k, ctrl+u yapıyruz



            string[] isimler = new string[] { "Gamze", "Ecrin", "Tülay", "Özgür" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler = new string[5];
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);

            //diziye dışardan yeni bir eleman(ilker) ekledikten sonra dizinin 0. elemanını tekrar çağırdık ancak ekrana yazmadı 
            //çünkü isimler= new string[5]; diyerek 5. stringi farklı bir adresten başlattık 
            //önceden yaxdığımız dizide farklı bir adreste kaldı yani oluşturduğumuz dizinin ilk elemanları 5. elamanın olduğu adrese kopyalanmadı
            //bu yüzden program ilk tanımlanan değerler sanki yokmuş gibi davranır
            //böyle problemlerde listelerden yararlanıyoruz.


            List<string> isimler2 = new List<string> {"Gamze","Ecrin","Tülay","Özgür" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            
            //bu sefer altta çağrılan 0. indisi okudu.
            //kısacası koleksiyonlarda değer kaybetmeyi önleyen bi alt yapı var arraylerin aksine.

        }
    }
}
