using System;
using System.Collections.Generic;

namespace _10_Collections
{
    public class Portfolio
    {
        public List<IAsset> Assets
        {
            set;
            get;
        }
        public Portfolio()
        {
            Assets = new List<IAsset>();
            
        }
        public Portfolio (List<IAsset> something)
        {
            Assets = something;
        }
        public double GetTotalValue()
        {
            double totalvalue = 0;
            foreach (IAsset a in Assets)
            {
                totalvalue += a.GetValue(); 
            }

            return totalvalue;
        }
        public void AddAsset(IAsset a)
        {
            Assets.Add(a);
            
        }

        public IList<IAsset> GetIAssets() {
            return Assets;
        }

        public Stock GetAssetByName(string name)
        {
            Stock s = null;
            foreach (IAsset a in Assets) {
                if (a.Name == name) s = (Stock)a;
            }
            return s;
        }

        public IList<IAsset> GetAssetsSortedByName()
        {
            Assets.Sort(new StockNameComparator());
            return Assets;
        }

        public IList<IAsset> GetAssetsSortedByValue()
        {
            Assets.Sort(new StockValueComparator());
            return Assets;
        }

        internal IList<IAsset> GetAssets()
        {
            IList<IAsset> _assets = Assets.AsReadOnly();

            return _assets;
        }
    }
}