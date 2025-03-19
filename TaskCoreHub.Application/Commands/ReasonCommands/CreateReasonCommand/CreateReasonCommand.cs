using MediatR;
using TaskCoreHub.Application.Models;

namespace TaskCoreHub.Application.Commands.ReasonCommands.CreateReasonCommand
{
    public class CreateReasonCommand : IRequest<ResponseResult<Guid>>
    {
        public string Description { get; set; }

    }
}
