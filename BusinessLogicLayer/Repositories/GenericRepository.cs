using FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories.Interfaces;
using FreelancerProjectManagementAPI.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

namespace FreelancerProjectManagementAPI.BusinessLogicLayer.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;
        private readonly ILogger<GenericRepository<T>> _logger; 

        public GenericRepository(ApplicationDbContext context, ILogger<GenericRepository<T>> logger)
        {
            _context = context;
            _dbSet = context.Set<T>();
            _logger = logger;
        }

        public virtual async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Adding a new {typeof(T).Name}");
        }

        public async Task DeleteAll()
        {
            _dbSet.RemoveRange(_dbSet);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {
            var entity = await GetById(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
               await  _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<T>> GetAll() => await _dbSet.ToListAsync();

        public async Task<T> GetById(int id) => await _dbSet.FindAsync(id);

        public async Task Update(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
