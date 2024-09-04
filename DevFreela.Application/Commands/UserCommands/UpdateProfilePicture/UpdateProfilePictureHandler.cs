using DevFreela.Application.Models;
using DevFreela.Infrastructure.Persistence;
using MediatR;

namespace DevFreela.Application.Commands.UserCommands.UpdateProfilePicture
{
    public class UpdateProfilePictureHandler : IRequestHandler<UpdateProfilePictureCommand, ResultViewModel>
    {
        private readonly DevFreelaDbContext _context;
        public UpdateProfilePictureHandler(DevFreelaDbContext context)
        {
            _context = context;
        }
        public async Task<ResultViewModel> Handle(UpdateProfilePictureCommand request, CancellationToken cancellationToken)
        {
            var description = $"FIle: {request.File.FileName}, Size: {request.File.Length}";

            // Processar a imagem

            return ResultViewModel.Success();
        }
    }
}
