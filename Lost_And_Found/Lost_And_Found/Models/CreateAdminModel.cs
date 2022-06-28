using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lost_And_Found.Models
{
    public class CreateAdminModel
    {
        public long Admin_ID { get; set; }
        public string Admin_FullName { get; set; }
        public System.DateTime Admin_DOB { get; set; }
        public string Admin_Gender { get; set; }
        public string Admin_Email { get; set; }
        public bool Gender { get; set; }
        public string Admin_Password { get; set; }
        public long Admin_Contact { get; set; }
        public string Admin_Role { get; set; }
        public System.DateTime Admin_Created_ON { get; set; }
        public int Admin_Created_By { get; set; }
        public System.DateTime Admin_Updated_ON { get; set; }
        public int Admin_Updated_By { get; set; }
        public bool Admin_IsActive { get; set; }
    }
}