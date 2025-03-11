using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.Repositories;

namespace TaskCoreHub.Application.Queries.UserQueries.GetAllUserCommand
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, ResponseResult<List<User>>>
    {
        private readonly IUserRepository _repository;

        public GetAllUserQueryHandler(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResponseResult<List<User>>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var users = await _repository.GetAllUser();

            return new ResponseResult<List<User>>(users);
        }
    }
}
