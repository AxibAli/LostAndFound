using Lost_And_Found.Models;
using Lost_And_Found.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Lost_And_Found.Models.AjaxResponseModel;
using Lost_And_Found.Filters;

namespace Lost_And_Found.Controllers
{
    [AuthorizedUser]
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
                    TempData["Message"] = "New Admin Created Successfully";
                    message = "Successfull";
                    response = true;
                }

                else
                {
                    TempData["Message"] = "Admin Not Created !";
                    message = "Not Successfull";
                    response = false;
                }

            }
            else
            {
                TempData["Message"] = "Fill Complete Form !";
                message = "Error! Add missing fields";
                response = false;
            }

            ajaxResponse = new AjaxResponse { Message = message, Response = response };
            return Json(ajaxResponse, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AllPosts(long postedby)
        {
            AdminManager obj = new AdminManager();
            List<PostProductModel> posts = obj.selectMyposts(postedby);
            if (posts == null)
            {
                TempData["Message"] = "Posts not Found";
                return View();
            }
            else
            {
                return View(posts);
            }
           
        }
        public ActionResult AllUsers()
        {
            AdminManager obj = new AdminManager();
            List<UserRegisterModel> User = obj.selectUser();
            return View(User);
        }

        [HttpPost]
        public ActionResult UpdateAdminStatus(bool Status, int adminid)
        {
            AdminManager obj = new AdminManager();
            var response = obj.UpdateAdminStatus(Status, adminid);

            return Json(response, JsonRequestBehavior.AllowGet);

        }


        [HttpPost]
        public ActionResult UpdatePostStatus(bool Status, int productid)
        {
            AdminManager obj = new AdminManager();
            var response = obj.UpdatePostStatus(Status, productid);

            return Json(response, JsonRequestBehavior.AllowGet);

        }

    }
}