using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces;
using FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces;
using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Services
{
    public class ProjectProgressService : IProjectProgressService
    {
        private readonly IProjectProgressRepo _repo;

        public ProjectProgressService(IProjectProgressRepo repo)
        {
            _repo = repo;
        }

        public async Task Add(ProjectProgress projectProgress)
        {
            await _repo.Add(projectProgress);
        }

        public async Task Delete(int id)
        {
            await _repo.DeleteById(id);
        }

        public async Task DeleteAll()
        {
            await _repo.DeleteAll();
        }

        public async Task<IEnumerable<ProjectProgress>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<ProjectProgress> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task Update(ProjectProgress projectProgress)
        {
            await _repo.Update(projectProgress);
        }
    }
}
