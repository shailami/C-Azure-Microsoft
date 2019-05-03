using EcommerceMVCWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceMVCWebApplication.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ProductDetails prod = new ProductDetails
        {
            Name = "Mobile Phone",
            Category="Electronics",
            RegistrationDate = DateTime.Now,
            ProductQty = 2,
            Price=1000.00
        };
    public ActionResult Index()
        {
            return View(prod);
        }
        public ActionResult Edit()
        {
            return View(prod);//right click add view name is Edit model is PrdouctDetails
        }

    }
}