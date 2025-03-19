using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskCoreHub.Application.Commands.StatusDemandCommands.CreateStatusDemandCommand;

namespace TaskCoreHub.Api.Controllers
{
    [ApiController]
    [Route("api/statusdemand")]
    public class StatusDemandController : ControllerBase    
    {
        private readonly IMediator _mediator;
        public StatusDemandController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost()]
        public async Task<IActionResult> CreateStatusDemand([FromBody] CreateStatusDemandCommand command)
        {
            var user = await _mediator.Send(command);
            return Ok(user);
        }
    }
}
