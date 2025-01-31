using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces;
using FreelancerProjectManagementAPI.DataAccessLayer;
using FreelancerProjectManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories
{
    public class PaymentStatusMasterRepo : GenericRepository<PaymentStatusMaster>, IPaymentStatusMasterRepo
    {
        private readonly ILogger<PaymentStatusMasterRepo> _logger;
        public PaymentStatusMasterRepo(ApplicationDbContext context, ILogger<PaymentStatusMasterRepo> logger) : base(context, logger)
        {
            _logger = logger;
        }
    }
}
