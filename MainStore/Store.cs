using System;
using System.Collections.Generic;
using System.Text;

namespace MainStore
{
    abstract class Store : StorageCapable
    {
        
        
        public abstract void storeProduct(Product product);
        public abstract List<Product> getAllProduct();
        public void store(Product product) 
        {
            saveToXml(product);
            storeProduct(product);
        }
        
        public void storeCDProduct(string name, int price, int tracks)
        {
            Product cd = createProduct("CD", name, price, tracks);
            store(cd);
        }
        public void storeBookProduct(string name, int price, int pages)
        {
            Product book = createProduct("Book", name, price, pages);
            store(book);

        }
        protected Product createProduct(string type, string name, int price, int size) 
        {
            if (type.Equals("CD"))
            {
                CDProduct cDProduct = new CDProduct(name, price, size);
                return cDProduct;
            }
            else 
            {
                BookProduct bookProduct = new BookProduct(name, price, size);
                return bookProduct;
            }
        }
        public List<Product> loadProducts()
        {
            return null;
        }
        private void saveToXml(Product product) 
        {

        }
    }
}
