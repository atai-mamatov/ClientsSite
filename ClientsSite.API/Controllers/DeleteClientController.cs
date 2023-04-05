using ClientsSite.Data.Request;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientsSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteClientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DeleteClientController(IMediator mediator)
        {
            _mediator = mediator;
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
