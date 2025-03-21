﻿
namespace TaskCoreHub.Core.Entitites
{
    public class AttachmentDemand : BaseEntity
    {
        public AttachmentDemand(int idDemand, string description, string keyAttachment)
        {
            IdDemand = idDemand;
            Description = description;
            KeyAttachment = keyAttachment;
        }

        public int IdDemand { get; private set; }
        public string Description { get; private set; }
        public string KeyAttachment { get; private set; }
    }
}
