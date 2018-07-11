using MVC0629.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC0629.Controllers
{
    public class HomeController : Controller
    {
        Models.DataStoreEntities0630 entities = new DataStoreEntities0630();
        public JsonResult GetData()
        {
            List<Product> products = entities.Products.ToList();
            //List<Product> products = new List<Product>()
            //{
            //    new Product{Id=1,Name="Apple",Price=11 },
            //    new Product{Id=2,Name="Pear",Price=12 }
            //};
            return Json(products, JsonRequestBehavior.AllowGet);
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult filterresult(int? id)
        {
            List<Product> products = new List<Product>()
            {
                new Product{ID=1,Name="Apple",Price=12 },
                new Product{ID=2,Name="Grape",Price=13 },
                new Product{ID=3,Name="Pear",Price=16 }
            };
            if (id != null)
            {
                products = products.Where(x => x.ID == id).ToList();
            }
            ViewBag.result = products;
            return PartialView("filterresult", products);
        }
        public ActionResult About()
        {
            List<Product> products = new List<Product>()
            {
                new Product{ID=1,Name="Apple",Price=23 },
                new Product{ID=2,Name="Berry",Price=25 },
                new Product{ID=3,Name="Apricot",Price=28 }
            };
            ViewBag.result = products;
            return View(products);
        }
    }

}
