using DevFreela.Application.Models;
using DevFreela.Applications.Models;
using DevFreela.Core.Entities;

namespace DevFreela.Application.Services
{
    public interface ISkillsService
    {
        ResultViewModel<List<Skill>> GetAll();
        ResultViewModel<int> Post(CreateSkillInputModel model);
    }
}