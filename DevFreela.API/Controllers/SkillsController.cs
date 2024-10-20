using Microsoft.AspNetCore.Mvc;
using MediatR;
using DevFreela.Application.Queries.SkillQueries.GetAllQuery;
using DevFreela.Application.Commands.SkillCommands;
using Microsoft.AspNetCore.Authorization;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/skills")]
    [Authorize]
    public class SkillsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SkillsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/skills
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           var result = await _mediator.Send(new GetAllQuery());
           return Ok(result);
        }

        // POST api/skills
        [HttpPost]
        public async Task<IActionResult> Post(InsertSkillCommand command)
        {
            var result = await _mediator.Send(command);
            if(!result.IsSuccess)
                return BadRequest(result);
            return NoContent();
        }
    }
}
