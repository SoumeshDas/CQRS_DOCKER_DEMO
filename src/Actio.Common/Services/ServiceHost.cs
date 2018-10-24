using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Actio.Common.Services
{
    public class ServiceHost : IServiceHost
    {
        private readonly IWebHost _webHost;

        public ServiceHost(IWebHost webhost)
        {
            _webHost=webhost;
        }

        public void Run() => _webHost.Run();

        public static HostBuilder Create<TStratup>(string[] args) where TStratup:class
        {
            //create console title the class namespace
            Console.Title = typeof(TStratup).Namespace;
            var config=new ConfigurationBuilder()
            .AddEnvironmentVariables()
            .AddCommandLine(args)
            .Build();
            
            var webHostBuilder=WebHost.CreateDefaultBuilder()
            .UseConfiguration(config)
            .UseStartup<TStratup>();

        

            return new HostBuilder(webHostBuilder.Build());
        }

        /// public void Run() => _webHost.Run();

    }
}