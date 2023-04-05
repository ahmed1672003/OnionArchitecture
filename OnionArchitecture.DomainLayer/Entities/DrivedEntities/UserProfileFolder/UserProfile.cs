using OnionArchitecture.DomainLayer.Entities.BaseEntities;
using OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserFolder;

namespace OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserProfileFolder
{
    public class UserProfile : Entitey
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public virtual User User { get; set; }
    }
}
