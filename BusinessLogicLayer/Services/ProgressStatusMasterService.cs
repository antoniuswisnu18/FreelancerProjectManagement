using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces;
using FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces;
using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Services
{
    public class ProgressStatusMasterService : IProgressStatusMasterService
    {
        private readonly IProgressStatusMasterRepo _repo;

        public ProgressStatusMasterService(IProgressStatusMasterRepo repo)
        {
            _repo = repo;
        }
        public async Task<IEnumerable<ProgressStatusMaster>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<ProgressStatusMaster> GetById(int id)
        {
            return await _repo.GetById(id);
        }
    }
}
