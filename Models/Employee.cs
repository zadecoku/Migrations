using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace Migrations.Models
{
    public class Employee: BaseEntity
    {
        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(10)]
        public string? Name { get; set; }

        public string? City { get; set; }

        public string? Gender { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [MaxLength(5)]
        public string? PostalCode { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {0}")]
        public int DepartmentId { get; set; }

        public virtual Department? Department { get; set; }

    }
}
