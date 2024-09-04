using DevFreela.Application.Models;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using MediatR;

namespace DevFreela.Application.Commands.UserCommands.InsertSkills
{
    public class InsertSkillsHandler : IRequestHandler<InsertSkillsCommand, ResultViewModel>
    {
        private readonly DevFreelaDbContext _context;
        public InsertSkillsHandler(DevFreelaDbContext context)
        {
            _context = context;
        }
        public async Task<ResultViewModel> Handle(InsertSkillsCommand request, CancellationToken cancellationToken)
        {
            var userSkills = request.SkillIds.Select(s => new UserSkill(request.Id, s)).ToList();

            await _context.UserSkills.AddRangeAsync(userSkills);
            await _context.SaveChangesAsync();

            return ResultViewModel<int>.Success(request.Id);
        }
    }

}
