using MVC0507.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC0507.Controllers
{
    public class HomeController : Controller
    {
        EFDbContext context = new EFDbContext();
        public ViewResult Index()
        {
            List<Product> products = context.Products.ToList();
            return View(products);
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
        [HttpGet]
        public ActionResult Payment()
        {
            return Json(new
            {
                newUrl = Url.Action("Payment", "Process")
            });
        }
    }
}