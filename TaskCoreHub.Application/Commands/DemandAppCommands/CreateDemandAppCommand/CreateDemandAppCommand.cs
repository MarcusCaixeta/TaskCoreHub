using MediatR;
using TaskCoreHub.Application.Models;

namespace TaskCoreHub.Application.Commands.DemandAppCommands.CreateDemandAppCommand
{
    public class CreateDemandAppCommand : IRequest<ResponseResult<Guid>>
    {
        public int IdApplication { get;  set; }
        public int IdDemand { get;  set; }
    }
}
