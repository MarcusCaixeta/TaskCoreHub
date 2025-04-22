using MediatR;
using TaskCoreHub.Application.Models;
using Microsoft.AspNetCore.Http;



namespace TaskCoreHub.Application.Commands.AttachmentDemandCommands.CreateAttachmentDemandCommand
{
    public class CreateAttachmentDemandCommand : IRequest<ResponseResult<Guid>>
    {
        public Guid IdDemand { get;  set; }
        public string Description { get;  set; }
        public IFormFile Arquivo { get; set; }
    }
}
