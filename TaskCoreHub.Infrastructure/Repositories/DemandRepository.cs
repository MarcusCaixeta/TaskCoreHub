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
    public class DemandRepository : IDemandRepository
    {
        private readonly TaskCoreHubDbContext _dbContext;

        public DemandRepository(TaskCoreHubDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Create(Demand demand)
        {
            await _dbContext.Demand.AddAsync(demand);

            await _dbContext.SaveChangesAsync();

            return demand.Id;
        }

    }
}
