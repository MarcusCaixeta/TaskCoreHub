using Microsoft.EntityFrameworkCore;
using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Infrastructure.Persistence.Context
{
    public class TaskCoreHubDbContext : DbContext
    {
        public TaskCoreHubDbContext(DbContextOptions<TaskCoreHubDbContext> options) : base(options) { }

        public DbSet<App> Application { get; set; }
        public DbSet<AttachmentDemand> AttachmentDemand { get; set; }
        public DbSet<Demand> Demand { get; set; }
        public DbSet<DemandApplication> DemandApplication { get; set; }
        public DbSet<LogDemand> LogDemand { get; set; }
        public DbSet<Reason> Reason { get; set; }
        public DbSet<StatusDemand> StatusDemand { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<TypeLog> TypeLog { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaskCoreHubDbContext).Assembly);
        }
    }
}
