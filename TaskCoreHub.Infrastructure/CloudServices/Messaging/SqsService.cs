using Amazon.SQS;
using Amazon.SQS.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TaskCoreHub.Application.DTOs;
using TaskCoreHub.Application.Interfaces.Messaging;
using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Infrastructure.CloudServices.Messaging
{
    public class SqsService : IMessagePublisher, IMessageConsumer
    {
        private readonly IAmazonSQS _sqsClient;
        private readonly ILogger<SqsService> _logger;

        public SqsService(IAmazonSQS sqsClient, ILogger<SqsService> logger)
        {
            _sqsClient = sqsClient;
            _logger = logger;
        }

        public async Task SendMessageAsync<T>(string queueUrl, T message)
        {
            var sendMessageRequest = new SendMessageRequest
            {
                QueueUrl = queueUrl,
                MessageBody = JsonSerializer.Serialize(message)
            };

            var response = await _sqsClient.SendMessageAsync(sendMessageRequest);
            _logger.LogInformation($"Mensagem enviada com sucesso. MessageId: {response.MessageId}");
        }

        public async Task StartListeningAsync(string queueUrl, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Iniciando consumo de mensagens SQS...");

            while (!cancellationToken.IsCancellationRequested)
            {
                var receiveMessageRequest = new ReceiveMessageRequest
                {
                    QueueUrl = queueUrl,
                    MaxNumberOfMessages = 10,
                    WaitTimeSeconds = 5
                };

                var response = await _sqsClient.ReceiveMessageAsync(receiveMessageRequest, cancellationToken);

                foreach (var message in response.Messages)
                {
                    _logger.LogInformation($"Mensagem recebida: {message.Body}");

                    // Aqui você pode chamar um UseCase para processar a mensagem
                    await ProcessMessageAsync(message.Body);

                    // Deletando a mensagem após o processamento
                    await _sqsClient.DeleteMessageAsync(queueUrl, message.ReceiptHandle);
                }
            }
        }

        private Task ProcessMessageAsync(string messageBody)
        {
            // Simulação de processamento
            _logger.LogInformation($"Processando mensagem: {messageBody}");
            return Task.CompletedTask;
        }

        public async Task<List<QueueMessage>> ReceiveMessagesAsync()
        {
            string _queueUrl = "https://sqs.us-east-1.amazonaws.com/692859908082/TaskCoreHubProblems";

            var receiveRequest = new ReceiveMessageRequest
            {
                QueueUrl = _queueUrl,
                MaxNumberOfMessages = 5,
                WaitTimeSeconds = 10,
                MessageAttributeNames = new List<string> { "All" }
            };

            var response = await _sqsClient.ReceiveMessageAsync(receiveRequest);
            var messages = new List<QueueMessage>();

            foreach (var message in response.Messages)
            {
                messages.Add(new QueueMessage
                {
                    Id = message.MessageId,
                    Body = message.Body,
                    Attributes = new Dictionary<string, string>()
                });

                await DeleteMessageAsync(message.ReceiptHandle);
            }

            return messages;
        }

        public async Task DeleteMessageAsync(string receiptHandle)
        {
            string _queueUrl = "https://sqs.us-east-1.amazonaws.com/692859908082/TaskCoreHubProblems";

            var deleteRequest = new DeleteMessageRequest
            {
                QueueUrl = _queueUrl,
                ReceiptHandle = receiptHandle
            };

            await _sqsClient.DeleteMessageAsync(deleteRequest);
        }
    }
}
