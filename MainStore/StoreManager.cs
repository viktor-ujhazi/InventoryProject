using System;
using System.Collections.Generic;
using System.Text;

namespace MainStore
{
    class StoreManager
    {
        private StorageCapable Storage { get; set; }
        public void addStorage(StorageCapable storage) 
        {
            Storage = storage;
        }
        public void addCDProduct(string name, int price, int tracks) 
        {
            Storage.storeCDProduct(name, price, tracks);
        }
        public void addBookProduct(string name, int price, int pages) 
        {
            Storage.storeBookProduct(name, price, pages);
        }
        public String listProducts() 
        {
            string result = "";
            List<Product> products = Storage.getAllProduct();
            foreach (var product in products)
            {
                result += product; 
            }
            return result;
        }
        public int getTotalProductPrice()
        {
            int result = 0;
            foreach (var product in Storage.getAllProduct())
            {
                result += product.getPrice();
            }
            return result;
        }

    }
}
