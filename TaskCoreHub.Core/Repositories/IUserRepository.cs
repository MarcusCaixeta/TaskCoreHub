using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Core.Repositories
{
    public interface IUserRepository
    {
        Task<Guid> Create(User user);
        Task<List<User>> GetAllUser ();
    }
}
