using MediatR;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.ValueObjects;

namespace TaskCoreHub.Application.Commands.DemandCommands.CreateDemandCommand
{
    public class CreateDemandCommand : IRequest<ResponseResult<Guid>>
    {
        public string Title { get;  set; }
        public string Description { get;  set; }
        public Guid IdTeam { get;  set; }
        public Guid IdStartReason { get; set; }
        public Guid IdUserCreate { get; set; }
        public Priority Priority { get; set; }
        public DateTime DateStart { get; set; }
        public int Effort { get; set; }
    }
}
