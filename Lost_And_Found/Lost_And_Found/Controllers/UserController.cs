using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lost_And_Found.Models;
using Lost_And_Found.Manager;
using System.IO;

namespace Lost_And_Found.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Home() 
        {
            return View();
        }

        public ActionResult PostProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PostProduct(PostProductModel ppm, HttpPostedFileBase ItemImage)
        {
            if (ModelState.IsValid)
            {
                if (ItemImage == null)
                {
                    TempData["Message"] = "Upload Item Picture !";
                    return View();
                }
                else
                {
                    if (Path.GetExtension(ItemImage.FileName) == ".jpg" || Path.GetExtension(ItemImage.FileName) == ".jpeg" || Path.GetExtension(ItemImage.FileName) == ".png")
                    {
                        string Filename = Path.GetFileNameWithoutExtension(ItemImage.FileName);
                        string Extension = Path.GetExtension(ItemImage.FileName);
                        Filename = Filename + DateTime.Now.ToString("yymmssfff") + Extension;
                        ppm.Product_Image = "~/ProjectData/" + Filename;
                        Filename = Path.Combine(Server.MapPath("~/ProjectData/"), Filename);
                        ItemImage.SaveAs(Filename);

                        UserManager obj = new UserManager();
                        ppm.Postedby = Convert.ToInt64(Session["User_ID"]);
                        ppm.Product_Created_On = DateTime.Now;
                        long u_id = obj.addpost(ppm);
                        if (u_id > 0)
                        {
                            TempData["Message"] = "User Created Successfuly and User Id is " + u_id;
                            return RedirectToAction("Home");
                        }

                        else
                        {
                            TempData["Message"] = "User Not Created !";
                        }
                    }
                    else
                    {
                        TempData["Message"] = "This is not Image file!";
                    }

                }
            }
            else
            {
                TempData["Message"] = "User Not Created Kindly Fill Complete Form !";
            }
            return View();
        }
    }
}