using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lost_And_Found.Models;
using Lost_And_Found.Manager;
using Lost_And_Found.Filters;

namespace Lost_And_Found.Controllers
{
    [AuthorizedUser]
    public class CategoryController : Controller
    {
        public ActionResult Mobile(ProductDataModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<ProductDataModel> mobilelist = obj.selectmobiles();
            return View(mobilelist);
        }

        public ActionResult Pets(ProductDataModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<ProductDataModel> petslist = obj.selectpets();
            return View(petslist);
        }

        public ActionResult Cars(ProductDataModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<ProductDataModel> carslist = obj.selectcars();
            return View(carslist);
        }

        public ActionResult Clothes_Shoes(ProductDataModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<ProductDataModel> cslist = obj.selectclothes_shoes();
            return View(cslist);
        }

        public ActionResult Bags(ProductDataModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<ProductDataModel> bagslist = obj.selectbags();
            return View(bagslist);
        }

        public ActionResult People(ProductDataModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<ProductDataModel> peoplelist = obj.selectpeople();
            return View(peoplelist);
        }

        public ActionResult Documents(ProductDataModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<ProductDataModel> docslist = obj.selectdocuments();
            return View(docslist);
        }

        public ActionResult Laptop(ProductDataModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<ProductDataModel> laptoplist = obj.selectlaptop();
            return View(laptoplist);
        }

        public ActionResult Jewellery(ProductDataModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<ProductDataModel> jewellerylist = obj.selectjewellery();
            return View(jewellerylist);
        }


        public ActionResult Keys(ProductDataModel ppm)
        {
            CategoryManager obj = new CategoryManager();
            List<ProductDataModel> keyslist = obj.selectKeys();
            return View(keyslist);
        }
    }
}