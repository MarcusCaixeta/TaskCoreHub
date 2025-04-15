using System;

namespace TaskCoreHub.Core.Entitites
{
    public class DemandApp : BaseEntity
    {
        public DemandApp(Guid idApplication, Guid idDemand)
        {
            IdApplication = idApplication;
            IdDemand = idDemand;
        }

        public Guid IdApplication { get; private set; }
        public Guid IdDemand { get; private set; }
    }
}
