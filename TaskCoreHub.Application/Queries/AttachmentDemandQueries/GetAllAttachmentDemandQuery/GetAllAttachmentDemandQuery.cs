using MediatR;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Application.Queries.AttachmentDemandQueries.GetAllAttachmentDemandQuery
{
    public class GetAllAttachmentDemandQuery : IRequest<ResponseResult<List<AttachmentDemand>>>
    {
    }
}
