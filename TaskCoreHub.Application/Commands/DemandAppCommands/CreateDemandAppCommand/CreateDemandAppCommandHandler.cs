using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.Repositories;

namespace TaskCoreHub.Application.Commands.DemandAppCommands.CreateDemandAppCommand
{
    public class CreateDemandAppCommandHandler : IRequestHandler<CreateDemandAppCommand, ResponseResult<Guid>>
    {
        private readonly IDemandAppRepository _repository;
        public CreateDemandAppCommandHandler(IDemandAppRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResponseResult<Guid>> Handle(CreateDemandAppCommand request, CancellationToken cancellationToken)
        {
            var createDemandApp = new DemandApp(request.IdApplication, request.IdDemand);

            await _repository.Create(createDemandApp);
            return new ResponseResult<Guid>(createDemandApp.Id);
        }
    }
}
