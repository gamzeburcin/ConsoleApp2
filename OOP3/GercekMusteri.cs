using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Individual--> Bireysel
    class GercekMusteri:Musteri  //miras-inheritance. Bu işlemi yaptıktan sonra müşterinin özellikleri gerçek müşteride de var demektir. Yani Gerçek müşteri,müşteri sınıfından miras alıyor.
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
