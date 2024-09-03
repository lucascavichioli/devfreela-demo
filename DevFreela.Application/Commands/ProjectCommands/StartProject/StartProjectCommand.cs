﻿
using DevFreela.Application.Models;
using MediatR;

namespace DevFreela.Application.Commands.ProjectCommands.StartProject
{
    public class StartProjectCommand : IRequest<ResultViewModel>
    {
        public int Id { get; set; }
        public StartProjectCommand(int id)
        {
            Id = id;
        }
    }
}
