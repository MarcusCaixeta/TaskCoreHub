using TaskCoreHub.Core.ValueObjects;

namespace TaskCoreHub.Core.Entitites
{
    public class Demand : BaseEntity
    {
        private Demand() { } // Para o ORM

        public Demand(string title, string description, Guid idTeam, Guid idStartReason, Guid idUserCreate, DateTime dateStart,
                      Priority priority, int effort)
        {
            Title = title ?? throw new ArgumentException("Title is required");
            Description = description ?? throw new ArgumentException("Description is required");
            IdTeam = idTeam;
            IdStartReason = idStartReason;
            IdUserCreate = idUserCreate;
            Status = DemandStatus.Created;
            DateCreate = DateTime.UtcNow;
            DateStart = dateStart;
            Priority = priority;
            Effort = effort;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public Guid IdTeam { get; private set; }
        public Guid IdStartReason { get; private set; }
        public Guid IdFinishReason { get; private set; }
        public Guid IdUserCreate { get; private set; }
        public Guid IdUserInProgress { get; private set; }
        public Guid IdUserFinish { get; private set; }
        public DateTime DateCreate { get; private set; }
        public DateTime DateStart { get; private set; }
        public DateTime? DateFinish { get; private set; }
        public DemandStatus Status { get; private set; }
        public Priority Priority { get; private set; }
        public int Effort { get; private set; }

        public void StartProgress(Guid idUser)
        {
            if (Status != DemandStatus.Created)
                throw new InvalidOperationException("Cannot start progress on a demand that is not in 'Created' status.");

            IdUserInProgress = idUser;
            Status = DemandStatus.InProgress;
        }

        public void FinishDemand(Guid idUser, Guid idFinishReason)
        {
            if (Status != DemandStatus.InProgress)
                throw new InvalidOperationException("Cannot finish a demand that is not in 'InProgress' status.");

            IdUserFinish = idUser;
            IdFinishReason = idFinishReason;
            DateFinish = DateTime.UtcNow;
            Status = DemandStatus.Finished;
        }
    }
}
