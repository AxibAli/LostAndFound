using Lost_And_Found.Manager;
using Lost_And_Found.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Lost_And_Found.Models.AjaxResponseModel;

namespace Lost_And_Found.Controllers
{
    public class LoginController : Controller
    {
        AjaxResponse ajaxResponse;
        string message = string.Empty;
        bool response;

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel lm)
        {
            if (ModelState.IsValid)
            {
                LoginManager obj = new LoginManager();
                
                CreateAdminModel admindata = obj.adminchecklogin(lm);
                UserRegisterModel userdata = obj.userchecklogin(lm);

                if (admindata != null && admindata.Admin_IsActive == false )
                {
                    TempData["Message"] = "You have currently disabled, kindly contact your Admin";
                    return View();
                }
                else if (userdata != null && userdata.User_IsActive == false)
                {
                    TempData["Message"] = "You have currently disabled, kindly contact With Lost & Found Contact Email";
                    return View();
                }
                if (admindata != null)
                {
                    Session["IsLogedIn"] = true;
                    Session["Admin_FullName"] = admindata.Admin_FullName;
                    Session["Admin_ID"] = admindata.Admin_ID;

                    return RedirectToAction("Dashboard", "Admin");
                }
                else if (userdata != null)
                {
                    Session["IsLogedIn"] = true;
                    Session["User_FullName"] = userdata.User_FullName;
                    Session["User_ID"] = userdata.User_ID;

                    return RedirectToAction("Home", "User");
                }
                else
                {
                    TempData["Message"] = "UserName Or Password Incorrect";
                    return View();
                }
            }
            else
            {
                TempData["Message"] = "Please Enter UserName and Password First ";
                return View();
            }
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserRegisterModel Rm)
        {
            if (ModelState.IsValid)
            {
                RegisterManager obj = new RegisterManager();
                Rm.User_Created_ON = DateTime.Now;
                Rm.User_Role = "User";
                Rm.User_IsActive = true;

                long u_id = obj.AddUser(Rm);
                if (u_id > 0)
                {
                    message = "Successfull";
                    response = true;
                    //TempData["Message"] = "You are Registered Successfull";
                    //return View();

                }

                else
                {
                    message = "Not Successfull";
                    response = false;
                    //TempData["Message"] = "You Not Registered ";
                    //return View();
                }

            }
            else
            {
               message = "Error! Add missing fields";
               response = false;
               // TempData["Message"] = "Fill all missing fields";
                //return View();
            }

            ajaxResponse = new AjaxResponse { Message = message, Response = response };
            return Json(ajaxResponse);
           
        }


        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Login");
        }
    }
}