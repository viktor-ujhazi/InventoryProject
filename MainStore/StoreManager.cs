using System;
using System.Collections.Generic;
using System.Text;

namespace MainStore
{
    class StoreManager
    {
        private StorageCapable storage;//{ get; set; }
        public void addStorage(StorageCapable storage) 
        {
            this.storage = storage;
        }
        public void addCDProduct(string name, int price, int tracks) 
        {
            storage.storeCDProduct(name, price, tracks);
        }
        public void addBookProduct(string name, int price, int pages) 
        {
            storage.storeBookProduct(name, price, pages);
        }
        public String listProducts() 
        {
            string result = "";
            List<Product> products = storage.getAllProduct();
            foreach (var product in products)
            {
                result += product; 
            }
            return result;
        }
        public int getTotalProductPrice()
        {
            int result = 0;
            foreach (var product in storage.getAllProduct())
            {
                result += product.getPrice();
            }
            return result;
        }

    }
}
