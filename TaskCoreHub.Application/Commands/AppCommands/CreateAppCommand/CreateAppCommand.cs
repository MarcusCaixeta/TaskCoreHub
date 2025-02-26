using MediatR;
using TaskCoreHub.Application.Models;

namespace TaskCoreHub.Application.Commands.AppCommands.CreateAppCommand
{
    public class CreateAppCommand : IRequest<ResponseResult<Guid>>
    {
        public string Description { get;  set; }
        public int IdTeam { get;  set; }
    }
}
