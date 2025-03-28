﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskCoreHub.Application.Commands.UserCommands.CreateUserCommand;
using TaskCoreHub.Application.Queries.UserQueries.GetAllUserCommand;

namespace TaskCoreHub.Api.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost()]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
        {
            var user = await _mediator.Send(command);
            return Ok(user);
        }
        [HttpGet()]
        public async Task<IActionResult> GetAllUser()
        {
            var query = new GetAllUserQuery();
            var users = await _mediator.Send(query);
            return Ok(users);
        }
    }
}
