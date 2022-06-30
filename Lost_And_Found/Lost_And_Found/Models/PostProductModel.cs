using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lost_And_Found.Models
{
    public class PostProductModel
    {
        public string Product_Name { get; set; }
        public string Product_Category { get; set; }
        public string Product_Image { get; set; }
        public string Product_Description { get; set; }
        public string Product_Location { get; set; }
        public string Product_Status { get; set; }
        public bool Product_IsActive { get; set; }
        public long Product_Id { get; set; }
        public long Postedby { get; set; }
        public DateTime Product_Created_On { get; set; }

    }
}