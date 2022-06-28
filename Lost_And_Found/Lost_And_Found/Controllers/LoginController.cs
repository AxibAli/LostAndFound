﻿using Lost_And_Found.Manager;
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
            if (lm.Username == "admin")
            {
                return RedirectToAction("Dashboard", "Admin");
            }
            else if (lm.Username == "user")
            {
                return RedirectToAction("Home", "User");
            }
            return View();
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
                long u_id = obj.AddUser(Rm);
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


        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Login");
        }
    }
}