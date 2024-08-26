using DevFreela.Application.Models;
using DevFreela.Applications.Models;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Services
{
    public class UsersService : IUsersService
    {
        private readonly DevFreelaDbContext _context;
        public UsersService(DevFreelaDbContext context)
        {
            _context = context;
        }
        public ResultViewModel<UserViewModel> GetById(int id)
        {
            var user = _context.Users
                        .Include(u => u.Skills)
                            .ThenInclude(u => u.Skill)
                        .SingleOrDefault(u => u.Id == id);

            if (user is null)
            {
                return ResultViewModel<UserViewModel>.Error("Usuário não existe");
            }

            var model = UserViewModel.FromEntity(user);

            return ResultViewModel<UserViewModel>.Success(model);
        }

        public ResultViewModel<int> Post(CreateUserInputModel model)
        {
            var user = new User(model.FullName, model.Email, model.BirthDate);
            _context.Users.Add(user);
            _context.SaveChanges();

            return ResultViewModel<int>.Success(user.Id);
        }

        public ResultViewModel PostProfilePicture(int id, IFormFile file)
        {
            var description = $"FIle: {file.FileName}, Size: {file.Length}";

            // Processar a imagem

            return ResultViewModel.Success();
        }

        public ResultViewModel<int> PostSkills(int id, UserSkillsInputModel model)
        {
            var userSkills = model.SkillIds.Select(s => new UserSkill(id, s)).ToList();

            _context.UserSkills.AddRange(userSkills);
            _context.SaveChanges();

            return ResultViewModel<int>.Success(id);
        }
    }
}
