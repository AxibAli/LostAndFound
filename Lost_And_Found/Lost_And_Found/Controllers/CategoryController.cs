using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lost_And_Found.Models;

namespace Lost_And_Found.Controllers
{
    public class CategoryController : Controller
    {
        public ActionResult Mobile(CategoryModel obj)
        {
            List<CategoryModel> lobj = new List<CategoryModel>();

            obj = new CategoryModel();
            obj.title = "Card Layout 1";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            obj = new CategoryModel();
            obj.title = "Card Layout 2";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            lobj.Add(obj);
            return View(lobj);
        }

        public ActionResult Pets(CategoryModel obj)
        {
            List<CategoryModel> lobj = new List<CategoryModel>();

            obj = new CategoryModel();
            obj.title = "Card Layout 1";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            obj = new CategoryModel();
            obj.title = "Card Layout 2";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            lobj.Add(obj);
            return View(lobj);
        }
        public ActionResult Cars(CategoryModel obj)
        {
            List<CategoryModel> lobj = new List<CategoryModel>();

            obj = new CategoryModel();
            obj.title = "Card Layout 1";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            obj = new CategoryModel();
            obj.title = "Card Layout 2";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            lobj.Add(obj);
            return View(lobj);
        }
        public ActionResult Clothes_Shoes(CategoryModel obj)
        {
            List<CategoryModel> lobj = new List<CategoryModel>();

            obj = new CategoryModel();
            obj.title = "Card Layout 1";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            obj = new CategoryModel();
            obj.title = "Card Layout 2";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            lobj.Add(obj);
            return View(lobj);
        }
        public ActionResult Bags(CategoryModel obj)
        {
            List<CategoryModel> lobj = new List<CategoryModel>();

            obj = new CategoryModel();
            obj.title = "Card Layout 1";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            obj = new CategoryModel();
            obj.title = "Card Layout 2";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            lobj.Add(obj);
            return View(lobj);
        }
        public ActionResult People(CategoryModel obj)
        {
            List<CategoryModel> lobj = new List<CategoryModel>();

            obj = new CategoryModel();
            obj.title = "Card Layout 1";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            obj = new CategoryModel();
            obj.title = "Card Layout 2";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            lobj.Add(obj);
            return View(lobj);
        }
        public ActionResult Documents(CategoryModel obj)
        {
            List<CategoryModel> lobj = new List<CategoryModel>();

            obj = new CategoryModel();
            obj.title = "Card Layout 1";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            obj = new CategoryModel();
            obj.title = "Card Layout 2";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            lobj.Add(obj);
            return View(lobj); ;
        }
        public ActionResult Laptop(CategoryModel obj)
        {
            List<CategoryModel> lobj = new List<CategoryModel>();

            obj = new CategoryModel();
            obj.title = "Card Layout 1";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            obj = new CategoryModel();
            obj.title = "Card Layout 2";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            lobj.Add(obj);
            return View(lobj);
        }
        public ActionResult Jewellery(CategoryModel obj)
        {
            List<CategoryModel> lobj = new List<CategoryModel>();

            obj = new CategoryModel();
            obj.title = "Card Layout 1";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            obj = new CategoryModel();
            obj.title = "Card Layout 2";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            lobj.Add(obj);
            return View(lobj);
        }
        public ActionResult Keys(CategoryModel obj)
        {
            List<CategoryModel> lobj = new List<CategoryModel>();

            obj = new CategoryModel();
            obj.title = "Card Layout 1";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            obj = new CategoryModel();
            obj.title = "Card Layout 2";
            obj.text = "Hello everyone this videos I want to show how to use card bootstrap 4 with data binding source.";
            obj.img = "https://library.kissclipart.com/20181214/xe/kissclipart-red-colour-clipart-mobile-phones-computer-icons-8910d5a4d3ffa5e2.png";
            lobj.Add(obj);

            lobj.Add(obj);
            return View(lobj);
        }
    }
}