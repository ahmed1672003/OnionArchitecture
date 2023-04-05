using System.ComponentModel.DataAnnotations;

namespace OnionArchitecture.DomainLayer.Entities.BaseEntities
{
    public class Entitey
    {
        [Key]
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string IPAddress { get; set; }
    }
}
