using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lost_And_Found.Models
{
    public class UserRegisterModel
    {
        public long User_ID { get; set; }

        [Required(ErrorMessage = "Kindly Write a User's Full Name?")]
        public string User_FullName { get; set; }

        [Required(ErrorMessage = "Kindly Enter your Email")]
        public string User_Email { get; set; }

        [Required(ErrorMessage = "Kindly Select your Gender")]
        public string User_Gender { get; set; }
        public string User_Role { get; set; }

        [Required(ErrorMessage = "Kindly Enter your Contact")]
        [MaxLength(11, ErrorMessage = "Enter a valid Contact Format: 03##-#######")]
        [MinLength(11, ErrorMessage = "Enter a valid contact Format: 03##-#######")]
        public string User_Contact { get; set; }

        [Required(ErrorMessage = "Kindly Enter your Password")]
        public string User_Password { get; set; }

        [Required(ErrorMessage = "Kindly Enter Date of Birth?")]
        public DateTime User_DOB { get; set; }

        [Required(ErrorMessage = "Kindly Enter a Complete Address")]
        public string User_Address { get; set; }
        public DateTime User_Created_ON { get; set; }
        public DateTime User_Updated_ON { get; set; }
        public bool User_IsActive { get; set; }
    }
}