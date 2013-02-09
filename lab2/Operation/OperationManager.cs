using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    class OperationManager
    {
        static Dictionary<Guid, Operation> _operations;

        static OperationManager()
        {
            _operations = new Dictionary<Guid, Operation>();
        }

        public static void AddOperation(Guid productId, Guid organizationId, bool income, int count)
        {
            Guid id = Guid.NewGuid();
            _operations.Add(id, new Operation()
            {
                Id = id,
                Income = income,
                OperationDate = DateTime.Now,
                ProductId = productId,
                OrganizationId = organizationId,
                Count = count
            });
        }

        public static List<Operation> OperationList
        {
            get
            {
                return _operations.Select(se => se.Value).ToList();
            }
        }
    }
}
