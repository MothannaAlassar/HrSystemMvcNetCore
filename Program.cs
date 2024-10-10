using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Setup NLog for Dependency injection
            var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings(System.IO.Directory.GetCurrentDirectory(), "appsettings.json", optional: false);
            //    var logger = NLog.LogManager.Setup()
            //.LoadConfigurationFromFile("appsettings.json") // If loading from another source, adjust accordingly
            //.GetCurrentClassLogger();

            try
            {
                logger.LogFactory.GetCurrentClassLogger().Debug("init main");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                logger.LogFactory.GetCurrentClassLogger().Error(ex, "Stopped program because of exception");
                throw;
            }
            finally
            {
                NLog.LogManager.Shutdown(); // Ensure to shut down NLog
            }
            // CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
