using System;

namespace _10_Collections
{
    public class Stock : IAsset
    {
        public int NumShares { get; set; }

        public double PricePerShare { get; set; }

        public string Name { get; set; }
        public long Id { get; set; }

        public Stock()
        {

        }
        public Stock(string name, double priceshare, int amount)
        {
            this.Name = name;
            this.PricePerShare = priceshare;
            this.NumShares = amount;
        }

        public double GetValue()
        {
            return (double)(NumShares * PricePerShare);

        }

        public override string ToString()
        {

            string str = "Stock[symbol=" + this.Name + ",pricePerShare=" + this.PricePerShare + ",numShares=" + this.NumShares + "]";
            return str;
        }
        public override bool Equals(object obj)
        {
            Stock s = (Stock)obj;
            if (this.NumShares == s.NumShares && this.PricePerShare == s.PricePerShare && this.Name == s.Name)
                return true;

            return false;
        }
        public static double TotalValue(IAsset [] portfolio)
        {
            double totalvalue = 0;
            foreach (IAsset s in portfolio)
            {
                totalvalue +=s.GetValue();
            }
            return totalvalue;



        }
        public static double TotalValue(Stock[] portfolio)
        {
            double totalvalue = 0;
            foreach (Stock s in portfolio)
            {
                totalvalue += s.GetValue();
            }
            return totalvalue;
        }
    }
}