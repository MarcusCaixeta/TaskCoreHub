using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Core.Repositories
{
    public interface IUserRepository
    {
        Task<Guid> Create(User user);
        Task<List<User>> GetAllUser ();
    }
}
