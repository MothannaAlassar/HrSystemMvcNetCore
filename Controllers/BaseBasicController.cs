using HrSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Controllers
{
    public class BaseBasicController : Controller
    {
       

        public BaseBasicController()
        {
        }

        protected void AddCookie(string key,string value)
        {
            // Create a cookie
            var cookieOptions = new CookieOptions
            {
                Expires = DateTimeOffset.UtcNow.AddDays(7), // Set cookie expiration
                HttpOnly = true, // Prevent JavaScript access
                Secure = true, // Send cookie only over HTTPS
                SameSite = SameSiteMode.Strict // Enhance CSRF protection
            };

            // Add the cookie
            Response.Cookies.Append(key, value, cookieOptions);
        }
        protected string GetCookie(string key,string defaultVal="")
        {
            if (Request.Cookies.TryGetValue(key, out var cookieValue))
            {
                return cookieValue;
            }
            else
            {
                return defaultVal;
            }
        }
        protected string GetDefaultLang()
        {
            string rtv = GetCookie("AppLanguage", "en");
            return rtv;
        }
    }
}
