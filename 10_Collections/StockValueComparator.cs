using System;
using System.Collections.Generic;

namespace _10_Collections
{
    public class StockValueComparator : IComparer<IAsset>
    {
        public int Compare(IAsset ass1, IAsset ass2)
        {
            int result = 0;

            if (ass1.GetValue().CompareTo(ass2.GetValue()) > 0) result = -1 ;
            if (ass1.GetValue().CompareTo(ass2.GetValue()) < 0) result = 1;

            return result;
        }
    }
}