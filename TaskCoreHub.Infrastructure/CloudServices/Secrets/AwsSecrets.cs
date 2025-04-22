using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;
using System;
using System.Text.Json;
using TaskCoreHub.Application.DTOs;
using TaskCoreHub.Application.Interfaces.Secrets;

namespace TaskCoreHub.Infrastructure.CloudServices.Secrets
{
    public class AwsSecrets : IAwsSecrets
    {
        private readonly IAmazonSecretsManager _secretsManager;

        public AwsSecrets(IAmazonSecretsManager secretsManager)
        {
            _secretsManager = secretsManager;
        }      

        async Task<AwsSecretsDto> IAwsSecrets.ReceiveSecretsAsync(string secretName)
        {
            var request = new GetSecretValueRequest
            {
                SecretId = secretName
            };

            var response = await _secretsManager.GetSecretValueAsync(request);
            var json = response.SecretString;

            return JsonSerializer.Deserialize<AwsSecretsDto>(json);
        }
    }
}
