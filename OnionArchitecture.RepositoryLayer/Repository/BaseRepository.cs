using Microsoft.EntityFrameworkCore;
using OnionArchitecture.RepositoryLayer.ApplicationDataBaseContexts;
using OnionArchitecture.RepositoryLayer.IRepository;
using System.Linq.Expressions;

namespace OnionArchitecture.RepositoryLayer.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _entities;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public async Task AddAsync(T entity) => await _entities.AddAsync(entity);
        public Task DeleteAsync(T entity) => Task.FromResult(_entities.Remove(entity));
        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate) => await _entities.FirstOrDefaultAsync(predicate);
        public Task UpdateAsync(T entity) => Task.FromResult(_entities.Attach(entity));
        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate is null)
                return await _entities.ToListAsync();
            else
                return await _entities.Where(predicate).ToListAsync();
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            if(predicate is null)
                return  _entities.Count(predicate);
            else return _entities.Count();
        }
    }
}
