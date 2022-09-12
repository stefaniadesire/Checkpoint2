using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2
{
    public class Product
    {
        public string category;
        public string item;
        public int price;



        public Product(string _category, string _item, int _price)
        {
            category = _category;
            item = _item;
            price = _price;
        }

    
    }
}
