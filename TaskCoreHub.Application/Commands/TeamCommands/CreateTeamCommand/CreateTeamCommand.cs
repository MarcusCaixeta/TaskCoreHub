using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCoreHub.Application.Models;

namespace TaskCoreHub.Application.Commands.TeamCommands.CreateTeamCommand
{
    public class CreateTeamCommand : IRequest<ResponseResult<Guid>>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
