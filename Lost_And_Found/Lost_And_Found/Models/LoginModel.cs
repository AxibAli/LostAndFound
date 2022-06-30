using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lost_And_Found.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Kindly Enter a User Name?")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Kindly Enter a Password?")]
        [MinLength(8, ErrorMessage = "Password Should Be Minimum Of 8 Character")]
        public string Password { get; set; }

        public bool IsActive { get; set; }
    }
}