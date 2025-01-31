using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces
{
    public interface IFreelancerService
    {
        Task<IEnumerable<Freelancer>> GetAll();
        Task<Freelancer> GetById(int id);
        Task Add(Freelancer freelancer);
        Task Update(Freelancer freelancer);
        Task Delete(int id);
        Task DeleteAll();
    }
}
