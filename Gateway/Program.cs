using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Gateway
{
    public class Program
    {
        private const string _defaultHostUrl = "http://ads-app.local:5001";

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls(_defaultHostUrl);
                    webBuilder.UseStartup<Startup>();
                });
    }
}
