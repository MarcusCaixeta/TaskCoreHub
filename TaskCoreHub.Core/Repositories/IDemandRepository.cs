using System;
using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Core.Repositories
{
    public interface IDemandRepository
    {
        Task<Guid> Create(Demand demand);
    }
}
