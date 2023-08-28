using FreelancerPortfolio.Domain.Entity;
using FreelancerPortfolio.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerPortfolio.Service.Interfaces
{
    public interface IProjectService
    {
        //BaseResponse<Dictionary<int, string>> GetTypes();

        IBaseResponse<List<Project>> GetProjects();

        //Task<IBaseResponse<CarViewModel>> GetProject(long id);

        //Task<BaseResponse<Dictionary<long, string>>> GetProject(string term);

        //Task<IBaseResponse<Project>> Create(ProjectViewModel car, byte[] imageData);

        //Task<IBaseResponse<bool>> DeleteProject(long id);

        //Task<IBaseResponse<Project>> Edit(long id, ProjectViewModel model);
    }
}
