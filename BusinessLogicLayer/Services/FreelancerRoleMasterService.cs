using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories;
using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces;
using FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces;
using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Services
{
    public class FreelancerRoleMasterService : IFreelancerRoleMasterService
    {
        private readonly IFreelancerRoleMasterRepo _repo;

        public FreelancerRoleMasterService(IFreelancerRoleMasterRepo repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<FreelancerRoleMaster>> GetAllRoleAsync()
        {
            return await _repo.GetAll();
        }

        public async Task<FreelancerRoleMaster> GetRoleById(int id)
        {
            return await _repo.GetById(id);
        }
    }
}
