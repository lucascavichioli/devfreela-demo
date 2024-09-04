using DevFreela.Application.Models;
using DevFreela.Applications.Models;
using MediatR;

namespace DevFreela.Application.Queries.UserQueries.GetUserById
{
    public class GetUserByIdQuery : IRequest<ResultViewModel<UserViewModel>>
    {
        public int Id { get; set; }
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}
