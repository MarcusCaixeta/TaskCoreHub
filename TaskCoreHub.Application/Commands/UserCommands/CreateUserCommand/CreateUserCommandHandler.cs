using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCoreHub.Application.Commands.AppCommands.CreateAppCommand;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.Repositories;

namespace TaskCoreHub.Application.Commands.UserCommands.CreateUserCommand
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, ResponseResult<Guid>>
    {
        private readonly IUserRepository _repository;
        public CreateUserCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResponseResult<Guid>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {

            var user = new User(request.Name,request.IdEmployee,request.IdTeam,request.IdPosition, request.Email, request.Password);

            await _repository.Create(user);

            return new ResponseResult<Guid>(user.Id);
        }
    }
}
