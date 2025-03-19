using MediatR;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.Repositories;

namespace TaskCoreHub.Application.Commands.ReasonCommands.CreateReasonCommand
{
    public class CreateReasonCommandHandler : IRequestHandler<CreateReasonCommand, ResponseResult<Guid>>
    {
        private readonly IReasonRepository _repository;
        public CreateReasonCommandHandler(IReasonRepository repository)
        {
            _repository = repository;
        }

        public async  Task<ResponseResult<Guid>> Handle(CreateReasonCommand request, CancellationToken cancellationToken)
        {
            var createReason = new Reason(request.Description);

            await _repository.Create(createReason);

            return new ResponseResult<Guid>(createReason.Id);
        }
    }
}
