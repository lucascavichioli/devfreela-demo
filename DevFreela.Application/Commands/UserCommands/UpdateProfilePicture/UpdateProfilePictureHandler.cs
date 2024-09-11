using DevFreela.Application.Models;
using MediatR;

namespace DevFreela.Application.Commands.UserCommands.UpdateProfilePicture
{
    public class UpdateProfilePictureHandler : IRequestHandler<UpdateProfilePictureCommand, ResultViewModel>
    {
        public async Task<ResultViewModel> Handle(UpdateProfilePictureCommand request, CancellationToken cancellationToken)
        {
            var description = $"FIle: {request.File.FileName}, Size: {request.File.Length}";

            // Processar a imagem

            return ResultViewModel.Success();
        }
    }
}
