using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    class StockManager
    {
        static Dictionary<Guid, Stock> _stocks;

        public static List<Stock> StockList
        {
            get
            {
                return _stocks.Select(se => se.Value).ToList();
            }
        }

        static StockManager()
        {
            _stocks = new Dictionary<Guid, Stock>();
            AddStock("s1");
        }

        public static Stock GetById(Guid id)
        {
            return _stocks[id];
        }

        public static void AddStock(string name)
        {
            Guid id = Guid.NewGuid();
            _stocks.Add(id, new Stock(id, name));
        }

        public static void UpdateStock(Guid id, string newName)
        {
            _stocks[id].Name = newName;
        }

        public static bool DeleteStock(Guid id)
        {
            return _stocks.Remove(id);
        }
    }
}
