using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    class ProductInStock
    {
        public Guid ID { get; set; }
        public Guid ProductId { get; set; }
        public Guid StockId { get; set; }
        //public Guid OrganisationId { get; set; }
        //public bool Operation { get; set; }
        //public DateTime Date { get; set; }
        public int Count { get; set; }
    }

    class ProductInStockManager
    {
        static Dictionary<Guid, ProductInStock> _productInStockList;

        static ProductInStockManager()
        {
            _productInStockList = new Dictionary<Guid, ProductInStock>();
        }

        public static List<ProductInStock> ProductInStockList
        {
            get
            {
                return _productInStockList.Select(se => se.Value).ToList();
            }
        }

        public static Guid AddProductToStock(Guid stockId, Guid productId, Guid organizationId, int count)
        {
            Guid recid;

            ProductInStock pr = _productInStockList
                .Where(wh => wh.Value.StockId == stockId && wh.Value.ProductId == productId)
                .Select(se => se.Value)
                .SingleOrDefault();

            if (pr != null)
            {
                recid = pr.ID;
                pr.Count += count;
            }
            else
            {
                Guid id = Guid.NewGuid();
                _productInStockList.Add(id, new ProductInStock()
                {
                    ID = id,
                    StockId = stockId,
                    ProductId = productId,
                    Count = count
                });
                recid = id;
            }

            OperationManager.AddOperation(productId, organizationId, true, count);

            return recid;
        }

        public static int RemoveProductToStock(Guid stockId, Guid productId, Guid organizationId, int count)
        {
            int removed = 0;

            ProductInStock pr = _productInStockList
                .Where(wh => wh.Value.StockId == stockId && wh.Value.ProductId == productId)
                .Select(se => se.Value)
                .SingleOrDefault();

            if (pr != null)
            {
                if (pr.Count > count)
                    pr.Count -= count;
                else
                {
                    removed = pr.Count;
                    pr.Count = 0;
                }

                OperationManager.AddOperation(productId, organizationId, false, count);
            }

            return removed;
        }

        public static void UpdateProductInStock(Guid Id,Guid orgid, int count)
        {
            ProductInStock pr = _productInStockList
                .Where(wh => wh.Key == Id)
                .Select(se => se.Value)
                .SingleOrDefault();

            

            if (pr != null)
            {
                int delta = count - pr.Count;
                if (delta > 0)
                {
                    AddProductToStock(pr.StockId, pr.ProductId, orgid, delta);
                }
                else
                {
                    RemoveProductToStock(pr.StockId, pr.ProductId, orgid, delta * (-1));
                }
            }
        }
    }
}
