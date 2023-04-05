using OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserFolder;
using OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserProfileFolder;
using OnionArchitecture.RepositoryLayer.ApplicationDataBaseContexts;
using OnionArchitecture.RepositoryLayer.IRepository;

namespace OnionArchitecture.RepositoryLayer.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public IBaseRepository<User> Users { get; private set; }
        public IBaseRepository<UserProfile> UsersProfiles { get; private set; }
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Users = new UserRepository(context);
            UsersProfiles = new UserProfileRepository(context);
        }
        public void Dispose() => _context.Dispose();
        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}
