using Amazon.SQS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCoreHub.Application.Interfaces.Messaging
{
    public interface IMessagePublisher
    {
        Task SendMessageAsync<T>(string queueUrl, T message);
    }
}