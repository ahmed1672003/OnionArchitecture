using OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserProfileFolder;
using OnionArchitecture.RepositoryLayer.IRepository;
using OnionArchitecture.ServicesLayer.IServices;
using System.Linq.Expressions;

namespace OnionArchitecture.ServicesLayer.Services
{
    public class UserProfileServices : IBaseServices<UserProfile>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserProfileServices(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
        public async Task AddAsync(UserProfile entity) => await _unitOfWork.UsersProfiles.AddAsync(entity);
        public async Task<int> CountAsync(Expression<Func<UserProfile, bool>> predicate = null)
        {
            if (predicate is null)
                return await _unitOfWork.UsersProfiles.CountAsync();
            else
                return await _unitOfWork.UsersProfiles.CountAsync(predicate);
        }
        public async Task DeleteAsync(UserProfile entity) => await _unitOfWork.UsersProfiles.DeleteAsync(entity);
        public async Task<IEnumerable<UserProfile>> GetAllAsync(Expression<Func<UserProfile, bool>> predicate = null)
        {
            if (predicate is null)
                return await _unitOfWork.UsersProfiles.GetAllAsync();
            else
                return await _unitOfWork.UsersProfiles.GetAllAsync(predicate);
        }
        public async Task<UserProfile> GetAsync(Expression<Func<UserProfile, bool>> predicate) => await _unitOfWork.UsersProfiles.GetAsync(predicate);
        public async Task UpdateAsync(UserProfile entity) => await _unitOfWork.UsersProfiles.UpdateAsync(entity);
        public async Task<int> SaveChangesAsync() => await _unitOfWork.SaveChangesAsync();
    }
}
