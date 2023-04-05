using OnionArchitecture.DomainLayer.Entities.BaseEntities;
using OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserProfileFolder;

namespace OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserFolder
{
    public class User : Entitey
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
