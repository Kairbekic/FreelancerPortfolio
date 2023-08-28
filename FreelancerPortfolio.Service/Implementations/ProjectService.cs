using FreelancerPortfolio.Domain.Entity;
using FreelancerPortfolio.Service.Interfaces;
using FreelancerPortfolio.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;
using FreelancerPortfolio.Domain.Response;
using FreelancerPortfolio.Domain.Enum;

namespace FreelancerPortfolio.Service.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly IBaseRepository<Project> _projectRepository;
        public ProjectService(IBaseRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public IBaseResponse<List<Project>> GetProjects()
        {
            try
            {
                var projects = _projectRepository.GetAll().ToList();
                if (!projects.Any())
                {
                    return new BaseResponse<List<Project>>()
                    {
                        Description = "Найдено 0 элементов",
                        StatusCode = StatusCode.OK
                    };
                }

                return new BaseResponse<List<Project>>()
                {
                    Data = projects,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<List<Project>>()
                {
                    Description = $"[GetProdjects] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        //public BaseResponse<Dictionary<int, string>> GetTypes()
        //{
        //    try
        //    {
        //        var types = ((TypeProject[])Enum.GetValues(typeof(TypeProject)))
        //            .ToDictionary(k => (int)k, t => t.GetDisplayName());

        //        return new BaseResponse<Dictionary<int, string>>()
        //        {
        //            Data = types,
        //            StatusCode = StatusCode.OK
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        return new BaseResponse<Dictionary<int, string>>()
        //        {
        //            Description = ex.Message,
        //            StatusCode = StatusCode.InternalServerError
        //        };
        //    }
        //}
    }
}
