using MediatR;
using TaskCoreHub.Application.Models;

namespace TaskCoreHub.Application.Commands.DemandAppCommands.CreateDemandAppCommand
{
    public class CreateDemandAppCommand : IRequest<ResponseResult<Guid>>
    {
        public Guid IdApplication { get;  set; }
        public Guid IdDemand { get;  set; }
    }
}
