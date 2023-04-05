using OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserProfileFolder;
using OnionArchitecture.RepositoryLayer.ApplicationDataBaseContexts;
using OnionArchitecture.RepositoryLayer.IRepository;

namespace OnionArchitecture.RepositoryLayer.Repository
{
    public class UserProfileRepository : BaseRepository<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
