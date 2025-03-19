using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCoreHub.Application.Commands.StatusDemandCommands.CreateStatusDemandCommand;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.Repositories;

namespace TaskCoreHub.Application.Commands.TeamCommands.CreateTeamCommand
{
    public class CreateTeamCommandHandler : IRequestHandler<CreateTeamCommand, ResponseResult<Guid>>
    {
        private readonly ITeamRepository _repository;
        public CreateTeamCommandHandler(ITeamRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResponseResult<Guid>> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
        {
            var createTeam= new Team(request.Title, request.Description);

            await _repository.Create(createTeam);

            return new ResponseResult<Guid>(createTeam.Id);
        }
    }
}
