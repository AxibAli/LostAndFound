using Lost_And_Found.Filters;
using Lost_And_Found.Manager;
using Lost_And_Found.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace Lost_And_Found.Controllers
{
    [AuthorizedUser]
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
                            TempData["Message"] = "Your Item Posted Succefully ";
                            return RedirectToAction("Itemlisting");
                        }

                        else
                        {
                            TempData["Message"] = "Your Item Not Posted Check Again !";
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
                TempData["Message"] = "Kindly Fill Complete Form !";
            }
            return View();
        }


        public ActionResult ItemListing(PostProductModel ppm)
        {
            UserManager obj = new UserManager();
            List<PostProductModel> items = obj.selectitems();
            return View(items);
        }



    }
}