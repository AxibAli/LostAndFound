using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lost_And_Found.Controllers
{
    public class AdminController : Controller
    {
        // GET: Dashboard
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult ViewAllAdmins()
        {
            return View();
        }

        public ActionResult CreateAdmin()
        {
            return View();
        }

    }
}