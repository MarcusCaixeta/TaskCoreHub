
namespace TaskCoreHub.Core.Entitites
{
    public class App : BaseEntity
    {
        public App() { }

        public App(string description, Guid idTeam)
        {
            Description = description;
            IdTeam = idTeam;
        }

        public string Description { get; private set; }
        public Guid IdTeam { get; private set; }
    }
}
