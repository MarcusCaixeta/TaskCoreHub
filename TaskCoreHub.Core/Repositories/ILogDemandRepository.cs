using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Core.Repositories
{
    public interface ILogDemandRepository
    {
        Task<Guid> Create(LogDemand logDemand);
    }
}
