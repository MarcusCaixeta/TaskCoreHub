using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCoreHub.Application.Models;

namespace TaskCoreHub.Application.Commands.UserCommands.CreateUserCommand
{
    public class CreateUserCommand : IRequest<ResponseResult<int>>
    {
        public string Name { get;  set; }
        public int IdEmployee { get;  set; }
        public int IdTeam { get;  set; }
        public int IdPosition { get;  set; }
        public string Email { get;  set; }
        public string Password { get;  set; }
    }
}
