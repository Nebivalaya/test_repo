using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    class ProductManager
    {
        static Dictionary<Guid, Product> _productsTypes;

        public static List<Product> ProductsList
        {
            get
            {
                return _productsTypes.Select(se => se.Value).ToList();
            }
        }

        static ProductManager()
        {
            _productsTypes = new Dictionary<Guid, Product>();
            AddProduct("p1");
            AddProduct("p2");
        }

        public static Product GetById(Guid id)
        {
            return _productsTypes[id];
        }

        public static void AddProduct(string name)
        {
            Guid id = Guid.NewGuid();
            _productsTypes.Add(id, new Product(id, name));
        }

        public static void UpdateProduct(Guid id, string newName)
        {
            _productsTypes[id].Name = newName;
        }

        public static bool DeleteProduct(Guid id)
        {
            return _productsTypes.Remove(id);
        }

    }
}
