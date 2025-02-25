
namespace TaskCoreHub.Core.Entitites
{
    public class App : BaseEntity
    {
        public App() { }

        public App(string description, int idTeam)
        {
            Description = description;
            IdTeam = idTeam;
        }

        public string Description { get; private set; }
        public int IdTeam { get; private set; }
    }
}
