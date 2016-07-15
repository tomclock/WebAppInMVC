using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using WebAppInMVC.Models;

namespace WebAppInMVC.Controllers
{
    public class HomeController : Controller
    {
        public IEnumerable<Product> Products { get; private set; }

        private ProductListViewModel productListVM = new ProductListViewModel();

        //public ViewResult List()
        //{
        //    var productList = new List<SelectListItem>();

        //    Products = new List<Product>
        //    { new Product {Name = "Tom", Price = 100, ProductId = "1" },
        //      new Product { Name = "Jack", Price = 101, ProductId = "2" },
        //      new Product { Name = "Tim", Price = 101, ProductId = "3" },
        //      new Product { Name = "Hack", Price = 101, ProductId = "4" }};

        //    foreach (Models.Product p in Products)
        //    {
        //        productList.Add(new SelectListItem
        //        {
        //            Value = p.ProductId.ToString(),
        //            Text = "Product: " + p.Name + " " + p.Price.ToString(),
        //            // To set the selected item use the following code 
        //            // Note: you should not set every item to selected
        //            Selected = true
        //        });
        //    }
        //    productListVM.Products = productList;

        //    return View(productListVM);
        //}

        public ActionResult Index()
        {

            //initialize the Product contents. 
            var productList = new List<SelectListItem>();

            //this part should been get from the Entity.(here for easy test)
            Products = new List<Product>
                { new Product {Name = "Tom", Price = 100, ProductId = "1" },
                  new Product { Name = "Jack", Price = 101, ProductId = "2" },
                  new Product { Name = "Tim", Price = 101, ProductId = "3" },
                  new Product { Name = "Hack", Price = 101, ProductId = "4" }};

            foreach (Models.Product p in Products)
            {
                productList.Add(new SelectListItem
                {
                    Value = p.ProductId.ToString(),
                    Text = "Product: " + p.Name + " " + p.Price.ToString(),
                    // To set the selected item use the following code 
                    // Note: you should not set every item to selected
                    Selected = true
                });
            }
            productListVM.Products = productList;

            return View(productListVM);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}