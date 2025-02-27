using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskCoreHub.Application.Commands.AppCommands.CreateAppCommand;

namespace TaskCoreHub.Api.Controllers
{
    [ApiController]
    [Route("api/app")]
    public class AppController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("App")]
        public async Task<IActionResult> CreateApp([FromBody] CreateAppCommand command)
        {
            var appId = await _mediator.Send(command);
            return Ok(appId);
        }
    }
}
