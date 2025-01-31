namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Add(T entity);
        Task Update(T entity);
        Task DeleteById(int id);
        Task DeleteAll();

    }
}
