using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces
{
    public interface IFreelancerRoleMasterService
    {
        Task<IEnumerable<FreelancerRoleMaster>> GetAllRoleAsync();
        Task<FreelancerRoleMaster> GetRoleById(int id);
    }
}
