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
    public class TypeLogRepository : ITypeLogRepository
    {
        private readonly TaskCoreHubDbContext _dbContext;

        public TypeLogRepository(TaskCoreHubDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Create(TypeLog typeLog)
        {
            await _dbContext.TypeLog.AddAsync(typeLog);

            await _dbContext.SaveChangesAsync();

            return typeLog.Id;
        }
    }
}
