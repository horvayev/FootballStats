using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {            
            return Host.CreateDefaultBuilder(args)                               
                .ConfigureAppConfiguration((context, config) => {
                    IHostEnvironment env = context.HostingEnvironment;
                    config.AddJsonFile("appsettings.json");
                    config.AddJsonFile($"appsettings.{env.EnvironmentName.ToLower()}.json", optional: true);
                    config.AddEnvironmentVariables();                    
                })
                .ConfigureWebHostDefaults(configure => {
                    configure.UseStartup<Startup>();
                    configure.UseKestrel();                    
                });               
        }
    }
}
