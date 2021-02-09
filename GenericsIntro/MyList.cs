using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //buradaki <> işaretinin içine int, string, boolean ya da class ismi verilebilir.

    {
        T[] items; //array oluşturduk.

        //constructor
        public MyList()
        {
            items = new T[0]; //oluşturduğumuz arrayi sıfırladık.
                
        }
        public void Add(T item) //tipi T olarak verdik programcı tipi ne olarak belirlerse T o olacak mesela int verirse T int olucak. item yerine eleman da yazabilirdik.
        {
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //items'ın sıfırıncı elemanı temp'in sıfırıncı elemanına eşitleniyor yani aslında dizideki tüm elemanları tek tek çağırmış oluyoruz.
                
            }
            items[items.Length - 1] = item; //aslında eklenmek istenen elemanı şu an ekledik.
            
        }
        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
