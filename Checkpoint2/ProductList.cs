using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2
{
    internal class ProductList
    {

        public List<Product> products = new List<Product>();

        public void addProduct(Product product)
        {
            products.Add(product);

        }

        
        public List<Product> getSorted()
        {

            return products.OrderBy(product => product.price).ToList();
          
        }

        public int priceSum()
        {
            int sum = 0;
          

            foreach (Product product in products)
            {
                
                sum = sum + product.price;
                
            }

            return sum;
        }

    }
}
 