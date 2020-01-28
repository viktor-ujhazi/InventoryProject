using System;
using System.Collections.Generic;
using System.Text;

namespace MainStore
{
    class PersistentStore : Store
    {
        private List<Product> products { get; set; }

        public override List<Product> getAllProduct()
        {
            return products;
        }

        public override void storeBookProduct(string name, int price, int pages)
        {
            throw new NotImplementedException();
        }

        public override void storeCDProduct(string name, int price, int tracks)
        {
            throw new NotImplementedException();
        }

        public override void storeProduct(Product product) 
        {
            products.Add(product);
        }
    }
}
