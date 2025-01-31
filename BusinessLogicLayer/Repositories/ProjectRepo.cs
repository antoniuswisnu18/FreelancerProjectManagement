using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces;
using FreelancerProjectManagementAPI.DataAccessLayer;
using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories
{
    public class ProjectRepo : GenericRepository<Project>, IProjectRepo
    {
        private readonly ILogger<ProjectRepo> _logger;
        public ProjectRepo(ApplicationDbContext context, ILogger<ProjectRepo> logger) : base(context, logger)
        {
            _logger = logger;
        }
    }
}
