using System;
using System.Collections.Generic;
using System.Text;

namespace MainStore
{
    class BookProduct : Product
    {
        private int NumOfPages { get; set; }

        public BookProduct(string name, int price, int numOfPages) : base(name, price)
        {

            NumOfPages = numOfPages;
        }
        public override String ToString()
        {
            string resultString = base.ToString() + $"Number of pages: {NumOfPages}\n";

            return resultString;
        }
    }
}
