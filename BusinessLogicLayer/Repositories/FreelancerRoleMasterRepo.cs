using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces;
using FreelancerProjectManagementAPI.DataAccessLayer;
using FreelancerProjectManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories
{
    public class FreelancerRoleMasterRepo : IFreelancerRoleMasterRepo
    {
        private readonly ApplicationDbContext _context;

        public FreelancerRoleMasterRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<FreelancerRoleMaster>> GetAllAsync()
        {
            return await _context.FreelancerRoleMasters.ToListAsync();
        }

        public async Task<FreelancerRoleMaster> GetByIdAsync(int id)
        {
            return await _context.FreelancerRoleMasters.FirstOrDefaultAsync(x => x.FreelancerRoleId == id);
        }
    }
}
