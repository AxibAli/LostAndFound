using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lost_And_Found.Filters
{
    public class AuthorizedUser : ActionFilterAttribute, IActionFilter
    {
        public string Roles { get; set; }

        public override void OnActionExecuting( ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["IsLogedIn"] == null)
            {
                filterContext.Result = new System.Web.Mvc.RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary
                {
                    
                    {"Controller", "Login"},
                    {"Action", "Login"}
                });

            }
            //else if (HttpContext.Current.Session["IsLogedIn"] != null && Roles == "User" )
            //{
            //    filterContext.Result = new System.Web.Mvc.RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary
            //    {

            //        {"Controller", "User"},
            //        {"Action", "Home"},
                    
            //    });
            //}
            //else if (HttpContext.Current.Session["IsLogedIn"] != null && Roles == "Admin")
            //{
            //    filterContext.Result = new System.Web.Mvc.RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary
            //    {

            //        {"Controller", "Admin"},
            //        {"Action", "Dashboard"},

            //    });
            //}
            base.OnActionExecuting(filterContext);
        }
    }
}