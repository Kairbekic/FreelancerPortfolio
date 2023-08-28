using FreelancerPortfolio.Domain.Entity;
using FreelancerPortfolio.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FreelancerPortfolio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        [HttpGet(Name = "GetProjects")]
        public IEnumerable<Project> GetProjects()
        {
            var response = _projectService.GetProjects();
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return response.Data;
            }
            return response.Data;
        }

    }
}
