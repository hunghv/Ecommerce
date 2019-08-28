using System;
using System.ComponentModel.DataAnnotations;

namespace Logging.Entities
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        

    }
}
