
namespace TaskCoreHub.Core.Entitites
{
    public class StatusDemand : BaseEntity
    {
        public StatusDemand(string descriptionBasic, string descriptionDetailed)
        {
            DescriptionBasic = descriptionBasic;
            DescriptionDetailed = descriptionDetailed;
        }

        public string DescriptionBasic { get; private set; }
        public string DescriptionDetailed { get; private set; }
    }
}
