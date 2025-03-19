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
    public class TeamRepository : ITeamRepository
    {
        private readonly TaskCoreHubDbContext _dbContext;

        public TeamRepository(TaskCoreHubDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Create(Team team)
        {
            await _dbContext.Team.AddAsync(team);

            await _dbContext.SaveChangesAsync();

            return team.Id;
        }
    }
}
