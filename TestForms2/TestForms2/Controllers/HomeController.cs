using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestForms2.Models;

namespace TestForms2.Controllers
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

        public ActionResult SignUpForm()
        {
            return View();
        }

        public ActionResult AddNewUser(UserInfo newUser )
        {
            // Validation! 
            if (ModelState.IsValid)
            {
                // to insert the newUser into the DB! 

                ViewBag.Message = $"Welcome {newUser.Username}";
                return View("Confirm");
            }
            else
            {
                ViewBag.Address = Request.UserAgent;
                return View("Error");
            }
        }
    }
}