using Microsoft.AspNetCore.Mvc;
using MediatR;
using DevFreela.Application.Queries.UserQueries.GetUserById;
using DevFreela.Application.Commands.ProjectCommands.InsertComment;
using DevFreela.Application.Commands.UserCommands.InsertSkills;
using DevFreela.Application.Commands.UserCommands.UpdateProfilePicture;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetUserByIdQuery(id));

            if (!result.IsSuccess)
                return BadRequest(result.Message);

            return Ok(result);
        }

        // POST api/users
        [HttpPost]
        public async Task<IActionResult> Post(InsertCommentCommand command)
        {
            var result = await _mediator.Send(command);
            
            if (!result.IsSuccess)
                return BadRequest(result.Message);

            return NoContent();
        }

        [HttpPost("{id}/skills")]
        public async Task<IActionResult> PostSkills(InsertSkillsCommand command)
        {
            var result = await _mediator.Send(command);
            if (!result.IsSuccess)
                return BadRequest(result.Message);

            return NoContent();
        }

        [HttpPut("{id}/profile-picture")]
        public async Task<IActionResult> PostProfilePicture(UpdateProfilePictureCommand command)
        {
            var result = await _mediator.Send(command);
            if (!result.IsSuccess)
                return BadRequest(result.Message);
            
            return Ok(result);
        }
    }
}
