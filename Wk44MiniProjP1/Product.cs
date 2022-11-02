using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk44MiniProjP1
{
    internal class Product //Class for product
    {
        public Product(string cat, string pName, string pPrice)
        {
            Cat = cat;
            PName = pName;
            PPrice = pPrice;
        }

        public string Cat { get; set; }
        public string PName { get; set; }
        public string PPrice { get; set; }
    }
}
