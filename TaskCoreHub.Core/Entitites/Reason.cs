
namespace TaskCoreHub.Core.Entitites
{
    public class Reason : BaseEntity
    {
        public Reason(string description)
        {
            Description = description;
        }
        public string Description { get; private set; }        
    }
}
