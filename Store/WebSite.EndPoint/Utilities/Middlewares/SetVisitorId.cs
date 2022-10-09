﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace WebSite.EndPoint.Utilities.Middlewares
{
    public class SetVisitorId
    {
        private readonly RequestDelegate _next;

        public SetVisitorId(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            string visitorId = httpContext.Request.Cookies["VisitorId"];
            if (visitorId == null)
            {
                visitorId = Guid.NewGuid().ToString();
                httpContext.Response.Cookies.Append("VisitorId", visitorId, new CookieOptions
                {
                    Path = "/",
                    HttpOnly = true,
                    Expires = DateTime.Now.AddYears(9),
                });

            }
            return _next(httpContext);

        }
    }

    public static class SetVisitorIdExtensions
    {
        public static IApplicationBuilder UseSetVisitorId(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SetVisitorId>();
        }
    }
}
