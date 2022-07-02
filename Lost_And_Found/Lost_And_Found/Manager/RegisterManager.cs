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
        public long AddUser(UserRegisterModel uid)
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

        ////public bool UpdateUserStatus(bool Status, int userId)
        ////{
        ////    using (LostandFoundEntities1 db = new LostandFoundEntities1())
        ////    {
        ////        try
        ////        {
        ////            var result = db.App_User.FirstOrDefault(x => x.User_ID == userId);
        ////            result.User_IsActive = Status;
        ////            db.Entry(result).State = EntityState.Modified;
        ////            var check = db.SaveChanges();
        ////            if (check > 0) return true;
        ////            return false;
        ////        }
        ////        catch (Exception)
        ////        {
        ////            return false;
        ////        }

        ////    }
        ////}


        //    public UserRegisterModel GetUser(int uid)
        //{
        //    using (LostandFoundEntities1 db = new LostandFoundEntities1())
        //    {
        //        var request = db.App_User.Where(x => x.User_ID == uid).FirstOrDefault();
        //        UserRegisterModel User = null;
        //        if (request != null)
        //        {
        //            User = new UserRegisterModel()
        //            {
        //                User_ID = request.User_ID,
        //                User_FullName = request.User_FullName,
        //                User_Email = request.User_Email,
        //                User_Gender = request.User_Gender,
        //                User_Contact = request.User_Contact,
        //                User_Password = request.User_Password,
        //                User_DOB = request.User_DOB,
        //                User_Address = request.User_Address,
        //            };
        //            return User;
        //        }

        //        else
        //        {
        //            return User;
        //        }
        //    }
        //}

        //public bool UpdateUser(UserRegisterModel uid)
        //{
        //    using (LostandFoundEntities1 db = new LostandFoundEntities1())
        //    {
        //        var Data = db.App_User.Where(x => x.User_ID == uid.User_ID).FirstOrDefault();
        //        if (Data != null)
        //        {
        //            Data.User_ID = uid.User_ID;
        //            Data.User_FullName = uid.User_FullName;
        //            Data.User_Email = uid.User_Email;
        //            Data.User_Gender = uid.User_Gender;
        //            Data.User_Contact = uid.User_Contact;
        //            Data.User_Password = uid.User_Password;
        //            Data.User_DOB = uid.User_DOB;
        //            Data.User_Address = uid.User_Address;
        //            Data.User_Created_ON = uid.User_Created_ON;
        //            Data.User_Updated_ON = uid.User_Updated_ON;
        //            db.Entry(Data).State = EntityState.Modified;
        //            db.SaveChanges();
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}

    }
}