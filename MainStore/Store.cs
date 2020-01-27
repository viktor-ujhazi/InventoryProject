using System;
using System.Collections.Generic;
using System.Text;

namespace MainStore
{
    abstract class Store : StorageCapable
    {
        private List<Product> products { get; set; }
        private void saveToXml(Product product) 
        {
        }
        protected void storeProduct(Product product) 
        {
            products.Add(product);
        }
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
        }

        public List<Product> getAllProduct()
        {
            return products;
        }

        public void storeCDProduct(string name, int price, int tracks)
        {
            throw new NotImplementedException();
        }

        public void storeBookProduct(string name, int price, int pages)
        {
            throw new NotImplementedException();
        }
    }
}
