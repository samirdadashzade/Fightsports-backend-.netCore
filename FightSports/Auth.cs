using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
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
            byte[] arr = null;
            var x = filterContext.HttpContext.Session.TryGetValue("id", out arr);

            if (arr == null)
            {
                filterContext.Result = new RedirectResult("Security/Login");
            }

            base.OnActionExecuting(filterContext);
        }
    }
}
