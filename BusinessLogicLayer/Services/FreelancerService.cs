using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces;
using FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces;
using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Services
{
    public class FreelancerService : IFreelancerService
    {
        private readonly IFreelancerRepo _repo;

        public FreelancerService(IFreelancerRepo repo)
        {
            _repo = repo;
        }

        public async Task Add(Freelancer freelancer)
        {
            await _repo.Add(freelancer);
        }

        public async Task Delete(int id)
        {
            await _repo.DeleteById(id);
        }

        public async Task DeleteAll()
        {
            await _repo.DeleteAll();
        }

        public async Task<IEnumerable<Freelancer>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Freelancer> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task Update(Freelancer freelancer)
        {
            await _repo.Update(freelancer);
        }
    }
}
