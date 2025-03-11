using MediatR;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Application.Queries.UserQueries.GetAllUserCommand
{
    public class GetAllUserQuery : IRequest<ResponseResult<List<User>>>
    {
    }
}
