using DevFreela.Application.Models;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Queries.SkillQueries.GetAllQuery
{
    public class GetAllHandler : IRequestHandler<GetAllQuery, ResultViewModel<List<Skill>>>
    {
        private readonly DevFreelaDbContext _context;
        public GetAllHandler(DevFreelaDbContext context)
        {
            _context = context;
        }
        public async Task<ResultViewModel<List<Skill>>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            var skills = await _context.Skills.ToListAsync();

            return ResultViewModel<List<Skill>>.Success(skills);
        }
    }
}
