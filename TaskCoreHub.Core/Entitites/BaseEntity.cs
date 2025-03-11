
namespace TaskCoreHub.Core.Entitites
{
    public class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }

    }
}
