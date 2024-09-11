using DevFreela.Application.Models;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using MediatR;

namespace DevFreela.Application.Commands.UserCommands.InsertSkills
{
    public class InsertSkillsHandler : IRequestHandler<InsertSkillsCommand, ResultViewModel>
    {
        private readonly IUserRepository _repository;
        public InsertSkillsHandler(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel> Handle(InsertSkillsCommand request, CancellationToken cancellationToken)
        {
            var userSkills = request.SkillIds.Select(s => new UserSkill(request.Id, s)).ToList();
            await _repository.AddSkill(userSkills);

            return ResultViewModel<int>.Success(request.Id);
        }
    }

}
