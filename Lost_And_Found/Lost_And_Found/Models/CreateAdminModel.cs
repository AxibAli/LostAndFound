using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lost_And_Found.Models
{
    public class CreateAdminModel
    {
        [Required(ErrorMessage = "Kindly enter an Admin ID")]
        public long Admin_ID { get; set; }

        [Required(ErrorMessage = "Kindly enter Admin Full name")]
        public string Admin_FullName { get; set; }

        [Required(ErrorMessage = "Kindly Enter a Date of Birth?")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Admin_DOB { get; set; }

        [Required(ErrorMessage = "Kindly Select Admin Gender")]
        public string Admin_Gender { get; set; }

        [Required(ErrorMessage = "Kindly enter Admin Email")]
        public string Admin_Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Admin_Password { get; set; }

        [Required]
        [MaxLength(11, ErrorMessage = "Enter a valid Contact Format: 03##-#######")]
        [MinLength(11, ErrorMessage = "Enter a valid contact Format: 03##-#######")]
        public long Admin_Contact { get; set; }

        [Required(ErrorMessage = "Kindly Select a Role")]
        public string Admin_Role { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Admin_Created_ON { get; set; }

        [Required(ErrorMessage = "Kindly enter who created the admin?")]
        public int Admin_Created_By { get; set; }


        public DateTime Admin_Updated_ON { get; set; }
        public int Admin_Updated_By { get; set; }

        [Required(ErrorMessage = "Kindly select if the admin is active or not?")]
        public bool Admin_IsActive { get; set; }
    }
}