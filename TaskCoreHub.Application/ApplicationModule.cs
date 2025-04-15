using Microsoft.Extensions.DependencyInjection;
using TaskCoreHub.Application.Commands.AppCommands.CreateAppCommand;
using TaskCoreHub.Application.Commands.AttachmentDemandCommands.CreateAttachmentDemandCommand;
using TaskCoreHub.Application.Commands.DemandAppCommands.CreateDemandAppCommand;
using TaskCoreHub.Application.Commands.DemandCommands.CreateDemandCommand;
using TaskCoreHub.Application.Commands.LogDemandCommands.CreateLogDemandCommand;
using TaskCoreHub.Application.Commands.ReasonCommands.CreateReasonCommand;
using TaskCoreHub.Application.Commands.StatusDemandCommands.CreateStatusDemandCommand;
using TaskCoreHub.Application.Commands.TeamCommands.CreateTeamCommand;
using TaskCoreHub.Application.Commands.TypeLogCommands.CreateTypeLogCommand;
using TaskCoreHub.Application.Commands.UserCommands.CreateUserCommand;
using TaskCoreHub.Application.Queries.AttachmentDemandQueries.GetAllAttachmentDemandQuery;
using TaskCoreHub.Application.Queries.UserQueries.GetAllUserCommand;

namespace TaskCoreHub.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediator();
            return services;
        }

        private static IServiceCollection AddMediator(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining<CreateAppCommand>();
                cfg.RegisterServicesFromAssemblyContaining<CreateAttachmentDemandCommand>();
                cfg.RegisterServicesFromAssemblyContaining<GetAllAttachmentDemandQuery>();
                cfg.RegisterServicesFromAssemblyContaining<CreateDemandAppCommand>();
                cfg.RegisterServicesFromAssemblyContaining<CreateUserCommand>();
                cfg.RegisterServicesFromAssemblyContaining<GetAllUserQuery>();
                cfg.RegisterServicesFromAssemblyContaining<CreateDemandCommand>();
                cfg.RegisterServicesFromAssemblyContaining<CreateLogDemandCommand>();
                cfg.RegisterServicesFromAssemblyContaining<CreateReasonCommand>();
                cfg.RegisterServicesFromAssemblyContaining<CreateStatusDemandCommand>();
                cfg.RegisterServicesFromAssemblyContaining<CreateTeamCommand>();
                cfg.RegisterServicesFromAssemblyContaining<CreateTypeLogCommand>();
            });
            return services;
        }
    }
}
