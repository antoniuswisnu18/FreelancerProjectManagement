﻿using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces;
using FreelancerProjectManagementAPI.DataAccessLayer;
using FreelancerProjectManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories
{
    public class FreelancerRoleMasterRepo : GenericRepository<FreelancerRoleMaster>, IFreelancerRoleMasterRepo
    {
        private readonly ILogger<FreelancerRoleMasterRepo> _logger;
        public FreelancerRoleMasterRepo(ApplicationDbContext context, ILogger<FreelancerRoleMasterRepo> logger) : base(context,logger)
        {
            _logger = logger;
        }
    }
}
