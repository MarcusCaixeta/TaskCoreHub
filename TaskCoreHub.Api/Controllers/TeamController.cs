using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskCoreHub.Application.Commands.TeamCommands.CreateTeamCommand;

namespace TaskCoreHub.Api.Controllers
{
    [ApiController]
    [Route("api/team")]
    public class TeamController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TeamController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("team")]
        public async Task<IActionResult> CreateTeam([FromBody] CreateTeamCommand command)
        {
            var user = await _mediator.Send(command);
            return Ok(user);
        }
    }
}
