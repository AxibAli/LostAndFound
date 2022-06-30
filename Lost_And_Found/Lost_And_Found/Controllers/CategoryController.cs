using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lost_And_Found.Models;
using Lost_And_Found.Manager;

namespace Lost_And_Found.Controllers
{
    public class CategoryController : Controller
    {
        public ActionResult Mobile(PostProductModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<PostProductModel> mobilelist = obj.selectmobiles();
            return View(mobilelist);
        }

        public ActionResult Pets(PostProductModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<PostProductModel> petslist = obj.selectpets();
            return View(petslist);
        }

        public ActionResult Cars(PostProductModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<PostProductModel> carslist = obj.selectcars();
            return View(carslist);
        }

        public ActionResult Clothes_Shoes(PostProductModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<PostProductModel> cslist = obj.selectclothes_shoes();
            return View(cslist);
        }

        public ActionResult Bags(PostProductModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<PostProductModel> bagslist = obj.selectbags();
            return View(bagslist);
        }

        public ActionResult People(PostProductModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<PostProductModel> peoplelist = obj.selectpeople();
            return View(peoplelist);
        }

        public ActionResult Documents(PostProductModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<PostProductModel> docslist = obj.selectdocuments();
            return View(docslist);
        }

        public ActionResult Laptop(PostProductModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<PostProductModel> laptoplist = obj.selectlaptop();
            return View(laptoplist);
        }

        public ActionResult Jewellery(PostProductModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<PostProductModel> jewellerylist = obj.selectjewellery();
            return View(jewellerylist);
        }


        public ActionResult Keys(PostProductModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<PostProductModel> keyslist = obj.selectKeys();
            return View(keyslist);
        }
    }
}