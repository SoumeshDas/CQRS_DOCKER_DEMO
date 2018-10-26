using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Actio.Common.Command;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace Actio.api.Controllers
{
    [Route("[controller]")]
    public class UserController:Controller
    {
        private readonly IBusClient _busClient;
        public UserController(IBusClient busClient) => _busClient = busClient;

        
        [HttpPost("registere")]
        public async Task<IActionResult> Post([FromBody]UserActivity command)
        {
            await _busClient.PublishAsync(command);
            return Accepted();
        }
    }
}