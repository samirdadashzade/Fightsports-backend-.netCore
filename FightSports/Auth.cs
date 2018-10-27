using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FightSports
{
    public class Auth:ActionFilterAttribute
    {
       
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //if (value == null)
            //{
            //    filterContext.Result = new RedirectResult("~/Admin/AdminLogEntrance/LogIn");
            //}

            base.OnActionExecuting(filterContext);
        }
    }
}
