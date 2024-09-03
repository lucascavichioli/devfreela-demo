﻿using DevFreela.Application.Commands.ProjectCommands.InsertProject;
using DevFreela.Application.Services;
using Microsoft.Extensions.DependencyInjection;


namespace DevFreela.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddServices()
                    .AddHandlers();
            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<ISkillsService, SkillsService>();
            return services;
        }

        private static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            services.AddMediatR(config =>
                    config.RegisterServicesFromAssemblyContaining<InsertProjectCommand>());

            return services;
        }
    }
}
