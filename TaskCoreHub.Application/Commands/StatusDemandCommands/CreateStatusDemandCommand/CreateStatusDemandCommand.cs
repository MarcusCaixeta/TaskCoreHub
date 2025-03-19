using MediatR;
using TaskCoreHub.Application.Models;

namespace TaskCoreHub.Application.Commands.StatusDemandCommands.CreateStatusDemandCommand
{
    public class CreateStatusDemandCommand : IRequest<ResponseResult<Guid>>
    {
        public string DescriptionBasic { get; set; }
        public string DescriptionDetailed { get; set; }
    }
}
