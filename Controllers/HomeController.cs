using HrSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Controllers
{
    public class HomeController : BaseBasicController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var lang = GetDefaultLang();
            return View($"{lang}/Index");
        }

        public IActionResult Privacy()
        {
            var lang = GetDefaultLang();
            return View($"{lang}/Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult changeLanguage(string url, string lang = "ar")
        {
            try
            {
                string currentUrl = url;
                if (!currentUrl.StartsWith("/"))
                    currentUrl = "/" + currentUrl;

                var rtv = new ChangeLangViewModel();
                AddCookie("AppLanguage", lang);
                // Check if the properties are null or empty and set default values
                if (string.IsNullOrEmpty(rtv.url_ar))
                    rtv.url_ar = "/";
                if (string.IsNullOrEmpty(rtv.url_en))
                    rtv.url_en = "/";
                
                // Return JSON response
                return Json(rtv); // No need for JsonRequestBehavior in .NET Core
            }
            catch (Exception ex)
            {
                AddErrorLog(ex);
            }
            // Fetch data from the database based on the URL segment
            var data = new object { };// db.YourModel.Where(m => m.UrlSegment == urlSegment).FirstOrDefault();

            return Json(data);
        }

    }
}
