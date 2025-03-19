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
    public class LogDemandRepository : ILogDemandRepository
    {
        private readonly TaskCoreHubDbContext _dbContext;

        public LogDemandRepository(TaskCoreHubDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Create(LogDemand logDemand)
        {
            await _dbContext.LogDemand.AddAsync(logDemand);

            await _dbContext.SaveChangesAsync();

            return logDemand.Id;
        }
    }
}
