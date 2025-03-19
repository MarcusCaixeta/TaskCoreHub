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
    public class ReasonRepository : IReasonRepository
    {
        private readonly TaskCoreHubDbContext _dbContext;

        public ReasonRepository(TaskCoreHubDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Create(Reason reason)
        {
            await _dbContext.Reason.AddAsync(reason);

            await _dbContext.SaveChangesAsync();

            return reason.Id;
        }
    }
}
