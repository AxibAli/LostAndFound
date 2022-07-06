using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lost_And_Found.Models
{
    public class MessageModel
    {
        public long Message_Id { get; set; }
        public long Product_Id { get; set; }
        public DateTime Meassage_Date { get; set; }
        public string Message { get; set; }

    }
}