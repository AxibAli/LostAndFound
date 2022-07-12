using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lost_And_Found.Models;

namespace Lost_And_Found.Manager
{
    public class SearchManager
    {
        LostandFoundEntities db = new LostandFoundEntities();

        public List<ProductDataModel> selectsearchitems(string category, string description)
        {
            try
            {
                var request = (from pd in db.Products
                               join u in db.App_User on pd.Postedby equals u.User_ID
                               join l in db.Lost_Product on pd.Product_ID equals l.Product_ID into lostpro
                               from lostproduct in lostpro.DefaultIfEmpty()
                               join f in db.Found_Product on pd.Product_ID equals f.Product_ID into foundpro
                               from foundproduct in foundpro.DefaultIfEmpty()
                               where (pd.Product_IsActive == true && 
                               (pd.Product_Description.Contains(description) && pd.Product_Category == category))
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