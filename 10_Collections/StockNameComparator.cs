using System;
using System.Collections;
using System.Collections.Generic;

namespace _10_Collections
{
    public class StockNameComparator : IComparer <IAsset>
    {

        public int Compare(IAsset ass1, IAsset ass2)
        {
            int result = 0;
            
            if (ass1.Name.CompareTo(ass2.Name) > 0) result = 1;
            if (ass1.Name.CompareTo(ass2.Name) < 0 ) result = -1;
            return result;
        }
    }
}