using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskCoreHub.Application.Commands.ReasonCommands.CreateReasonCommand;

namespace TaskCoreHub.Api.Controllers
{
    [ApiController]
    [Route("api/reason")]
    public class ReasonController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ReasonController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost()]
        public async Task<IActionResult> CreateReason([FromBody] CreateReasonCommand command)
        {
            var user = await _mediator.Send(command);
            return Ok(user);
        }
    }
}
