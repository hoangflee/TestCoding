using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Movies.Entities;
using System.Net;

namespace Movies.Extensions
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AppAuthorize : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // Authorization
            var users = (Users)context.HttpContext.Items["User"];
            if (users == null)
                context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = (int)HttpStatusCode.Unauthorized };
        }
    }
}
