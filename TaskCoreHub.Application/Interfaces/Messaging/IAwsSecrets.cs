using TaskCoreHub.Application.DTOs;

namespace TaskCoreHub.Application.Interfaces.Secrets
{
    public interface IAwsSecrets
    {
        Task<AwsSecretsDto> ReceiveSecretsAsync(string secretName);
    }
}
