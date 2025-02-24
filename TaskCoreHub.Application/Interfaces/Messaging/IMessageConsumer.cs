using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCoreHub.Application.DTOs;

namespace TaskCoreHub.Application.Interfaces.Messaging
{
    public interface IMessageConsumer
    {
        Task StartListeningAsync(string queueUrl, CancellationToken cancellationToken);
        Task<List<QueueMessage>> ReceiveMessagesAsync();
        Task DeleteMessageAsync(string receiptHandle);

    }
}