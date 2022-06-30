using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lost_And_Found.Models
{
    public class UserRegisterModel
    {
        [Required(ErrorMessage = "Kindly enter an User ID")]
        public long User_ID { get; set; }

        [Required(ErrorMessage = "Kindly Write a User's Full Name?")]
        public string User_FullName { get; set; }

        [Required(ErrorMessage = "Kindly Enter your Email")]
        public string User_Email { get; set; }

        [Required(ErrorMessage = "Kindly Select Admin Gender")]
        public string User_Gender { get; set; }

        public string User_Role { get; set; }

        [Required]
        [MaxLength(11, ErrorMessage = "Enter a valid Contact Format: 03##-#######")]
        [MinLength(11, ErrorMessage = "Enter a valid contact Format: 03##-#######")]
        public long User_Contact { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string User_Password { get; set; }

        [Required(ErrorMessage = "Kindly Enter Date of Birth?")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime User_DOB { get; set; }

        [Required(ErrorMessage = "Kindly Enter a Complete Address")]
        public string User_Address { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime User_Created_ON { get; set; }

        public DateTime User_Updated_ON { get; set; }

        [Required(ErrorMessage = "Kindly select if the user is active or not?")]
        public bool User_IsActive { get; set; }
    }
}