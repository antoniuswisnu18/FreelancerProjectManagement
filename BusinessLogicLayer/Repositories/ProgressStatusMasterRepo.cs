using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces;
using FreelancerProjectManagementAPI.DataAccessLayer;
using FreelancerProjectManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories
{
    public class ProgressStatusMasterRepo : GenericRepository<ProgressStatusMaster>, IProgressStatusMasterRepo
    {
        private readonly ILogger<ProgressStatusMasterRepo> _logger;
        public ProgressStatusMasterRepo(ApplicationDbContext context, ILogger<ProgressStatusMasterRepo> logger) : base(context, logger)
        {
            _logger = logger;
        }
    }
}
