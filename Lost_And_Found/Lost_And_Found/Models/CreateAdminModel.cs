using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lost_And_Found.Models
{
    public class CreateAdminModel
    {
        public long Admin_ID { get; set; }

        [Required(ErrorMessage = "Kindly enter Admin Full name")]
        public string Admin_FullName { get; set; }

        [Required(ErrorMessage = "Kindly enter a Date of Birth?")]
        public DateTime Admin_DOB { get; set; }

        public string Admin_Gender { get; set; }

        [Required(ErrorMessage = "Kindly enter Admin Email")]
        public string Admin_Email { get; set; }

        [Required(ErrorMessage = "Kindly enter Password")]
        public string Admin_Password { get; set; }

        [Required(ErrorMessage = "Kindly enter Contatct No")]
        [MaxLength(11, ErrorMessage = "Enter a valid Contact Format: 03##-#######")]
        [MinLength(11, ErrorMessage = "Enter a valid contact Format: 03##-#######")]
        public string Admin_Contact { get; set; }

        [Required(ErrorMessage = "Kindly Select a Role")]
        public string Admin_Role { get; set; }
        public DateTime Admin_Created_ON { get; set; }
        public int Admin_Created_By { get; set; }
        public DateTime Admin_Updated_ON { get; set; }
        public int Admin_Updated_By { get; set; }
        public bool Admin_IsActive { get; set; }
    }
}