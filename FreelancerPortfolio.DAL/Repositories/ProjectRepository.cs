using FreelancerPortfolio.DAL.Interfaces;
using FreelancerPortfolio.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerPortfolio.DAL.Repositories
{
    public class ProjectRepository : IBaseRepository<Project>
    {
        private readonly ApplicationDbContext _db;

        public ProjectRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Create(Project entity)
        {
            await _db.Projects.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Project> GetAll()
        {
            return _db.Projects;
        }

        public async Task Delete(Project entity)
        {
            _db.Projects.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<Project> Update(Project entity)
        {
            _db.Projects.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
