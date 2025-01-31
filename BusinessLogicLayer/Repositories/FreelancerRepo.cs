using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces;
using FreelancerProjectManagementAPI.DataAccessLayer;
using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories
{
    public class FreelancerRepo : GenericRepository<Freelancer>, IFreelancerRepo
    {
        private readonly ILogger<FreelancerRepo> _logger;
        public FreelancerRepo(ApplicationDbContext context, ILogger<FreelancerRepo> logger) : base(context, logger)
        {
            _logger = logger;
        }
    }
}
