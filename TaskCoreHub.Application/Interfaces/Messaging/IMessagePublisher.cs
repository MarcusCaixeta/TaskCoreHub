
namespace TaskCoreHub.Application.Interfaces.Messaging
{
    public interface IMessagePublisher
    {
        Task SendMessageAsync<T>(string queueUrl, T message);
    }
}