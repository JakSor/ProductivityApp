using Application.Tasks.Commands;
using Application.Tasks.Queries;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductivityAPI.Controllers
{        public class TasksController : BaseController
        {
        public TasksController(IMediator mediator) : base(mediator)
        { }
           
            [Route("CreateTask")]
            [HttpPost]
            public async Task<IActionResult> CreateTask([FromBody] TaskItem task)
            {
                var command = new CreateTaskCommand(task);
                var result = await _mediator.Send(command);
                return Ok(result);
            }
        [AllowAnonymous]
        [Route("GetAllTasks"),HttpPost]
        public async Task<IActionResult> GetAllTasks()
        {
            var query = new GetAllTasksQuery();
            var result = await _mediator.Send(query);   
            return Ok(result);
        }
        }
    }


