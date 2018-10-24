using Actio.Common.Command;
using Actio.Common.Events;
using Actio.Common.RabbitMq;
using Microsoft.AspNetCore.Hosting;
using RawRabbit;

namespace Actio.Common.Services
{
    public class BusBuilder:BuilderBase
    {
        
         private readonly IWebHost _webHost;
        private IBusClient _bus;

        public BusBuilder(IWebHost webHost ,IBusClient bus)
        {
            _webHost=webHost;
            _bus=bus;
        }

        public  BusBuilder SubScribeToCommand<TCommand>() where TCommand :ICommand
        {
            var handler=_webHost.Services.GetService(typeof(ICommandHandler<TCommand>)) 
            as ICommandHandler<TCommand>;

            _bus.WithCommandHandlerAsync(handler);

            return this;
        }


        public  BusBuilder SubScribeToEvent<TEvent>() where TEvent :IEvent
        {
            var handler=_webHost.Services.GetService(typeof(IEventHandler<TEvent>)) 
            as IEventHandler<TEvent>;

            _bus.WithEventHandlerAsync(handler);

            return this;
        }

        public override ServiceHost Build()
        {
            return new ServiceHost(_webHost);
        }
    }
}