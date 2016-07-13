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

        public ViewResult List()
        {
            var productList = new List<SelectListItem>();

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

            ProductListviewModel productListVM = new ProductListViewModeld();

            productListVM.Products = productList;

            return View(productListVM);
        }

        public ActionResult Index()
        {
            return View();
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