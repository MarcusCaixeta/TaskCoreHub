
using MediatR;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.Repositories;

namespace TaskCoreHub.Application.Commands.AppCommands.CreateAppCommand
{
    public class CreateAppCommandHandler : IRequestHandler<CreateAppCommand, ResponseResult<Guid>>
    {
        private readonly IAppRepository _repository;
        public CreateAppCommandHandler(IAppRepository repository)
        {
            _repository = repository;
        }


        async Task<ResponseResult<Guid>> IRequestHandler<CreateAppCommand, ResponseResult<Guid>>.Handle(CreateAppCommand request, CancellationToken cancellationToken)
        {
            var app = new App(request.Description, request.IdTeam);

            await _repository.Create(app);

            return new ResponseResult<Guid>(app.Id);
        }
    }
}
