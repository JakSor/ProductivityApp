using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace ProductivityAPI.Controllers
{   [Authorize]
    [RequiredScope("tasks.read")]
    [Route("[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        internal IMediator _mediator;
        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
