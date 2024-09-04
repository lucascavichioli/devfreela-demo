using DevFreela.Application.Models;
using DevFreela.Core.Entities;
using MediatR;

namespace DevFreela.Application.Queries.SkillQueries.GetAllQuery
{
    public class GetAllQuery : IRequest<ResultViewModel<List<Skill>>>
    {
    }
}
