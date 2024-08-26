using DevFreela.Core.Entities;
using DevFreela.Applications.Models;
using DevFreela.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DevFreela.Application.Services;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _service;
        public UsersController(IUsersService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _service.GetById(id);

            if (!result.IsSuccess)
                return BadRequest(result.Message);

            return Ok(result);
        }

        // POST api/users
        [HttpPost]
        public IActionResult Post(CreateUserInputModel model)
        {
            var result = _service.Post(model);
            if (!result.IsSuccess)
                return BadRequest(result.Message);

            return NoContent();
        }

        [HttpPost("{id}/skills")]
        public IActionResult PostSkills(int id, UserSkillsInputModel model)
        {
            var result = _service.PostSkills(id, model);
            if (!result.IsSuccess)
                return BadRequest(result.Message);

            return NoContent();
        }

        [HttpPut("{id}/profile-picture")]
        public IActionResult PostProfilePicture(int id, IFormFile file)
        {
            var result = _service.PostProfilePicture(id, file);
            if (!result.IsSuccess)
                return BadRequest(result.Message);
            
            return Ok(result);
        }
    }
}
