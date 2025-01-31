using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces;
using FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces;
using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Services
{
    public class PaymentStatusMasterService : IPaymentStatusMasterService
    {
        private readonly IPaymentStatusMasterRepo _repo;

        public PaymentStatusMasterService(IPaymentStatusMasterRepo repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<PaymentStatusMaster>> GetAllStatus()
        {
            return await _repo.GetAll();
        }

        public async Task<PaymentStatusMaster> GetStatusById(int id)
        {
            return await _repo.GetById(id);
        }
    }
}
