using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskCoreHub.Application.Commands.TypeLogCommands.CreateTypeLogCommand;

namespace TaskCoreHub.Api.Controllers
{
    [ApiController]
    [Route("api/typelog")]
    public class TypeLogController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TypeLogController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost()]
        public async Task<IActionResult> CreateTypeLog([FromBody] CreateTypeLogCommand command)
        {
            var user = await _mediator.Send(command);
            return Ok(user);
        }
    }
}
