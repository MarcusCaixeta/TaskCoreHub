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
    public class AttachmentDemandRepository : IAttachmentDemandRepository
    {
        private readonly TaskCoreHubDbContext _dbContext;

        public AttachmentDemandRepository(TaskCoreHubDbContext dbContext)
        {
            _dbContext = dbContext;
        }       

        async Task<Guid> IAttachmentDemandRepository.Create(AttachmentDemand attachmentDemand)
        {
            await _dbContext.AttachmentDemand.AddAsync(attachmentDemand);

            await _dbContext.SaveChangesAsync();

            return attachmentDemand.Id;
        }
        public async Task<List<AttachmentDemand>> GetAllAttachmentDemand()
        {
            var attachmentDemand = await _dbContext.AttachmentDemand.ToListAsync();

            return attachmentDemand;
        }
    }
}
