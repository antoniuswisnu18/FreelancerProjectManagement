using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces
{
    public interface IPaymentStatusMasterService
    {
        Task<IEnumerable<PaymentStatusMaster>> GetAllStatus();

        Task<PaymentStatusMaster> GetStatusById(int id);
    }
}
