using System;
using System.Collections.Generic;
using System.Text;

namespace MainStore
{
    interface StorageCapable
    {
        public List<Product> getAllProduct();
        public void storeCDProduct(String name, int price, int tracks);
        public void storeBookProduct(String name, int price, int pages);
    }
}
