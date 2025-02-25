
namespace TaskCoreHub.Application.DTOs
{
    public class QueueMessage
    {
        public string Id { get; set; }
        public string Body { get; set; }
        public Dictionary<string, string> Attributes { get; set; }
    }
}
