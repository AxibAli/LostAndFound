using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lost_And_Found.Models;
using System.Data.Entity;

namespace Lost_And_Found.Manager
{
    public class LoginManager
    {
        LostandFoundEntities db = new LostandFoundEntities();

        // admin Login work
        public CreateAdminModel adminchecklogin(LoginModel logindata)
        {
            try
            {
                var data = db.App_Admin.Where
                (x => x.Admin_Email == logindata.Username ||
                 x.Admin_FullName == logindata.Username &&
                 x.Admin_Password == logindata.Password).FirstOrDefault();
                CreateAdminModel admindata = null;

                if (data != null)
                {
                    admindata = new CreateAdminModel()
                    {
                        Admin_FullName = data.Admin_FullName,
                        Admin_ID = data.Admin_ID,
                        Admin_Email = data.Admin_Email,
                        Admin_Role = data.Admin_Role,
                        Admin_Password = data.Admin_Password,
                        Admin_IsActive = data.Admin_IsActive
                    };
                }

                return admindata;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // user Login work
        public UserRegisterModel userchecklogin(LoginModel ld)
        {
            try
            {
                var user = db.App_User.Where
                   (x => x.User_Email == ld.Username ||
                    x.User_FullName == ld.Username &&
                    x.User_Password == ld.Password).FirstOrDefault();
                
                UserRegisterModel userdata = null;

                if (user != null)
                {
                    userdata = new UserRegisterModel()
                    {
                        User_FullName = user.User_FullName,
                        User_ID = user.User_ID,
                        User_Email = user.User_Email,
                        User_Role = user.User_Role,
                        User_Password = user.User_Password,
                        User_IsActive = user.User_IsActive
                    };
                }
                return userdata;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}