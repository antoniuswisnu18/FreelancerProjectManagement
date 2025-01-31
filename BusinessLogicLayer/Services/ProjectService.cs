using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces;
using FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces;
using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepo _repo;

        public ProjectService(IProjectRepo repo)
        {
            _repo = repo;
        }

        public async Task Add(Project project)
        {
            await _repo.Add(project);
        }

        public async Task Delete(int id)
        {
            await _repo.DeleteById(id);
        }

        public async Task DeleteAll()
        {
            await _repo.DeleteAll();
        }

        public async Task<IEnumerable<Project>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Project> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task Update(Project project)
        {
            await _repo.Update(project);
        }
    }
}
