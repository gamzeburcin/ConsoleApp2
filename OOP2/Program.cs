//main ekran görevi gören class

using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;


            //yukarıdakinin yerine aşağıdaki gibi de yapabilirsin daha kısa yolu
            
            Product product2 = new Product {Id=2, CategoryId=5, UnitInStock=5, ProductName="Kalem", UnitPrice=35};
            
            
            //case sensitive büyük küçük harf duyarlı
            //PascalCase   //camelCase
            //class ismi   //adlandırma değişken gibi
            ProductManager productManager=new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //int,double,bool... değer tip
            //diziler, class, abstract class, interface... referans tip
            //ref out keywordlari
            
        }
    }
}
