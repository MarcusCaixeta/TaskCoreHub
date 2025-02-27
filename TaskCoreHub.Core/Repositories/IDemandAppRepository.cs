using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Core.Repositories
{
    public interface IDemandAppRepository
    {
        Task<Guid> Create(DemandApp demandApp);

    }
}
