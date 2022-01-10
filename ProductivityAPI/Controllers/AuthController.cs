using Application.Auth.Commands;
using Common.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductivityAPI.Controllers
{
  
    public class AuthController : BaseController    
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost, Route("Login"), AllowAnonymous]

        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            if (loginModel == null) return BadRequest();


            var query = await _mediator.Send(new LoginCommand(loginModel));
            return Ok(query);
        }
      
        [HttpPost,Route("Register"), AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] LoginModel registerModel)
        {
           return BadRequest();
        }
    }
}
