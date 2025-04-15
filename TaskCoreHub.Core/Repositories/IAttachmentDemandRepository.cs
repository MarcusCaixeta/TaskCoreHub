using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Core.Repositories
{
    public interface IAttachmentDemandRepository
    {
        Task<Guid> Create(AttachmentDemand attachmentDemand);

        Task<List<AttachmentDemand>> GetAllAttachmentDemand();

    }
}
