using Lost_And_Found.Models;
using Lost_And_Found.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lost_And_Found.Filters;
using Newtonsoft.Json;

namespace Lost_And_Found.Controllers
{
    //[AuthorizedUser]
    public class AdminController : Controller
    {
        LostandFoundEntities db = new LostandFoundEntities();
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
                    return RedirectToAction("ViewAllAdmins");
                }

                else
                {
                    TempData["Message"] = "Admin Not Created !";
                    return View();
                }

            }
            else
            {
                TempData["Message"] = "Fill Complete Form !";
                return View();
            }
        }

        public ActionResult AllPosts()
        {
            AdminManager obj = new AdminManager();
            List<PostProductModel> posts = obj.selectitemsforadmins();
            return View(posts);
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
        public JsonResult GetStudentById(int Admin_ID)
        {
            App_Admin model = db.App_Admin.Where(x => x.Admin_ID == Admin_ID).SingleOrDefault();
            string value = string.Empty;
            value = JsonConvert.SerializeObject(model, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SaveDataInDatabase(CreateAdminModel model)
        {
            var result = false;
            try
            {
                if (model.Admin_ID > 0)
                {
                    App_Admin Add = db.App_Admin.SingleOrDefault(x => x.Admin_IsActive == false && x.Admin_ID == model.Admin_ID);
                    Add.Admin_FullName = model.Admin_FullName;
                    db.SaveChanges();
                    result = true;
                }

                else
                {
                    App_Admin Add = new App_Admin();
                    Add.Admin_ID = model.Admin_ID;
                    Add.Admin_FullName = model.Admin_FullName;
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return Json(result, JsonRequestBehavior.AllowGet);

        }

    }
}