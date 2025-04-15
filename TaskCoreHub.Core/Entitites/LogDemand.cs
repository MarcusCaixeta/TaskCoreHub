
namespace TaskCoreHub.Core.Entitites
{
    public class LogDemand : BaseEntity
    {
        public LogDemand(Guid idDemand, Guid idUserLog, Guid idTypeLog, string descriptionLog)
        {
            IdDemand = idDemand;
            IdUserLog = idUserLog;
            IdTypeLog = idTypeLog;
            DescriptionLog = descriptionLog;
        }

        public Guid IdDemand { get; private set; }
        public Guid IdUserLog { get; private set; }
        public Guid IdTypeLog { get; private set; }
        public string DescriptionLog { get; private set; }
    }
}
