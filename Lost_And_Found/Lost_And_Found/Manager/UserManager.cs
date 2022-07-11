using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        // add new post
        public long addpost(PostProductModel ppm)
        {
            try
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // select all items
        public List<ProductDataModel> selectitems()
        {
            try
            {
                var request = (from pd in db.Products
                               join u in db.App_User on pd.Postedby equals u.User_ID
                               join l in db.Lost_Product on pd.Product_ID equals l.Product_ID into lostpro
                               from lostproduct in lostpro.DefaultIfEmpty()
                               join f in db.Found_Product on pd.Product_ID equals f.Product_ID into foundpro
                               from foundproduct in foundpro.DefaultIfEmpty()
                               where (pd.Product_IsActive == true)
                               select new
                               {
                                   pd.Product_ID,
                                   pd.Product_Image,
                                   pd.Product_Name,
                                   pd.Product_Category,
                                   pd.Product_Location,
                                   pd.Product_Description,
                                   pd.Product_IsActive,
                                   u.User_FullName,
                                   u.User_Contact,
                                   lostproduct.Lost_Product_Status,
                                   foundproduct.Found_Product_Status
                               }).OrderByDescending(x => x.Product_ID).ToList();


                //var request = db.Products.Where(x => x.Product_IsActive == true).OrderByDescending(x => x.Product_ID).ToList();

                List<ProductDataModel> List = request.Select(x => new ProductDataModel
                {
                    Product_Id = x.Product_ID,
                    Product_Image = x.Product_Image,
                    Product_Name = x.Product_Name,
                    Product_Category = x.Product_Category,
                    Product_Location = x.Product_Location,
                    Product_Description = x.Product_Description,
                    Product_IsActive = x.Product_IsActive,
                    Name = x.User_FullName,
                    Contact = x.User_Contact,
                    Product_Lost_Status=x.Lost_Product_Status,
                    Product_Found_Status = x.Found_Product_Status
                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // all active posts
        public List<ProductDataModel> selectMyposts(long postedby)
        {
            try
            {
                var request = (from pd in db.Products
                               join u in db.App_User on pd.Postedby equals u.User_ID
                               join l in db.Lost_Product on pd.Product_ID equals l.Product_ID into lostpro
                               from lostproduct in lostpro.DefaultIfEmpty()
                               join f in db.Found_Product on pd.Product_ID equals f.Product_ID into foundpro
                               from foundproduct in foundpro.DefaultIfEmpty()
                               where (pd.Product_IsActive == true && pd.Postedby == postedby)
                               select new
                               {
                                   pd.Product_ID,
                                   pd.Product_Image,
                                   pd.Product_Name,
                                   pd.Product_Category,
                                   pd.Product_Location,
                                   pd.Product_Description,
                                   pd.Product_IsActive,
                                   u.User_FullName,
                                   u.User_Contact,
                                   lostproduct.Lost_Product_Status,
                                   foundproduct.Found_Product_Status
                               }).OrderByDescending(x => x.Product_ID).ToList();


                //var request = db.Products.Where(x => x.Product_IsActive == true && x.Postedby == postedby).OrderByDescending(x => x.Product_ID).ToList();

                List<ProductDataModel> List = request.Select(x => new ProductDataModel
                {
                    Product_Id = x.Product_ID,
                    Product_Image = x.Product_Image,
                    Product_Name = x.Product_Name,
                    Product_Category = x.Product_Category,
                    Product_Location = x.Product_Location,
                    Product_Description = x.Product_Description,
                    Product_IsActive = x.Product_IsActive,
                    Name = x.User_FullName,
                    Contact = x.User_Contact,
                    Product_Lost_Status=x.Lost_Product_Status,
                    Product_Found_Status = x.Found_Product_Status
                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // all deactivate posts
        public List<ProductDataModel> selectMyDeactiveposts(long postedby)
        {
            try
            {
                var request = (from pd in db.Products
                               join u in db.App_User on pd.Postedby equals u.User_ID
                               join l in db.Lost_Product on pd.Product_ID equals l.Product_ID into lostpro
                               from lostproduct in lostpro.DefaultIfEmpty()
                               join f in db.Found_Product on pd.Product_ID equals f.Product_ID into foundpro
                               from foundproduct in foundpro.DefaultIfEmpty()
                               where (pd.Product_IsActive == false && pd.Postedby == postedby)
                               select new
                               {
                                   pd.Product_ID,
                                   pd.Product_Image,
                                   pd.Product_Name,
                                   pd.Product_Category,
                                   pd.Product_Location,
                                   pd.Product_Description,
                                   pd.Product_IsActive,
                                   u.User_FullName,
                                   u.User_Contact,
                                   lostproduct.Lost_Product_Status,
                                   foundproduct.Found_Product_Status
                               }).OrderByDescending(x => x.Product_ID).ToList();

                //var request = db.Products.Where(x => x.Product_IsActive == false && x.Postedby == postedby).OrderByDescending(x => x.Product_ID).ToList();

                List<ProductDataModel> List = request.Select(x => new ProductDataModel
                {
                    Product_Id = x.Product_ID,
                    Product_Image = x.Product_Image,
                    Product_Name = x.Product_Name,
                    Product_Category = x.Product_Category,
                    Product_Location = x.Product_Location,
                    Product_Description = x.Product_Description,
                    Product_IsActive = x.Product_IsActive,
                    Name = x.User_FullName,
                    Contact = x.User_Contact,
                    Product_Lost_Status=x.Lost_Product_Status,
                    Product_Found_Status = x.Found_Product_Status
                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // deactivate post from user side
        public bool UpdatePostStatus(bool Status, int productid)
        {
            try
            {
                var result = db.Products.FirstOrDefault(x => x.Product_ID == productid);
                result.Product_IsActive = Status;
                db.Entry(result).State = EntityState.Modified;
                var check = db.SaveChanges();
                if (check > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //update my profile user side
        public bool UpdateUser(UserRegisterModel urm)
        {
            var result = false;
            try
            {
                if (urm.User_ID > 0)
                {
                    var User = db.App_User.SingleOrDefault(x => x.User_IsActive == true && x.User_ID == urm.User_ID);
                    User.User_FullName = urm.User_FullName;
                    User.User_Email = urm.User_Email;
                    User.User_Contact = urm.User_Contact;
                    User.User_Password = urm.User_Password;
                    User.User_DOB = urm.User_DOB;
                    User.User_Address = urm.User_Address;
                    User.User_Updated_ON = DateTime.Now;
                    User.User_Role = "User";
                    User.User_Gender = urm.User_Gender;

                    db.Entry(User).State = EntityState.Modified;

                    var check = db.SaveChanges();
                    if (check > 0) return true;
                    return false;
                }
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // post update work user side
        public bool UpdateMyPost(PostProductModel ppm)
        {
            var result = false;
            try
            {
                if (ppm.Product_Id > 0)
                {
                    var Product = db.Products.SingleOrDefault(x => x.Product_IsActive == true && x.Product_ID == ppm.Product_Id);
                    Product.Product_Name = ppm.Product_Name;
                    Product.Product_Location = ppm.Product_Location;
                    Product.Product_Category = ppm.Product_Category;
                    Product.Product_Description = ppm.Product_Description;
                    Product.Product_Created_ON = DateTime.Now;

                    db.Entry(Product).State = EntityState.Modified;

                    var check = db.SaveChanges();
                    if (check > 0) return true;
                    return false;
                }
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}