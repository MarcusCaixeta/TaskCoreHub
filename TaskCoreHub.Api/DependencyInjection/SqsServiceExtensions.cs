using Amazon;
using Amazon.S3;
using Amazon.SecretsManager;
using Amazon.SQS;
using TaskCoreHub.Application.DTOs;
using TaskCoreHub.Application.Interfaces.Messaging;
using TaskCoreHub.Application.Interfaces.Secrets;
using TaskCoreHub.Infrastructure.CloudServices.Messaging;
using TaskCoreHub.Infrastructure.CloudServices.Secrets;

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
            services.AddSingleton<IAmazonS3>(sp =>
            {
                var config = sp.GetRequiredService<IConfiguration>();
                return new AmazonS3Client(
                    config["AWS:AccessKey"],
                    config["AWS:SecretKey"],
                    RegionEndpoint.GetBySystemName(config["AWS:Region"])
                );
            });
            services.AddSingleton<IAmazonSecretsManager>(sp =>
            {
                var config = sp.GetRequiredService<IConfiguration>();
                return new AmazonSecretsManagerClient(
                    config["AWS2:AccessKey"],
                    config["AWS2:SecretKey"],
                    RegionEndpoint.GetBySystemName(config["AWS2:Region"])
                );
            });
            services.AddSingleton<IMessagePublisher, SqsService>();
            services.AddSingleton<IMessageConsumer, SqsService>();
            services.AddSingleton<IAwsSecrets, AwsSecrets>();

            return services;
        }
    }
}
