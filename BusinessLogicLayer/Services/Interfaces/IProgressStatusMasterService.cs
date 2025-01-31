using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces
{
    public interface IProgressStatusMasterService
    {
        Task<IEnumerable<ProgressStatusMaster>> GetAll();

        Task<ProgressStatusMaster> GetById(int id);
    }
}
