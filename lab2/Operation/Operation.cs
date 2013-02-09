using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    class Operation
    {
        public Guid Id { get; set; }
        public bool Income { get; set; }
        public Guid ProductId { get; set; }
        public Guid OrganizationId { get; set; }
        public DateTime OperationDate { get; set; }
        public int Count { get; set; }
    }
}
