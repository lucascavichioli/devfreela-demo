using DevFreela.Application.Models;
using DevFreela.Applications.Models;
using MediatR;

namespace DevFreela.Application.Queries.ProjectQueries.GetProjectById
{
    public class GetProjectByIdQuery : IRequest<ResultViewModel<ProjectViewModel>>
    {
        public int Id { get; set; }

        public GetProjectByIdQuery(int id)
        {
            Id = id;
        }
    }
}
