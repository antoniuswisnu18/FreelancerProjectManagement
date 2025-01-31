using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetAll();
        Task<Project> GetById(int id);
        Task Add (Project project);
        Task Update (Project project);
        Task Delete (int id);
        Task DeleteAll();

    }
}
