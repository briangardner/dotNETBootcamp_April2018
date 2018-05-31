using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestEF.Models;

namespace TestEF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {    //1. Create an ORM object 
            masterEntities ORM = new masterEntities();

            ViewBag.CustomerList = ORM.Customers.ToList();

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SearchByCity(string city)
        {
            //1. Create the ORM
            masterEntities ORM = new masterEntities();

           ViewBag.CustomerList= 
                ORM.Customers.Where(c => c.City.Contains(city)).ToList();

            return View("About");

        }

        public ActionResult AddNewCustomer(Customer NewCustomer)
        {
            //1. Create the ORM
            masterEntities ORM = new masterEntities();

            //2. TODO: Validation!!!!!!!

            //3. Add the new object to the Customer list

            ORM.Customers.Add(NewCustomer);

            //4. save changes to the DB
            ORM.SaveChanges();

            // load the customer info back again 
            ViewBag.CustomerList = ORM.Customers.ToList();
            return View("About");

            // OR 
            // return RedirectToAction("About");

        }

        public ActionResult DeleteCustomer(string CustomerID)
        {
            //1. ORM 

            masterEntities ORM = new masterEntities();

            //2. Find the customer you want to delete 
            Customer Found =ORM.Customers.Find(CustomerID);



            if (Found != null)
            {    //3. Remove the customer

                // TODO: Delete all orders for that customer first! 
                ORM.Customers.Remove(Found);
                //4. Save to the DB 
                ORM.SaveChanges();

                return RedirectToAction("About");// execute the About Action again

            }
            else
            {
                ViewBag.ErrorMessage = "User not found!";
                return View("Error");

            }




        }

        public ActionResult ShowCustomerDetails(string CustomerID)
        {
            //1. Create ORM

            masterEntities ORM = new masterEntities();

            //2. Find the customer

            Customer Found = ORM.Customers.Find(CustomerID);

            if (Found !=null)
            {  //3. Send the data to a view 
                return View(Found);// send the customer back using a model

                // OR 
                // ViewBag.Found = Found;
                // return View();


            }
            else
            {
                ViewBag.ErrorMessage = "Customer not found!";
                return View("Error");

            }
          

        }

        public ActionResult SaveCustomerUpdates(Customer updatedCustomer)
        {
            //1. create the ORM
            masterEntities ORM = new masterEntities();

            //2. Find the customer

            Customer OldCustomerRecord = ORM.Customers.Find(updatedCustomer.CustomerID);
            if (OldCustomerRecord != null && ModelState.IsValid)
            {
                //3. Update the existing customer

                OldCustomerRecord.CompanyName = updatedCustomer.CompanyName;
                OldCustomerRecord.City = updatedCustomer.City;

                ORM.Entry(OldCustomerRecord).State = System.Data.Entity.EntityState.Modified;

                //4. save back to the DB 
                ORM.SaveChanges();

                return RedirectToAction("About");

            }
            else
            {
                ViewBag.ErrorMessage = "Oops! Something went wrong!";
                return View("Error");
            }
           

        }
    }
}