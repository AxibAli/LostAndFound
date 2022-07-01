using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lost_And_Found.Models
{
    public class AjaxResponseModel
    {
        public class AjaxResponse
        {
            public bool Response { get; set; }
            public string Message { get; set; }
        }
    }
}