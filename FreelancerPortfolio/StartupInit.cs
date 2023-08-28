using FreelancerPortfolio.DAL.Interfaces;
using FreelancerPortfolio.Domain.Entity;
using FreelancerPortfolio.Service.Implementations;
using FreelancerPortfolio.Service.Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;
using FreelancerPortfolio.DAL.Repositories;

namespace FreelancerPortfolio
{
    public static class StartupInit
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<Project>, ProjectRepository>();
        }

        public static void InitializeServices(this IServiceCollection services)
        {
            services.AddScoped<IProjectService, ProjectService>();
        }
    }
}
