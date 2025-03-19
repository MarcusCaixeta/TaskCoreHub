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
    public class StatusDemandRepository : IStatusDemandRepository
    {
        private readonly TaskCoreHubDbContext _dbContext;

        public StatusDemandRepository(TaskCoreHubDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Create(StatusDemand statusDemand)
        {
            await _dbContext.StatusDemand.AddAsync(statusDemand);

            await _dbContext.SaveChangesAsync();

            return statusDemand.Id;
        }

    }
}
