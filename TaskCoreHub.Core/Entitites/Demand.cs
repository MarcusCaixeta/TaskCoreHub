using TaskCoreHub.Core.ValueObjects;

namespace TaskCoreHub.Core.Entitites
{
    public class Demand : BaseEntity
    {
        private Demand() { } // Para o ORM

        public Demand(string title, string description, Team team, Reason startReason, User userCreate, DateTime dateStart,
                      Priority priority, Effort effort)
        {
            Title = title ?? throw new ArgumentException("Title is required");
            Description = description ?? throw new ArgumentException("Description is required");
            Team = team ?? throw new ArgumentNullException(nameof(team));
            StartReason = startReason ?? throw new ArgumentNullException(nameof(startReason));
            UserCreate = userCreate ?? throw new ArgumentNullException(nameof(userCreate));
            Status = DemandStatus.Created;
            DateCreate = DateTime.UtcNow;
            DateStart = dateStart;
            Priority = priority;
            Effort = effort;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public Team Team { get; private set; }
        public Reason StartReason { get; private set; }
        public Reason? FinishReason { get; private set; }
        public User UserCreate { get; private set; }
        public User? UserInProgress { get; private set; }
        public User? UserFinish { get; private set; }
        public DateTime DateCreate { get; private set; }
        public DateTime DateStart { get; private set; }
        public DateTime? DateFinish { get; private set; }
        public DemandStatus Status { get; private set; }
        public Priority Priority { get; private set; }
        public Effort Effort { get; private set; }

        public void StartProgress(User user)
        {
            if (Status != DemandStatus.Created)
                throw new InvalidOperationException("Cannot start progress on a demand that is not in 'Created' status.");

            UserInProgress = user;
            Status = DemandStatus.InProgress;
        }

        public void FinishDemand(User user, Reason finishReason)
        {
            if (Status != DemandStatus.InProgress)
                throw new InvalidOperationException("Cannot finish a demand that is not in 'InProgress' status.");

            UserFinish = user;
            FinishReason = finishReason;
            DateFinish = DateTime.UtcNow;
            Status = DemandStatus.Finished;
        }
    }
}
