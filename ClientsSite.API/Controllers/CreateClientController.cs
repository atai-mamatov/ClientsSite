using ClientsSite.Data.Request;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientsSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateClientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CreateClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateClient(CreateClientRequest request)
        {
            var clientId = await _mediator.Send(request);
            return Ok(clientId);
        }



    }
}

