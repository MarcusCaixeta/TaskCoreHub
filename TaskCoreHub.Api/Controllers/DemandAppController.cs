using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskCoreHub.Application.Commands.DemandAppCommands.CreateDemandAppCommand;

namespace TaskCoreHub.Api.Controllers
{
    [ApiController]
    [Route("api/demandapp")]
    public class DemandAppController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DemandAppController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost()]
        public async Task<IActionResult> CreateDemandApp([FromBody] CreateDemandAppCommand command)
        {
            var user = await _mediator.Send(command);
            return Ok(user);
        }
    }
}
