using System;
using System.Linq;
using Lost_And_Found.Models;

namespace Lost_And_Found
{
    public class DashboardManager
    {
        LostandFoundEntities db = new LostandFoundEntities();

        // cards work for admin dashboard
        public DashboardModel Cards(DashboardModel dm)
        {
            try
            {
                dm.total_users = db.App_User.Count();
                dm.total_admins = db.App_Admin.Count();
                dm.total_post = db.Products.Count();
                dm.total_found_post = db.Found_Product.Count();
                dm.total_lost_post = db.Lost_Product.Count();
                dm.total_recovered_post = db.Products.Where(x=>x.Product_IsActive == false).Count();
                var act = db.App_Admin.Where(x => x.Admin_IsActive == true).Count();
                var deact = db.App_Admin.Where(x => x.Admin_IsActive == false).Count();

                dm.active_admins = act;
                dm.deactivated_admins = deact;

                return dm;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


