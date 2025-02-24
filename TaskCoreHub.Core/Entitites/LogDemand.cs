using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCoreHub.Core.Entitites
{
    public class LogDemand : BaseEntity
    {
        public LogDemand(int idDemand, int idUserLog, int idTypeLog, string descriptionLog)
        {
            IdDemand = idDemand;
            IdUserLog = idUserLog;
            IdTypeLog = idTypeLog;
            DescriptionLog = descriptionLog;
        }

        public int IdDemand { get; private set; }
        public int IdUserLog { get; private set; }
        public int IdTypeLog { get; private set; }
        public string DescriptionLog { get; private set; }
    }
}
