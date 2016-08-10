using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationDemo2.Models;

namespace WebApplicationDemo2.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FillCustomer()
        {
            
            return View();

        }

        [HttpPost]
        public ActionResult DisplayCustomer(Customer c)
        {
            //Customer c = new Customer();
            //c.Id = Convert.ToInt32(Request.Form["CustomerId"]);
            //c.CustomerCode = Request.Form["CustomerCode"];
            //c.Amount = Convert.ToDouble(Request.Form["CustomerAmount"]);
            return View(c);
        }
    }
}