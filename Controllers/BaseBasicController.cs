using HrSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Controllers
{
    public class BaseBasicController : Controller
    {
        private static readonly Logger Baselogger = LogManager.GetCurrentClassLogger();

        public BaseBasicController()
        {
        }
        protected void AddErrorLog(Exception ex)
        {
            Baselogger.Error($"{Environment.NewLine}----------------- Date Of Exception: {DateTime.Now}  ------------------{Environment.NewLine}");
            Baselogger.Error(ex);
            Baselogger.Error("" + Environment.NewLine);
        }
        protected ViewResult RedirectToView(string view, object model)
        {
            var lang = GetDefaultLang();
            return View($"{lang}/{view}", model);
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
