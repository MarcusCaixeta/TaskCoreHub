using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskCoreHub.Application.Commands.LogDemandCommands.CreateLogDemandCommand;

namespace TaskCoreHub.Api.Controllers
{
    [ApiController]
    [Route("api/logdemand")]
    public class LogDemandController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LogDemandController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost()]
        public async Task<IActionResult> CreateLogDemand([FromBody] CreateLogDemandCommand command)
        {
            var user = await _mediator.Send(command);
            return Ok(user);
        }
    }
}
