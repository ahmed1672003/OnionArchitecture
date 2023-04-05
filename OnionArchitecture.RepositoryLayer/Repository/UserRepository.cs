using OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserFolder;
using OnionArchitecture.RepositoryLayer.ApplicationDataBaseContexts;
using OnionArchitecture.RepositoryLayer.IRepository;

namespace OnionArchitecture.RepositoryLayer.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
