using MediatR;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.Repositories;

namespace TaskCoreHub.Application.Commands.AttachmentDemandCommands.CreateAttachmentDemandCommand
{

    public class CreateAttachmentDemandCommandHandler : IRequestHandler<CreateAttachmentDemandCommand, ResponseResult<Guid>>
    {
        private readonly IAttachmentDemandRepository _repository;
        public CreateAttachmentDemandCommandHandler(IAttachmentDemandRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseResult<Guid>> Handle(CreateAttachmentDemandCommand request, CancellationToken cancellationToken)
        {
            var createAttachmentDemand = new AttachmentDemand(request.IdDemand, request.Description, request.KeyAttachment);

            await _repository.Create(createAttachmentDemand);
            return new ResponseResult<Guid>(createAttachmentDemand.Id);
        }
    }
}
