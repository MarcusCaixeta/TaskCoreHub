using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Core.Repositories
{
    public interface IStatusDemandRepository
    {
        Task<Guid> Create(StatusDemand statusDemand);
    }
}
