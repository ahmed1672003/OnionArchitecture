using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserProfileFolder
{
    public class UserProfileConfigurations
    {
        public UserProfileConfigurations(EntityTypeBuilder<UserProfile> userProfileBuilder)
        {
            userProfileBuilder.HasKey(t => t.Id);
            userProfileBuilder.Property(t => t.FirstName).IsRequired();
            userProfileBuilder.Property(t => t.LastName).IsRequired();
            userProfileBuilder.Property(t => t.Address);
        }
    }
}
