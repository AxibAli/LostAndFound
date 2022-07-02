using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lost_And_Found.Models;

namespace Lost_And_Found.Manager
{
    public class UserManager
    {
        LostandFoundEntities db = new LostandFoundEntities();

        long postid = 0;
        public long addpost(PostProductModel ppm)
        {
            Product tblpro = new Product();
            tblpro.Product_ID = ppm.Product_Id;
            tblpro.Product_Image = ppm.Product_Image;
            tblpro.Product_Name = ppm.Product_Name;
            tblpro.Product_Description = ppm.Product_Description;
            tblpro.Product_Category = ppm.Product_Category;
            tblpro.Product_Location = ppm.Product_Location;
            tblpro.Product_Created_ON = ppm.Product_Created_On;
            tblpro.Postedby = ppm.Postedby;
            tblpro.Product_IsActive = true;

            db.Products.Add(tblpro);

            if (ppm.Product_Status == "Have you found the product?")
            {
                Found_Product tblfound = new Found_Product();
                tblfound.Product_ID = ppm.Product_Id;
                tblfound.Found_Product_Status = "Owner Not Found";
                db.Found_Product.Add(tblfound);
            }
            else if (ppm.Product_Status == "Have you lost the product?")
            {
                Lost_Product tbllost = new Lost_Product();
                tbllost.Product_ID = ppm.Product_Id;
                tbllost.Lost_Product_Status = "Still Not Found";
                db.Lost_Product.Add(tbllost);
            }

            db.SaveChanges();
            postid = tblpro.Product_ID;

            return postid;
        }


        public List<PostProductModel> selectitems()
        {
            var request = db.Products.Where(x => x.Product_IsActive == true).OrderByDescending(x => x.Product_ID).ToList();
            List<PostProductModel> List = request.Select(x => new PostProductModel
            {
                Product_Id = x.Product_ID,
                Product_Image = x.Product_Image,
                Product_Name = x.Product_Name,
                Product_Description = x.Product_Description,
            }).ToList();
            return List;

        }

        public List<PostProductModel> selectMyposts(long postedby)
        {
            var request = db.Products.Where(x => x.Product_IsActive == true && x.Postedby == postedby).OrderByDescending(x => x.Product_ID).ToList();
            List<PostProductModel> List = request.Select(x => new PostProductModel
            {
                Product_Id = x.Product_ID,
                Product_Image = x.Product_Image,
                Product_Name = x.Product_Name,
                Product_Description = x.Product_Description,
            }).ToList();
            return List;

        }
        
    }
}