using Lost_And_Found.Filters;
using Lost_And_Found.Manager;
using Lost_And_Found.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lost_And_Found.Controllers
{
    [AuthorizedUser]
    public class UserController : Controller
    {
        LostandFoundEntities db = new LostandFoundEntities();
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

        public ActionResult MyPosts(long postedby)
        {
            UserManager obj = new UserManager();
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

        public ActionResult MyDeactivePosts(long postedby)
        {
            UserManager obj = new UserManager();
            List<PostProductModel> posts = obj.selectMyDeactiveposts(postedby);
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

        [HttpPost]
        public ActionResult UpdatePostStatus(bool Status, int productid) 
        {
            UserManager obj = new UserManager();
            var response = obj.UpdatePostStatus(Status, productid);

            return Json(response, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetUserById(int User_ID)
        {
            
            App_User model = db.App_User.Where(x => x.User_ID == User_ID).SingleOrDefault();
            string value = string.Empty;
            value = JsonConvert.SerializeObject(model, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public JsonResult UpdateDataInDatabase(UserRegisterModel model)
        {
            var result = false;
            try
            {
                if (model.User_ID > 0)
                {
                    App_User User = db.App_User.SingleOrDefault(x => x.User_IsActive == true && x.User_ID == model.User_ID);
                    User.User_FullName = model.User_FullName;
                    User.User_Email = model.User_Email;
                    User.User_Contact = model.User_Contact;
                    User.User_Password = model.User_Password;
                    User.User_DOB = model.User_DOB;
                    User.User_Address = model.User_Address;
                    User.User_Updated_ON = DateTime.Now;
                    User.User_Gender = model.User_Gender;
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