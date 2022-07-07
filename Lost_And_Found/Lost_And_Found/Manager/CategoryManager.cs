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

        // mobiles category
        public List<PostProductModel> selectmobiles()
        {
            try
            {
                var request = db.Products.Where(x => x.Product_Category == "Mobile" && x.Product_IsActive == true).ToList();
                List<PostProductModel> List = request.Select(x => new PostProductModel
                {
                    Product_Id = x.Product_ID,
                    Product_Image = x.Product_Image,
                    Product_Name = x.Product_Name,
                    Product_Description = x.Product_Description
                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // bags category
        public List<PostProductModel> selectbags()
        {
            try
            {
                var request = db.Products.Where(x => x.Product_Category == "Bags" && x.Product_IsActive == true).ToList();
                List<PostProductModel> List = request.Select(x => new PostProductModel
                {
                    Product_Id = x.Product_ID,
                    Product_Image = x.Product_Image,
                    Product_Name = x.Product_Name,
                    Product_Description = x.Product_Description

                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // cars category
        public List<PostProductModel> selectcars()
        {
            try
            {
                var request = db.Products.Where(x => x.Product_Category == "Cars" && x.Product_IsActive == true).ToList();
                List<PostProductModel> List = request.Select(x => new PostProductModel
                {
                    Product_Id = x.Product_ID,
                    Product_Image = x.Product_Image,
                    Product_Name = x.Product_Name,
                    Product_Description = x.Product_Description

                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // clothees and shoes category
        public List<PostProductModel> selectclothes_shoes()
        {
            try
            {
                var request = db.Products.Where(x => x.Product_Category == "Clothes_Shoes" && x.Product_IsActive == true).ToList();
                List<PostProductModel> List = request.Select(x => new PostProductModel
                {
                    Product_Id = x.Product_ID,
                    Product_Image = x.Product_Image,
                    Product_Name = x.Product_Name,
                    Product_Description = x.Product_Description

                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // documents category
        public List<PostProductModel> selectdocuments()
        {
            try
            {
                var request = db.Products.Where(x => x.Product_Category == "Documents" && x.Product_IsActive == true).ToList();
                List<PostProductModel> List = request.Select(x => new PostProductModel
                {
                    Product_Id = x.Product_ID,
                    Product_Image = x.Product_Image,
                    Product_Name = x.Product_Name,
                    Product_Description = x.Product_Description

                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Jewellery category
        public List<PostProductModel> selectjewellery()
        {
            try
            {
                var request = db.Products.Where(x => x.Product_Category == "Jewellery" && x.Product_IsActive == true).ToList();
                List<PostProductModel> List = request.Select(x => new PostProductModel
                {
                    Product_Id = x.Product_ID,
                    Product_Image = x.Product_Image,
                    Product_Name = x.Product_Name,
                    Product_Description = x.Product_Description

                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // keys category
        public List<PostProductModel> selectKeys()
        {
            try
            {
                var request = db.Products.Where(x => x.Product_Category == "Keys" && x.Product_IsActive == true).ToList();
                List<PostProductModel> List = request.Select(x => new PostProductModel
                {
                    Product_Id = x.Product_ID,
                    Product_Image = x.Product_Image,
                    Product_Name = x.Product_Name,
                    Product_Description = x.Product_Description

                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // laptop category
        public List<PostProductModel> selectlaptop()
        {
            try
            {
                var request = db.Products.Where(x => x.Product_Category == "Laptop" && x.Product_IsActive == true).ToList();
                List<PostProductModel> List = request.Select(x => new PostProductModel
                {
                    Product_Id = x.Product_ID,
                    Product_Image = x.Product_Image,
                    Product_Name = x.Product_Name,
                    Product_Description = x.Product_Description

                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // people category
        public List<PostProductModel> selectpeople()
        {
            try
            {
                var request = db.Products.Where(x => x.Product_Category == "People" && x.Product_IsActive == true).ToList();
                List<PostProductModel> List = request.Select(x => new PostProductModel
                {
                    Product_Id = x.Product_ID,
                    Product_Image = x.Product_Image,
                    Product_Name = x.Product_Name,
                    Product_Description = x.Product_Description

                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // pets category
        public List<PostProductModel> selectpets()
        {
            try
            {
                var request = db.Products.Where(x => x.Product_Category == "Pets" && x.Product_IsActive == true).ToList();
                List<PostProductModel> List = request.Select(x => new PostProductModel
                {
                    Product_Id = x.Product_ID,
                    Product_Image = x.Product_Image,
                    Product_Name = x.Product_Name,
                    Product_Description = x.Product_Description

                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}