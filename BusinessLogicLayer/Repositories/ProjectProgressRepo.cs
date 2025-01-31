using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces;
using FreelancerProjectManagementAPI.DataAccessLayer;
using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories
{
    public class ProjectProgressRepo : GenericRepository<ProjectProgress>, IProjectProgressRepo
    {
        private readonly ILogger<ProjectProgressRepo> _logger;
        public ProjectProgressRepo(ApplicationDbContext context, ILogger<ProjectProgressRepo> logger) : base(context, logger)
        {
            _logger = logger;
        }
    }
}
