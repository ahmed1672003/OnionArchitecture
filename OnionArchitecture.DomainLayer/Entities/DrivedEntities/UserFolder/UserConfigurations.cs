using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitecture.DomainLayer.Entities.BaseEntities;
using OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserProfileFolder;

namespace OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserFolder
{
    public class UserConfigurations
    {
        public UserConfigurations(EntityTypeBuilder<User> userBuilder)
        {
            userBuilder.HasKey(t => t.Id);
            userBuilder.Property(t => t.Email).IsRequired();
            userBuilder.Property(t => t.Password).IsRequired();
            userBuilder.Property(t => t.Email).IsRequired();
            userBuilder.HasOne(t => t.UserProfile).WithOne(u => u.User).HasForeignKey<UserProfile>(x => x.Id);
        }
    }
}
