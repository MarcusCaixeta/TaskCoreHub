using MediatR;
using TaskCoreHub.Application.Models;

namespace TaskCoreHub.Application.Commands.LogDemandCommands.CreateLogDemandCommand
{
    public class CreateLogDemandCommand : IRequest<ResponseResult<Guid>>
    {
        public int IdDemand { get; set; }
        public int IdUserLog { get; set; }
        public int IdTypeLog { get; set; }
        public string DescriptionLog { get; set; }
    }
}
