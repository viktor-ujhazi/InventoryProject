using System;
using System.Collections.Generic;
using System.Text;

namespace MainStore
{
    class PersistentStore : Store
    {
        private List<Product> products { get; set; } = new List<Product>();

        public override List<Product> getAllProduct()
        {
            return products;
        }

        
        public override void storeProduct(Product product) 
        {
            products.Add(product);
        }
    }
}
