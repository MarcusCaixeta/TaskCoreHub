using System;

namespace TaskCoreHub.Core.Entitites
{
    public class DemandApplication : BaseEntity
    {
        public DemandApplication(int idApplication, int idDemand)
        {
            IdApplication = idApplication;
            IdDemand = idDemand;
        }

        public int IdApplication { get; private set; }
        public int IdDemand { get; private set; }
    }
}
