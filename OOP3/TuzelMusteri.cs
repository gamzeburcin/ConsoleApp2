using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Coorporate--> Tüzel
    class TuzelMusteri:Musteri  //miras yani inheritance. Tüzel müşteriye :Musteri yazarak sen bir müşterisin demiş olduk bu olaya miras deniliyor.
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
