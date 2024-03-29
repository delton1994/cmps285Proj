﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace StarterProject.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args)
                .Build()
                .Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args) 
            .ConfigureAppConfiguration((ctx, builder) =>
            {
                builder.AddJsonFile("appsettings.json", false, true);
                builder.AddJsonFile($"appsettings.mac.json", true, true);
            })
                .UseStartup<Startup>();
    }
}
