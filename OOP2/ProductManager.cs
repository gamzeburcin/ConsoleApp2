//iş yapan manager class

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class ProductManager
    {
        //encapsulation- aşağıda product product diyerek ıd ad vs gibi değerleri tek tek getirmek yerine hep birlşkte getirdik.Nesnelerin hepsini kümülatif yolladık.
        public void Add(Product product) //string ad demekle Product product demeke aynı şeydir değişken tanımlamak gibi düşün.
        {
            Console.WriteLine(product.ProductName+ " eklendi.");
            
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        
      
    }
}
