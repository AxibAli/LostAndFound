using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lost_And_Found.Models;

namespace Lost_And_Found.Manager
{
    public class CategoryManager
    {
        LostandFoundEntities db = new LostandFoundEntities();

        public List<PostProductModel> selectmobiles()
        {
            var request = db.Products.Where(x=>x.Product_Category=="Mobile" && x.Product_IsActive==true).ToList();
            List<PostProductModel> List = request.Select(x => new PostProductModel
            {
                Product_Id = x.Product_ID,
                Product_Image = x.Product_Image,
                Product_Name = x.Product_Name,
            }).ToList();
            return List;

        }
        public List<PostProductModel> selectbags()
        {
            var request = db.Products.Where(x => x.Product_Category == "Bags" && x.Product_IsActive == true).ToList();
            List<PostProductModel> List = request.Select(x => new PostProductModel
            {
                Product_Id = x.Product_ID,
                Product_Image = x.Product_Image,
                Product_Name = x.Product_Name,
            }).ToList();
            return List;

        }

        public List<PostProductModel> selectcars()
        {
            var request = db.Products.Where(x => x.Product_Category == "Cars" && x.Product_IsActive == true).ToList();
            List<PostProductModel> List = request.Select(x => new PostProductModel
            {
                Product_Id = x.Product_ID,
                Product_Image = x.Product_Image,
                Product_Name = x.Product_Name,
            }).ToList();
            return List;

        }


        public List<PostProductModel> selectclothes_shoes()
        {
            var request = db.Products.Where(x => x.Product_Category == "Clothes_Shoes" && x.Product_IsActive == true).ToList();
            List<PostProductModel> List = request.Select(x => new PostProductModel
            {
                Product_Id = x.Product_ID,
                Product_Image = x.Product_Image,
                Product_Name = x.Product_Name,
            }).ToList();
            return List;

        }

        public List<PostProductModel> selectdocuments()
        {
            var request = db.Products.Where(x => x.Product_Category == "Documents" && x.Product_IsActive == true).ToList();
            List<PostProductModel> List = request.Select(x => new PostProductModel
            {
                Product_Id = x.Product_ID,
                Product_Image = x.Product_Image,
                Product_Name = x.Product_Name,
            }).ToList();
            return List;

        }

        public List<PostProductModel> selectjewellery()
        {
            var request = db.Products.Where(x => x.Product_Category == "Jewellery" && x.Product_IsActive == true).ToList();
            List<PostProductModel> List = request.Select(x => new PostProductModel
            {
                Product_Id = x.Product_ID,
                Product_Image = x.Product_Image,
                Product_Name = x.Product_Name,
            }).ToList();
            return List;

        }

        public List<PostProductModel> selectKeys()
        {
            var request = db.Products.Where(x => x.Product_Category == "Keys" && x.Product_IsActive == true).ToList();
            List<PostProductModel> List = request.Select(x => new PostProductModel
            {
                Product_Id = x.Product_ID,
                Product_Image = x.Product_Image,
                Product_Name = x.Product_Name,
            }).ToList();
            return List;

        }

        public List<PostProductModel> selectlaptop()
        {
            var request = db.Products.Where(x => x.Product_Category == "Laptop" && x.Product_IsActive == true).ToList();
            List<PostProductModel> List = request.Select(x => new PostProductModel
            {
                Product_Id = x.Product_ID,
                Product_Image = x.Product_Image,
                Product_Name = x.Product_Name,
            }).ToList();
            return List;

        }

        public List<PostProductModel> selectpeople()
        {
            var request = db.Products.Where(x => x.Product_Category == "People" && x.Product_IsActive == true).ToList();
            List<PostProductModel> List = request.Select(x => new PostProductModel
            {
                Product_Id = x.Product_ID,
                Product_Image = x.Product_Image,
                Product_Name = x.Product_Name,
            }).ToList();
            return List;

        }

        public List<PostProductModel> selectpets()
        {
            var request = db.Products.Where(x => x.Product_Category == "Pets" && x.Product_IsActive == true).ToList();
            List<PostProductModel> List = request.Select(x => new PostProductModel
            {
                Product_Id = x.Product_ID,
                Product_Image = x.Product_Image,
                Product_Name = x.Product_Name,
            }).ToList();
            return List;

        }


    }
}