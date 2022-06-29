using System;
using Lost_And_Found.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lost_And_Found.Manager
{
    public class AdminManager
    {
        long adminid = 0;
        public long AddAdmin( CreateAdminModel aid)
        {
            using (LostandFoundEntities db = new LostandFoundEntities())
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
                tbladmin.Admin_Created_By = 0;
                tbladmin.Admin_Updated_ON = aid.Admin_Updated_ON;
                tbladmin.Admin_Updated_By = aid.Admin_Updated_By;
                tbladmin.Admin_Contact = aid.Admin_Contact;
                tbladmin.Admin_IsActive = true;
                db.App_Admin.Add(tbladmin);
                db.SaveChanges();

                adminid = tbladmin.Admin_ID;
            }
            return adminid;

        }

        public List<UserRegisterModel> selectUser()
        {
            using (LostandFoundEntities db = new LostandFoundEntities())
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
                    User_Updated_ON = x.User_Updated_ON,
                    User_IsActive = x.User_IsActive
                }).ToList();
                return List;
            }
        }


        public List<CreateAdminModel> selectAdmin()
        {
            using (LostandFoundEntities db = new LostandFoundEntities())
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
                    Admin_Updated_By = x.Admin_Updated_By.Value,
                    Admin_Updated_ON = x.Admin_Updated_ON.Value,
                    Admin_Created_By = x.Admin_Created_By,
                    Admin_IsActive = x.Admin_IsActive
                }).ToList();
                return List;
            }
        }
    }
}