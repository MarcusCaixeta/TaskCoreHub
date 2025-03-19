using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Core.Repositories
{
    public interface IReasonRepository
    {
        Task<Guid> Create(Reason reason);
    }
}
