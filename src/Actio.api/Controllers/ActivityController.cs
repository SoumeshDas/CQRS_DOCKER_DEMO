using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;
using Actio.Common.Command;

namespace Actio.api.Controllers
{
    [Route("[controller]")]
    public class ActivityController:Controller
    {
        private readonly IBusClient _busClient;
        public ActivityController(IBusClient busClient) => _busClient = busClient;

        public async Task<IActionResult> Post([FromBody]CreateActivity command)
        {
            command.Id = Guid.NewGuid();
            command.CreatedAt = DateTime.UtcNow;
            await _busClient.PublishAsync(command);
            return Accepted($"activities/{command.Id}");
        }
    }
}