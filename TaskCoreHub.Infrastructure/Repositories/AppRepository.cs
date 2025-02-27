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
    public class AppRepository : IAppRepository
    {
        private readonly TaskCoreHubDbContext _dbContext;

        public AppRepository(TaskCoreHubDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        async Task<Guid> IAppRepository.Create(App app)
        {
            await _dbContext.App.AddAsync(app);

            await _dbContext.SaveChangesAsync();

            return app.Id;
        }
    }
}
