﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lost_And_Found.Models
{
    public class MessageModel
    {
        public long Message_Id { get; set; }
        public long Product_Id { get; set; }
        public long Sent_By { get; set; }
        public DateTime Meassage_Date { get; set; }
        public string User_Message { get; set; }
        public string From {get; set;}
        public string Contact {get; set;}
    }
}