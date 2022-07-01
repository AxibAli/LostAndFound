using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lost_And_Found.Models
{
    public class DashboardModel
    {
        public string List { get; set; }
        public int total_users { get; set; }
        public int total_admins { get; set; }
        public int total_post { get; set; }
        public int total_found_post { get; set; }
        public int total_lost_post { get; set; }
        public int total_recovered_post { get; set; }
        public int active_admins { get; set; }
        public int deactivated_admins { get; set; }
    }
}