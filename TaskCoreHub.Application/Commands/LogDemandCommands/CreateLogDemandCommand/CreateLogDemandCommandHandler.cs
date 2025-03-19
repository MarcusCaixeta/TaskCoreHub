using MediatR;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.Repositories;

namespace TaskCoreHub.Application.Commands.LogDemandCommands.CreateLogDemandCommand
{
    public class CreateLogDemandCommandHandler : IRequestHandler<CreateLogDemandCommand,ResponseResult<Guid>>
    {
        private readonly ILogDemandRepository _repository;
        public CreateLogDemandCommandHandler(ILogDemandRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseResult<Guid>> Handle(CreateLogDemandCommand request, CancellationToken cancellationToken)
        {
            var createLogDemand = new LogDemand(request.IdDemand,request.IdUserLog, request.IdTypeLog, request.DescriptionLog);

            await _repository.Create(createLogDemand);

            return new ResponseResult<Guid>(createLogDemand.Id);
        }
    }
}
