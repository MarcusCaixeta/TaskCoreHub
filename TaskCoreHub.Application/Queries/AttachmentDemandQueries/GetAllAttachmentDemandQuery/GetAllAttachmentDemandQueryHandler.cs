using MediatR;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.Repositories;

namespace TaskCoreHub.Application.Queries.AttachmentDemandQueries.GetAllAttachmentDemandQuery
{
    public class GetAllAttachmentDemandQueryHandler : IRequestHandler<GetAllAttachmentDemandQuery, ResponseResult<List<AttachmentDemand>>>
    {
        private readonly IAttachmentDemandRepository _repository;

        public GetAllAttachmentDemandQueryHandler(IAttachmentDemandRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResponseResult<List<AttachmentDemand>>> Handle(GetAllAttachmentDemandQuery request, CancellationToken cancellationToken)
        {
            var attachmentdemand = await _repository.GetAllAttachmentDemand();

            return new ResponseResult<List<AttachmentDemand>>(attachmentdemand);
        }
    }
}
