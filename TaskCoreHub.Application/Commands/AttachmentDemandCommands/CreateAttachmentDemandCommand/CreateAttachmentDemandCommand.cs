using MediatR;
using TaskCoreHub.Application.Models;

namespace TaskCoreHub.Application.Commands.AttachmentDemandCommands.CreateAttachmentDemandCommand
{
    public class CreateAttachmentDemandCommand : IRequest<ResponseResult<Guid>>
    {
        public int IdDemand { get; private set; }
        public string Description { get; private set; }
        public string KeyAttachment { get; private set; }
    }
}
