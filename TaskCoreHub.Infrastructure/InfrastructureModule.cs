using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCoreHub.Core.Repositories;
using TaskCoreHub.Infrastructure.Repositories;

namespace TaskCoreHub.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddRepositories();
            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAppRepository,AppRepository>();
            services.AddScoped<IAttachmentDemandRepository, AttachmentDemandRepository>();
            services.AddScoped<IDemandAppRepository, DemandAppRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IDemandRepository, DemandRepository>();
            services.AddScoped<ILogDemandRepository, LogDemandRepository>();
            services.AddScoped<IReasonRepository, ReasonRepository>();
            services.AddScoped<IStatusDemandRepository, StatusDemandRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<ITypeLogRepository, TypeLogRepository>();
            return services;
        }

    }
}
