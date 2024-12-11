using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces
{
    public interface IFreelancerRoleMasterRepo
    {
        Task<IEnumerable<FreelancerRoleMaster>> GetAllAsync();
        Task<FreelancerRoleMaster> GetByIdAsync(int id);

    }
}
