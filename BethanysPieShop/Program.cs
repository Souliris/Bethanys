using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BethanysPieShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<AppDbContext>();
                    DbInitializer.Seed(context);

                }
                catch (Exception)
                {

                    // bleh
                }
            }
            host.Run();
        }

        private static int AppDbContext()
        {
            throw new NotImplementedException();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }// end class
}//end namespace
