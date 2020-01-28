using System;
using System.Collections.Generic;
using System.Text;

namespace MainStore
{
    abstract class Store : StorageCapable
    {
        
        private void saveToXml(Product product) 
        {

        }
        public abstract void storeProduct(Product product);
        
        protected Product createProduct(string type, string name, int price, int size) 
        {
            // TODO: Exception handling
            if (type.ToUpper().Equals("CD"))
            {
                CDProduct cDProduct = new CDProduct(name, price, size);
                return cDProduct;
            }
            else if (type.ToUpper().Equals("BOOK"))
            {
                BookProduct bookProduct = new BookProduct(name, price, size);
                return bookProduct;
            }
            else
            {
                return null;
            }
            
        }
        public List<Product> loadProducts()
        {
            return null;
        }
        public void store(Product product) 
        {
            saveToXml(product);
            storeProduct(product);
        }

        public abstract List<Product> getAllProduct();
        public abstract void storeCDProduct(string name, int price, int tracks);
        public abstract void storeBookProduct(string name, int price, int pages);
        
    }
}
