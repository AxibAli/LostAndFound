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
        public List<ProductDataModel> selectmobiles()
        {
            try
            {
                var request = (from pd in db.Products
                               join u in db.App_User on pd.Postedby equals u.User_ID
                               join l in db.Lost_Product on pd.Product_ID equals l.Product_ID into lostpro
                               from lostproduct in lostpro.DefaultIfEmpty()
                               join f in db.Found_Product on pd.Product_ID equals f.Product_ID into foundpro
                               from foundproduct in foundpro.DefaultIfEmpty()
                               where (pd.Product_Category == "Mobile" && pd.Product_IsActive == true)
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

                //var request = db.Products.Where(x => x.Product_Category == "Mobile" && x.Product_IsActive == true).ToList();

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
                    Product_Lost_Status = x.Lost_Product_Status,
                    Product_Found_Status = x.Found_Product_Status
                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // bags category
        public List<ProductDataModel> selectbags()
        {
            try
            {
                var request = (from pd in db.Products
                               join u in db.App_User on pd.Postedby equals u.User_ID
                               join l in db.Lost_Product on pd.Product_ID equals l.Product_ID into lostpro
                               from lostproduct in lostpro.DefaultIfEmpty()
                               join f in db.Found_Product on pd.Product_ID equals f.Product_ID into foundpro
                               from foundproduct in foundpro.DefaultIfEmpty()
                               where (pd.Product_Category == "Bags" && pd.Product_IsActive == true)
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

                //var request = db.Products.Where(x => x.Product_Category == "Bags" && x.Product_IsActive == true).ToList();

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
                    Product_Lost_Status = x.Lost_Product_Status,
                    Product_Found_Status = x.Found_Product_Status
                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // cars category
        public List<ProductDataModel> selectcars()
        {
            try
            {
                var request = (from pd in db.Products
                               join u in db.App_User on pd.Postedby equals u.User_ID
                               join l in db.Lost_Product on pd.Product_ID equals l.Product_ID into lostpro
                               from lostproduct in lostpro.DefaultIfEmpty()
                               join f in db.Found_Product on pd.Product_ID equals f.Product_ID into foundpro
                               from foundproduct in foundpro.DefaultIfEmpty()
                               where (pd.Product_Category == "Cars" && pd.Product_IsActive == true)
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

                //var request = db.Products.Where(x => x.Product_Category == "Cars" && x.Product_IsActive == true).ToList();

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
                    Product_Lost_Status = x.Lost_Product_Status,
                    Product_Found_Status = x.Found_Product_Status
                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // clothees and shoes category
        public List<ProductDataModel> selectclothes_shoes()
        {
            try
            {
                var request = (from pd in db.Products
                               join u in db.App_User on pd.Postedby equals u.User_ID
                               join l in db.Lost_Product on pd.Product_ID equals l.Product_ID into lostpro
                               from lostproduct in lostpro.DefaultIfEmpty()
                               join f in db.Found_Product on pd.Product_ID equals f.Product_ID into foundpro
                               from foundproduct in foundpro.DefaultIfEmpty()
                               where (pd.Product_Category == "Clothes_Shoes" && pd.Product_IsActive == true)
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

                //var request = db.Products.Where(x => x.Product_Category == "Clothes_Shoes" && x.Product_IsActive == true).ToList();

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
                    Product_Lost_Status = x.Lost_Product_Status,
                    Product_Found_Status = x.Found_Product_Status
                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // documents category
        public List<ProductDataModel> selectdocuments()
        {
            try
            {
                var request = (from pd in db.Products
                               join u in db.App_User on pd.Postedby equals u.User_ID
                               join l in db.Lost_Product on pd.Product_ID equals l.Product_ID into lostpro
                               from lostproduct in lostpro.DefaultIfEmpty()
                               join f in db.Found_Product on pd.Product_ID equals f.Product_ID into foundpro
                               from foundproduct in foundpro.DefaultIfEmpty()
                               where (pd.Product_Category == "Documents" && pd.Product_IsActive == true)
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

                //var request = db.Products.Where(x => x.Product_Category == "Documents" && x.Product_IsActive == true).ToList();

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
                    Product_Lost_Status = x.Lost_Product_Status,
                    Product_Found_Status = x.Found_Product_Status
                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Jewellery category
        public List<ProductDataModel> selectjewellery()
        {
            try
            {
                var request = (from pd in db.Products
                               join u in db.App_User on pd.Postedby equals u.User_ID
                               join l in db.Lost_Product on pd.Product_ID equals l.Product_ID into lostpro
                               from lostproduct in lostpro.DefaultIfEmpty()
                               join f in db.Found_Product on pd.Product_ID equals f.Product_ID into foundpro
                               from foundproduct in foundpro.DefaultIfEmpty()
                               where (pd.Product_Category == "Jewellery" && pd.Product_IsActive == true)
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


                //var request = db.Products.Where(x => x.Product_Category == "Jewellery" && x.Product_IsActive == true).ToList();

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
                    Product_Lost_Status = x.Lost_Product_Status,
                    Product_Found_Status = x.Found_Product_Status
                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // keys category
        public List<ProductDataModel> selectKeys()
        {
            try
            {
                var request = (from pd in db.Products
                               join u in db.App_User on pd.Postedby equals u.User_ID
                               join l in db.Lost_Product on pd.Product_ID equals l.Product_ID into lostpro
                               from lostproduct in lostpro.DefaultIfEmpty()
                               join f in db.Found_Product on pd.Product_ID equals f.Product_ID into foundpro
                               from foundproduct in foundpro.DefaultIfEmpty()
                               where (pd.Product_Category == "Keys" && pd.Product_IsActive == true)
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


                // var request = db.Products.Where(x => x.Product_Category == "Keys" && x.Product_IsActive == true).ToList();
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
                    Product_Lost_Status = x.Lost_Product_Status,
                    Product_Found_Status = x.Found_Product_Status
                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // laptop category
        public List<ProductDataModel> selectlaptop()
        {
            try
            {
                var request = (from pd in db.Products
                               join u in db.App_User on pd.Postedby equals u.User_ID
                               join l in db.Lost_Product on pd.Product_ID equals l.Product_ID into lostpro
                               from lostproduct in lostpro.DefaultIfEmpty()
                               join f in db.Found_Product on pd.Product_ID equals f.Product_ID into foundpro
                               from foundproduct in foundpro.DefaultIfEmpty()
                               where (pd.Product_Category == "Laptop" && pd.Product_IsActive == true)
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


                //var request = db.Products.Where(x => x.Product_Category == "Laptop" && x.Product_IsActive == true).ToList();

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
                    Product_Lost_Status = x.Lost_Product_Status,
                    Product_Found_Status = x.Found_Product_Status
                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // people category
        public List<ProductDataModel> selectpeople()
        {
            try
            {
                var request = (from pd in db.Products
                               join u in db.App_User on pd.Postedby equals u.User_ID
                               join l in db.Lost_Product on pd.Product_ID equals l.Product_ID into lostpro
                               from lostproduct in lostpro.DefaultIfEmpty()
                               join f in db.Found_Product on pd.Product_ID equals f.Product_ID into foundpro
                               from foundproduct in foundpro.DefaultIfEmpty()
                               where (pd.Product_Category == "People" && pd.Product_IsActive == true)
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


                //var request = db.Products.Where(x => x.Product_Category == "People" && x.Product_IsActive == true).ToList();
                
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
                    Product_Lost_Status = x.Lost_Product_Status,
                    Product_Found_Status = x.Found_Product_Status
                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // pets category
        public List<ProductDataModel> selectpets()
        {
            try
            {
                var request = (from pd in db.Products
                               join u in db.App_User on pd.Postedby equals u.User_ID
                               join l in db.Lost_Product on pd.Product_ID equals l.Product_ID into lostpro
                               from lostproduct in lostpro.DefaultIfEmpty()
                               join f in db.Found_Product on pd.Product_ID equals f.Product_ID into foundpro
                               from foundproduct in foundpro.DefaultIfEmpty()
                               where (pd.Product_Category == "Pets" && pd.Product_IsActive == true)
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


                //var request = db.Products.Where(x => x.Product_Category == "Pets" && x.Product_IsActive == true).ToList();

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
                    Product_Lost_Status = x.Lost_Product_Status,
                    Product_Found_Status = x.Found_Product_Status
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