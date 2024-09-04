using DevFreela.Application.Models;
using DevFreela.Applications.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Commands.UserCommands.InsertSkills
{
    public class InsertSkillsCommand : IRequest<ResultViewModel>
    {
        public int[] SkillIds { get; set; }
        public int Id { get; set; }
    }

}
