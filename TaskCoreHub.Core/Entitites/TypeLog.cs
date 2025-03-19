
namespace TaskCoreHub.Core.Entitites
{
    public class TypeLog : BaseEntity
    {
        public TypeLog(string description)
        {
            Description = description;
        }
        public string Description { get; private set; }

       
    }
}
