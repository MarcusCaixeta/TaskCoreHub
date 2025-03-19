using MediatR;
using TaskCoreHub.Application.Models;

namespace TaskCoreHub.Application.Commands.TypeLogCommands.CreateTypeLogCommand
{
    public class CreateTypeLogCommand : IRequest<ResponseResult<Guid>>
    {
        public string Description { get;  set; }

    }
}
