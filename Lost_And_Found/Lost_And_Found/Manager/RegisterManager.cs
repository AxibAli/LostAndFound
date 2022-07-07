using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lost_And_Found.Models;
using System.Data.Entity;

namespace Lost_And_Found.Manager
{
    public class RegisterManager
    {
        LostandFoundEntities db = new LostandFoundEntities();
        long userid = 0;

        // register new user work
        public long AddUser(UserRegisterModel uid)
        {
            try
            {
                App_User tbluser = new App_User();
                tbluser.User_ID = uid.User_ID;
                tbluser.User_FullName = uid.User_FullName;
                tbluser.User_Email = uid.User_Email;
                tbluser.User_Gender = uid.User_Gender;
                tbluser.User_Contact = uid.User_Contact;
                tbluser.User_Password = uid.User_Password;
                tbluser.User_Role = uid.User_Role;
                tbluser.User_DOB = uid.User_DOB;
                tbluser.User_Address = uid.User_Address;
                tbluser.User_Created_ON = uid.User_Created_ON;
                tbluser.User_IsActive = uid.User_IsActive;
                db.App_User.Add(tbluser);
                db.SaveChanges();

                userid = tbluser.User_ID;

                return userid;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}