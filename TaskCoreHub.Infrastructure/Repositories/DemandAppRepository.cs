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
    public class DemandAppRepository : IDemandAppRepository
    {
        private readonly TaskCoreHubDbContext _dbContext;

        public DemandAppRepository(TaskCoreHubDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Create(DemandApp demandApp)
        {
            await _dbContext.DemandApp.AddAsync(demandApp);

            await _dbContext.SaveChangesAsync();

            return demandApp.Id;
        }
    }
}
