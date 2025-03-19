using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Core.Repositories
{
    public interface ITeamRepository
    {
        Task<Guid> Create(Team team);
    }
}
