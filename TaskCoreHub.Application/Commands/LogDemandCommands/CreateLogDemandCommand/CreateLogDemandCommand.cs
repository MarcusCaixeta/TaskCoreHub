using MediatR;
using TaskCoreHub.Application.Models;

namespace TaskCoreHub.Application.Commands.LogDemandCommands.CreateLogDemandCommand
{
    public class CreateLogDemandCommand : IRequest<ResponseResult<Guid>>
    {
        public Guid IdDemand { get; set; }
        public Guid IdUserLog { get; set; }
        public Guid IdTypeLog { get; set; }
        public string DescriptionLog { get; set; }
    }
}
