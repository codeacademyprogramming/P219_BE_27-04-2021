using _27042021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27042021.ViewModels
{
    public class ProductDetailViewModel
    {
        public Product Product { get; set; }
        public List<CreditCard> CreditCards { get; set; }
    }
}
