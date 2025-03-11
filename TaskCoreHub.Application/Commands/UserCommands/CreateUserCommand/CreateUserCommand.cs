using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCoreHub.Application.Models;

namespace TaskCoreHub.Application.Commands.UserCommands.CreateUserCommand
{
    public class CreateUserCommand : IRequest<ResponseResult<Guid>>
    {
        public string Name { get; private set; }
        public int IdEmployee { get; private set; }
        public int IdTeam { get; private set; }
        public int IdPosition { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
