using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationDemo2.Controllers
{
    public class NavigateController : Controller
    {
        // GET: Navigate
        public ActionResult GoToHome()
        {
            return View("Home");
        }

        public ActionResult AboutUs()
        {
            return View("AboutUs");
        }

        public ActionResult SeeProduct()
        {
            return View("Product");
        }
    }
}