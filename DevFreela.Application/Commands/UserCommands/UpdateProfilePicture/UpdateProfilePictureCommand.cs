using DevFreela.Application.Models;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace DevFreela.Application.Commands.UserCommands.UpdateProfilePicture
{
    public class UpdateProfilePictureCommand : IRequest<ResultViewModel>
    {
        public int Id { get; set; }
        public IFormFile File { get; set; }
    }
}
