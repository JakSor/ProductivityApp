using Application.Tasks.Commands;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductivityAPI.Controllers
{        public class TasksController : BaseController
        {
           
            [Route("CreateTask")]
            [HttpPost]
            public async Task<IActionResult> CreateTask([FromBody] TaskItem task)
            {
                var command = new CreateTaskCommand(task);
                var result = await _mediator.Send(command);
                return Ok(result);
            }
        }
    }


