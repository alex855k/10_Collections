using System;
using System.Collections;
using System.Collections.Generic;

namespace _10_Collections
{
    public class MemoryStockRepository : IStockRepository
    {
       public SortedList<long, Stock> _stocks;

        public int indexCounter = -1;
        private long generateKey = 0;

        public int used = 0;
        public MemoryStockRepository() {
            _stocks = new SortedList<long, Stock>();
            /*_stocks.Add(123, new Stock("HP", 11.4, 10));
            _stocks.Add(234, new Stock("YHOO", 57.2, 30));*/
            
        }

        public long NextId()
        {
            generateKey = generateKey+1;
            return generateKey;
        }

        public void SaveStock(Stock s)
        {
            if (!_stocks.ContainsKey(s.Id)) {
                s.Id = this.NextId();
                _stocks.Add(s.Id, s);
            }
        }

        public Stock LoadStock(long id)
        {
            Stock stock = null;
            if (_stocks.ContainsKey(id))
            {
                stock = _stocks[id];
            }
            
            return stock;
        }

        public ICollection FindAllStocks()
        {
            return _stocks;
        }

        public void Clear()
        {
            _stocks.Clear();
        }
    }
}