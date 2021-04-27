using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27042021.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public double SalePrice { get; set; }
        public double? DiscountedPrice { get; set; }
    }
}
