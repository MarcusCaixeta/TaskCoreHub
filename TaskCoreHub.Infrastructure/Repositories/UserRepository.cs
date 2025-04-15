using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.Repositories;
using TaskCoreHub.Infrastructure.Persistence.Context;

namespace TaskCoreHub.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TaskCoreHubDbContext _dbContext;

        public UserRepository(TaskCoreHubDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Create(User user)
        {
            await _dbContext.User.AddAsync(user);

            await _dbContext.SaveChangesAsync();

            return user.Id;
        }

        public async Task<List<User>> GetAllUser()
        {
            var users = await _dbContext.User.ToListAsync();

            return users;
        }
    }
}
