﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace FlightPassengerApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseUrls("http://localhost:5000/;https://localhost:5001/")
                .UseStartup<Startup>();
    }
}
