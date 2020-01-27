using System;
using System.Collections.Generic;
using System.Text;

namespace MainStore
{
    class CDProduct : Product
    {
        private int NumOfTracks { get; set; }

        public CDProduct(string name, int price, int numOfTracks) : base(name, price)
        {
            
            NumOfTracks = numOfTracks; 
        }
    }
}
