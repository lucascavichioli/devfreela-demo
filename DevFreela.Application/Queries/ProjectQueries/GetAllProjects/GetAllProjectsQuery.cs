using DevFreela.API.Models;
using DevFreela.Application.Models;
using MediatR;

namespace DevFreela.Application.Queries.ProjectQueries.GetAllProjects
{
    public class GetAllProjectsQuery : IRequest<ResultViewModel<List<ProjectItemViewModel>>>
    {
        public string search { get; set; } = "";
        public int page { get; set; } = 0;
        public int size { get; set; } = 3;
    }
}
