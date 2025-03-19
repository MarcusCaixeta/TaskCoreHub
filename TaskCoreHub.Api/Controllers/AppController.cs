using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskCoreHub.Application.Commands.AppCommands.CreateAppCommand;
using TaskCoreHub.Application.Queries.AppQueries.GetAllAppQuery;
using TaskCoreHub.Application.Queries.UserQueries.GetAllUserCommand;
using TaskCoreHub.Core.Entitites;

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
        [HttpGet("App")]
        public async Task<IActionResult> GetAllApp()
        {
            var query = new GetAllAppQuery();
            var users = await _mediator.Send(query);
            return Ok(users);
        }
    }
}
