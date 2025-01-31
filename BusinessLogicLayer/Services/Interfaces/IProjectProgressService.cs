using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces
{
    public interface IProjectProgressService
    {
        Task<IEnumerable<ProjectProgress>> GetAll();
        Task<ProjectProgress> GetById(int id);
        Task Add (ProjectProgress projectProgress);
        Task Update (ProjectProgress projectProgress);
        Task Delete (int id);
        Task DeleteAll();
    }
}
