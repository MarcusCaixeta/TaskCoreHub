using MediatR;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.Repositories;

namespace TaskCoreHub.Application.Commands.StatusDemandCommands.CreateStatusDemandCommand
{
    public class CreateStatusDemandCommandHandler : IRequestHandler<CreateStatusDemandCommand, ResponseResult<Guid>>
    {
        private readonly IStatusDemandRepository _repository;
        public CreateStatusDemandCommandHandler(IStatusDemandRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseResult<Guid>> Handle(CreateStatusDemandCommand request, CancellationToken cancellationToken)
        {
            var createStatusDemand = new StatusDemand(request.DescriptionBasic, request.DescriptionDetailed);

            await _repository.Create(createStatusDemand);

            return new ResponseResult<Guid>(createStatusDemand.Id);
        }
    }
}
