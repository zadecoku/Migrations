using System.ComponentModel.DataAnnotations;

namespace Migrations.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public int CreatedBy { get; set; }

        public int UpdatedBy { get; set;}
    }
}
