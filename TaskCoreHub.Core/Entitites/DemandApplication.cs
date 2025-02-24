using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
