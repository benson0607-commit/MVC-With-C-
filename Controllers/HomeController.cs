using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            // ViewBag.Message = "Your application description page.";
            foreach (var item in new Client.Client().download()) {
                Console.WriteLine(item.確定病名);
                ViewBag.Message += item.確定病名 + "\n";
            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}