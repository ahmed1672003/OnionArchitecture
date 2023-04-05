using OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserFolder;
using OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserProfileFolder;

namespace OnionArchitecture.RepositoryLayer.IRepository
{
    public interface IUnitOfWork
    {
        public IBaseRepository<User> Users { get; }
        public IBaseRepository<UserProfile> UsersProfiles { get;}
        public Task<int> SaveChangesAsync();
    }
}
