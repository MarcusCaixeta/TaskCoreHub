﻿using Amazon.SQS.Model;
using Microsoft.AspNetCore.Mvc;
using TaskCoreHub.Application.DTOs;
using TaskCoreHub.Application.Interfaces.Messaging;

[ApiController]
[Route("api/sqs")]
public class SqsController : ControllerBase
{
    private readonly IMessagePublisher _messagePublisher;
    private readonly IMessageConsumer _messageConsumer;

    public SqsController(IMessagePublisher messagePublisher, IMessageConsumer messageConsumer)
    {
        _messagePublisher = messagePublisher;
        _messageConsumer = messageConsumer;
    }

    [HttpPost("send")]
    public async Task<IActionResult> SendMessage()
    {


        string queueUrl = "https://sqs.us-east-1.amazonaws.com/692859908082/TaskCoreHubProblems";
        var sendMessageRequest = new SendMessageRequest
        {
            QueueUrl = queueUrl,
            MessageBody = "Processar pedido #12345",
            MessageAttributes = new Dictionary<string, MessageAttributeValue>
            {
                {
                    "PedidoId", new MessageAttributeValue
                    {
                        StringValue = "12345",
                        DataType = "String"
                    }
                },
                {
                    "Prioridade", new MessageAttributeValue
                    {
                        StringValue = "Alta",
                        DataType = "String"
                    }
                }
            }
        };
        await _messagePublisher.SendMessageAsync(queueUrl, sendMessageRequest);
        return Ok("Mensagem enviada com sucesso!");
    }
    [HttpGet("receive")]
    public async Task<ActionResult<List<QueueMessage>>> ReceiveMessages()
    {
        var messages = await _messageConsumer.ReceiveMessagesAsync();
        return Ok(messages);
    }
}