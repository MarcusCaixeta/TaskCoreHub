using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Application.Queries.UserQueries.GetAllUserCommand;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.Repositories;

namespace TaskCoreHub.Application.Queries.AppQueries.GetAllAppQuery
{
    public class GetAllAppQueryHandler : IRequestHandler<GetAllAppQuery, ResponseResult<List<App>>>
    {
        private readonly IAppRepository _repository;

        public GetAllAppQueryHandler(IAppRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResponseResult<List<App>>> Handle(GetAllAppQuery request, CancellationToken cancellationToken)
        {
            var apps = await _repository.GetAllApp();

            return new ResponseResult<List<App>>(apps);
        }
    }
}
