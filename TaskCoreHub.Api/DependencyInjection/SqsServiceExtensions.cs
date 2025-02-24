using Amazon;
using Amazon.SQS;
using TaskCoreHub.Application.Interfaces.Messaging;
using TaskCoreHub.Infrastructure.CloudServices.Messaging;

namespace TaskCoreHub.Api.DependencyInjection
{
    public static class SqsServiceExtensions
    {
        public static IServiceCollection AddSqsServices(this IServiceCollection services, IConfiguration configuration)
        {
            var awsOptions = configuration.GetAWSOptions();
            services.AddDefaultAWSOptions(awsOptions);
            // Alternativamente, para passar manualmente as credenciais
            services.AddSingleton<IAmazonSQS>(sp =>
            {
                var config = sp.GetRequiredService<IConfiguration>();
                return new AmazonSQSClient(
                    config["AWS:AccessKey"],
                    config["AWS:SecretKey"],
                    RegionEndpoint.GetBySystemName(config["AWS:Region"])
                );
            });
            services.AddSingleton<IMessagePublisher, SqsService>();
            services.AddSingleton<IMessageConsumer, SqsService>();

            return services;
        }
    }
}
