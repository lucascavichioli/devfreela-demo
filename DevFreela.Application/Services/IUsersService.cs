using DevFreela.Application.Models;
using DevFreela.Applications.Models;
using Microsoft.AspNetCore.Http;

namespace DevFreela.Application.Services
{
    public interface IUsersService
    {
        ResultViewModel<UserViewModel> GetById(int id);
        ResultViewModel<int> Post(CreateUserInputModel model);
        ResultViewModel<int> PostSkills(int id, UserSkillsInputModel model);
        ResultViewModel PostProfilePicture(int id, IFormFile file);
    }
}