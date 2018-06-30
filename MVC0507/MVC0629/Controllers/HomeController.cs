using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC0629.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult GetData()
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Apple",Price=11 },
                new Product{Id=2,Name="Pear",Price=12 }
            };
            return Json(products, JsonRequestBehavior.AllowGet);
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

    }
}
