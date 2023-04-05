using System.Linq.Expressions;


namespace OnionArchitecture.RepositoryLayer.IRepository
{
    public interface IBaseRepository <T> where T : class
    {
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T , bool>> predicate = null);
        Task<T> GetAsync(Expression<Func<T , bool>> predicate);
        Task<int> CountAsync(Expression<Func<T , bool>> predicate = null);
    }
}
