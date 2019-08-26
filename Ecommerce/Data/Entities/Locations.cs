using Data.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Locations : Entity
    {
        [MaxLength(100)]
        public string LocationName { get; set; }
    }
}
