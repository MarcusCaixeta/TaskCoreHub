using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCoreHub.Application.Models;
using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Application.Queries.AppQueries.GetAllAppQuery
{
    public class GetAllAppQuery : IRequest<ResponseResult<List<App>>>
    {
    }
}
