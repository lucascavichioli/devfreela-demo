using DevFreela.Core.Entities;
using DevFreela.Applications.Models;
using DevFreela.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using DevFreela.Application.Services;

namespace DevFreela.API.Controllers
{
    [Route("api/skills")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillsService _service;
        public SkillsController(ISkillsService service)
        {
            _service = service;
        }

        // GET api/skills
        [HttpGet]
        public IActionResult GetAll()
        {
           var result = _service.GetAll();
           return Ok(result);
        }

        // POST api/skills
        [HttpPost]
        public IActionResult Post(CreateSkillInputModel model)
        {
            var result = _service.Post(model);
            if(!result.IsSuccess)
                return BadRequest(result);
            return NoContent();
        }
    }
}
