
namespace TaskCoreHub.Core.Entitites
{
    public class AttachmentDemand : BaseEntity
    {
        public AttachmentDemand(Guid idDemand, string description, string keyAttachment)
        {
            IdDemand = idDemand;
            Description = description;
            KeyAttachment = keyAttachment;
        }

        public Guid IdDemand { get; private set; }
        public string Description { get; private set; }
        public string KeyAttachment { get; private set; }
    }
}
