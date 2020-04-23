using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace Gateway
{
    public class Program
    {
        private static string _defaultHostUrl = "http://betonomeshalka.herokuapp.com";
        private static string _devHostUrl = "http://localhost:5000";

        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            try
            {
                var webHost = new WebHostBuilder()
                    .UseKestrel()
                    .UseStartup<Startup>()
                    .Start(_devHostUrl);

                webHost.WaitForShutdown();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls(_defaultHostUrl)
                        .PreferHostingUrls(true)
                        .UseStartup<Startup>();
                });
    }
}
