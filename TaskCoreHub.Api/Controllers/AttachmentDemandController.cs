using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskCoreHub.Application.Commands.AttachmentDemandCommands.CreateAttachmentDemandCommand;
using TaskCoreHub.Application.Queries.AttachmentDemandQueries.GetAllAttachmentDemandQuery;

namespace TaskCoreHub.Api.Controllers
{
    [ApiController]
    [Route("api/attachmentdemand")]
    public class AttachmentDemandController : Controller
    {
        private readonly IMediator _mediator;

        public AttachmentDemandController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("")]
        public async Task<IActionResult> CreateAttachmentDemand([FromBody] CreateAttachmentDemandCommand command)
        {
            var appId = await _mediator.Send(command);
            return Ok(appId);
        }
        [HttpGet("")]
        public async Task<IActionResult> GetAllAttachmentDemand()
        {
            var query = new GetAllAttachmentDemandQuery();
            var users = await _mediator.Send(query);
            return Ok(users);
        }
    }
}
