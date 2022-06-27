using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lost_And_Found.Controllers
{
    public class UserController : Controller
    {
        public ActionResult PostProduct()
        {
            return View();
        }
        public ActionResult Home() 
        {
            return View();
        }
    }
}