﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // POST api/users
        [HttpPost]
        public IActionResult Post()
        {
            return NoContent();
        }

        [HttpPut("{id}/profile-picture")]
        public IActionResult PostProfilePicture(IFormFile file) 
        {
            var description = $"File: {file.FileName}, Size: {file.Length}";

            //processar a imagem
            return Ok(description);
        }
    }
}
