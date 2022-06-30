using Lost_And_Found.Manager;
using Lost_And_Found.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lost_And_Found.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult MainIndex()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        
    }
}