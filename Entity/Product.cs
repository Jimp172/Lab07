using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        public int product_id { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }
        public Boolean active { get; set; }
    }

}

