using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lost_And_Found.Models
{
    public class PostProductModel
    {
        [Required(ErrorMessage = "Kindly enter the Product name")]
        public string Product_Name { get; set; }

        [Required(ErrorMessage = "Kindly select the Product category")]
        public string Product_Category { get; set; }

        public string Product_Image { get; set; }

        [Required(ErrorMessage = "Kindly enter the Product description")]
        public string Product_Description { get; set; }

        [Required(ErrorMessage = "Kindly enter the Product location")]
        public string Product_Location { get; set; }

        [Required(ErrorMessage = "Kindly select the Product status")]
        public string Product_Status { get; set; }

        public bool Product_IsActive { get; set; }

        public long Product_Id { get; set; }

        public long Postedby { get; set; }

        public System.DateTime Product_Created_On { get; set; }
        public long Myposts { get; set; }

    }
}