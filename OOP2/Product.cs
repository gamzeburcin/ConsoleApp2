//Entity yani varlık class

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //snippet
    class Product
    {
        public int Id { get; set; } //prop>tab-tab
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        //CRUD C-Creat U-pdate D-Delete
    }
}
