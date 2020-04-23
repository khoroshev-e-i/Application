using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Angular
{
    public class Program
    {
        private static readonly string _herokuApiUrl = "https://betonomeshalka.herokuapp.com/";

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls(_herokuApiUrl);
                    webBuilder.PreferHostingUrls(true);
                });
    }
}
