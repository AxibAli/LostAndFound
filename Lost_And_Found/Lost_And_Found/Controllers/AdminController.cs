using Lost_And_Found.Models;
using Lost_And_Found.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Lost_And_Found.Models.AjaxResponseModel;

namespace Lost_And_Found.Controllers
{
    public class AdminController : Controller
    {
        AjaxResponse ajaxResponse;
        string message = string.Empty;
        bool response;

        [HttpGet]
        public ActionResult Dashboard(DashboardModel dbm)
        {
            DashboardManager obj = new DashboardManager();
            var request = obj.Cards(dbm);
            return View(request);
        }

        public ActionResult ViewAllAdmins()
        {
            AdminManager obj = new AdminManager();
            List<CreateAdminModel> User = obj.selectAdmin();
            return View(User);
        }
        [HttpGet]
        public ActionResult CreateAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAdmin(CreateAdminModel cam)
        {
            if (ModelState.IsValid)
            {
                AdminManager obj = new AdminManager();
                cam.Admin_Created_By = Convert.ToInt32(Session["Admin_ID"]);
                cam.Admin_Created_ON = DateTime.Now;
                cam.Admin_IsActive = true;

                long u_id = obj.AddAdmin(cam);
                if (u_id > 0)
                {
                    message = "Successfull";
                    response = true;
                }

                else
                {
                    message = "Not Successfull";
                    response = false;
                }

            }
            else
            {
                message = "Error! Add missing fields";
                response = false;
            }

            ajaxResponse = new AjaxResponse { Message = message, Response = response };
            return Json(ajaxResponse, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AllPosts()
        {
            UserManager obj = new UserManager();
            List<PostProductModel> posts = obj.selectitems();
            return View(posts);
        }
        public ActionResult AllUsers()
        {
            AdminManager obj = new AdminManager();
            List<UserRegisterModel> User = obj.selectUser();
            return View(User);
        }
    }
}