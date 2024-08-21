using Azure;
using DevFreela.API.Models;
using DevFreela.Application.Models;
using DevFreela.Applications.Models;
using System.Drawing;

namespace DevFreela.Application.Services
{
    public interface IProjectService
    {
        ResultViewModel<List<ProjectItemViewModel>> GetAll(string search = "", int page = 0, int size = 3);
        ResultViewModel<ProjectViewModel> GetById(int id);

        ResultViewModel<int> Insert(CreateProjectInputModel model);
        ResultViewModel Update(int id, UpdateProjectInputModel model);
        ResultViewModel Delete(int id);
        ResultViewModel Start(int id);
        ResultViewModel Complete(int id);
        ResultViewModel InsertComment(int id, CreateProjectCommentInputModel model);
    }
}
