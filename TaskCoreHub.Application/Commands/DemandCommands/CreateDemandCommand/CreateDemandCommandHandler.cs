using MediatR;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.Repositories;

namespace TaskCoreHub.Application.Commands.DemandCommands.CreateDemandCommand
{
    public class CreateDemandCommandHandler : IRequestHandler<CreateDemandCommand, ResponseResult<Guid>>
    {
        private readonly IDemandRepository _repository;
        public CreateDemandCommandHandler(IDemandRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResponseResult<Guid>> Handle(CreateDemandCommand request, CancellationToken cancellationToken)
        {
            var createDemand = new Demand(request.Title, request.Description, request.IdTeam, request.IdStartReason, request.IdUserCreate, request.DateStart, request.Priority, request.Effort);

            await _repository.Create(createDemand);

            return new ResponseResult<Guid>(createDemand.Id);
        }
    }
}
