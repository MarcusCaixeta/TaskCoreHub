﻿using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Core.Repositories
{
    public interface IAppRepository
    {
        Task<Guid> Create(App app);
    }
}
