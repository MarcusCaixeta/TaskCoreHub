using Amazon.Runtime.Internal;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.ValueObjects;

namespace TaskCoreHub.Application.Commands.DemandCommands.CreateDemandCommand
{
    public class CreateDemandCommand : IRequest<ResponseResult<Guid>>
    {
        public string Title { get;  set; }
        public string Description { get;  set; }
        public Team Team { get;  set; }
        public Reason StartReason { get; set; }
        public User UserCreate { get; set; }
        public Priority Priority { get; set; }
        public DateTime DateStart { get; set; }
        public int Effort { get; set; }
    }
}
