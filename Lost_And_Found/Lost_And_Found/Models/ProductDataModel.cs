using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lost_And_Found.Models
{
    public class ProductDataModel
    {
        public long Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Image { get; set; }
        public string Product_Category { get; set; }
        public string Product_Description { get; set; }
        public string Product_Location { get; set; }
        public string Product_Lost_Status { get; set; }
        public string Product_Found_Status { get; set; }
        public bool Product_IsActive { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
    }
}