using OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserFolder;
using OnionArchitecture.RepositoryLayer.IRepository;
using OnionArchitecture.ServicesLayer.IServices;
using System.Linq.Expressions;

namespace OnionArchitecture.ServicesLayer.Services
{
    public class UserServices : IBaseServices<User>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserServices(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
        public async Task AddAsync(User entity) => await _unitOfWork.Users.AddAsync(entity);
        public async Task<int> CountAsync(Expression<Func<User, bool>> predicate = null)
        {
            if (predicate is null)
                return await _unitOfWork.Users.CountAsync();
            else
                return await _unitOfWork.Users.CountAsync(predicate);
        }
        public async Task DeleteAsync(User entity) => await _unitOfWork.Users.DeleteAsync(entity);
        public async Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>> predicate = null)
        {
            if (predicate is null)
                return await _unitOfWork.Users.GetAllAsync();
            else
                return await _unitOfWork.Users.GetAllAsync(predicate);
        }
        public async Task<User> GetAsync(Expression<Func<User, bool>> predicate) => await _unitOfWork.Users.GetAsync(predicate);
        public async Task UpdateAsync(User entity) => await _unitOfWork.Users.UpdateAsync(entity);  
        public async Task<int> SaveChangesAsync() =>  await _unitOfWork.SaveChangesAsync();
    }
}
