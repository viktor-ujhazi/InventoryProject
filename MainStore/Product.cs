using System;
using System.Collections.Generic;
using System.Text;

namespace MainStore
{
    abstract class Product
    {
        private String Name { get; set; }
        private int Price { get; set; }

        public Product(String name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
