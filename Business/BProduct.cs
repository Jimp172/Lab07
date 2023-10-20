using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace Business
{
    public class BProduct
    {
        public List<Product> GetByName(string Name)
        {
            List<Product> result = new List<Product>();

            Dproduct data= new Dproduct();

            var products = data.Get();

            foreach (var item in products)
            {
                if (item.Name == Name)
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
