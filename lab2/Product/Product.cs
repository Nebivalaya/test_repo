using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    class Product
    {
        Guid id;
        string name;

        public Product(Guid id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Product(string name)
        {
            this.id = Guid.NewGuid();
            this.name = name;
        }

        public Guid ID { get { return id; } }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
