using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using ClientsSite.Data.Request;

namespace ClientsSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditClientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EditClientController(IMediator mediator)
        {
            _mediator = mediator;
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
    }

}