using System;
using Lost_And_Found.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Lost_And_Found.Manager
{
    public class AdminManager
    {
        LostandFoundEntities db = new LostandFoundEntities();
        long adminid = 0;

        //create admin work
        public long AddAdmin(CreateAdminModel aid)
        {
            try
            {
                App_Admin tbladmin = new App_Admin();
                tbladmin.Admin_ID = aid.Admin_ID;
                tbladmin.Admin_FullName = aid.Admin_FullName;
                tbladmin.Admin_Gender = aid.Admin_Gender;
                tbladmin.Admin_DOB = aid.Admin_DOB;
                tbladmin.Admin_Email = aid.Admin_Email;
                tbladmin.Admin_Password = aid.Admin_Password;
                tbladmin.Admin_Role = aid.Admin_Role;
                tbladmin.Admin_Created_ON = aid.Admin_Created_ON;
                tbladmin.Admin_Created_By = aid.Admin_Created_By;
                tbladmin.Admin_Contact = aid.Admin_Contact;
                tbladmin.Admin_IsActive = aid.Admin_IsActive;
                db.App_Admin.Add(tbladmin);
                db.SaveChanges();

                adminid = tbladmin.Admin_ID;

                return adminid;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // get all user work for admin
        public List<UserRegisterModel> selectUser()
        {
            try
            {
                var request = db.App_User.ToList();
                List<UserRegisterModel> List = request.Select(x => new UserRegisterModel
                {
                    User_ID = x.User_ID,
                    User_FullName = x.User_FullName,
                    User_Email = x.User_Email,
                    User_Gender = x.User_Gender,
                    User_Contact = x.User_Contact,
                    User_Password = x.User_Password,
                    User_DOB = x.User_DOB,
                    User_Address = x.User_Address,
                    User_Created_ON = x.User_Created_ON,
                    User_IsActive = x.User_IsActive
                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // get all admin for admin
        public List<CreateAdminModel> selectAdmin()
        {
            try
            {
                var request = db.App_Admin.ToList();
                List<CreateAdminModel> List = request.Select(x => new CreateAdminModel
                {
                    Admin_ID = x.Admin_ID,
                    Admin_FullName = x.Admin_FullName,
                    Admin_Email = x.Admin_Email,
                    Admin_Gender = x.Admin_Gender,
                    Admin_Contact = x.Admin_Contact,
                    Admin_Password = x.Admin_Password,
                    Admin_DOB = x.Admin_DOB,
                    Admin_Created_ON = x.Admin_Created_ON,
                    Admin_Created_By = x.Admin_Created_By,
                    Admin_IsActive = x.Admin_IsActive
                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
            
        // activate and deactivate admin work
        public bool UpdateAdminStatus(bool Status, int adminid)
        {
            try
            {
                var result = db.App_Admin.FirstOrDefault(x => x.Admin_ID == adminid);
                result.Admin_IsActive = Status;
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

        // activate and deactivate post from admin side
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

        // select all post for admin work
        public List<ProductDataModel> selectitemsforadmins()
        {
            try
            {
                var request = (from pd in db.Products
                               join u in db.App_User on pd.Postedby equals u.User_ID
                               join l in db.Lost_Product on pd.Product_ID equals l.Product_ID into lostpro
                               from lostproduct in lostpro.DefaultIfEmpty()
                               join f in db.Found_Product on pd.Product_ID equals f.Product_ID into foundpro
                               from foundproduct in foundpro.DefaultIfEmpty()
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


                //var request = db.Products.OrderByDescending(x => x.Product_ID).ToList();

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

        // update admin profile
        public bool UpdateAdmin(CreateAdminModel crm)
        {
            var result = false;
            try
            {
                if (crm.Admin_ID > 0)
                {
                    var Admin = db.App_Admin.SingleOrDefault(x => x.Admin_IsActive == true && x.Admin_ID == crm.Admin_ID);
                    Admin.Admin_FullName = crm.Admin_FullName;
                    Admin.Admin_Email = crm.Admin_Email;
                    Admin.Admin_Contact = crm.Admin_Contact;
                    Admin.Admin_Password = crm.Admin_Password;
                    Admin.Admin_DOB = crm.Admin_DOB;
                    Admin.Admin_Updated_ON = DateTime.Now;
                    Admin.Admin_Role = "Admin";
                    Admin.Admin_Gender = crm.Admin_Gender;

                    db.Entry(Admin).State = EntityState.Modified;

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

