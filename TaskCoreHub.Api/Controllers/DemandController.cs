using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskCoreHub.Application.Commands.DemandCommands.CreateDemandCommand;

namespace TaskCoreHub.Api.Controllers
{
    [ApiController]
    [Route("api/demand")]
    public class DemandController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DemandController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost()]
        public async Task<IActionResult> CreateDemand([FromBody] CreateDemandCommand command)
        {
            var user = await _mediator.Send(command);
            return Ok(user);
        }
    }
}
