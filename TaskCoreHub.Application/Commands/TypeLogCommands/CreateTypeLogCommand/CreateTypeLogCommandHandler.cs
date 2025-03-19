using MediatR;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.Repositories;

namespace TaskCoreHub.Application.Commands.TypeLogCommands.CreateTypeLogCommand
{
    public class CreateTypeLogCommandHandler : IRequestHandler<CreateTypeLogCommand, ResponseResult<Guid>>
    {
        private readonly ITypeLogRepository _repository;
        public CreateTypeLogCommandHandler(ITypeLogRepository repository)
        {
            _repository = repository;

        }

        public async Task<ResponseResult<Guid>> Handle(CreateTypeLogCommand request, CancellationToken cancellationToken)
        {
            var typeLog = new TypeLog(request.Description);

            await _repository.Create(typeLog);

            return new ResponseResult<Guid>(typeLog.Id);
        }
    }
}
