using Microsoft.EntityFrameworkCore;
using OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserFolder;
using OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserProfileFolder;

namespace OnionArchitecture.RepositoryLayer.ApplicationDataBaseContexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UsersProfiles { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new UserConfigurations(modelBuilder.Entity<User>());
            new UserProfileConfigurations(modelBuilder.Entity<UserProfile>());
        }
    }
}
