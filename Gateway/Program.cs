using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace Gateway
{
    public class Program
    {
        private const string _defaultHostUrl = "https://betonomeshalka.herokuapp.com/";

        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            try
            {
                var webHost = new WebHostBuilder()
                    .UseKestrel()
                    .UseStartup<Startup>()
                    .Start(_defaultHostUrl);

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
