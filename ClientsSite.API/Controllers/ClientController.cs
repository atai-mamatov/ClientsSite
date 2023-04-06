using ClientsSite.Data.Request;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientsSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateClient(CreateClientRequest request)
        {
            var clientId = await _mediator.Send(request);
            return Ok(clientId);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditClient(int id, EditClientRequest request)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }

            var result = await _mediator.Send(request);

            if (result == 0)
            {
                return NotFound();
            }

            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<int>> DeleteClient(int id)
        {
            var request = new DeleteClientRequest { Id = id };
            var clientId = await _mediator.Send(request);
            return Ok(clientId);
        }


    }
}

