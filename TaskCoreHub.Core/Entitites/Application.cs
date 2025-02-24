using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCoreHub.Core.Entitites
{
    public class Application : BaseEntity
    {
        public Application() { }

        public Application(string description, int idTeam)
        {
            Description = description;
            IdTeam = idTeam;
        }

        public string Description { get; private set; }
        public int IdTeam { get; private set; }
    }
}
