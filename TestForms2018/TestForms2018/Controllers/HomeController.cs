using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestForms2018.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult SearchProducts(string productName)
        {
            string[] Products = { "Apples", "Coke","Coffee","Water"};
            // Products.Where(x => x.Contains(productName)).ToArray();
            List<string> result = new List<string>();
            foreach (string element in Products)
            {
                if (element.ToLower().Contains(productName.ToLower()))
                {
                    result.Add(element);
                }
            }
            ViewBag.Results = result;
            return View();
        }
    }
}