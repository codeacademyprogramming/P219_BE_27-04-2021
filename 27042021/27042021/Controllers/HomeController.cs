using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _27042021.Models;
using _27042021.ViewModels;

namespace _27042021.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserName = "Ayxan";

            List<Product> products = new List<Product>();


            Product product1 = new Product
            {
                Brand = "Apple",
                Name = "Iphone 12 Pro 128GB",
                SalePrice = 2649,
                DiscountedPrice = null
            };


            Product product2 = new Product
            {
                Brand = "Samsung",
                Name = "S20",
                SalePrice = 2000,
                DiscountedPrice = 1850
            };

            Product product3 = new Product
            {
                Brand = "Apple",
                Name = "Macbook pro",
                SalePrice = 5500,
                DiscountedPrice = null
            };

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);

            //ViewBag.Products = products;

            return View(products);
        }

        public IActionResult Detail()
        {
            Product product1 = new Product
            {
                Brand = "Apple",
                Name = "Iphone 12 Pro 128GB",
                SalePrice = 2649,
                DiscountedPrice = null
            };


            List<CreditCard> creditCards = new List<CreditCard>
            {
                new CreditCard
                {
                    Month = 18,
                    Name = "Birkart",
                    Price = 141.61
                },
                new CreditCard
                {
                    Month = 18,
                    Name = "Tamkart",
                    Price = 141.61
                }
            };

            //ViewBag.Product = product1;
            //ViewBag.CreditCards = creditCards;

            ProductDetailViewModel productDetailVM = new ProductDetailViewModel
            {
                Product = product1,
                CreditCards = creditCards,
            };

            return View(productDetailVM);
        }
    }
}
