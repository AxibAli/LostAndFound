using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lost_And_Found.Models
{
    public class UserRegisterModel
    {
        public long User_ID { get; set; }
        public string User_FullName { get; set; }
        public string User_Email { get; set; }
        public string User_Gender { get; set; }
        public long User_Contact { get; set; }
        public string User_Password { get; set; }
        public System.DateTime User_DOB { get; set; }
        public string User_Address { get; set; }
        public System.DateTime User_Created_ON { get; set; }
        public System.DateTime User_Updated_ON { get; set; }
        public bool User_IsActive { get; set; }
    }
}