using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationDemo2.Models;

namespace WebApplicationDemo2.Controllers
{
    public class LoadCustomerAndDisplayController : Controller
    {


        // GET: LoadCustomerAndDisplay
        public ActionResult Index()
        {
            Customer customer = new Customer();

            customer.Id = 1;
            customer.CustomerCode = "c001";
            customer.Amount = 9.99;



            return View(customer);
        }
        //@model WebApplicationDemo2.Models.Customer


    }
}