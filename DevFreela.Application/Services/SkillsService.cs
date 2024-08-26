using DevFreela.Application.Models;
using DevFreela.Applications.Models;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Services
{
    public class SkillsService : ISkillsService
    {
        private readonly DevFreelaDbContext _context;
        public SkillsService(DevFreelaDbContext context)
        {
            _context = context;
        }

        public ResultViewModel<List<Skill>> GetAll()
        {
            var skills = _context.Skills.ToList();

            return ResultViewModel<List<Skill>>.Success(skills);
        }
        public ResultViewModel<int> Post(CreateSkillInputModel model)
        {
            var skill = new Skill(model.Description);
            _context.Skills.Add(skill);
            _context.SaveChanges();

            return ResultViewModel<int>.Success(skill.Id);
        }
    }
}
