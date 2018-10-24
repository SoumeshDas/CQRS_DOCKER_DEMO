using System;
using Microsoft.AspNetCore.Hosting;
using RawRabbit;

namespace Actio.Common.Services
{
    public class HostBuilder : BuilderBase
    {
         private readonly IWebHost _webHost;
        private IBusClient _bus;
        public HostBuilder(IWebHost webhost)
        {
            _webHost=webhost;
        }

        public BusBuilder UseRabbitMQ()
        {
            _bus=_webHost.Services.GetService(typeof(IBusClient))as IBusClient;
            return new BusBuilder(_webHost,_bus);
        }

        public override ServiceHost Build()
        {
            return new ServiceHost(_webHost);
        }
    }
}